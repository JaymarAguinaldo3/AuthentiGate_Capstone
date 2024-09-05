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
    public partial class FacultyStaffTransacForm : Form
    {
        int num = 0, Count = 0;
        string IDno = " ";
        public void DelFCStaff()
        {

            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                string cm = "DELETE FROM foodcourtstaff_table WHERE RFID_tag = '" + tbRFID.Text + "'";
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
        public void DelStaff()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                string cm = "DELETE FROM staff_table WHERE RFID_tag = '" + tbRFID.Text + "'";
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
        public void DelFaculty()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                string cm = "DELETE FROM faculty_table WHERE RFID_tag = '" + tbRFID.Text + "'";
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
        public void disable() 
        {
            tbRFID.Enabled = false;
            tbIDno.Enabled = false;
            tbFullName.Enabled = false;
            cbProgram.Enabled = false;
            cbRole.Enabled = false;
            roundedButton3.Enabled = false;
        }
        public void enable() 
        {
            tbRFID.Enabled = true;
            tbIDno.Enabled = true;
            tbFullName.Enabled = true;
            cbProgram.Enabled = true;
            cbRole.Enabled = true;
            roundedButton3.Enabled = true;
        }
        public void UpdateFCStaff()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            Byte[] img = ms.ToArray();

            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);

            try
            {
                con.Open();
                string cm = "UPDATE foodcourtstaff_table SET RFID_tag='" + tbRFID.Text + "',ID_Number='" + tbIDno.Text + "',Full_Name='" + tbFullName.Text + "',Picture= '" + img + "' WHERE ID_Number = '" + IDno + "' ";

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
        public void UpdateStaff()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            Byte[] img = ms.ToArray();

            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);

            try
            {
                con.Open();
                string cm = "UPDATE staff_table SET RFID_tag='" + tbRFID.Text + "',ID_Number='" + tbIDno.Text + "',Full_Name='" + tbFullName.Text + "',Picture= '" + img + "' WHERE ID_Number = '" + IDno + "' ";

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
        public void UpdateFaculty()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            Byte[] img = ms.ToArray();

            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);

            try
            {
                con.Open();
                string cm = "UPDATE faculty_table SET RFID_tag='" + tbRFID.Text + "',ID_Number='" + tbIDno.Text + "',Full_Name='" + tbFullName.Text + "',Program='" + cbProgram.SelectedItem + "',Picture= '" + img + "' WHERE ID_Number = '" + IDno + "' ";

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
        public void FilldataAllFaculty()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM faculty_table", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.AllowUserToAddRows = false;
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView1.Columns[5];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;

            Count = dataGridView1.Rows.Count;
            labelTot.Text = Count.ToString();

            con.Close();

        }
        public string FilldataDifFac(string condition)
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM faculty_table WHERE Program = '" + condition + "'", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.AllowUserToAddRows = false;
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView1.Columns[5];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;

            Count = dataGridView1.Rows.Count;
            labelTot.Text = Count.ToString();

            con.Close();

            return condition;

        }
        public void FilldataStaff()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM staff_table", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.AllowUserToAddRows = false;
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView1.Columns[4];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;

            Count = dataGridView1.Rows.Count;
            labelTot.Text = Count.ToString();

            con.Close();
        }
        public void FilldataFcStaff()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM foodcourtstaff_table", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.AllowUserToAddRows = false;
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView1.Columns[4];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;

            Count = dataGridView1.Rows.Count;
            labelTot.Text = Count.ToString();

            con.Close();
        }
        public FacultyStaffTransacForm()
        {
            InitializeComponent();

            allBtn.BackColor = Color.White;
            allBtn.ForeColor = Color.MidnightBlue;
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            FilldataAllFaculty();
            allBtn.BackColor = Color.White;
            cicsBtn.BackColor = Color.MidnightBlue;
            chmBtn.BackColor = Color.MidnightBlue;
            ctedBtn.BackColor = Color.MidnightBlue;
            coaBtn.BackColor = Color.MidnightBlue;
            staffBtn.BackColor = Color.MidnightBlue;
            fcStaffBtn.BackColor = Color.MidnightBlue;

            allBtn.ForeColor = Color.MidnightBlue;
            cicsBtn.ForeColor = Color.White;
            chmBtn.ForeColor = Color.White;
            ctedBtn.ForeColor = Color.White;
            coaBtn.ForeColor = Color.White;
            staffBtn.ForeColor = Color.White;
            fcStaffBtn.ForeColor = Color.White;

            label6.Visible = true;
            cbProgram.Visible = true;
            num = 0;

            tbRFID.Text = " ";
            tbIDno.Text = " ";
            tbFullName.Text = " ";
            cbRole.SelectedIndex = -1;
            cbProgram.SelectedIndex = -1;
        }

        private void cicsBtn_Click(object sender, EventArgs e)
        {
            string name = "BSIT";
            FilldataDifFac(name);
            allBtn.BackColor = Color.MidnightBlue;
            cicsBtn.BackColor = Color.White;
            chmBtn.BackColor = Color.MidnightBlue;
            ctedBtn.BackColor = Color.MidnightBlue;
            coaBtn.BackColor = Color.MidnightBlue;
            staffBtn.BackColor = Color.MidnightBlue;
            fcStaffBtn.BackColor = Color.MidnightBlue;

            allBtn.ForeColor = Color.White;
            cicsBtn.ForeColor = Color.MidnightBlue;
            chmBtn.ForeColor = Color.White;
            ctedBtn.ForeColor = Color.White;
            coaBtn.ForeColor = Color.White;
            staffBtn.ForeColor = Color.White;
            fcStaffBtn.ForeColor = Color.White;

            label6.Visible = true;
            cbProgram.Visible = true;
            num = 0;

            tbRFID.Text = " ";
            tbIDno.Text = " ";
            tbFullName.Text = " ";
            cbRole.SelectedIndex = -1;
            cbProgram.SelectedIndex = -1;
        }

        private void chmBtn_Click(object sender, EventArgs e)
        {
            string name = "BSHM";
            FilldataDifFac(name);
            allBtn.BackColor = Color.MidnightBlue;
            cicsBtn.BackColor = Color.MidnightBlue;
            chmBtn.BackColor = Color.White;
            ctedBtn.BackColor = Color.MidnightBlue;
            coaBtn.BackColor = Color.MidnightBlue;
            staffBtn.BackColor = Color.MidnightBlue;
            fcStaffBtn.BackColor = Color.MidnightBlue;

            allBtn.ForeColor = Color.White;
            cicsBtn.ForeColor = Color.White;
            chmBtn.ForeColor = Color.MidnightBlue;
            ctedBtn.ForeColor = Color.White;
            coaBtn.ForeColor = Color.White;
            staffBtn.ForeColor = Color.White;
            fcStaffBtn.ForeColor = Color.White;

            label6.Visible = true;
            cbProgram.Visible = true;
            num = 0;

            tbRFID.Text = " ";
            tbIDno.Text = " ";
            tbFullName.Text = " ";
            cbRole.SelectedIndex = -1;
            cbProgram.SelectedIndex = -1;
        }

        private void ctedBtn_Click(object sender, EventArgs e)
        {
            string name = "BSED";
            FilldataDifFac(name);
            allBtn.BackColor = Color.MidnightBlue;
            cicsBtn.BackColor = Color.MidnightBlue;
            chmBtn.BackColor = Color.MidnightBlue;
            ctedBtn.BackColor = Color.White;
            coaBtn.BackColor = Color.MidnightBlue;
            staffBtn.BackColor = Color.MidnightBlue;
            fcStaffBtn.BackColor = Color.MidnightBlue;

            allBtn.ForeColor = Color.White;
            cicsBtn.ForeColor = Color.White;
            chmBtn.ForeColor = Color.White;
            ctedBtn.ForeColor = Color.MidnightBlue;
            coaBtn.ForeColor = Color.White;
            staffBtn.ForeColor = Color.White;
            fcStaffBtn.ForeColor = Color.White;

            label6.Visible = true;
            cbProgram.Visible = true;
            num = 0;

            tbRFID.Text = " ";
            tbIDno.Text = " ";
            tbFullName.Text = " ";
            cbRole.SelectedIndex = -1;
            cbProgram.SelectedIndex = -1;
        }

        private void coaBtn_Click(object sender, EventArgs e)
        {
            string name = "BSA";
            FilldataDifFac(name);
            allBtn.BackColor = Color.MidnightBlue;
            cicsBtn.BackColor = Color.MidnightBlue;
            chmBtn.BackColor = Color.MidnightBlue;
            ctedBtn.BackColor = Color.MidnightBlue;
            coaBtn.BackColor = Color.White;
            staffBtn.BackColor = Color.MidnightBlue;
            fcStaffBtn.BackColor = Color.MidnightBlue;

            allBtn.ForeColor = Color.White;
            cicsBtn.ForeColor = Color.White;
            chmBtn.ForeColor = Color.White;
            ctedBtn.ForeColor = Color.White;
            coaBtn.ForeColor = Color.MidnightBlue;
            staffBtn.ForeColor = Color.White;
            fcStaffBtn.ForeColor = Color.White;

            label6.Visible = true;
            cbProgram.Visible = true;
            num = 0;

            tbRFID.Text = " ";
            tbIDno.Text = " ";
            tbFullName.Text = " ";
            cbRole.SelectedIndex = -1;
            cbProgram.SelectedIndex = -1;
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            FilldataStaff();
            allBtn.BackColor = Color.MidnightBlue;
            cicsBtn.BackColor = Color.MidnightBlue;
            chmBtn.BackColor = Color.MidnightBlue;
            ctedBtn.BackColor = Color.MidnightBlue;
            coaBtn.BackColor = Color.MidnightBlue;
            staffBtn.BackColor = Color.White;
            fcStaffBtn.BackColor = Color.MidnightBlue;

            allBtn.ForeColor = Color.White;
            cicsBtn.ForeColor = Color.White;
            chmBtn.ForeColor = Color.White;
            ctedBtn.ForeColor = Color.White;
            coaBtn.ForeColor = Color.White;
            staffBtn.ForeColor = Color.MidnightBlue;
            fcStaffBtn.ForeColor = Color.White;

            label6.Visible = false;
            cbProgram.Visible = false;
            num = 1;

            tbRFID.Text = " ";
            tbIDno.Text = " ";
            tbFullName.Text = " ";
            cbRole.SelectedIndex = -1;
            cbProgram.SelectedIndex = -1;
        }

        private void fcStaffBtn_Click(object sender, EventArgs e)
        {
            FilldataFcStaff();
            allBtn.BackColor = Color.MidnightBlue;
            cicsBtn.BackColor = Color.MidnightBlue;
            chmBtn.BackColor = Color.MidnightBlue;
            ctedBtn.BackColor = Color.MidnightBlue;
            coaBtn.BackColor = Color.MidnightBlue;
            staffBtn.BackColor = Color.MidnightBlue;
            fcStaffBtn.BackColor = Color.White;

            allBtn.ForeColor = Color.White;
            cicsBtn.ForeColor = Color.White;
            chmBtn.ForeColor = Color.White;
            ctedBtn.ForeColor = Color.White;
            coaBtn.ForeColor = Color.White;
            staffBtn.ForeColor = Color.White;
            fcStaffBtn.ForeColor = Color.MidnightBlue;

            label6.Visible = false;
            cbProgram.Visible = false;
            num = 1;

            tbRFID.Text = " ";
            tbIDno.Text = " ";
            tbFullName.Text = " ";
            cbRole.SelectedIndex = -1;
            cbProgram.SelectedIndex = -1;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddFacultyStaffForm addFacultyStaffForm = new AddFacultyStaffForm();
            addFacultyStaffForm.Show();
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

        private void FacultyStaffTransacForm_Load(object sender, EventArgs e)
        {
            FilldataAllFaculty();
            disable();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            IDno = tbIDno.Text;
            if (num == 0)
            {
                UpdateFaculty();
                disable();
                pictureBox1.Image = Properties.Resources.Splash_AG;
            }
            else if (num == 1)
            {
                if (cbRole.SelectedIndex == 1)
                {
                    UpdateStaff();
                    disable();
                    pictureBox1.Image = Properties.Resources.Splash_AG;
                }
                else if (cbRole.SelectedIndex == 2)
                {
                    UpdateFCStaff();
                    disable();
                    pictureBox1.Image = Properties.Resources.Splash_AG;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FilldataAllFaculty();
            FilldataFcStaff();
            FilldataStaff();
            FilldataDifFac("BSIT");
            FilldataDifFac("BSHM");
            FilldataDifFac("BSED");
            FilldataDifFac("BSA");
            timer1.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (num == 1)
            {
                tbRFID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tbIDno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tbFullName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cbRole.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[4].Value;
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
            else if (num == 0)
            {
                tbRFID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tbIDno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tbFullName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cbRole.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cbProgram.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (tbRFID.Text == null)
            {
                MessageBox.Show("Select a record from the table", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dlgR = MessageBox.Show("Do you really want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgR == DialogResult.Yes)
                {
                    if (cbRole.SelectedIndex == 0)
                    {
                        if (Name == "BSIT")
                        {
                            DelFaculty();
                            FilldataDifFac(Name);
                        }
                        else if (Name == "BSHM")
                        {
                            DelFaculty();
                            FilldataDifFac(Name);
                        }
                        else if (Name == "BSED")
                        {
                            DelFaculty();
                            FilldataDifFac(Name);
                        }
                        else if (Name == "BSA")
                        {
                            DelFaculty();
                            FilldataDifFac(Name);
                        }
                        FilldataAllFaculty();
                    }
                    else if (cbRole.SelectedIndex == 1)
                    {
                        DelStaff();
                        FilldataStaff();
                    }
                    else if (cbRole.SelectedIndex == 2)
                    {
                        DelFCStaff();
                        FilldataFcStaff();
                    }
                }
            }
        }
    }
}
