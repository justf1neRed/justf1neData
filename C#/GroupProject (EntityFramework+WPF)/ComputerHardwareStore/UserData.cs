using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerHardwareStore.Model;

namespace ComputerHardwareStore
{
    public partial class UserData : Form
    {
        public List<UserBuyer> userBayerfromDB = new List<UserBuyer>();        
        public int userID = 0;
        public string email = null;
        public UserData()
        {
            InitializeComponent();
        }

           

        private void buttonOK_Click(object sender, EventArgs e)
        {
            using (MellorShopEntities1 db = new MellorShopEntities1())
            {
                string userName = null;
                string userPhone = null;
                string deleveryAddress = null;
                bool check = false;                
                    userName = textBoxEnterName.Text;
                    userPhone = textBoxEnterPhone.Text;
                    deleveryAddress = textBoxDelivAddress.Text;
                    email = textBoxEmail.Text;
                
                //get all users from the database
                userBayerfromDB = db.UserBuyer.ToList();
                //if there is already a customer with the same phone number, we get it ID
                foreach (var user in userBayerfromDB)
                {
                    if (user.NameUserBuyer == userName && user.ContactPhone == userPhone)
                    {
                        userID = user.ID_UserBuyer;
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    UserBuyer userToAdd = new UserBuyer();
                    userToAdd.NameUserBuyer = userName;
                    userToAdd.ContactPhone = userPhone;
                    db.UserBuyer.Add(userToAdd);
                    db.SaveChanges();
                    UserBuyer ub;
                    ub = db.UserBuyer.FirstOrDefault(u => u.ContactPhone == userToAdd.ContactPhone) as UserBuyer;
                    userID = ub.ID_UserBuyer;
                }
                DialogResult = DialogResult.OK;
            }
        }
        //// ---------button click Exit---form close--------
        private void buttonExit_Click(object sender, EventArgs e)
        {           
            this.Close();
        }
    }
}
