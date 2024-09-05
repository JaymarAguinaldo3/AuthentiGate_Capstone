namespace Authenti_Gate.SuperAdminTransaction
{
    partial class TransactionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vehicleBtn = new Authenti_Gate.CustomControls.RoundedButton();
            this.facStaffBtn = new Authenti_Gate.CustomControls.RoundedButton();
            this.studBtn = new Authenti_Gate.CustomControls.RoundedButton();
            this.transacPanel = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new Authenti_Gate.CustomControls.RoundedPanel();
            this.roundedButton1 = new Authenti_Gate.CustomControls.RoundedButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 67);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.roundedPanel1);
            this.panel2.Controls.Add(this.vehicleBtn);
            this.panel2.Controls.Add(this.facStaffBtn);
            this.panel2.Controls.Add(this.studBtn);
            this.panel2.Location = new System.Drawing.Point(-5, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 54);
            this.panel2.TabIndex = 2;
            // 
            // vehicleBtn
            // 
            this.vehicleBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.vehicleBtn.BorderColor = System.Drawing.Color.Black;
            this.vehicleBtn.BorderRadius = 40;
            this.vehicleBtn.BorderSize = 0;
            this.vehicleBtn.FlatAppearance.BorderSize = 0;
            this.vehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicleBtn.ForeColor = System.Drawing.Color.White;
            this.vehicleBtn.Location = new System.Drawing.Point(314, 6);
            this.vehicleBtn.Name = "vehicleBtn";
            this.vehicleBtn.Size = new System.Drawing.Size(135, 40);
            this.vehicleBtn.TabIndex = 2;
            this.vehicleBtn.Text = "Vehicles";
            this.vehicleBtn.UseVisualStyleBackColor = false;
            this.vehicleBtn.Click += new System.EventHandler(this.vehicleBtn_Click);
            // 
            // facStaffBtn
            // 
            this.facStaffBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.facStaffBtn.BorderColor = System.Drawing.Color.Black;
            this.facStaffBtn.BorderRadius = 40;
            this.facStaffBtn.BorderSize = 0;
            this.facStaffBtn.FlatAppearance.BorderSize = 0;
            this.facStaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facStaffBtn.ForeColor = System.Drawing.Color.White;
            this.facStaffBtn.Location = new System.Drawing.Point(173, 6);
            this.facStaffBtn.Name = "facStaffBtn";
            this.facStaffBtn.Size = new System.Drawing.Size(135, 40);
            this.facStaffBtn.TabIndex = 1;
            this.facStaffBtn.Text = "Faculty and Staff";
            this.facStaffBtn.UseVisualStyleBackColor = false;
            this.facStaffBtn.Click += new System.EventHandler(this.facStaffBtn_Click);
            // 
            // studBtn
            // 
            this.studBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.studBtn.BorderColor = System.Drawing.Color.Black;
            this.studBtn.BorderRadius = 40;
            this.studBtn.BorderSize = 0;
            this.studBtn.FlatAppearance.BorderSize = 0;
            this.studBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studBtn.ForeColor = System.Drawing.Color.White;
            this.studBtn.Location = new System.Drawing.Point(32, 6);
            this.studBtn.Name = "studBtn";
            this.studBtn.Size = new System.Drawing.Size(135, 40);
            this.studBtn.TabIndex = 0;
            this.studBtn.Text = "Student";
            this.studBtn.UseVisualStyleBackColor = false;
            this.studBtn.Click += new System.EventHandler(this.studBtn_Click);
            // 
            // transacPanel
            // 
            this.transacPanel.Location = new System.Drawing.Point(-5, 117);
            this.transacPanel.Name = "transacPanel";
            this.transacPanel.Size = new System.Drawing.Size(893, 515);
            this.transacPanel.TabIndex = 3;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderRadius = 40;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.textBox1);
            this.roundedPanel1.Controls.Add(this.roundedButton1);
            this.roundedPanel1.Location = new System.Drawing.Point(532, 6);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(345, 40);
            this.roundedPanel1.TabIndex = 3;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.MidnightBlue;
            this.roundedButton1.BorderColor = System.Drawing.Color.Black;
            this.roundedButton1.BorderRadius = 35;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(252, 3);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(90, 34);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.Text = "Search";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 19);
            this.textBox1.TabIndex = 1;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 630);
            this.Controls.Add(this.transacPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RoundedButton vehicleBtn;
        private CustomControls.RoundedButton facStaffBtn;
        private CustomControls.RoundedButton studBtn;
        private System.Windows.Forms.Panel transacPanel;
        private CustomControls.RoundedPanel roundedPanel1;
        private CustomControls.RoundedButton roundedButton1;
        private System.Windows.Forms.TextBox textBox1;
    }
}