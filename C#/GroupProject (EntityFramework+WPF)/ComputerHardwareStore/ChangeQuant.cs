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
    public partial class ChangeQuant : Form
    {
        public ChangeQuant()
        {
            InitializeComponent();
        }

        private void buttonOKchange_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
