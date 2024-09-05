using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authenti_Gate.Dashboards;
using MySqlConnector;

namespace Authenti_Gate.Logins
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }
        string user = " ", pass = " ";

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                string cm = "Select Username, Password from account_table WHERE Username=@Username AND Password=@Password AND Number=2";
                var cmd = new MySqlCommand(cm, con);
                cmd.Parameters.AddWithValue("@Username", tbUsername.Text);
                cmd.Parameters.AddWithValue("@Password", tbPassword.Text);
                MySqlDataReader myReader;
                myReader = cmd.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                    user = myReader["Username"].ToString();
                    pass = myReader["Password"].ToString();
                }
                myReader.Close();
                if (count == 1)
                {
                    if (user == tbUsername.Text && pass == tbPassword.Text)
                    {
                        string cmm = "INSERT into acclogs_table (Username,Log_Date,Login_Time) VALUES('" + tbUsername.Text + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "','" + DateTime.Now.ToString("hh:mm tt") + "')";
                        var cmds = new MySqlCommand(cmm, con);
                        cmds.ExecuteNonQuery();
                        AdminDashboardForm dashboardForm = new AdminDashboardForm();
                        dashboardForm.Show();
                        this.Close();
                    }
                    else 
                    {
                        string cmm = "INSERT into acclogserror_table (Username,Log_Date) VALUES('" + "Admin" + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "')";
                        var cmds = new MySqlCommand(cmm, con);
                        cmds.ExecuteNonQuery();
                        MessageBox.Show(this, "Incorrect login credentials. Failed to login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    string cmm = "INSERT into acclogserror_table (Username,Log_Date) VALUES('" + "Admin" + "','" + DateTime.Now.ToString("MM/dd/yyyy") + "')";
                    var cmds = new MySqlCommand(cmm, con);
                    cmds.ExecuteNonQuery();
                    MessageBox.Show(this, "Incorrect login credentials. Failed to login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            DialogResult dlgR = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo);
            if (dlgR == DialogResult.Yes)
            {
                this.Close();
                ContinueAsForm continueAs = new ContinueAsForm();
                continueAs.Show();
            }
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
