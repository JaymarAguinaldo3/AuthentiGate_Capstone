namespace Authenti_Gate.Dashboards
{
    partial class AdminDashboardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedPanel2 = new Authenti_Gate.CustomControls.RoundedPanel();
            this.labelTime = new System.Windows.Forms.Label();
            this.roundedPanel1 = new Authenti_Gate.CustomControls.RoundedPanel();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.logoutBtn = new Authenti_Gate.CustomControls.RoundedButton();
            this.scanBtn = new Authenti_Gate.CustomControls.RoundedButton();
            this.homeBtn = new Authenti_Gate.CustomControls.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.roundedButton3 = new Authenti_Gate.CustomControls.RoundedButton();
            this.roundedButton1 = new Authenti_Gate.CustomControls.RoundedButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.roundedPanel2);
            this.panel1.Controls.Add(this.roundedPanel1);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.scanBtn);
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 666);
            this.panel1.TabIndex = 1;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel2.BorderRadius = 40;
            this.roundedPanel2.BorderSize = 0;
            this.roundedPanel2.Controls.Add(this.labelTime);
            this.roundedPanel2.Location = new System.Drawing.Point(16, 420);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(224, 100);
            this.roundedPanel2.TabIndex = 7;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(90, 32);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(35, 13);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "label1";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderRadius = 40;
            this.roundedPanel1.BorderSize = 0;
            this.roundedPanel1.Controls.Add(this.labelYear);
            this.roundedPanel1.Controls.Add(this.labelDay);
            this.roundedPanel1.Controls.Add(this.labelMonth);
            this.roundedPanel1.Location = new System.Drawing.Point(16, 314);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(224, 100);
            this.roundedPanel1.TabIndex = 6;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(160, 46);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(35, 13);
            this.labelYear.TabIndex = 0;
            this.labelYear.Text = "label1";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(90, 46);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(35, 13);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "label1";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(16, 46);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(35, 13);
            this.labelMonth.TabIndex = 0;
            this.labelMonth.Text = "label1";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.logoutBtn.BorderColor = System.Drawing.Color.Black;
            this.logoutBtn.BorderRadius = 40;
            this.logoutBtn.BorderSize = 0;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(16, 608);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(224, 40);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // scanBtn
            // 
            this.scanBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.scanBtn.BorderColor = System.Drawing.Color.Black;
            this.scanBtn.BorderRadius = 40;
            this.scanBtn.BorderSize = 0;
            this.scanBtn.FlatAppearance.BorderSize = 0;
            this.scanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanBtn.ForeColor = System.Drawing.Color.White;
            this.scanBtn.Location = new System.Drawing.Point(16, 184);
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.Size = new System.Drawing.Size(224, 40);
            this.scanBtn.TabIndex = 2;
            this.scanBtn.TabStop = false;
            this.scanBtn.Text = "Scan";
            this.scanBtn.UseVisualStyleBackColor = false;
            this.scanBtn.Click += new System.EventHandler(this.scanBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.homeBtn.BorderColor = System.Drawing.Color.Black;
            this.homeBtn.BorderRadius = 40;
            this.homeBtn.BorderSize = 0;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Location = new System.Drawing.Point(16, 138);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(224, 40);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.TabStop = false;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Authenti_Gate.Properties.Resources.admin_header;
            this.pictureBox1.Location = new System.Drawing.Point(16, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(245, 33);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(884, 630);
            this.mainPanel.TabIndex = 2;
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
            this.roundedButton3.Location = new System.Drawing.Point(1061, 5);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(22, 22);
            this.roundedButton3.TabIndex = 29;
            this.roundedButton3.TabStop = false;
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
            this.roundedButton1.Location = new System.Drawing.Point(1089, 5);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(22, 22);
            this.roundedButton1.TabIndex = 28;
            this.roundedButton1.TabStop = false;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1123, 657);
            this.Controls.Add(this.roundedButton3);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboardForm";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.RoundedButton logoutBtn;
        private CustomControls.RoundedButton scanBtn;
        private CustomControls.RoundedButton homeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mainPanel;
        private CustomControls.RoundedButton roundedButton3;
        private CustomControls.RoundedButton roundedButton1;
        private CustomControls.RoundedPanel roundedPanel2;
        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Timer timer1;
    }
}