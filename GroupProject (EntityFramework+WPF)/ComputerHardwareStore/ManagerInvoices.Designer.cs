namespace ComputerHardwareStore
{
    partial class ManagerInvoices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerInvoices));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewManagerInvoice = new System.Windows.Forms.DataGridView();
            this.iDInvoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInvoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUserBuyerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDOrderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPersonnelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSummDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mellorShopDataSet3 = new ComputerHardwareStore.MellorShopDataSet3();
            this.invoiceTableAdapter = new ComputerHardwareStore.MellorShopDataSet3TableAdapters.InvoiceTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagerInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mellorShopDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Exit";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "tRefresh";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // dataGridViewManagerInvoice
            // 
            this.dataGridViewManagerInvoice.AllowUserToDeleteRows = false;
            this.dataGridViewManagerInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewManagerInvoice.AutoGenerateColumns = false;
            this.dataGridViewManagerInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManagerInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDInvoiceDataGridViewTextBoxColumn,
            this.dateInvoiceDataGridViewTextBoxColumn,
            this.iDUserBuyerDataGridViewTextBoxColumn,
            this.iDOrderStatusDataGridViewTextBoxColumn,
            this.iDPersonnelDataGridViewTextBoxColumn,
            this.totalSummDataGridViewTextBoxColumn,
            this.deliveryAddressDataGridViewTextBoxColumn});
            this.dataGridViewManagerInvoice.DataSource = this.invoiceBindingSource;
            this.dataGridViewManagerInvoice.Location = new System.Drawing.Point(6, 28);
            this.dataGridViewManagerInvoice.MultiSelect = false;
            this.dataGridViewManagerInvoice.Name = "dataGridViewManagerInvoice";
            this.dataGridViewManagerInvoice.ReadOnly = true;
            this.dataGridViewManagerInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewManagerInvoice.Size = new System.Drawing.Size(678, 436);
            this.dataGridViewManagerInvoice.TabIndex = 15;
            this.dataGridViewManagerInvoice.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManagerInvoice_CellContentDoubleClick);
            // 
            // iDInvoiceDataGridViewTextBoxColumn
            // 
            this.iDInvoiceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDInvoiceDataGridViewTextBoxColumn.DataPropertyName = "ID_Invoice";
            this.iDInvoiceDataGridViewTextBoxColumn.HeaderText = "ID_Invoice";
            this.iDInvoiceDataGridViewTextBoxColumn.Name = "iDInvoiceDataGridViewTextBoxColumn";
            this.iDInvoiceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateInvoiceDataGridViewTextBoxColumn
            // 
            this.dateInvoiceDataGridViewTextBoxColumn.DataPropertyName = "DateInvoice";
            this.dateInvoiceDataGridViewTextBoxColumn.HeaderText = "DateInvoice";
            this.dateInvoiceDataGridViewTextBoxColumn.Name = "dateInvoiceDataGridViewTextBoxColumn";
            this.dateInvoiceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDUserBuyerDataGridViewTextBoxColumn
            // 
            this.iDUserBuyerDataGridViewTextBoxColumn.DataPropertyName = "ID_UserBuyer";
            this.iDUserBuyerDataGridViewTextBoxColumn.HeaderText = "ID_UserBuyer";
            this.iDUserBuyerDataGridViewTextBoxColumn.Name = "iDUserBuyerDataGridViewTextBoxColumn";
            this.iDUserBuyerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDOrderStatusDataGridViewTextBoxColumn
            // 
            this.iDOrderStatusDataGridViewTextBoxColumn.DataPropertyName = "ID_OrderStatus";
            this.iDOrderStatusDataGridViewTextBoxColumn.HeaderText = "ID_OrderStatus";
            this.iDOrderStatusDataGridViewTextBoxColumn.Name = "iDOrderStatusDataGridViewTextBoxColumn";
            this.iDOrderStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDPersonnelDataGridViewTextBoxColumn
            // 
            this.iDPersonnelDataGridViewTextBoxColumn.DataPropertyName = "ID_Personnel";
            this.iDPersonnelDataGridViewTextBoxColumn.HeaderText = "ID_Personnel";
            this.iDPersonnelDataGridViewTextBoxColumn.Name = "iDPersonnelDataGridViewTextBoxColumn";
            this.iDPersonnelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalSummDataGridViewTextBoxColumn
            // 
            this.totalSummDataGridViewTextBoxColumn.DataPropertyName = "TotalSumm";
            this.totalSummDataGridViewTextBoxColumn.HeaderText = "TotalSumm";
            this.totalSummDataGridViewTextBoxColumn.Name = "totalSummDataGridViewTextBoxColumn";
            this.totalSummDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryAddressDataGridViewTextBoxColumn
            // 
            this.deliveryAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deliveryAddressDataGridViewTextBoxColumn.DataPropertyName = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.HeaderText = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.Name = "deliveryAddressDataGridViewTextBoxColumn";
            this.deliveryAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.mellorShopDataSet3;
            // 
            // mellorShopDataSet3
            // 
            this.mellorShopDataSet3.DataSetName = "MellorShopDataSet3";
            this.mellorShopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // ManagerInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.dataGridViewManagerInvoice);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ManagerInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManagerInvoices";
            this.Load += new System.EventHandler(this.ManagerInvoices_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagerInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mellorShopDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
       public System.Windows.Forms.DataGridView dataGridViewManagerInvoice;
        private MellorShopDataSet3 mellorShopDataSet3;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private MellorShopDataSet3TableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDInvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUserBuyerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOrderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPersonnelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSummDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}