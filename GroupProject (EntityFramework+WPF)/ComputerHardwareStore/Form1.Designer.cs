namespace ComputerHardwareStore
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthorizationManager = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Button();
            this.button_us_OK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCatalog = new System.Windows.Forms.ComboBox();
            this.panel1StartPage = new System.Windows.Forms.Panel();
            this.panel2StoreUser = new System.Windows.Forms.Panel();
            this.panelSelectProduct = new System.Windows.Forms.Panel();
            this.buttonResetFilters = new System.Windows.Forms.Button();
            this.textBoxBefore = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.buttonBackToSelection = new System.Windows.Forms.Button();
            this.buttonGoToOrder = new System.Windows.Forms.Button();
            this.dataGridView1Products = new System.Windows.Forms.DataGridView();
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonApplyFilters = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.vProductToUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vProductsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vProduct1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1StartPage.SuspendLayout();
            this.panel2StoreUser.SuspendLayout();
            this.panelSelectProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductToUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProduct1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 664);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contact Information :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(333, 664);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zaporizhzhia, Soborny Ave., 777";
            // 
            // AuthorizationManager
            // 
            this.AuthorizationManager.BackColor = System.Drawing.Color.SteelBlue;
            this.AuthorizationManager.Cursor = System.Windows.Forms.Cursors.Cross;
            this.AuthorizationManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationManager.Location = new System.Drawing.Point(107, 55);
            this.AuthorizationManager.Name = "AuthorizationManager";
            this.AuthorizationManager.Size = new System.Drawing.Size(160, 51);
            this.AuthorizationManager.TabIndex = 7;
            this.AuthorizationManager.Text = "Manager";
            this.AuthorizationManager.UseVisualStyleBackColor = false;
            this.AuthorizationManager.Click += new System.EventHandler(this.AuthorizationManager_Click);
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.SteelBlue;
            this.User.Cursor = System.Windows.Forms.Cursors.Cross;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User.Location = new System.Drawing.Point(353, 55);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(157, 51);
            this.User.TabIndex = 8;
            this.User.Text = "User";
            this.User.UseVisualStyleBackColor = false;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // button_us_OK
            // 
            this.button_us_OK.BackColor = System.Drawing.Color.SteelBlue;
            this.button_us_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_us_OK.Location = new System.Drawing.Point(462, 179);
            this.button_us_OK.Name = "button_us_OK";
            this.button_us_OK.Size = new System.Drawing.Size(127, 41);
            this.button_us_OK.TabIndex = 6;
            this.button_us_OK.Text = "OK";
            this.button_us_OK.UseVisualStyleBackColor = false;
            this.button_us_OK.Click += new System.EventHandler(this.button_us_OK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(145, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Catalog";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxCatalog
            // 
            this.comboBoxCatalog.BackColor = System.Drawing.Color.LightBlue;
            this.comboBoxCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCatalog.FormattingEnabled = true;
            this.comboBoxCatalog.Location = new System.Drawing.Point(324, 65);
            this.comboBoxCatalog.Name = "comboBoxCatalog";
            this.comboBoxCatalog.Size = new System.Drawing.Size(277, 33);
            this.comboBoxCatalog.TabIndex = 4;
            // 
            // panel1StartPage
            // 
            this.panel1StartPage.BackColor = System.Drawing.Color.Transparent;
            this.panel1StartPage.Controls.Add(this.panel2StoreUser);
            this.panel1StartPage.Controls.Add(this.User);
            this.panel1StartPage.Controls.Add(this.AuthorizationManager);
            this.panel1StartPage.Location = new System.Drawing.Point(12, 123);
            this.panel1StartPage.Name = "panel1StartPage";
            this.panel1StartPage.Size = new System.Drawing.Size(660, 337);
            this.panel1StartPage.TabIndex = 10;
            // 
            // panel2StoreUser
            // 
            this.panel2StoreUser.Controls.Add(this.button_us_OK);
            this.panel2StoreUser.Controls.Add(this.comboBoxCatalog);
            this.panel2StoreUser.Controls.Add(this.label4);
            this.panel2StoreUser.Location = new System.Drawing.Point(0, 0);
            this.panel2StoreUser.Name = "panel2StoreUser";
            this.panel2StoreUser.Size = new System.Drawing.Size(660, 337);
            this.panel2StoreUser.TabIndex = 9;
            // 
            // panelSelectProduct
            // 
            this.panelSelectProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSelectProduct.BackColor = System.Drawing.Color.Transparent;
            this.panelSelectProduct.Controls.Add(this.buttonResetFilters);
            this.panelSelectProduct.Controls.Add(this.textBoxBefore);
            this.panelSelectProduct.Controls.Add(this.textBoxFrom);
            this.panelSelectProduct.Controls.Add(this.label3);
            this.panelSelectProduct.Controls.Add(this.ProductNameLabel);
            this.panelSelectProduct.Controls.Add(this.buttonBackToSelection);
            this.panelSelectProduct.Controls.Add(this.buttonGoToOrder);
            this.panelSelectProduct.Controls.Add(this.dataGridView1Products);
            this.panelSelectProduct.Controls.Add(this.buttonAddToOrder);
            this.panelSelectProduct.Controls.Add(this.comboBoxManufacturer);
            this.panelSelectProduct.Controls.Add(this.label7);
            this.panelSelectProduct.Controls.Add(this.buttonApplyFilters);
            this.panelSelectProduct.Controls.Add(this.label6);
            this.panelSelectProduct.Location = new System.Drawing.Point(12, 12);
            this.panelSelectProduct.Name = "panelSelectProduct";
            this.panelSelectProduct.Size = new System.Drawing.Size(671, 494);
            this.panelSelectProduct.TabIndex = 7;
            // 
            // buttonResetFilters
            // 
            this.buttonResetFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonResetFilters.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonResetFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResetFilters.Location = new System.Drawing.Point(138, 453);
            this.buttonResetFilters.Name = "buttonResetFilters";
            this.buttonResetFilters.Size = new System.Drawing.Size(118, 34);
            this.buttonResetFilters.TabIndex = 17;
            this.buttonResetFilters.Text = "Reset  Filters";
            this.buttonResetFilters.UseVisualStyleBackColor = false;
            this.buttonResetFilters.Click += new System.EventHandler(this.buttonResetFilters_Click);
            // 
            // textBoxBefore
            // 
            this.textBoxBefore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxBefore.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBefore.Location = new System.Drawing.Point(208, 412);
            this.textBoxBefore.Multiline = true;
            this.textBoxBefore.Name = "textBoxBefore";
            this.textBoxBefore.Size = new System.Drawing.Size(104, 26);
            this.textBoxBefore.TabIndex = 16;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFrom.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFrom.Location = new System.Drawing.Point(121, 412);
            this.textBoxFrom.Multiline = true;
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(65, 26);
            this.textBoxFrom.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(188, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductNameLabel.Location = new System.Drawing.Point(18, 85);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(0, 18);
            this.ProductNameLabel.TabIndex = 13;
            // 
            // buttonBackToSelection
            // 
            this.buttonBackToSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackToSelection.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonBackToSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackToSelection.Location = new System.Drawing.Point(487, 409);
            this.buttonBackToSelection.Name = "buttonBackToSelection";
            this.buttonBackToSelection.Size = new System.Drawing.Size(148, 39);
            this.buttonBackToSelection.TabIndex = 12;
            this.buttonBackToSelection.Text = "Back to selection";
            this.buttonBackToSelection.UseCompatibleTextRendering = true;
            this.buttonBackToSelection.UseVisualStyleBackColor = false;
            this.buttonBackToSelection.Click += new System.EventHandler(this.buttonBackToSelection_Click_1);
            // 
            // buttonGoToOrder
            // 
            this.buttonGoToOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGoToOrder.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonGoToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoToOrder.Location = new System.Drawing.Point(505, 17);
            this.buttonGoToOrder.Name = "buttonGoToOrder";
            this.buttonGoToOrder.Size = new System.Drawing.Size(141, 39);
            this.buttonGoToOrder.TabIndex = 9;
            this.buttonGoToOrder.Text = "Go to order";
            this.buttonGoToOrder.UseVisualStyleBackColor = false;
            this.buttonGoToOrder.Click += new System.EventHandler(this.buttonGoToOrder_Click);
            // 
            // dataGridView1Products
            // 
            this.dataGridView1Products.AllowUserToDeleteRows = false;
            this.dataGridView1Products.AllowUserToResizeColumns = false;
            this.dataGridView1Products.AllowUserToResizeRows = false;
            this.dataGridView1Products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Products.Location = new System.Drawing.Point(9, 106);
            this.dataGridView1Products.MultiSelect = false;
            this.dataGridView1Products.Name = "dataGridView1Products";
            this.dataGridView1Products.ReadOnly = true;
            this.dataGridView1Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1Products.Size = new System.Drawing.Size(651, 261);
            this.dataGridView1Products.TabIndex = 0;
            this.dataGridView1Products.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1Products_CellContentDoubleClick);
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddToOrder.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToOrder.Location = new System.Drawing.Point(334, 409);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(129, 39);
            this.buttonAddToOrder.TabIndex = 8;
            this.buttonAddToOrder.Text = "Add to order";
            this.buttonAddToOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonAddToOrder.UseVisualStyleBackColor = false;
            this.buttonAddToOrder.Click += new System.EventHandler(this.buttonAddToOrder_Click);
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxManufacturer.BackColor = System.Drawing.Color.LightBlue;
            this.comboBoxManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(121, 378);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(191, 28);
            this.comboBoxManufacturer.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(18, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Price   :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonApplyFilters
            // 
            this.buttonApplyFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonApplyFilters.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonApplyFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApplyFilters.Location = new System.Drawing.Point(7, 454);
            this.buttonApplyFilters.Name = "buttonApplyFilters";
            this.buttonApplyFilters.Size = new System.Drawing.Size(114, 34);
            this.buttonApplyFilters.TabIndex = 7;
            this.buttonApplyFilters.Text = "Apply Filters";
            this.buttonApplyFilters.UseVisualStyleBackColor = false;
            this.buttonApplyFilters.Click += new System.EventHandler(this.buttonApplyFilters_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(4, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Manufacturer :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vProductToUserBindingSource
            // 
            this.vProductToUserBindingSource.DataMember = "v_ProductToUser";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.panelSelectProduct);
            this.Controls.Add(this.panel1StartPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComputerHardwareStore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1StartPage.ResumeLayout(false);
            this.panel2StoreUser.ResumeLayout(false);
            this.panel2StoreUser.PerformLayout();
            this.panelSelectProduct.ResumeLayout(false);
            this.panelSelectProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductToUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProduct1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AuthorizationManager;
        private System.Windows.Forms.Button User;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCatalog;
        private System.Windows.Forms.Button button_us_OK;
        private System.Windows.Forms.Panel panel1StartPage;
        private System.Windows.Forms.Panel panel2StoreUser;
        private System.Windows.Forms.Panel panelSelectProduct;
        private System.Windows.Forms.DataGridView dataGridView1Products;
        private System.Windows.Forms.Button buttonApplyFilters;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.Button buttonGoToOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxManufacturer;
        private System.Windows.Forms.Button buttonBackToSelection;
        private System.Windows.Forms.Label ProductNameLabel;       
        private System.Windows.Forms.BindingSource vProductsBindingSource;   
        private System.Windows.Forms.BindingSource vProductsBindingSource1;               
        private System.Windows.Forms.BindingSource productBindingSource;        
        private System.Windows.Forms.BindingSource vProductToUserBindingSource;             
        private System.Windows.Forms.BindingSource vProduct1BindingSource;       
        private System.Windows.Forms.TextBox textBoxBefore;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonResetFilters;
    }
}