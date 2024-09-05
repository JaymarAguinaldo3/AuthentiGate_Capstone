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

namespace Authenti_Gate.Home
{
    public partial class HomeForm : Form
    {
        int stCount = 0, fCount = 0, sCount = 0, fsCount = 0, vCount = 0, gCount = 0;
        public HomeForm()
        {
            InitializeComponent();
        }
        public void TotStud() 
        {
            try 
            {
                string cs = @"server=localhost;userid=root;password=;database=authentigate";
                var con = new MySqlConnection(cs);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM studinfo_table WHERE Program = '"+"BSIT"+"' ", con);
                var count = cmd.ExecuteScalar();
                int c = count.GetHashCode();
                pbSbsit.Maximum = 1000;
                pbSbsit.Minimum = 0;
                pbSbsit.Value = c;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string cs = @"server=localhost;userid=root;password=;database=authentigate";
                var con = new MySqlConnection(cs);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM studinfo_table WHERE Program = '" + "BSED" + "' ", con);
                var count = cmd.ExecuteScalar();
                int c = count.GetHashCode();
                pbSbsed.Maximum = 1000;
                pbSbsed.Minimum = 0;
                pbSbsed.Value = c;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string cs = @"server=localhost;userid=root;password=;database=authentigate";
                var con = new MySqlConnection(cs);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM studinfo_table WHERE Program = '" + "BSHM" + "' ", con);
                var count = cmd.ExecuteScalar();
                int c = count.GetHashCode();
                pbSbshm.Maximum = 1000;
                pbSbshm.Minimum = 0;
                pbSbshm.Value = c;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string cs = @"server=localhost;userid=root;password=;database=authentigate";
                var con = new MySqlConnection(cs);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM studinfo_table WHERE Program = '" + "BSA" + "' ", con);
                var count = cmd.ExecuteScalar();
                int c = count.GetHashCode();
                pbSbsa.Maximum = 1000;
                pbSbsa.Minimum = 0;
                pbSbsa.Value = c;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void TotFac()
        {
            try
            {
                string cs = @"server=localhost;userid=root;password=;database=authentigate";
                var con = new MySqlConnection(cs);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM faculty_table WHERE Program = '" + "BSIT" + "' ", con);
                var count = cmd.ExecuteScalar();
                int c = count.GetHashCode();
                pbFbsit.Maximum = 1000;
                pbFbsit.Minimum = 0;
                pbFbsit.Value = c;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string cs = @"server=localhost;userid=root;password=;database=authentigate";
                var con = new MySqlConnection(cs);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM faculty_table WHERE Program = '" + "BSED" + "' ", con);
                var count = cmd.ExecuteScalar();
                int c = count.GetHashCode();
                pbFbsed.Maximum = 1000;
                pbFbsed.Minimum = 0;
                pbFbsed.Value = c;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string cs = @"server=localhost;userid=root;password=;database=authentigate";
                var con = new MySqlConnection(cs);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM faculty_table WHERE Program = '" + "BSHM" + "' ", con);
                var count = cmd.ExecuteScalar();
                int c = count.GetHashCode();
                pbFbshm.Maximum = 1000;
                pbFbshm.Minimum = 0;
                pbFbshm.Value = c;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string cs = @"server=localhost;userid=root;password=;database=authentigate";
                var con = new MySqlConnection(cs);
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM faculty_table WHERE Program = '" + "BSA" + "' ", con);
                var count = cmd.ExecuteScalar();
                int c = count.GetHashCode();
                pbFbsa.Maximum = 1000;
                pbFbsa.Minimum = 0;
                pbFbsa.Value = c;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Student() 
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM studlogs_table WHERE Log_date = '"+DateTime.Now.ToString("MM/dd/yyyy")+"' ", con);
            var count = cmd.ExecuteScalar();
            stCount = count.GetHashCode();
            con.Close();
        }
        public void Faculty() 
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM facultylogs_table WHERE Log_date = '"+DateTime.Now.ToString("MM/dd/yyyy")+"' ", con);
            var count = cmd.ExecuteScalar();
            fCount = count.GetHashCode();
            con.Close();
        }


        public void Staff() 
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM stafflogs_table WHERE Log_date = '"+DateTime.Now.ToString("MM/dd/yyyy")+"' ", con);
            var count = cmd.ExecuteScalar();
            sCount = count.GetHashCode();
            con.Close();
        }
        public void FStaff() 
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM fcstafflogs_table WHERE Log_date = '"+DateTime.Now.ToString("MM/dd/yyyy")+"' ", con);
            var count = cmd.ExecuteScalar();
            fsCount = count.GetHashCode();
            con.Close();
        }
        public void Vehicle() 
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM passedvehicle_table WHERE Log_date = '"+DateTime.Now.ToString("MM/dd/yyyy")+"' ", con);
            var count = cmd.ExecuteScalar();
            vCount = count.GetHashCode();
            con.Close();
        }
        public void Guest() 
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM guestlogs_table WHERE Log_date = '"+DateTime.Now.ToString("MM/dd/yyyy")+"' ", con);
            var count = cmd.ExecuteScalar();
            gCount = count.GetHashCode();
            con.Close();
        }
        

        private void HomeForm_Load(object sender, EventArgs e)
        {
            TotFac();
            TotStud();

            Student();
            Faculty();
            Staff();
            FStaff();
            Vehicle();
            Guest();
            labelStud.Text = stCount.ToString();
            labelFac.Text = fCount.ToString();
            labelStafF.Text = (fsCount + sCount).ToString();
            labelVec.Text = vCount.ToString();
            labelGuest.Text = gCount.ToString();
        }
    }
}
