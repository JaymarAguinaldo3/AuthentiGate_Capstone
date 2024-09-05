using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySqlConnector;

namespace Authenti_Gate.SuperAdminReports.Logs
{
    public partial class StaffLogsForm : Form
    {
        public void FilldataAll()
        {
            string cs = @"server=localhost; userid=root; password=; database=authentigate;";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM stafflogs_table", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.AllowUserToAddRows = false;

            con.Close();
        }
        public void Filldata()
        {
            string cs = @"server=localhost; userid=root; password=; database=authentigate;";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM stafflogs_table WHERE Log_Date = '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "'", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.AllowUserToAddRows = false;

            con.Close();
        }
        public StaffLogsForm()
        {
            InitializeComponent();
        }

        private void StaffLogsForm_Load(object sender, EventArgs e)
        {
            Filldata();
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            FilldataAll();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Filldata();
        }

        ReportDataSource rs = new ReportDataSource();
        private void studBtn_Click(object sender, EventArgs e)
        {
            List<Staff> list = new List<Staff>();
            list.Clear();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                list.Add(new Staff
                {
                    Number = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    IDNum = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    Fullname = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    Logdate = dataGridView1.Rows[i].Cells[4].Value.ToString(),
                    timein = dataGridView1.Rows[i].Cells[5].Value.ToString(),
                    timeout = dataGridView1.Rows[i].Cells[6].Value.ToString()
                });
            }
            rs.Name = "DataSet1";
            rs.Value = list;
            FormReport fr = new FormReport();
            fr.reportViewer1.LocalReport.DataSources.Clear();
            fr.reportViewer1.LocalReport.DataSources.Add(rs);
            fr.reportViewer1.LocalReport.ReportEmbeddedResource = "Authenti_Gate.SuperAdminReports.Reports.StaffReports.rdlc";
            fr.ShowDialog();
        }
    }
    public class Staff
    {
        public string Number { get; set; }
        public string IDNum { get; set; }
        public string Fullname { get; set; }
        public string Logdate { get; set; }
        public string timein { get; set; }
        public string timeout { get; set; }
    }
}
