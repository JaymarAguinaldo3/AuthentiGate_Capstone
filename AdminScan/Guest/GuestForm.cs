using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySqlConnector;

namespace Authenti_Gate.AdminScan.Guest
{
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
        }

        public void logGuest()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();
            try
            {
                string cmm = "INSERT into guestlogs_table (Name,Purpose,Plate_Number,Log_date) VALUES(@Name,@Purpose,@Plate_Number,@Log_date)";
                var cmds = new MySqlCommand(cmm, con);
                cmds.Parameters.AddWithValue("@Name", tbName.Text);
                cmds.Parameters.AddWithValue("@Purpose", tbPurpose.Text);
                cmds.Parameters.AddWithValue("@Plate_Number", tbPlate.Text);
                cmds.Parameters.AddWithValue("@Log_date", DateTime.Now.ToString("MM/dd/yyyy"));
                cmds.ExecuteNonQuery();

                MessageBox.Show("Access Granted", "Access", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbName.Text = " ";
                tbPlate.Text = " ";
                tbPurpose.Text = " ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }


        private void GuestForm_Load(object sender, EventArgs e)
        {

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbPurpose.Text))
            {
                MessageBox.Show("Please enter the name and purpose", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                logGuest();

            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
