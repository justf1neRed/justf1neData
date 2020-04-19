using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSQLNew
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            PassField.AutoSize = false;
            PassField.Size = new Size(PassField.Size.Width, 30);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string LoginUser = LoginField.Text;
            string PassUser = PassField.Text;

            DataBase MyDB = new DataBase();

            DataTable Table = new DataTable();

            MySqlDataAdapter Adapter = new MySqlDataAdapter();

            MySqlCommand Command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", MyDB.GetConnect()); 

            Command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginUser; 
            Command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassUser;

            Adapter.SelectCommand = Command;
            Adapter.Fill(Table); 

            if (Table.Rows.Count > 0) 
            {
                MessageBox.Show("Autorization Complete", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MainForm Mainform = new MainForm();
                Mainform.Show();
            }
            else
                MessageBox.Show("Autorization Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm Registr = new RegisterForm();
            Registr.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
