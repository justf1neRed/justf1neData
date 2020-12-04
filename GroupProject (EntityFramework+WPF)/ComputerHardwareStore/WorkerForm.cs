using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerHardwareStore.Model;

namespace ComputerHardwareStore
{
    public partial class WorkerForm : Form
    {
        public List<Personnel> listPersonnels = new List<Personnel>();
        List<Product> allProducts = new List<Product>();
        public MellorShopEntities1 db = new MellorShopEntities1();
        int idPers = 7;
        bool flag = false;
        string selectedCategoryName = null;
        public WorkerForm()
        {
            InitializeComponent();
            panel1AuthorizationPersonal.Visible = true;
            panelManagerWork.Visible = false;
        }

        //Panel1 worker  authorization
        private void buttonToApplyAuthorization_Click(object sender, EventArgs e)
        {
          
            using (var db = new MellorShopEntities1())
            {
                listPersonnels = db.Personnel.ToList();

                foreach (var item in listPersonnels)
                {//if login adm1-  panelManagerWork.Visible.Working with the DB- CRUD
                    if (textBoxLogin.Text == "adm1" && textBoxPassword.Text == "3333" && item.ID_Position == 3)
                    {
                        toolStripName.Text = item.NamePers;
                        toolStripPosition.Text = item.Position.NamePosition;
                        idPers = item.ID_Personnel;
                        db.Product.Load();
                        dataGridViewManagerForm.DataSource = db.Product.Local.ToBindingList();
                        flag = true;
                        panelManagerWork.Visible = true;
                        break;
                    }
                    //if login 
                    if (textBoxLogin.Text == item.LoginPers && textBoxPassword.Text == item.PasswordPers&& textBoxLogin.Text != "adm1")
                    {
                        toolStripName.Text = item.NamePers;
                        toolStripPosition.Text = item.Position.NamePosition;
                        idPers = item.ID_Personnel;
                        flag = true;
                        
                        ManagerInvoices newManager = new ManagerInvoices(idPers);
                        this.Hide();
                        if (newManager.ShowDialog() == DialogResult.OK)
                        {
                            Application.Exit();
                        }
                        break;
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("Error authorization!!!");
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
            }
           
        }

        //Button exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void WorkerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mellorShopDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.mellorShopDataSet.Product);
        }

        private void allBaseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (var db1 = new MellorShopEntities1())
            {
                db1.Product.Load();
                dataGridViewManagerForm.DataSource = db1.Product.Local.ToBindingList();
            }
        }
        private void ApplayFilter(string selectedCategoryName)
        {
            using (var db1 = new MellorShopEntities1())
            {
                db1.Product.Where(c => c.Category.NameCategory == selectedCategoryName).Load();
                dataGridViewManagerForm.DataSource = db1.Product.Local.ToBindingList();
            }
        }
        private void mBToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            selectedCategoryName = "Motherboard";
            ApplayFilter(selectedCategoryName);
           
        }       

        private void cPUToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            selectedCategoryName = "CPU";
            ApplayFilter(selectedCategoryName);
        }

        private void gPUToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            selectedCategoryName = "GPU";
            ApplayFilter(selectedCategoryName);
        }

        private void rAMToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            selectedCategoryName = "RAM";
            ApplayFilter(selectedCategoryName);
        }

        private void hDDSSDToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            selectedCategoryName = "HDD";
            ApplayFilter(selectedCategoryName);
        }

        private void pSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            selectedCategoryName = "SSD";
            ApplayFilter(selectedCategoryName);
        }

        private void boxToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            selectedCategoryName = "Box";
            ApplayFilter(selectedCategoryName);
        }

        private void powerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            selectedCategoryName = "Power";
            ApplayFilter(selectedCategoryName);
        }
        //Added new product 
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            
            AddNewProduct newForm = new AddNewProduct();
            newForm.ShowDialog();
        }
        // Edit product
        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            decimal selectPrice = decimal.Parse(dataGridViewManagerForm[4, dataGridViewManagerForm.CurrentRow.Index].Value.ToString());
            int selectRemaind = int.Parse(dataGridViewManagerForm[5, dataGridViewManagerForm.CurrentRow.Index].Value.ToString());
            int selectVendor = int.Parse(dataGridViewManagerForm[0, dataGridViewManagerForm.CurrentRow.Index].Value.ToString());

            EditProductForm newForm = new EditProductForm(selectPrice, selectRemaind, selectVendor);
           if( newForm.ShowDialog()==DialogResult.OK)
            {
                if (selectedCategoryName!=null)
                {
                    using (var db1 = new MellorShopEntities1())
                    {
                        db1.Product.Where(c => c.Category.NameCategory == selectedCategoryName).Load();
                        dataGridViewManagerForm.DataSource = db1.Product.Local.ToBindingList();
                    }
                }
                else
                {
                    using (var db1 = new MellorShopEntities1())
                    {
                        db1.Product.Load();
                        dataGridViewManagerForm.DataSource = db1.Product.Local.ToBindingList();
                    }
                }
            }            
        }
       
        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            //процесс ПОЛНОГО удаления товара из базы

            DialogResult res = MessageBox.Show("This operation will delete the Product from the DataBase!\nAre you sure?",
                "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            if (res == DialogResult.Yes)
            {
                using (MellorShopEntities1 db = new MellorShopEntities1())
                {
                    allProducts = db.Product.ToList();
                    Product selectProd = new Product();
                    string selectProdName = dataGridViewManagerForm[1, dataGridViewManagerForm.CurrentRow.Index].Value.ToString();

                    foreach (var product in allProducts)
                    {
                        if (product.NameProduct == selectProdName)
                        {
                            MellorShopEntities1 newEnt = new MellorShopEntities1();

                            Product delProd = newEnt.Product.Where(p => p.NameProduct == selectProdName).FirstOrDefault();

                            newEnt.Product.Remove(delProd);
                            newEnt.SaveChanges();
                        }
                    }
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            using (var db1 = new MellorShopEntities1())
            {
                db1.Product.Load();
                dataGridViewManagerForm.DataSource = db1.Product.Local.ToBindingList();
               
            }
        }
    }

}

