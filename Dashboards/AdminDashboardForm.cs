using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authenti_Gate.AdminScan;
using Authenti_Gate.Home;
using MySqlConnector;

namespace Authenti_Gate.Dashboards
{
    public partial class AdminDashboardForm : Form
    {
        public void Logout()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);

            try
            {
                con.Open();
                string cm = "UPDATE acclogs_table SET Logout_Time = '" + DateTime.Now.ToString("hh:mm tt") + "' WHERE Username = '" + "Admin" + "' AND Log_Date = '" + DateTime.Now.ToString("MM/dd/yyyy") + "' AND Logout_Time = '"+" "+"' ";
                var cmd = new MySqlCommand(cm, con);
                cmd.ExecuteNonQuery();
                ContinueAsForm continueAs = new ContinueAsForm();
                continueAs.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public AdminDashboardForm()
        {
            InitializeComponent();

            homeBtn.BackColor = Color.White;
            homeBtn.ForeColor = Color.MidnightBlue;

            HomeForm superAdminHome = new HomeForm();
            mainPanel.Controls.Clear();
            superAdminHome.TopLevel = false;
            mainPanel.Controls.Add(superAdminHome);
            superAdminHome.Dock = DockStyle.Fill;
            superAdminHome.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.White;
            scanBtn.BackColor = Color.MidnightBlue;

            homeBtn.ForeColor = Color.MidnightBlue;
            scanBtn.ForeColor = Color.White;


            HomeForm superAdminHome = new HomeForm();
            mainPanel.Controls.Clear();
            superAdminHome.TopLevel = false;
            mainPanel.Controls.Add(superAdminHome);
            superAdminHome.Dock = DockStyle.Fill;
            superAdminHome.Show();
        }

        private void scanBtn_Click(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.MidnightBlue;
            scanBtn.BackColor = Color.White;

            homeBtn.ForeColor = Color.White;
            scanBtn.ForeColor = Color.MidnightBlue;

            ScanForm scan = new ScanForm();
            mainPanel.Controls.Clear();
            scan.TopLevel = false;
            mainPanel.Controls.Add(scan);
            scan.Dock = DockStyle.Fill;
            scan.Show();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            labelMonth.Text = DateTime.Now.ToString("MMM");
            labelDay.Text = DateTime.Now.ToString("dd");
            labelYear.Text = DateTime.Now.ToString("yyyy");
            labelTime.Text = DateTime.Now.ToString("hh:mm tt");
            timer1.Start();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dlgR = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo);
            if (dlgR == DialogResult.Yes)
            {
                Logout();
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            DialogResult dlgR = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo);
            if (dlgR == DialogResult.Yes)
            {
                Logout();
            }
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm tt");
            timer1.Start();
        }
    }
}
