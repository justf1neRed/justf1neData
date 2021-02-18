using ComputerHardwareStore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ComputerHardwareStore
{
    public partial class Order : Form
    {
        public List<Product> prodFromGrid = new List<Product>();
        public string emailUserData = null;
        int amountProdToOrder = 0;
        decimal totalSumToOrder = 0;
        int userID = 0;
        int invoiceID = 0; 
        public Order(List<Product> ordersProducts)
        {
            InitializeComponent();
            ////When initializing, create dataGridViewOrder
            dataGridViewOrder.RowCount = ordersProducts.Count+1;//empty line at the end
            dataGridViewOrder.Columns.AddRange(
    new DataGridViewTextBoxColumn() { Name = "clmName", HeaderText = "Name", DataPropertyName = "name", Width = 300 },
    new DataGridViewTextBoxColumn() { Name = "clmPrice", HeaderText = "Price", DataPropertyName = "price", Width = 70 },
    new DataGridViewTextBoxColumn() { Name = "clmQuantity", HeaderText = "Quantity", DataPropertyName = "quantity", Width = 50 },
    new DataGridViewTextBoxColumn() { Name = "clmSum", HeaderText = "Sum", DataPropertyName = "summa", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill }
            );
            dataGridViewOrder.Columns[0].HeaderText = "VendoreCode";
            FillingGrid(ordersProducts);
            prodFromGrid = ordersProducts;
        }

        private void FillingGrid(List<Product> ordersProducts)
        {
            totalSumToOrder = 0;
            amountProdToOrder = 0;
            for (int i = 0; i < ordersProducts.Count; i++)
            {
                dataGridViewOrder[0, i].Value = ordersProducts[i].VendoreCode;
                dataGridViewOrder[1, i].Value = ordersProducts[i].NameProduct;
                dataGridViewOrder[2, i].Value = Math.Round(ordersProducts[i].Price, 2);
                dataGridViewOrder[3, i].Value = ordersProducts[i].Remainder;
                amountProdToOrder += ordersProducts[i].Remainder;
                dataGridViewOrder[4, i].Value = Math.Round((ordersProducts[i].Price * ordersProducts[i].Remainder), 2).ToString();
                totalSumToOrder += (ordersProducts[i].Price * ordersProducts[i].Remainder);
                textBoxQuantity.Text = amountProdToOrder.ToString();
                textBoxOrderPrice.Text = Math.Round(totalSumToOrder, 2).ToString();
            }          
        }

        ////We place an order
        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            using (var db=new MellorShopEntities1())
            {
                UserData dataUserBayer = new UserData();
               // =dataUserBayer.email;
                if (dataUserBayer.ShowDialog() == DialogResult.OK)
                {
                    emailUserData=dataUserBayer.email;
                    userID = dataUserBayer.userID;
                    //create new order send order to invoises(Summa , user ID,)                   
                    Invoice invoiceNew = new Invoice();
                    invoiceNew.DateInvoice = DateTime.Now;
                    invoiceNew.ID_UserBuyer = userID;
                    invoiceNew.ID_OrderStatus = 5;
                    invoiceNew.ID_Personnel = 7;
                    invoiceNew.TotalSumm = totalSumToOrder;
                    invoiceNew.DeliveryAddress = dataUserBayer.textBoxDelivAddress.Text;
                    //add new invoice to DB 
                    db.Invoice.Add(invoiceNew);
                    db.SaveChanges();

                    Invoice idInvoice;
                    idInvoice = db.Invoice.FirstOrDefault(i => i.DeliveryAddress == invoiceNew.DeliveryAddress & i.ID_UserBuyer== invoiceNew.ID_UserBuyer & i.TotalSumm== invoiceNew.TotalSumm) as Invoice;
                    invoiceID = idInvoice.ID_Invoice;

                    // fill in all orders from the forich grid
                    for (int i = 0; i < prodFromGrid.Count; i++)
                    {
                        OrderBuy newOrderBuy = new OrderBuy();
                        newOrderBuy.VendoreCode = prodFromGrid[i].VendoreCode;
                        newOrderBuy.ID_Invoice = invoiceID;
                        newOrderBuy.QuantityProduct = prodFromGrid[i].Remainder;
                        db.OrderBuy.Add(newOrderBuy);
                        db.SaveChanges();
                    }
                }
                if (emailUserData!=null)
                {
                    WFinPDF(totalSumToOrder, invoiceID);
                    SendMailAcync(emailUserData, invoiceID).GetAwaiter();//Send email if customer enter email
                }

                // Clear list end dataGrid
                prodFromGrid.Clear();               
                amountProdToOrder = 0;
                dataGridViewOrder.Rows.Clear();
                dataGridViewOrder.Refresh();
            }
            // Finish the purchase, clear everything and return to the home page
            this.Close();
            DialogResult = DialogResult.Cancel;
            MessageBox.Show($"Your order is being processed !!! Total order amount { totalSumToOrder} ");
            totalSumToOrder = 0;
        }

        //Send message to customer 
        private static async Task SendMailAcync(string emailUserData,int invoiceID)
        {
            //From
            MailAddress From = new MailAddress("mymellorshop@gmail.com","MellorShop");
            //To
            MailAddress To = new MailAddress(emailUserData);
            //Create object message
            MailMessage msg = new MailMessage(From,To);
            // Subject mail
            msg.Subject = "MellorShop store order ";
            // Text mail
            string txtBody = $"Your order number is {invoiceID} in processing. Our manager will contact you shortly.";
            msg.Body = "<html><body><br><img src=\"https://picua.org/images/2020/10/08/1c2594fd2ebe821588572b518a20bfae.png\" width=\"600\" hight=\"50\" alt=\"MellorShop\">" + @" 
            <br>Good afternoon! 
            <br>" + txtBody + "<p>Thank you for your order! Have a nice day!" + "<hr>Respectfully, MellorShop<br>Our address: Zaporizhzhia, Soborny Ave., 777" +
            "<br><br>This message was sent automatically. Please do not answer it. If you have any questions, call 067 777 77 77 or 050 777 77 77.</p></body></html>";
            msg.IsBodyHtml = true;
            msg.Attachments.Add(new Attachment("DataGridViewExport.pdf"));
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("mymellorshop@gmail.com", "12345678qwerty*");
            smtp.EnableSsl = true;
            await smtp.SendMailAsync(msg);
           
        }

        private void WFinPDF(decimal totalSumToOrder, int invoiceID)
        {
            using (var db = new MellorShopEntities1())
            {
                //Creating iTextSharp Table from the DataTable data
                PdfPTable pdfTable = new PdfPTable(dataGridViewOrder.Columns.Count);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;

                //If we work only with English-language texts, then the font can be omitted
                BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

                //Adding Header row
                foreach (DataGridViewColumn column in dataGridViewOrder.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));

                    cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                    pdfTable.AddCell(cell);
                }               

                foreach (DataGridViewRow row in dataGridViewOrder.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string value = cell.Value == null ? "" : cell.Value.ToString();
                        pdfTable.AddCell(new Phrase(value, font));
                    }
                }

                string head = $"\n                                                                  Invoice  # {invoiceID}\n " +
                              $"                                                                                                                       {DateTime.Now}\n\n\n";
                Paragraph headerP = new Paragraph(head);

                string str = $"\nPayment amount :                                                                                                   {Math.Round(totalSumToOrder, 2)}";
                Paragraph totalSum = new Paragraph(str);

                using (FileStream stream = new FileStream("DataGridViewExport.pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(headerP);
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Add(totalSum);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
            //MessageBox.Show("Pdf-документ сохранен");
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            dataGridViewOrder.Rows.Clear();
            prodFromGrid.Clear();
            DialogResult = DialogResult.No;
        }
            
    private void buttonDelete_Click(object sender, EventArgs e)
        {
            //we get the product code that we want to delete
            int delVendorCode = Convert.ToInt32(dataGridViewOrder.Rows[dataGridViewOrder.CurrentCell.RowIndex].Cells[0].Value.ToString());
            //get the index of the selected row
            Product delProd = new Product();
            int selectedIndex = dataGridViewOrder.CurrentCell.RowIndex;
            //if the line is highlighted , remove  row from dataGridViewOrder
            if (selectedIndex > -1)
                {
                    dataGridViewOrder.Rows.RemoveAt(selectedIndex);
                    dataGridViewOrder.Refresh();

                //remove product from list prodFromGrid, change sum end quantity
                for (int i = 0; i < prodFromGrid.Count; i++)
            {
                if (prodFromGrid[i].VendoreCode== delVendorCode)
                {
                    totalSumToOrder -= prodFromGrid[i].Remainder * prodFromGrid[i].Price;
                    amountProdToOrder -= prodFromGrid[i].Remainder;                  
                    prodFromGrid.Remove(prodFromGrid[i]);
                    textBoxQuantity.Text = amountProdToOrder.ToString();
                    textBoxOrderPrice.Text = Math.Round(totalSumToOrder, 2).ToString();
                    break;
                }
            }
                if (dataGridViewOrder.Rows.Count == 1)
                {
                    DialogResult = DialogResult.Yes;
                }
            }
            else
            {
                MessageBox.Show("Select an item to delete");
            }
        }
        private void buttonBackToSelection_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void buttonChangeQuantity_Click(object sender, EventArgs e)
        {
            //create form to change quantity selected product
            ChangeQuant changeProd = new ChangeQuant();
            //get the product code end index select row
            int changeVendorCode = Convert.ToInt32(dataGridViewOrder.Rows[dataGridViewOrder.CurrentCell.RowIndex].Cells[0].Value.ToString());
            int selectedIndex = dataGridViewOrder.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {               
                foreach (var item in prodFromGrid)
                {
                    if (item.VendoreCode == changeVendorCode)
                    {//we add to the numericUpDownQuantChange quantity of goods to change
                        changeProd.numericUpDownQuantChange.Value = item.Remainder;
                        changeProd.labelNameProd.Text = item.NameProduct;                        
                        textBoxQuantity.Text = amountProdToOrder.ToString();
                        textBoxOrderPrice.Text = Math.Round(totalSumToOrder, 2).ToString();
                        break;
                    }
                }                         
                if (changeProd.ShowDialog() == DialogResult.OK)
                {
                    foreach (var item in prodFromGrid)
                    {
                        if (item.VendoreCode == changeVendorCode)
                        {//Change quantity product on new 
                            item.Remainder= (int)changeProd.numericUpDownQuantChange.Value ;                           
                            FillingGrid(prodFromGrid);
                            textBoxQuantity.Text = amountProdToOrder.ToString();
                            textBoxOrderPrice.Text = Math.Round(totalSumToOrder, 2).ToString();
                            dataGridViewOrder.Refresh();
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select an item to change the quantity");
            }

        }
    }
}
