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
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (productNameTB.Text == "" || priceTB.Text == "" || remainderTB.Text == "" || specTB.Text == "")
            {
                MessageBox.Show("Error! You need to add ALL information!");
            }
            else
            {
                // переменные для проверки чтобы в поле цена и остаток были введены именно цифры
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

                if (flagRemin && flagPrice)
                {
                    // Добавляем в базу новый товар
                    MellorShopEntities1 con = new MellorShopEntities1();

                    Product newProd = new Product();

                    newProd.NameProduct = productNameTB.Text;
                    newProd.ID_Category = idCatCB.SelectedIndex + 1;
                    newProd.ID_Manufacturer = idManCB.SelectedIndex + 1;
                    newProd.Price = decimal.Parse(priceTB.Text);
                    newProd.Remainder = int.Parse(remainderTB.Text);
                    newProd.Specification = specTB.Text;

                    con.Product.Add(newProd);
                    con.SaveChanges();

                    MessageBox.Show("New Product has been added!");

                    this.Hide();                    
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
           
        }
    }
}
