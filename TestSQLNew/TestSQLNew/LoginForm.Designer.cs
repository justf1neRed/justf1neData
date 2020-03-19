namespace TestSQLNew
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.BackGroundPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.PassField = new System.Windows.Forms.TextBox();
            this.LockIcon = new System.Windows.Forms.PictureBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.LoginIcon = new System.Windows.Forms.PictureBox();
            this.AutorizationText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BackGroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LockIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGroundPanel
            // 
            this.BackGroundPanel.BackColor = System.Drawing.Color.Khaki;
            this.BackGroundPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackGroundPanel.BackgroundImage")));
            this.BackGroundPanel.Controls.Add(this.label2);
            this.BackGroundPanel.Controls.Add(this.label1);
            this.BackGroundPanel.Controls.Add(this.EnterButton);
            this.BackGroundPanel.Controls.Add(this.PassField);
            this.BackGroundPanel.Controls.Add(this.LockIcon);
            this.BackGroundPanel.Controls.Add(this.LoginField);
            this.BackGroundPanel.Controls.Add(this.LoginIcon);
            this.BackGroundPanel.Controls.Add(this.AutorizationText);
            this.BackGroundPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackGroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackGroundPanel.Name = "BackGroundPanel";
            this.BackGroundPanel.Size = new System.Drawing.Size(484, 361);
            this.BackGroundPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(157, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Register new Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.Turquoise;
            this.EnterButton.FlatAppearance.BorderSize = 0;
            this.EnterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(215, 255);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(90, 40);
            this.EnterButton.TabIndex = 5;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(161, 203);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(200, 29);
            this.PassField.TabIndex = 4;
            this.PassField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassField.UseSystemPasswordChar = true;
            // 
            // LockIcon
            // 
            this.LockIcon.BackColor = System.Drawing.Color.Transparent;
            this.LockIcon.Image = global::TestSQLNew.Properties.Resources.Lock;
            this.LockIcon.Location = new System.Drawing.Point(79, 184);
            this.LockIcon.Name = "LockIcon";
            this.LockIcon.Size = new System.Drawing.Size(64, 64);
            this.LockIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LockIcon.TabIndex = 3;
            this.LockIcon.TabStop = false;
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(161, 118);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(200, 30);
            this.LoginField.TabIndex = 2;
            this.LoginField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginIcon
            // 
            this.LoginIcon.BackColor = System.Drawing.Color.Transparent;
            this.LoginIcon.Image = global::TestSQLNew.Properties.Resources.User;
            this.LoginIcon.Location = new System.Drawing.Point(79, 96);
            this.LoginIcon.Name = "LoginIcon";
            this.LoginIcon.Size = new System.Drawing.Size(64, 64);
            this.LoginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginIcon.TabIndex = 1;
            this.LoginIcon.TabStop = false;
            // 
            // AutorizationText
            // 
            this.AutorizationText.BackColor = System.Drawing.Color.Transparent;
            this.AutorizationText.Font = new System.Drawing.Font("Harrington", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutorizationText.ForeColor = System.Drawing.Color.Turquoise;
            this.AutorizationText.Location = new System.Drawing.Point(159, 27);
            this.AutorizationText.Name = "AutorizationText";
            this.AutorizationText.Size = new System.Drawing.Size(200, 43);
            this.AutorizationText.TabIndex = 0;
            this.AutorizationText.Text = "Autorization";
            this.AutorizationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Harrington", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(452, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.BackGroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorizaton Form";
            this.BackGroundPanel.ResumeLayout(false);
            this.BackGroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LockIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackGroundPanel;
        private System.Windows.Forms.PictureBox LockIcon;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.PictureBox LoginIcon;
        private System.Windows.Forms.Label AutorizationText;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

