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
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using MySqlConnector;

namespace Authenti_Gate.SuperAdminReports.Logs
{
    public partial class UserLogsForm : Form
    {
        public UserLogsForm()
        {
            InitializeComponent();
        }
        public void FilldataAll()
        {
            string cs = @"server=localhost; userid=root; password=; database=authentigate;";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM acclogs_table", con);
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

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM acclogs_table WHERE Log_Date = '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "'", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.AllowUserToAddRows = false;

            con.Close();
        }
        private void UserLogsForm_Load(object sender, EventArgs e)
        {
            Filldata();
        }

        ReportDataSource rs = new ReportDataSource();
        private void studBtn_Click(object sender, EventArgs e)
        {
            List<Userlg> list = new List<Userlg>();
            list.Clear();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                list.Add(new Userlg
                {
                    Number = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    UserName = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    LogDate = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    LoginTime = dataGridView1.Rows[i].Cells[3].Value.ToString(),
                    LogoutTime = dataGridView1.Rows[i].Cells[4].Value.ToString()
                });
            }
            rs.Name = "DataSet1";
            rs.Value = list;
            FormReport fr = new FormReport();
            fr.reportViewer1.LocalReport.DataSources.Clear();
            fr.reportViewer1.LocalReport.DataSources.Add(rs);
            fr.reportViewer1.LocalReport.ReportEmbeddedResource ="Authenti_Gate.SuperAdminReports.Reports.userlogs.rdlc";
            fr.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Filldata();
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            FilldataAll();
        }
    }
    
    public class Userlg
    {
        public String Number { get; set; }
        public String UserName { get; set; }
        public String LogDate { get; set; }
        public String LoginTime { get; set; }
        public String LogoutTime { get; set; }

    }
}
