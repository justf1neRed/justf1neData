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
    public partial class ManagerInvoices : Form
    {
        int managerID = 0;
        public ManagerInvoices(int idPers)
        {
            InitializeComponent();
            using (var db = new MellorShopEntities1())
            {
                //fill dataGridViewManagerInvoice from db.Invoice with OrderStatus ==5(new) or ID_Personnel=ID activated user 
                db.Invoice.Where(i => i.ID_OrderStatus ==5 | i.ID_Personnel== idPers).Load();
               dataGridViewManagerInvoice.DataSource = db.Invoice.Local.ToBindingList();
                managerID = idPers;
            }
        }

        private void ManagerInvoices_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mellorShopDataSet3.Invoice". При необходимости она может быть перемещена или удалена.
            this.invoiceTableAdapter.Fill(this.mellorShopDataSet3.Invoice);
        }

        //With 2 clicks on the invoice, detailed information with goods opens
        private void dataGridViewManagerInvoice_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            int invoiceID = (int)dataGridViewManagerInvoice[0, dataGridViewManagerInvoice.CurrentRow.Index].Value;
            int userBuyerID = (int)dataGridViewManagerInvoice[2, dataGridViewManagerInvoice.CurrentRow.Index].Value;
            using (var db = new MellorShopEntities1())
            {
                int statusID = (int)dataGridViewManagerInvoice[3, dataGridViewManagerInvoice.CurrentRow.Index].Value;
                int PersonnelID = (int)dataGridViewManagerInvoice[4, dataGridViewManagerInvoice.CurrentRow.Index].Value;
                // craete form detailed information with goods
                InvoiceInfo invoiceInfo = new InvoiceInfo(invoiceID, userBuyerID, managerID);

                for (int i = 0; i < invoiceInfo.dataGridViewInvoiceInfo.Rows.Count - 1; i++)// Count-1  -last row empty
                {
                    int venCode = (int)invoiceInfo.dataGridViewInvoiceInfo[0, i].Value;
                    int quantOrderProd = (int)invoiceInfo.dataGridViewInvoiceInfo[3, i].Value;
                    //We get the product with the given code from the table of goods
                    Product prod;
                    prod = db.Product.Where(p => p.VendoreCode == venCode).FirstOrDefault() as Product;
                    //If there is less product in stock than in the order, display a message, warning
                    if (prod.Remainder < quantOrderProd)
                    {
                        MessageBox.Show($"Product Venor Code № {venCode} Remaining in stock {prod.Remainder} . An insufficient amount!!! ");
                    }
                }
                //We receive an invoice with the selected
                var Invoice = db.Invoice.Where(i => i.ID_Invoice == invoiceID).FirstOrDefault();
                Invoice.ID_Personnel = managerID;
                invoiceInfo.textBoxTotalSum.Text = Invoice.TotalSumm.ToString();
                //Change order status with new- at work
                if (Invoice.ID_OrderStatus == 5)
                {
                    Invoice.ID_OrderStatus = 1;
                }
                db.SaveChanges();
                
                if (invoiceInfo.ShowDialog() == DialogResult.OK)
                {
                    //Refresh
                     toolStripButton2_Click(sender,e);                    
                }
            }              
        }
        //Close form
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        //Refresh
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            using (var db = new MellorShopEntities1())
            {
                db.Invoice.Where(i => i.ID_OrderStatus == 5 | i.ID_Personnel == managerID).Load();
                dataGridViewManagerInvoice.DataSource = db.Invoice.Local.ToBindingList();
                dataGridViewManagerInvoice.Refresh();
            }
        }
    }
}
