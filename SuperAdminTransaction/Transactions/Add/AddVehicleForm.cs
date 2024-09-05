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

namespace Authenti_Gate.SuperAdminTransaction.Transactions.Add
{
    public partial class AddVehicleForm : Form
    {
        public AddVehicleForm()
        {
            InitializeComponent();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            string fullname = tbLname.Text + ", " + tbFname.Text + " " + tbMname.Text + tbSuffix.Text;

            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();
            try
            {
                if (tbRFID.Text == " " && tbPlate.Text == " " &&
                    tbModel.Text == " " && cbCategory.SelectedIndex == -1 &&
                    tbLname.Text == " " && tbMname.Text == " " && tbFname.Text == " ")
                {
                    MessageBox.Show("Please fill all the required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string cmm = "INSERT into vehicle_table (RFID_tag, Plate_Number, Owner_Name, Category, Model) VALUES(@RFID_tag, @Plate_Number, @Owner_Name, @Category, @Model)";
                    var cmds = new MySqlCommand(cmm, con);
                    cmds.Parameters.AddWithValue("@RFID_tag", tbRFID.Text);
                    cmds.Parameters.AddWithValue("@Plate_Number", tbPlate.Text);
                    cmds.Parameters.AddWithValue("@Owner_Name", fullname);
                    cmds.Parameters.AddWithValue("@Category", cbCategory.SelectedItem);
                    cmds.Parameters.AddWithValue("@Model", tbModel.Text);
                    cmds.ExecuteNonQuery();

                    MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbRFID.Text = null;
                    tbPlate.Text = null;
                    tbLname.Text = null;
                    tbMname.Text = null;
                    tbFname.Text = null;
                    tbModel.Text = null;
                    cbCategory.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
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
