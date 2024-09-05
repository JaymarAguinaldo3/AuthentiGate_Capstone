namespace Authenti_Gate
{
    partial class ContinueAsForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminBtn = new Authenti_Gate.CustomControls.RoundedButton();
            this.superAdminBtn = new Authenti_Gate.CustomControls.RoundedButton();
            this.roundedButton3 = new Authenti_Gate.CustomControls.RoundedButton();
            this.roundedButton1 = new Authenti_Gate.CustomControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Authenti_Gate.Properties.Resources.Admins;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.White;
            this.adminBtn.BorderColor = System.Drawing.Color.Black;
            this.adminBtn.BorderRadius = 40;
            this.adminBtn.BorderSize = 0;
            this.adminBtn.FlatAppearance.BorderSize = 0;
            this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.adminBtn.Location = new System.Drawing.Point(240, 358);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(150, 62);
            this.adminBtn.TabIndex = 1;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // superAdminBtn
            // 
            this.superAdminBtn.BackColor = System.Drawing.Color.White;
            this.superAdminBtn.BorderColor = System.Drawing.Color.Black;
            this.superAdminBtn.BorderRadius = 40;
            this.superAdminBtn.BorderSize = 0;
            this.superAdminBtn.FlatAppearance.BorderSize = 0;
            this.superAdminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.superAdminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superAdminBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.superAdminBtn.Location = new System.Drawing.Point(396, 358);
            this.superAdminBtn.Name = "superAdminBtn";
            this.superAdminBtn.Size = new System.Drawing.Size(150, 62);
            this.superAdminBtn.TabIndex = 2;
            this.superAdminBtn.Text = "Super Admin";
            this.superAdminBtn.UseVisualStyleBackColor = false;
            this.superAdminBtn.Click += new System.EventHandler(this.superAdminBtn_Click);
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.Green;
            this.roundedButton3.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButton3.BorderRadius = 10;
            this.roundedButton3.BorderSize = 0;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.ForeColor = System.Drawing.Color.White;
            this.roundedButton3.Location = new System.Drawing.Point(738, 12);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(22, 22);
            this.roundedButton3.TabIndex = 29;
            this.roundedButton3.UseVisualStyleBackColor = false;
            this.roundedButton3.Click += new System.EventHandler(this.roundedButton3_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.Red;
            this.roundedButton1.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButton1.BorderRadius = 10;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(766, 12);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(22, 22);
            this.roundedButton1.TabIndex = 28;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // ContinueAsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundedButton3);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.superAdminBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContinueAsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContinueAsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RoundedButton adminBtn;
        private CustomControls.RoundedButton superAdminBtn;
        private CustomControls.RoundedButton roundedButton3;
        private CustomControls.RoundedButton roundedButton1;
    }
}