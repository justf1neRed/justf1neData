namespace ComputerHardwareStore
{
    partial class WorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerForm));
            this.buttonToApplyAuthorization = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1AuthorizationPersonal = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelManagerWork = new System.Windows.Forms.Panel();
            this.dataGridViewManagerForm = new System.Windows.Forms.DataGridView();
            this.vendoreCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mellorShopDataSet = new ComputerHardwareStore.MellorShopDataSet();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hDDSSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.productTableAdapter = new ComputerHardwareStore.MellorShopDataSetTableAdapters.ProductTableAdapter();
            this.panel1AuthorizationPersonal.SuspendLayout();
            this.panelManagerWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagerForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mellorShopDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonToApplyAuthorization
            // 
            this.buttonToApplyAuthorization.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonToApplyAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToApplyAuthorization.Location = new System.Drawing.Point(493, 198);
            this.buttonToApplyAuthorization.Name = "buttonToApplyAuthorization";
            this.buttonToApplyAuthorization.Size = new System.Drawing.Size(140, 58);
            this.buttonToApplyAuthorization.TabIndex = 5;
            this.buttonToApplyAuthorization.Text = "To apply";
            this.buttonToApplyAuthorization.UseVisualStyleBackColor = false;
            this.buttonToApplyAuthorization.Click += new System.EventHandler(this.buttonToApplyAuthorization_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(378, 53);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(255, 38);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(378, 116);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(255, 35);
            this.textBoxPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(161, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter password  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(161, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter login :";
            // 
            // panel1AuthorizationPersonal
            // 
            this.panel1AuthorizationPersonal.BackColor = System.Drawing.Color.Transparent;
            this.panel1AuthorizationPersonal.Controls.Add(this.buttonExit);
            this.panel1AuthorizationPersonal.Controls.Add(this.buttonToApplyAuthorization);
            this.panel1AuthorizationPersonal.Controls.Add(this.textBoxLogin);
            this.panel1AuthorizationPersonal.Controls.Add(this.textBoxPassword);
            this.panel1AuthorizationPersonal.Controls.Add(this.label1);
            this.panel1AuthorizationPersonal.Controls.Add(this.label2);
            this.panel1AuthorizationPersonal.Location = new System.Drawing.Point(12, 138);
            this.panel1AuthorizationPersonal.Name = "panel1AuthorizationPersonal";
            this.panel1AuthorizationPersonal.Size = new System.Drawing.Size(660, 337);
            this.panel1AuthorizationPersonal.TabIndex = 7;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(330, 198);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(140, 58);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // panelManagerWork
            // 
            this.panelManagerWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManagerWork.BackColor = System.Drawing.Color.LightGray;
            this.panelManagerWork.Controls.Add(this.dataGridViewManagerForm);
            this.panelManagerWork.Controls.Add(this.statusStrip1);
            this.panelManagerWork.Controls.Add(this.toolStrip1);
            this.panelManagerWork.Controls.Add(this.menuStrip1);
            this.panelManagerWork.ForeColor = System.Drawing.Color.Black;
            this.panelManagerWork.Location = new System.Drawing.Point(-1, 1);
            this.panelManagerWork.Name = "panelManagerWork";
            this.panelManagerWork.Size = new System.Drawing.Size(687, 510);
            this.panelManagerWork.TabIndex = 7;
            // 
            // dataGridViewManagerForm
            // 
            this.dataGridViewManagerForm.AllowUserToDeleteRows = false;
            this.dataGridViewManagerForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewManagerForm.AutoGenerateColumns = false;
            this.dataGridViewManagerForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManagerForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendoreCodeDataGridViewTextBoxColumn,
            this.nameProductDataGridViewTextBoxColumn,
            this.iDCategoryDataGridViewTextBoxColumn,
            this.iDManufacturerDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.remainderDataGridViewTextBoxColumn,
            this.specificationDataGridViewTextBoxColumn});
            this.dataGridViewManagerForm.DataSource = this.productBindingSource;
            this.dataGridViewManagerForm.Location = new System.Drawing.Point(6, 49);
            this.dataGridViewManagerForm.MultiSelect = false;
            this.dataGridViewManagerForm.Name = "dataGridViewManagerForm";
            this.dataGridViewManagerForm.ReadOnly = true;
            this.dataGridViewManagerForm.RowHeadersWidth = 51;
            this.dataGridViewManagerForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewManagerForm.Size = new System.Drawing.Size(678, 436);
            this.dataGridViewManagerForm.TabIndex = 14;
            // 
            // vendoreCodeDataGridViewTextBoxColumn
            // 
            this.vendoreCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vendoreCodeDataGridViewTextBoxColumn.DataPropertyName = "VendoreCode";
            this.vendoreCodeDataGridViewTextBoxColumn.HeaderText = "VendoreCode";
            this.vendoreCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vendoreCodeDataGridViewTextBoxColumn.Name = "vendoreCodeDataGridViewTextBoxColumn";
            this.vendoreCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendoreCodeDataGridViewTextBoxColumn.Width = 97;
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            this.nameProductDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.HeaderText = "NameProduct";
            this.nameProductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            this.nameProductDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameProductDataGridViewTextBoxColumn.Width = 97;
            // 
            // iDCategoryDataGridViewTextBoxColumn
            // 
            this.iDCategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDCategoryDataGridViewTextBoxColumn.DataPropertyName = "ID_Category";
            this.iDCategoryDataGridViewTextBoxColumn.HeaderText = "ID_Category";
            this.iDCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCategoryDataGridViewTextBoxColumn.Name = "iDCategoryDataGridViewTextBoxColumn";
            this.iDCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCategoryDataGridViewTextBoxColumn.Width = 91;
            // 
            // iDManufacturerDataGridViewTextBoxColumn
            // 
            this.iDManufacturerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDManufacturerDataGridViewTextBoxColumn.DataPropertyName = "ID_Manufacturer";
            this.iDManufacturerDataGridViewTextBoxColumn.HeaderText = "ID_Manufacturer";
            this.iDManufacturerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDManufacturerDataGridViewTextBoxColumn.Name = "iDManufacturerDataGridViewTextBoxColumn";
            this.iDManufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDManufacturerDataGridViewTextBoxColumn.Width = 112;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 56;
            // 
            // remainderDataGridViewTextBoxColumn
            // 
            this.remainderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.remainderDataGridViewTextBoxColumn.DataPropertyName = "Remainder";
            this.remainderDataGridViewTextBoxColumn.HeaderText = "Remainder";
            this.remainderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remainderDataGridViewTextBoxColumn.Name = "remainderDataGridViewTextBoxColumn";
            this.remainderDataGridViewTextBoxColumn.ReadOnly = true;
            this.remainderDataGridViewTextBoxColumn.Width = 83;
            // 
            // specificationDataGridViewTextBoxColumn
            // 
            this.specificationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.specificationDataGridViewTextBoxColumn.DataPropertyName = "Specification";
            this.specificationDataGridViewTextBoxColumn.HeaderText = "Specification";
            this.specificationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specificationDataGridViewTextBoxColumn.Name = "specificationDataGridViewTextBoxColumn";
            this.specificationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.mellorShopDataSet;
            // 
            // mellorShopDataSet
            // 
            this.mellorShopDataSet.DataSetName = "MellorShopDataSet";
            this.mellorShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPosition,
            this.toolStripName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(687, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripPosition
            // 
            this.toolStripPosition.Name = "toolStripPosition";
            this.toolStripPosition.Size = new System.Drawing.Size(13, 17);
            this.toolStripPosition.Text = "1";
            // 
            // toolStripName
            // 
            this.toolStripName.Name = "toolStripName";
            this.toolStripName.Size = new System.Drawing.Size(13, 17);
            this.toolStripName.Text = "2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(687, 27);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Add";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Edit";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Delete";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.categoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mBToolStripMenuItem,
            this.cPUToolStripMenuItem,
            this.gPUToolStripMenuItem,
            this.rAMToolStripMenuItem,
            this.hDDSSDToolStripMenuItem,
            this.pSToolStripMenuItem,
            this.boxToolStripMenuItem,
            this.powerToolStripMenuItem,
            this.allBaseToolStripMenuItem});
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // mBToolStripMenuItem
            // 
            this.mBToolStripMenuItem.Name = "mBToolStripMenuItem";
            this.mBToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.mBToolStripMenuItem.Text = "Motherboard";
            this.mBToolStripMenuItem.Click += new System.EventHandler(this.mBToolStripMenuItem_Click_1);
            // 
            // cPUToolStripMenuItem
            // 
            this.cPUToolStripMenuItem.Name = "cPUToolStripMenuItem";
            this.cPUToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cPUToolStripMenuItem.Text = "CPU";
            this.cPUToolStripMenuItem.Click += new System.EventHandler(this.cPUToolStripMenuItem_Click_1);
            // 
            // gPUToolStripMenuItem
            // 
            this.gPUToolStripMenuItem.Name = "gPUToolStripMenuItem";
            this.gPUToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.gPUToolStripMenuItem.Text = "GPU";
            this.gPUToolStripMenuItem.Click += new System.EventHandler(this.gPUToolStripMenuItem_Click_1);
            // 
            // rAMToolStripMenuItem
            // 
            this.rAMToolStripMenuItem.Name = "rAMToolStripMenuItem";
            this.rAMToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.rAMToolStripMenuItem.Text = "RAM";
            this.rAMToolStripMenuItem.Click += new System.EventHandler(this.rAMToolStripMenuItem_Click_1);
            // 
            // hDDSSDToolStripMenuItem
            // 
            this.hDDSSDToolStripMenuItem.Name = "hDDSSDToolStripMenuItem";
            this.hDDSSDToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.hDDSSDToolStripMenuItem.Text = "HDD";
            this.hDDSSDToolStripMenuItem.Click += new System.EventHandler(this.hDDSSDToolStripMenuItem_Click_1);
            // 
            // pSToolStripMenuItem
            // 
            this.pSToolStripMenuItem.Name = "pSToolStripMenuItem";
            this.pSToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pSToolStripMenuItem.Text = "SSD";
            this.pSToolStripMenuItem.Click += new System.EventHandler(this.pSToolStripMenuItem_Click_1);
            // 
            // boxToolStripMenuItem
            // 
            this.boxToolStripMenuItem.Name = "boxToolStripMenuItem";
            this.boxToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.boxToolStripMenuItem.Text = "Box";
            this.boxToolStripMenuItem.Click += new System.EventHandler(this.boxToolStripMenuItem_Click_1);
            // 
            // powerToolStripMenuItem
            // 
            this.powerToolStripMenuItem.Name = "powerToolStripMenuItem";
            this.powerToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.powerToolStripMenuItem.Text = "Power";
            this.powerToolStripMenuItem.Click += new System.EventHandler(this.powerToolStripMenuItem_Click_1);
            // 
            // allBaseToolStripMenuItem
            // 
            this.allBaseToolStripMenuItem.Name = "allBaseToolStripMenuItem";
            this.allBaseToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.allBaseToolStripMenuItem.Text = "All Base";
            this.allBaseToolStripMenuItem.Click += new System.EventHandler(this.allBaseToolStripMenuItem_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // WorkerForm
            // 
            this.AcceptButton = this.buttonToApplyAuthorization;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.panelManagerWork);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1AuthorizationPersonal);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager worker form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkerForm_FormClosing);
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            this.panel1AuthorizationPersonal.ResumeLayout(false);
            this.panel1AuthorizationPersonal.PerformLayout();
            this.panelManagerWork.ResumeLayout(false);
            this.panelManagerWork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagerForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mellorShopDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToApplyAuthorization;
        public System.Windows.Forms.TextBox textBoxLogin;
        public System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel1AuthorizationPersonal;
        private System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.Panel panelManagerWork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hDDSSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gPUToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem pSToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripPosition;
        private System.Windows.Forms.ToolStripStatusLabel toolStripName;
        private System.Windows.Forms.ToolStripMenuItem boxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewManagerForm;
        private MellorShopDataSet mellorShopDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private MellorShopDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendoreCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem allBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}