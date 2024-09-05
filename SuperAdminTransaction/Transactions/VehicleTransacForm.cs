using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authenti_Gate.SuperAdminTransaction.Transactions.Add;
using MySqlConnector;

namespace Authenti_Gate.SuperAdminTransaction.Transactions
{
    public partial class VehicleTransacForm : Form
    {
        int Count = 0;
        public void disable() 
        {
            tbRFID.Enabled = false;
            tbPlate.Enabled = false;
            tbModel.Enabled = false;   
            cbCategory.Enabled = false;
            tbOwner.Enabled = false;
        }
        public void enable()
        {
            tbRFID.Enabled = true;
            tbPlate.Enabled = true;
            tbModel.Enabled = true;
            cbCategory.Enabled = true;
            tbOwner.Enabled = true;
        }
        public void FilldataVehicle()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM vehicle_table", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.AllowUserToAddRows = false;

            Count = dataGridView1.Rows.Count;
            labelTot.Text = Count.ToString();

            con.Close();
        }
        public void UpdateVec() 
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            try 
            {
                con.Open();
                string cm = "UPDATE vehicle_table SET RFID_tag='" + tbRFID.Text + "',Plate_Number='" + tbPlate.Text + "',Owner_Name='" + tbOwner.Text + "',Category='" + cbCategory.SelectedItem + "',Model= '" + tbModel.Text + "' WHERE Plate_Number = '" + tbPlate.Text + "' ";
                var cmd = new MySqlCommand(cm, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DelVec()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            try
            {
                con.Open();
                string cm = "DELETE FROM vehicle_table WHERE RFID_tag = '" + tbRFID.Text + "'";
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
        public VehicleTransacForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddVehicleForm addVehicleForm = new AddVehicleForm();
            addVehicleForm.Show();
        }

        private void VehicleTransacForm_Load(object sender, EventArgs e)
        {
            FilldataVehicle();
            disable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbRFID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbPlate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbOwner.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); 
            cbCategory.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbModel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateVec();
            disable();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            enable();
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
                    DelVec();
                    FilldataVehicle();
                }
            }
        }
    }
}
