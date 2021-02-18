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
    public partial class Form1 : Form
    {
        List<Category> listCategoryProduct = new List<Category>();
        List<Product> allProducts = new List<Product>();
        List<OrderBuy> newOrderBuy = new List<OrderBuy>();
       public List<Product> ordersProducts = new List<Product>();
        List<string> listManufacturers=new List<string>();
        decimal totalSumm = 0;
        public Form1()
        {
            InitializeComponent();
            panel1StartPage.Visible = true;//start page
            panel2StoreUser.Visible = false;//storeUser page
            panelSelectProduct.Visible = false;//SelectProduct page
            ////We fill in the list of categories from DB
            using (MellorShopEntities1 db = new MellorShopEntities1())
            {
                listCategoryProduct = db.Category.ToList();
                ////Fill combobox items from db.Category
                for (int i = 0; i < listCategoryProduct.Count; i++)
                {
                    comboBoxCatalog.Items.Add(listCategoryProduct[i].NameCategory.ToString());
                }
            }
        }
       
        //////------------------Panel Start-----------------------------                   
        ////authorization manager
       
        private void AuthorizationManager_Click(object sender, EventArgs e)
        {   ////Create end open form authorization manager          
            WorkerForm authorization = new WorkerForm();
            if(authorization.ShowDialog()==DialogResult.OK)
            {

            }
        }

        //// User panel visible
        private void User_Click(object sender, EventArgs e)
        {           
            panel2StoreUser.Visible = true;//storeUser page            
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        ////------------------------panelUserStore after select OK---------------------
        ////---------------------------------------------------------------------------------
        private void button_us_OK_Click(object sender, EventArgs e)
        {
            using (var db1=new MellorShopEntities1())
            {
                string categoryName = comboBoxCatalog.SelectedItem.ToString();
                ////Fill dataGridView according to the selected category
                db1.v_ProductUser.Where(c => c.Category == categoryName & c.Quantity!=0).Load();
                dataGridView1Products.DataSource = db1.v_ProductUser.Local.ToBindingList();
                dataGridView1Products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                dataGridView1Products.Columns[5].AutoSizeMode= DataGridViewAutoSizeColumnMode.Fill;
                ////label Name category
                ProductNameLabel.Text = comboBoxCatalog.SelectedItem.ToString();
                ////All product from DB selected category
                var result = from m in db1.v_ProductUser     
                            where m.Category == categoryName & m.Quantity>0
                            select m;
                ////Add to list this product manufacturers
                foreach (var item in result)
                {
                    listManufacturers.Add(item.Manufacturer);                    
                }
                ////Create end fill IEnumerable not repetitive manufacturers
                IEnumerable<string> manufact = listManufacturers.Distinct();                
                foreach (var item in manufact)
                {
                    comboBoxManufacturer.Items.Add(item);
                }   
                
                textBoxFrom.Text = "0";
                textBoxBefore.Text = "0";
                ////panel selectet category product visible
                panelSelectProduct.Visible = true;
            }
        }          


        //////-------------- panelSelectProduct--------------------
        private void dataGridView1Products_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ////2 clicks on a position open a product with characteristics
            using (MellorShopEntities1 db = new MellorShopEntities1())
            {
                allProducts = db.Product.ToList();
                Product selectProd = new Product();
                string selectProdName = dataGridView1Products[1, dataGridView1Products.CurrentRow.Index].Value.ToString();
                foreach (var product in allProducts)
                {
                    ////we go through the list of all products from the database,
                    ////and if the name is the same, we read the data into an object by type product
                    if (product.NameProduct == selectProdName)
                    {
                        selectProd.VendoreCode = product.VendoreCode;
                        selectProd.NameProduct = product.NameProduct;
                        selectProd.ID_Category = product.ID_Category;
                        selectProd.ID_Manufacturer = product.ID_Manufacturer;
                        selectProd.Price = product.Price;
                        selectProd.Remainder = product.Remainder;
                        selectProd.Specification = product.Specification;
                    }
                }
                //create end open form specification select product
                InfoProduct infoProd = new InfoProduct();
                infoProd.SelectProdName.Text = selectProd.NameProduct;
                infoProd.richTextBoxProdSpecific.Text = selectProd.Specification;

                if (infoProd.ShowDialog() == DialogResult.OK)
                {
                    ////refresh dataGrid
                    buttonAddToOrder_Click(sender, e);
                }
            }
       }       
    
        //// Button add to order
    private void buttonAddToOrder_Click(object sender, EventArgs e)
    {
            using (MellorShopEntities1 db = new MellorShopEntities1())
            {
                ////Add product data to the product quantity selection form - UserBuyQuant
                string selectProdName = dataGridView1Products[1, dataGridView1Products.CurrentRow.Index].Value.ToString();               
                UserBuyQuant UserBQ = new UserBuyQuant();
                UserBQ.labelNameText.Text = dataGridView1Products[1, dataGridView1Products.CurrentRow.Index].Value.ToString(); ;
                UserBQ.labelCatText.Text = dataGridView1Products[0, dataGridView1Products.CurrentRow.Index].Value.ToString();
                UserBQ.labelManufText.Text = dataGridView1Products[2, dataGridView1Products.CurrentRow.Index].Value.ToString();
                UserBQ.labelPriceText.Text = Math.Round(Convert.ToDecimal(dataGridView1Products[3, dataGridView1Products.CurrentRow.Index].Value),2).ToString();
                UserBQ.labelQuantAvText.Text = dataGridView1Products[4, dataGridView1Products.CurrentRow.Index].Value.ToString();
                UserBQ.labelSumText.Text = Math.Round(Convert.ToDecimal(dataGridView1Products[3, dataGridView1Products.CurrentRow.Index].Value), 2).ToString();
                UserBQ.numericUpDownQuant.Maximum = Convert.ToInt32(UserBQ.labelQuantAvText.Text);
               
                if (UserBQ.ShowDialog() == DialogResult.OK)
                {
                    ////We transfer the selected quantity of goods from the form
                    Product selectProd = new Product();
                    selectProd = db.Product.Where(n => n.NameProduct == selectProdName).FirstOrDefault();
                    selectProd.Remainder= Convert.ToInt32(UserBQ.numericUpDownQuant.Value);                  
                    totalSumm += (selectProd.Remainder * selectProd.Price);
                    ordersProducts.Add(selectProd);//add select prod to list 
                }
            }
    }
        
    private void buttonGoToOrder_Click(object sender, EventArgs e)
        {
            // // Create and open form Order with selected products
            Order order = new Order(ordersProducts);
            order.ShowDialog();
            if(order.DialogResult==DialogResult.No)
            {
                //if pressed button Delete all in Order form
                ordersProducts.Clear();
                ordersProducts = order.prodFromGrid;
            }
            if (order.DialogResult == DialogResult.Yes)
            {  
                //  if pressed button Delete one selected product in Order form
                ordersProducts = order.prodFromGrid;
            }
            if (order.DialogResult == DialogResult.Cancel)
            {
                //  if pressed button CheckOut in Order form end placed an order
                ordersProducts = order.prodFromGrid;
                totalSumm = 0;
                panel2StoreUser.Visible = true;//storeUser page
                panelSelectProduct.Visible = false;
            }
        }        
       
        //------------------BAck to selection click from CATEGORY--------------
        private void buttonBackToSelection_Click_1(object sender, EventArgs e)
        {           
            panel2StoreUser.Visible = true;//storeUser page                           
            panelSelectProduct.Visible = false;//SelectProduct page 
            listManufacturers.Clear();
            comboBoxManufacturer.Items.Clear();

        }
        
        ////------------Apply Filters--------------
        private void buttonApplyFilters_Click(object sender, EventArgs e)
        {
            decimal priceFrom = Convert.ToDecimal(textBoxFrom.Text);
            decimal priceBefore = Convert.ToDecimal(textBoxBefore.Text);
            //change incorrectly entered data
            if (priceFrom> priceBefore)
            {
                decimal tmp = priceFrom;
                priceFrom = priceBefore;
                priceBefore = tmp;
                textBoxFrom.Text = priceFrom.ToString();
                textBoxBefore.Text = priceBefore.ToString();
            }
            string categoryName = comboBoxCatalog.SelectedItem.ToString();
            //if selected only price filter
            if (comboBoxManufacturer.SelectedIndex<0 && priceBefore > 0 && priceFrom >= 0)
            {
                using (var db1 = new MellorShopEntities1())
                {
                    db1.v_ProductUser.Where(c => c.Category == categoryName & c.Quantity > 0 & c.Price >= priceFrom & c.Price <= priceBefore).Load();
                    dataGridView1Products.DataSource = db1.v_ProductUser.Local.ToBindingList();
                    ProductNameLabel.Text = comboBoxCatalog.SelectedItem.ToString();
                    panelSelectProduct.Visible = true;
                }
            }
          
            else if (comboBoxManufacturer.SelectedItem.ToString() != null)
            {
                using (var db1 = new MellorShopEntities1())
                {                
                    //if selected Manufacturer end price    
                    if (priceBefore > 0 && priceFrom >= 0)
                    {
                        db1.v_ProductUser.Where(c => c.Category == categoryName & c.Quantity > 0 & c.Manufacturer == comboBoxManufacturer.SelectedItem.ToString() & c.Price >= priceFrom & c.Price <= priceBefore).Load();
                        dataGridView1Products.DataSource = db1.v_ProductUser.Local.ToBindingList();
                        ProductNameLabel.Text = comboBoxCatalog.SelectedItem.ToString();
                        panelSelectProduct.Visible = true;
                    }
                    //if selected only Manufacturer 
                    else
                    {
                        db1.v_ProductUser.Where(c => c.Category == categoryName & c.Quantity > 0 & c.Manufacturer == comboBoxManufacturer.SelectedItem.ToString()).Load();
                        dataGridView1Products.DataSource = db1.v_ProductUser.Local.ToBindingList();
                        ProductNameLabel.Text = comboBoxCatalog.SelectedItem.ToString();
                        panelSelectProduct.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Data entered incorrectly !");
            }

        }
        ////--------Reset Filters-----------
        private void buttonResetFilters_Click(object sender, EventArgs e)
        {
            using (var db1 = new MellorShopEntities1())
            {
                string categoryName = comboBoxCatalog.SelectedItem.ToString();

                db1.v_ProductUser.Where(c => c.Category == categoryName & c.Quantity>0).Load();
                dataGridView1Products.DataSource = db1.v_ProductUser.Local.ToBindingList();
                ProductNameLabel.Text = comboBoxCatalog.SelectedItem.ToString();               
                textBoxFrom.Text = "0";
                panelSelectProduct.Visible = true;
            }
        }
        //////---------End----- panelSelectProduct--------------------
    }
}
