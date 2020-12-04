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
    public partial class InvoiceInfo : Form
    {
        List<OrderStatus> orderStatuses = new List<OrderStatus>();
        int invID = 0;
        int manID = 0;
        public InvoiceInfo(int invoiceID,int userBuyerID,int managerID)
        {
            InitializeComponent();
            invID = invoiceID;
            manID = managerID;
            using (var db = new MellorShopEntities1())
            {
                //We fill dataGridViewInvoiceInfo with data from v_InvoiceInfo  orders with selected invoice ID
                db.v_InvoiceInfo.Where(i => i.ID_Invoice == invoiceID).Load();
                dataGridViewInvoiceInfo.DataSource = db.v_InvoiceInfo.Local.ToBindingList();
                //We receive customer data
                UserBuyer userData;
                userData = db.UserBuyer.FirstOrDefault(u=>u.ID_UserBuyer== userBuyerID)as UserBuyer;
                labelUserName.Text = userData.NameUserBuyer;
                labelUserPhone.Text = userData.ContactPhone;
                //We receive all orders statuses
                orderStatuses = db.OrderStatus.ToList();
                for (int i = 0; i < orderStatuses.Count; i++)
                {
                    comboBoxOrderStatus.Items.Add(orderStatuses[i].NameOrderStatus.ToString());
                }
                comboBoxOrderStatus.SelectedIndex = 4;               
            }
        }
        //// Delete selected position order  from invoice
         private void buttonDeleteFromInvoice_Click(object sender, EventArgs e)
        {          
            using (var db = new MellorShopEntities1())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove this item from the invoice?", "Are you sure???", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int idOrderToDelete = (int)dataGridViewInvoiceInfo[6, dataGridViewInvoiceInfo.CurrentRow.Index].Value;
                    int idCodeToDelete = (int)dataGridViewInvoiceInfo[0, dataGridViewInvoiceInfo.CurrentRow.Index].Value;
                    OrderBuy orderDelete;
                    orderDelete = db.OrderBuy.Where(o => o.ID_OrderBuy == idOrderToDelete).FirstOrDefault();
                    Product prodToDel;
                    prodToDel = db.Product.Where(p => p.VendoreCode == idCodeToDelete).FirstOrDefault();
                    decimal price = orderDelete.QuantityProduct * prodToDel.Price;
                    Invoice invOrderToDel;
                    invOrderToDel = db.Invoice.Where(i => i.ID_Invoice == invID).FirstOrDefault();
                    invOrderToDel.TotalSumm -= price;
                    textBoxTotalSum.Text = invOrderToDel.TotalSumm.ToString();
                    //When deleting a position from the invoice, the order is deleted from the base             
                    db.OrderBuy.Remove(orderDelete);
                    db.SaveChanges();
                    //Refresh dataGrid
                    buttonRefresh_Click(sender, e);                 

                }               
            }
        }

        //Button click OK if change order status 
        private void buttonOK_Click(object sender, EventArgs e)
        {
            using (var db = new MellorShopEntities1())
            {
                var Invoice = db.Invoice.Where(i => i.ID_Invoice == invID).FirstOrDefault();
                string osName = comboBoxOrderStatus.SelectedItem.ToString();
                OrderStatus os;
                //We get into the object from the table with the data order status name
                os = db.OrderStatus.FirstOrDefault(o => o.NameOrderStatus == osName) as OrderStatus;
                //We get ID 
                int orderStatusID = os.ID_OrderStatus;
                //Change object select invoice ID order status
                Invoice.ID_Personnel = manID;
                Invoice.ID_OrderStatus = orderStatusID;
                db.SaveChanges();
                //if order status Completed, products from invoice delete from DB
                if (comboBoxOrderStatus.SelectedItem.ToString() == "Completed")
                {
                    List<OrderBuy> prodDelDB = new List<OrderBuy>();
                    prodDelDB = db.OrderBuy.Where(o => o.ID_Invoice == invID).ToList();
                    foreach (var item in prodDelDB)
                    {
                        int codeProdToRemove = item.VendoreCode;
                        int quantProdToRemove = item.QuantityProduct;
                        var prodToChangeQuant = db.Product.Where(p => p.VendoreCode == codeProdToRemove).FirstOrDefault();
                        prodToChangeQuant.Remainder -= quantProdToRemove;
                        db.SaveChanges();
                    }
                }
                DialogResult = DialogResult.OK;
            }
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            using (var db = new MellorShopEntities1())
            {
                db.v_InvoiceInfo.Where(i => i.ID_Invoice == invID).Load();
                dataGridViewInvoiceInfo.DataSource = db.v_InvoiceInfo.Local.ToBindingList();
                dataGridViewInvoiceInfo.Refresh();
            }
        }
        //We select the goods that are not enough in the warehouse red color
        private void dataGridViewInvoiceInfo_RowPrePaint(object sender, object e)
        {
            using (var db = new MellorShopEntities1())
            {
                for (int i = 0; i < dataGridViewInvoiceInfo.Rows.Count - 1; i++)
                {
                    int venCode = (int)dataGridViewInvoiceInfo[0, i].Value;
                    int quantOrderProd = (int)dataGridViewInvoiceInfo[3, i].Value;

                    Product prod;
                    prod = db.Product.Where(p => p.VendoreCode == venCode).FirstOrDefault() as Product;
                    if (prod.Remainder < quantOrderProd)
                    {
                        this.dataGridViewInvoiceInfo.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        this.dataGridViewInvoiceInfo.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        private void InvoiceInfo_Load(object sender, EventArgs e)
        {
            dataGridViewInvoiceInfo_RowPrePaint(sender, e);
        }
    }
}
