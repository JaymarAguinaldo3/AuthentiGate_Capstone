using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Authenti_Gate.SuperAdminTransaction.Transactions.Add
{
    public partial class AddFacultyStaffForm : Form
    {
        public AddFacultyStaffForm()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            string fullname = tbLname.Text + ", " + tbFname.Text + " " + tbMname.Text + tbSuffix.Text;

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            Byte[] img = ms.ToArray();

            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();
            try
            {
                if (tbRFID.Text == " " && tbID.Text == " " &&
                    tbLname.Text == " " && tbFname.Text == " " &&
                    tbMname.Text == " " && cbRole.SelectedIndex == -1 &&
                    cbProgram.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill all the required fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (cbRole.SelectedIndex == 0)
                    {
                        string cmm = "INSERT into faculty_table (RFID_tag, ID_Number, Full_Name, Program, Role, Picture) VALUES(@RFID_tag, @ID_Number, @Full_Name, @Program, @Role, @Picture)";
                        var cmds = new MySqlCommand(cmm, con);
                        cmds.Parameters.AddWithValue("@RFID_tag", tbRFID.Text);
                        cmds.Parameters.AddWithValue("@ID_Number", tbID.Text);
                        cmds.Parameters.AddWithValue("@Full_Name", fullname);
                        cmds.Parameters.AddWithValue("@Program", cbProgram.SelectedItem);
                        cmds.Parameters.AddWithValue("@Role", cbRole.SelectedItem);
                        cmds.Parameters.AddWithValue("@Picture", img);
                        cmds.ExecuteNonQuery();

                        MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tbRFID.Text = null;
                        tbID.Text = null;
                        tbLname.Text = null;
                        tbFname.Text = null;
                        tbMname.Text = null;
                        cbProgram.SelectedIndex = -1;
                        cbRole.SelectedIndex = -1;
                        pictureBox1.Image = Properties.Resources.Splash_AG;
                    }
                    else if (cbRole.SelectedIndex == 1)
                    {
                        string cmm = "INSERT into staff_table (RFID_tag, ID_Number, Full_Name, Role, Picture) VALUES(@RFID_tag, @ID_Number, @Full_Name, @Role, @Picture)";
                        var cmds = new MySqlCommand(cmm, con);
                        cmds.Parameters.AddWithValue("@RFID_tag", tbRFID.Text);
                        cmds.Parameters.AddWithValue("@ID_Number", tbID.Text);
                        cmds.Parameters.AddWithValue("@Full_Name", fullname);
                        cmds.Parameters.AddWithValue("@Role", cbRole.SelectedItem);
                        cmds.Parameters.AddWithValue("@Picture", img);
                        cmds.ExecuteNonQuery();

                        MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tbRFID.Text = null;
                        tbID.Text = null;
                        tbLname.Text = null;
                        tbFname.Text = null;
                        tbMname.Text = null;
                        cbProgram.SelectedIndex = -1;
                        cbRole.SelectedIndex = -1;
                        pictureBox1.Image = Properties.Resources.Splash_AG;
                    }
                    else if (cbRole.SelectedIndex == 2)
                    {
                        string cmm = "INSERT into foodcourtstaff_table (RFID_tag, ID_Number, Full_Name, Role, Picture) VALUES(@RFID_tag, @ID_Number, @Full_Name, @Role, @Picture)";
                        var cmds = new MySqlCommand(cmm, con);
                        cmds.Parameters.AddWithValue("@RFID_tag", tbRFID.Text);
                        cmds.Parameters.AddWithValue("@ID_Number", tbID.Text);
                        cmds.Parameters.AddWithValue("@Full_Name", fullname);
                        cmds.Parameters.AddWithValue("@Role", cbRole.SelectedItem);
                        cmds.Parameters.AddWithValue("@Picture", img);
                        cmds.ExecuteNonQuery();

                        MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tbRFID.Text = null;
                        tbID.Text = null;
                        tbLname.Text = null;
                        tbFname.Text = null;
                        tbMname.Text = null;
                        cbProgram.SelectedIndex = -1;
                        cbRole.SelectedIndex = -1;
                        pictureBox1.Image = Properties.Resources.Splash_AG;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRole.SelectedIndex == 0)
            {
                label7.Enabled = true;
                cbProgram.Enabled = true;
            }
            else if (cbRole.SelectedIndex == -1 || cbRole.SelectedIndex == 1 || cbRole.SelectedIndex == 2)
            {
                label7.Enabled = false;
                cbProgram.Enabled = false;
            }
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
