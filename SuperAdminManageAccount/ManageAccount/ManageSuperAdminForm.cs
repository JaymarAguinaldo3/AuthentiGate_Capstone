using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Authenti_Gate.SuperAdminManageAccount.ManageAccount
{
    public partial class ManageSuperAdminForm : Form
    {
        public ManageSuperAdminForm()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                string cm = "Select Password from account_table WHERE Password=@Password AND Number=1";
                var cmd = new MySqlCommand(cm, con);
                cmd.Parameters.AddWithValue("@Password", tbOldPass.Text);
                MySqlDataReader myReader;
                myReader = cmd.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                myReader.Close();
                if (count == 1)
                {
                    if (tbNewPass.Text.Equals(tbCNewPass.Text))
                    {
                        string cmm = "UPDATE account_table SET Password='" + tbNewPass.Text + "' WHERE Number = 1";
                        var cmds = new MySqlCommand(cmm, con);
                        cmds.ExecuteNonQuery();
                        MessageBox.Show("Password Changed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please confirm if the new password is matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Incorrect old password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
