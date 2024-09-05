namespace Authenti_Gate.SuperAdminReports.Logs
{
    partial class FacultyLogsForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studBtn = new Authenti_Gate.CustomControls.RoundedButton();
            this.roundedPanel2 = new Authenti_Gate.CustomControls.RoundedPanel();
            this.coaBtn = new Authenti_Gate.CustomControls.RoundedButton();
            this.allBtn = new Authenti_Gate.CustomControls.RoundedButton();
            this.ctedBtn = new Authenti_Gate.CustomControls.RoundedButton();
            this.cicsBtn = new Authenti_Gate.CustomControls.RoundedButton();
            this.chmBtn = new Authenti_Gate.CustomControls.RoundedButton();
            this.btnSeeAll = new Authenti_Gate.CustomControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.roundedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(869, 421);
            this.dataGridView1.TabIndex = 1;
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
            this.studBtn.Location = new System.Drawing.Point(746, 465);
            this.studBtn.Name = "studBtn";
            this.studBtn.Size = new System.Drawing.Size(135, 40);
            this.studBtn.TabIndex = 2;
            this.studBtn.Text = "Print";
            this.studBtn.UseVisualStyleBackColor = false;
            this.studBtn.Click += new System.EventHandler(this.studBtn_Click);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.roundedPanel2.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel2.BorderRadius = 40;
            this.roundedPanel2.BorderSize = 0;
            this.roundedPanel2.Controls.Add(this.coaBtn);
            this.roundedPanel2.Controls.Add(this.allBtn);
            this.roundedPanel2.Controls.Add(this.ctedBtn);
            this.roundedPanel2.Controls.Add(this.cicsBtn);
            this.roundedPanel2.Controls.Add(this.chmBtn);
            this.roundedPanel2.Location = new System.Drawing.Point(12, 465);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(557, 40);
            this.roundedPanel2.TabIndex = 4;
            // 
            // coaBtn
            // 
            this.coaBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.coaBtn.BorderColor = System.Drawing.Color.Black;
            this.coaBtn.BorderRadius = 30;
            this.coaBtn.BorderSize = 0;
            this.coaBtn.FlatAppearance.BorderSize = 0;
            this.coaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coaBtn.ForeColor = System.Drawing.Color.White;
            this.coaBtn.Location = new System.Drawing.Point(430, 5);
            this.coaBtn.Name = "coaBtn";
            this.coaBtn.Size = new System.Drawing.Size(93, 32);
            this.coaBtn.TabIndex = 22;
            this.coaBtn.Text = "COA";
            this.coaBtn.UseVisualStyleBackColor = false;
            this.coaBtn.Click += new System.EventHandler(this.coaBtn_Click);
            // 
            // allBtn
            // 
            this.allBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.allBtn.BorderColor = System.Drawing.Color.Black;
            this.allBtn.BorderRadius = 30;
            this.allBtn.BorderSize = 0;
            this.allBtn.FlatAppearance.BorderSize = 0;
            this.allBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allBtn.ForeColor = System.Drawing.Color.White;
            this.allBtn.Location = new System.Drawing.Point(34, 5);
            this.allBtn.Name = "allBtn";
            this.allBtn.Size = new System.Drawing.Size(93, 32);
            this.allBtn.TabIndex = 18;
            this.allBtn.Text = "All";
            this.allBtn.UseVisualStyleBackColor = false;
            this.allBtn.Click += new System.EventHandler(this.allBtn_Click);
            // 
            // ctedBtn
            // 
            this.ctedBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.ctedBtn.BorderColor = System.Drawing.Color.Black;
            this.ctedBtn.BorderRadius = 30;
            this.ctedBtn.BorderSize = 0;
            this.ctedBtn.FlatAppearance.BorderSize = 0;
            this.ctedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctedBtn.ForeColor = System.Drawing.Color.White;
            this.ctedBtn.Location = new System.Drawing.Point(331, 5);
            this.ctedBtn.Name = "ctedBtn";
            this.ctedBtn.Size = new System.Drawing.Size(93, 32);
            this.ctedBtn.TabIndex = 21;
            this.ctedBtn.Text = "CTED";
            this.ctedBtn.UseVisualStyleBackColor = false;
            this.ctedBtn.Click += new System.EventHandler(this.ctedBtn_Click);
            // 
            // cicsBtn
            // 
            this.cicsBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.cicsBtn.BorderColor = System.Drawing.Color.Black;
            this.cicsBtn.BorderRadius = 30;
            this.cicsBtn.BorderSize = 0;
            this.cicsBtn.FlatAppearance.BorderSize = 0;
            this.cicsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cicsBtn.ForeColor = System.Drawing.Color.White;
            this.cicsBtn.Location = new System.Drawing.Point(133, 5);
            this.cicsBtn.Name = "cicsBtn";
            this.cicsBtn.Size = new System.Drawing.Size(93, 32);
            this.cicsBtn.TabIndex = 19;
            this.cicsBtn.Text = "CICS";
            this.cicsBtn.UseVisualStyleBackColor = false;
            this.cicsBtn.Click += new System.EventHandler(this.cicsBtn_Click);
            // 
            // chmBtn
            // 
            this.chmBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.chmBtn.BorderColor = System.Drawing.Color.Black;
            this.chmBtn.BorderRadius = 30;
            this.chmBtn.BorderSize = 0;
            this.chmBtn.FlatAppearance.BorderSize = 0;
            this.chmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chmBtn.ForeColor = System.Drawing.Color.White;
            this.chmBtn.Location = new System.Drawing.Point(232, 5);
            this.chmBtn.Name = "chmBtn";
            this.chmBtn.Size = new System.Drawing.Size(93, 32);
            this.chmBtn.TabIndex = 20;
            this.chmBtn.Text = "CHM";
            this.chmBtn.UseVisualStyleBackColor = false;
            this.chmBtn.Click += new System.EventHandler(this.chmBtn_Click);
            // 
            // btnSeeAll
            // 
            this.btnSeeAll.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSeeAll.BorderColor = System.Drawing.Color.Black;
            this.btnSeeAll.BorderRadius = 40;
            this.btnSeeAll.BorderSize = 0;
            this.btnSeeAll.FlatAppearance.BorderSize = 0;
            this.btnSeeAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeAll.ForeColor = System.Drawing.Color.White;
            this.btnSeeAll.Location = new System.Drawing.Point(218, 7);
            this.btnSeeAll.Name = "btnSeeAll";
            this.btnSeeAll.Size = new System.Drawing.Size(104, 28);
            this.btnSeeAll.TabIndex = 19;
            this.btnSeeAll.Text = "See All";
            this.btnSeeAll.UseVisualStyleBackColor = false;
            this.btnSeeAll.Click += new System.EventHandler(this.btnSeeAll_Click);
            // 
            // FacultyLogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 517);
            this.Controls.Add(this.btnSeeAll);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.studBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacultyLogsForm";
            this.Text = "FacultyLogsForm";
            this.Load += new System.EventHandler(this.FacultyLogsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.roundedPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControls.RoundedButton studBtn;
        private CustomControls.RoundedPanel roundedPanel2;
        private CustomControls.RoundedButton coaBtn;
        private CustomControls.RoundedButton allBtn;
        private CustomControls.RoundedButton ctedBtn;
        private CustomControls.RoundedButton cicsBtn;
        private CustomControls.RoundedButton chmBtn;
        private CustomControls.RoundedButton btnSeeAll;
    }
}