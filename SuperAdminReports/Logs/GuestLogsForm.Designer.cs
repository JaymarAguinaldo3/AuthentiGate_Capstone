namespace Authenti_Gate.SuperAdminReports.Logs
{
    partial class GuestLogsForm
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
            this.studBtn.Location = new System.Drawing.Point(995, 572);
            this.studBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studBtn.Name = "studBtn";
            this.studBtn.Size = new System.Drawing.Size(180, 49);
            this.studBtn.TabIndex = 8;
            this.studBtn.Text = "Print";
            this.studBtn.UseVisualStyleBackColor = false;
            this.studBtn.Click += new System.EventHandler(this.studBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 47);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1159, 518);
            this.dataGridView1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 15);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            this.btnSeeAll.Location = new System.Drawing.Point(289, 7);
            this.btnSeeAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeeAll.Name = "btnSeeAll";
            this.btnSeeAll.Size = new System.Drawing.Size(139, 34);
            this.btnSeeAll.TabIndex = 22;
            this.btnSeeAll.Text = "See All";
            this.btnSeeAll.UseVisualStyleBackColor = false;
            this.btnSeeAll.Click += new System.EventHandler(this.btnSeeAll_Click);
            // 
            // GuestLogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 636);
            this.Controls.Add(this.btnSeeAll);
            this.Controls.Add(this.studBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GuestLogsForm";
            this.Text = "GuestLogsForm";
            this.Load += new System.EventHandler(this.GuestLogsForm_Load);
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