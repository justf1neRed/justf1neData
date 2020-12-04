using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerHardwareStore
{
    public partial class UserBuyQuant : Form
    {
        public UserBuyQuant()
        {
            InitializeComponent();          
        }

        private void numericUpDownQuant_ValueChanged(object sender, EventArgs e)
        {
           //// If the quantity changes, we change the amount
            string price = labelPriceText.Text;
            labelSumText.Text =( numericUpDownQuant.Value * Convert.ToDecimal(price)).ToString();            
        }      

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
