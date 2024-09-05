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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
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
                if (tbRFID.Text == " " && tbStudID.Text == " " &&
                    tbLname.Text == " " && tbFname.Text == " " &&
                    tbMname.Text == " " && cbProgram.SelectedIndex == -1 &&
                    cbYear.SelectedIndex == -1 && tbSection.Text == " " &&
                    tbPhoneNumber.Text == " ")
                {
                    MessageBox.Show("Please fill all the required fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string cmm = "INSERT into studinfo_table (RFID_tag, ID_Number, Full_Name, Program, Year, Section, Role, GuardianConNumber, Picture) VALUES(@RFID_tag, @ID_Number, @Full_Name, @Program, @Year, @Section, @Role, @GuardianConNumber, @Picture)";
                    var cmds = new MySqlCommand(cmm, con);
                    cmds.Parameters.AddWithValue("@RFID_tag", tbRFID.Text);
                    cmds.Parameters.AddWithValue("@ID_Number", tbStudID.Text);
                    cmds.Parameters.AddWithValue("@Full_Name", fullname);
                    cmds.Parameters.AddWithValue("@Program", cbProgram.SelectedItem);
                    cmds.Parameters.AddWithValue("@Year", cbYear.SelectedItem);
                    cmds.Parameters.AddWithValue("@Section", tbSection.Text);
                    cmds.Parameters.AddWithValue("@Role", "Student");
                    cmds.Parameters.AddWithValue("@GuardianConNumber", tbPhoneNumber.Text);
                    cmds.Parameters.AddWithValue("@Picture", img);
                    cmds.ExecuteNonQuery();

                    MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbRFID.Text = null;
                    tbStudID.Text = null;
                    tbLname.Text = null;
                    tbFname.Text = null;
                    tbMname.Text = null;
                    cbProgram.SelectedIndex = -1;
                    cbYear.SelectedIndex = -1;
                    tbSection.Text = null;
                    tbPhoneNumber.Text = null;
                    pictureBox1.Image = Properties.Resources.Splash_AG;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
