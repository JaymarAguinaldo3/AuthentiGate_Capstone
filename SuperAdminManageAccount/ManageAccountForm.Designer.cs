namespace Authenti_Gate.SuperAdminManageAccount
{
    partial class ManageAccountForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminBtn = new Authenti_Gate.CustomControls.RoundedButton();
            this.superAdminBtn = new Authenti_Gate.CustomControls.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.managePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.adminBtn);
            this.panel1.Controls.Add(this.superAdminBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 67);
            this.panel1.TabIndex = 1;
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.adminBtn.BorderColor = System.Drawing.Color.Black;
            this.adminBtn.BorderRadius = 40;
            this.adminBtn.BorderSize = 0;
            this.adminBtn.FlatAppearance.BorderSize = 0;
            this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.ForeColor = System.Drawing.Color.White;
            this.adminBtn.Location = new System.Drawing.Point(633, 21);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(119, 40);
            this.adminBtn.TabIndex = 3;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // superAdminBtn
            // 
            this.superAdminBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.superAdminBtn.BorderColor = System.Drawing.Color.Black;
            this.superAdminBtn.BorderRadius = 40;
            this.superAdminBtn.BorderSize = 0;
            this.superAdminBtn.FlatAppearance.BorderSize = 0;
            this.superAdminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.superAdminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superAdminBtn.ForeColor = System.Drawing.Color.White;
            this.superAdminBtn.Location = new System.Drawing.Point(758, 21);
            this.superAdminBtn.Name = "superAdminBtn";
            this.superAdminBtn.Size = new System.Drawing.Size(119, 40);
            this.superAdminBtn.TabIndex = 2;
            this.superAdminBtn.Text = "Super Admin";
            this.superAdminBtn.UseVisualStyleBackColor = false;
            this.superAdminBtn.Click += new System.EventHandler(this.superAdminBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Account";
            // 
            // managePanel
            // 
            this.managePanel.Location = new System.Drawing.Point(-5, 65);
            this.managePanel.Name = "managePanel";
            this.managePanel.Size = new System.Drawing.Size(894, 569);
            this.managePanel.TabIndex = 2;
            // 
            // ManageAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 630);
            this.Controls.Add(this.managePanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAccountForm";
            this.Text = "ManageAccountForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RoundedButton adminBtn;
        private CustomControls.RoundedButton superAdminBtn;
        private System.Windows.Forms.Panel managePanel;
    }
}