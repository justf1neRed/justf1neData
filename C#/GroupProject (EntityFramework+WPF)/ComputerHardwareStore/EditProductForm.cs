using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerHardwareStore.Model;

namespace ComputerHardwareStore
{
    public partial class EditProductForm : Form
    {
        decimal Price;
        int Remainder;
        int Vendor;

        public EditProductForm(decimal _Price, int _Remainder, int _Vendor)
        {
            this.Price = _Price;
            this.Remainder = _Remainder;
            this.Vendor = _Vendor;
            InitializeComponent();
            priceTB.Text = Price.ToString();
            remainderTB.Text = Remainder.ToString();
        }


        public EditProductForm()
        {
            InitializeComponent();
            priceTB.Text = Price.ToString();
            remainderTB.Text = Remainder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = priceTB.Text.Trim();
            string str2 = remainderTB.Text.Trim();
            decimal num1 = 0;
            int num2 = 0;
            bool isNum1 = decimal.TryParse(str1, out num1);
            bool isNum2 = int.TryParse(str2, out num2);
            bool flagPrice = false;
            bool flagRemin = false;

            if (isNum1)
                flagPrice = true;
            else
                MessageBox.Show("Error! Plese enter the NUMBER in Price TextBox");

            if (isNum2)
                flagRemin = true;
            else
                MessageBox.Show("Error! Plese enter the NUMBER in Remainder TextBox");

            if (priceTB.Text != "" && remainderTB.Text != "" && flagPrice && flagRemin)
            {
                DialogResult res = MessageBox.Show("Do you really want to change Price or Remainder of the Product?",
                "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                if (res == DialogResult.Yes)
                {
                    MellorShopEntities1 con = new MellorShopEntities1();

                    Product EditedProd = con.Product.Where(v => v.VendoreCode == Vendor).FirstOrDefault();

                    EditedProd.Price = decimal.Parse(priceTB.Text);
                    EditedProd.Remainder = int.Parse(remainderTB.Text);

                    con.SaveChanges();

                    this.Close();
                    //WorkerForm newForm = new WorkerForm();
                    //newForm.Show();
                }
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Error! Enter all data!");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            //WorkerForm newForm = new WorkerForm();
            //newForm.Show();
        }
    }
}
