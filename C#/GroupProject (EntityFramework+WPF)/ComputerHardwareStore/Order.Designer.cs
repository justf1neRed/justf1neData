namespace ComputerHardwareStore
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxOrderPrice = new System.Windows.Forms.TextBox();
            this.OrderPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonChangeQuantity = new System.Windows.Forms.Button();
            this.buttonBackToSelection = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCheckout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contact Information :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(197, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zaporizhzhia, Soborny Ave., 777";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(469, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "0677777777 / 0507777777";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(12, 120);
            this.dataGridViewOrder.MultiSelect = false;
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrder.Size = new System.Drawing.Size(660, 235);
            this.dataGridViewOrder.TabIndex = 6;
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteAll.Location = new System.Drawing.Point(15, 377);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(153, 42);
            this.buttonDeleteAll.TabIndex = 9;
            this.buttonDeleteAll.Text = "Delete All";
            this.buttonDeleteAll.UseVisualStyleBackColor = false;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuantity.Location = new System.Drawing.Point(408, 366);
            this.textBoxQuantity.Multiline = true;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(54, 31);
            this.textBoxQuantity.TabIndex = 10;
            // 
            // textBoxOrderPrice
            // 
            this.textBoxOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOrderPrice.Location = new System.Drawing.Point(568, 366);
            this.textBoxOrderPrice.Multiline = true;
            this.textBoxOrderPrice.Name = "textBoxOrderPrice";
            this.textBoxOrderPrice.Size = new System.Drawing.Size(104, 31);
            this.textBoxOrderPrice.TabIndex = 11;
            // 
            // OrderPrice
            // 
            this.OrderPrice.AutoSize = true;
            this.OrderPrice.BackColor = System.Drawing.Color.Transparent;
            this.OrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrderPrice.Location = new System.Drawing.Point(468, 377);
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.Size = new System.Drawing.Size(95, 20);
            this.OrderPrice.TabIndex = 12;
            this.OrderPrice.Text = "Order price :";
            this.OrderPrice.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(326, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quantity :";
            this.label4.UseMnemonic = false;
            // 
            // buttonChangeQuantity
            // 
            this.buttonChangeQuantity.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonChangeQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeQuantity.Location = new System.Drawing.Point(15, 429);
            this.buttonChangeQuantity.Name = "buttonChangeQuantity";
            this.buttonChangeQuantity.Size = new System.Drawing.Size(153, 42);
            this.buttonChangeQuantity.TabIndex = 14;
            this.buttonChangeQuantity.Text = "Change quantity";
            this.buttonChangeQuantity.UseVisualStyleBackColor = false;
            this.buttonChangeQuantity.Click += new System.EventHandler(this.buttonChangeQuantity_Click);
            // 
            // buttonBackToSelection
            // 
            this.buttonBackToSelection.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonBackToSelection.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBackToSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackToSelection.Location = new System.Drawing.Point(174, 431);
            this.buttonBackToSelection.Name = "buttonBackToSelection";
            this.buttonBackToSelection.Size = new System.Drawing.Size(153, 42);
            this.buttonBackToSelection.TabIndex = 15;
            this.buttonBackToSelection.Text = "Back to selection";
            this.buttonBackToSelection.UseVisualStyleBackColor = false;
            this.buttonBackToSelection.Click += new System.EventHandler(this.buttonBackToSelection_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(174, 377);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(143, 42);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheckout.Location = new System.Drawing.Point(517, 429);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(155, 42);
            this.buttonCheckout.TabIndex = 17;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = false;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // Order
            // 
            this.AcceptButton = this.buttonCheckout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonBackToSelection;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonBackToSelection);
            this.Controls.Add(this.buttonChangeQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrderPrice);
            this.Controls.Add(this.textBoxOrderPrice);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDeleteAll;
        public System.Windows.Forms.TextBox textBoxQuantity;
        public System.Windows.Forms.TextBox textBoxOrderPrice;
        private System.Windows.Forms.Label OrderPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonChangeQuantity;
        private System.Windows.Forms.Button buttonBackToSelection;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
    }
}