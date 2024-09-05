namespace Authenti_Gate.SuperAdminReports.Logs
{
    partial class FoodcourtStaffLogsForm
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
            this.studBtn = new Authenti_Gate.CustomControls.RoundedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSeeAll = new Authenti_Gate.CustomControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.studBtn.TabIndex = 5;
            this.studBtn.Text = "Print";
            this.studBtn.UseVisualStyleBackColor = false;
            this.studBtn.Click += new System.EventHandler(this.studBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(869, 421);
            this.dataGridView1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
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
            this.btnSeeAll.Location = new System.Drawing.Point(218, 6);
            this.btnSeeAll.Name = "btnSeeAll";
            this.btnSeeAll.Size = new System.Drawing.Size(104, 28);
            this.btnSeeAll.TabIndex = 19;
            this.btnSeeAll.Text = "See All";
            this.btnSeeAll.UseVisualStyleBackColor = false;
            this.btnSeeAll.Click += new System.EventHandler(this.btnSeeAll_Click);
            // 
            // FoodcourtStaffLogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 517);
            this.Controls.Add(this.btnSeeAll);
            this.Controls.Add(this.studBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodcourtStaffLogsForm";
            this.Text = "FoodcourtStaffLogsForm";
            this.Load += new System.EventHandler(this.FoodcourtStaffLogsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundedButton studBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private CustomControls.RoundedButton btnSeeAll;
    }
}