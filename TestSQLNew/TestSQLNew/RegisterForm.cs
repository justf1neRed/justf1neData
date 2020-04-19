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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            UserRegistField.ForeColor = Color.IndianRed;
            PassRegistrFrom.ForeColor = Color.IndianRed;
        }

        private void RegistrButton_Click(object sender, EventArgs e)
        {
            if (UserRegistField.Text == "")
            {
                MessageBox.Show("Enter Your Login!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PassRegistrFrom.Text == "")
            {
                MessageBox.Show("Enter Your Password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsLoginTaken())
                return;

            DataBase NewDB = new DataBase();
            MySqlCommand Command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES (@login, @pass)", NewDB.GetConnect());
            Command.Parameters.Add("@login", MySqlDbType.VarChar).Value = UserRegistField.Text;
            Command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassRegistrFrom.Text;

            NewDB.OpenConnection();

            if (Command.ExecuteNonQuery() == 1)
                MessageBox.Show("Registration is Successful!", "Alright!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Registration Error!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            NewDB.CloseConnection();
        }

        public bool IsLoginTaken()
        {
            DataBase MyDB = new DataBase();

            DataTable Table = new DataTable();

            MySqlDataAdapter Adapter = new MySqlDataAdapter();

            MySqlCommand Command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", MyDB.GetConnect()); 

            Command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = UserRegistField.Text; 

            Adapter.SelectCommand = Command;
            Adapter.Fill(Table);

            if (Table.Rows.Count > 0)
            {
                MessageBox.Show("This Login is Aready taken!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
                return false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm NewLogForm = new LoginForm();
            NewLogForm.Show();
        }
    }
}
