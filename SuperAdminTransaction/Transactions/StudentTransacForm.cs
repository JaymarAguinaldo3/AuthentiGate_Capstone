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
using Authenti_Gate.SuperAdminTransaction.Transactions.Add;
using MySqlConnector;

namespace Authenti_Gate.SuperAdminTransaction.Transactions
{
    public partial class StudentTransacForm : Form
    {
        int Count = 0;
        string StudID = "";
        public void DelStud()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                string cm = "DELETE FROM studinfo_table WHERE RFID_tag = '" + tbRFID.Text + "'";
                var cmd = new MySqlCommand(cm, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void UpdateStudent()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            Byte[] img = ms.ToArray();

            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);

            try
            {
                con.Open();
                string cm = "UPDATE studinfo_table SET RFID_tag='" + tbRFID.Text + "',ID_Number='" + tbStudID.Text + "',Full_Name='" + tbFullName.Text + "',Program='" + cbProgram.SelectedItem + "',Year='" + cbYear.SelectedItem + "',Section='" + tbSection.Text + "',GuardianConNumber='" + tbPhone.Text + "',Picture= '" + img + "' WHERE ID_Number = '" + StudID + "' ";

                var cmd = new MySqlCommand(cm, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void FilldataAll()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM studinfo_table", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.AllowUserToAddRows = false;

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView1.Columns[8];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;

            Count = dataGridView1.Rows.Count;
            labelTot.Text = Count.ToString();

            con.Close();

        }
        public string Filldata(string condition)
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM studinfo_table WHERE Program = '" + condition + "'", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;


            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView1.Columns[8];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;

            Count = dataGridView1.Rows.Count;
            labelTot.Text = Count.ToString();

            con.Close();

            return condition;

        }

        public void disable() 
        {
            tbRFID.Enabled = false;
            tbStudID.Enabled = false;
            tbFullName.Enabled = false;
            cbProgram.Enabled = false;
            cbYear.Enabled = false;
            tbSection.Enabled = false;
            tbPhone.Enabled = false;
            roundedButton3.Enabled = false;
            updateBtn.Enabled = false;
        }
        public void enable()
        {
            tbRFID.Enabled = true;
            tbStudID.Enabled = true;
            tbFullName.Enabled = true;
            cbProgram.Enabled = true;
            cbYear.Enabled = true;
            tbSection.Enabled = true;
            tbPhone.Enabled = true;
            roundedButton3.Enabled = true;
            updateBtn.Enabled = true;
        }
        public StudentTransacForm()
        {
            InitializeComponent();

            allBtn.BackColor = Color.White;
            allBtn.ForeColor = Color.MidnightBlue;
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            allBtn.BackColor = Color.White;
            cicsBtn.BackColor = Color.MidnightBlue;
            chmBtn.BackColor = Color.MidnightBlue;
            ctedBtn.BackColor = Color.MidnightBlue;
            coaBtn.BackColor = Color.MidnightBlue;

            allBtn.ForeColor = Color.MidnightBlue;
            cicsBtn.ForeColor = Color.White;
            chmBtn.ForeColor = Color.White;
            ctedBtn.ForeColor = Color.White;
            coaBtn.ForeColor = Color.White;
            FilldataAll();
        }

        private void cicsBtn_Click(object sender, EventArgs e)
        {
            allBtn.BackColor = Color.MidnightBlue;
            cicsBtn.BackColor = Color.White;
            chmBtn.BackColor = Color.MidnightBlue;
            ctedBtn.BackColor = Color.MidnightBlue;
            coaBtn.BackColor = Color.MidnightBlue;

            allBtn.ForeColor = Color.White;
            cicsBtn.ForeColor = Color.MidnightBlue;
            chmBtn.ForeColor = Color.White;
            ctedBtn.ForeColor = Color.White;
            coaBtn.ForeColor = Color.White;
            string name = "BSIT";
            Filldata(name);
        }

        private void chmBtn_Click(object sender, EventArgs e)
        {
            allBtn.BackColor = Color.MidnightBlue;
            cicsBtn.BackColor = Color.MidnightBlue;
            chmBtn.BackColor = Color.White;
            ctedBtn.BackColor = Color.MidnightBlue;
            coaBtn.BackColor = Color.MidnightBlue;

            allBtn.ForeColor = Color.White;
            cicsBtn.ForeColor = Color.White;
            chmBtn.ForeColor = Color.MidnightBlue;
            ctedBtn.ForeColor = Color.White;
            coaBtn.ForeColor = Color.White;
            string name = "BSHM";
            Filldata(name);
        }

        private void ctedBtn_Click(object sender, EventArgs e)
        {
            allBtn.BackColor = Color.MidnightBlue;
            cicsBtn.BackColor = Color.MidnightBlue;
            chmBtn.BackColor = Color.MidnightBlue;
            ctedBtn.BackColor = Color.White;
            coaBtn.BackColor = Color.MidnightBlue;

            allBtn.ForeColor = Color.White;
            cicsBtn.ForeColor = Color.White;
            chmBtn.ForeColor = Color.White;
            ctedBtn.ForeColor = Color.MidnightBlue;
            coaBtn.ForeColor = Color.White;
            string name = "BSED";
            Filldata(name);
        }

        private void coaBtn_Click(object sender, EventArgs e)
        {
            allBtn.BackColor = Color.MidnightBlue;
            cicsBtn.BackColor = Color.MidnightBlue;
            chmBtn.BackColor = Color.MidnightBlue;
            ctedBtn.BackColor = Color.MidnightBlue;
            coaBtn.BackColor = Color.White;

            allBtn.ForeColor = Color.White;
            cicsBtn.ForeColor = Color.White;
            chmBtn.ForeColor = Color.White;
            ctedBtn.ForeColor = Color.White;
            coaBtn.ForeColor = Color.MidnightBlue;
            string name = "BSA";
            Filldata(name);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void StudentTransacForm_Load(object sender, EventArgs e)
        {
            FilldataAll();
            disable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbRFID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbStudID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbFullName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbProgram.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbYear.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbSection.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbPhone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[8].Value;

            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);

            StudID = tbStudID.Text;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateStudent();
            disable();
            pictureBox1.Image = Properties.Resources.Splash_AG;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FilldataAll();
            Filldata("BSIT");
            Filldata("BSHM");
            Filldata("BSED");
            Filldata("BSA");
            timer1.Start();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (tbRFID.Text == " ")
            {
                MessageBox.Show("Select a record from the table", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dlgR = MessageBox.Show("Do you really want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgR == DialogResult.Yes)
                {
                    DelStud();
                    if (Name == "BSIT")
                    {
                        Filldata(Name);
                    }
                    else if (Name == "BSHM")
                    {
                        Filldata(Name);
                    }
                    else if (Name == "BSED")
                    {
                        Filldata(Name);
                    }
                    else if (Name == "BSA")
                    {
                        Filldata(Name);
                    }
                    FilldataAll();
                }
            }
        }
    }
}
