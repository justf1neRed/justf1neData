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
    public partial class InfoProduct : Form
    {
        public InfoProduct()
        {
            InitializeComponent();
        }      


        private void AddToOrder_Click(object sender, EventArgs e)
        {
            //логика
            DialogResult = DialogResult.OK; 

        }

        private void buttonBackToSelection_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
