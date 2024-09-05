using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authenti_Gate.AdminScan.Guest;
using MySqlConnector;

namespace Authenti_Gate.AdminScan
{
    public partial class ScanForm : Form
    {
        string PrfidData = " ";
        string VrfidData = " ";

        SerialPort serialPort1 = new SerialPort();
        SerialPort serialPort2 = new SerialPort();

        string  id = " ", 
                name = " ", 
                position = " ", 
                college = " ", 
                year = " ", 
                section = " ", 
                date = " ", 
                time  = " ";

        public void FStaffrScan()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            using (var con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();

                    // Query to get faculty details
                    string query = "SELECT ID_Number, Full_Name, Role FROM foodcourtstaff_table WHERE Full_Name = @Full_Name";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Full_Name", labelName.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate
                                id = reader["ID_Number"].ToString();
                                name = reader["Full_Name"].ToString();
                                position = reader["Role"].ToString();
                                date = DateTime.Now.ToString("MM/dd/yyyy");
                                time = DateTime.Now.ToString("hh:mm tt");
                            }
                            else
                            {
                                return;
                            }
                        }
                    }

                    // Check if a log exists for today
                    string logQuery = "SELECT * FROM fcstafflogs_table WHERE ID_Number = @ID_Number AND Log_Date = @Log_Date AND Time_out = @Time_out";
                    using (var cmdLog = new MySqlCommand(logQuery, con))
                    {
                        cmdLog.Parameters.AddWithValue("@ID_Number", id);
                        cmdLog.Parameters.AddWithValue("@Log_Date", date);
                        cmdLog.Parameters.AddWithValue("@Time_out", " ");

                        using (var readerLog = cmdLog.ExecuteReader())
                        {
                            if (readerLog.Read())
                            {
                                // Update the Time_out if a log exists
                                readerLog.Close(); // Close reader before executing another command

                                string updateQuery = "UPDATE fcstafflogs_table SET Time_out = @Time_out WHERE  ID_Number = @ID_Number AND Log_Date = @Log_Date AND Time_out = @OldTime_out";
                                using (var cmdUpdate = new MySqlCommand(updateQuery, con))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@Time_out", time);
                                    cmdUpdate.Parameters.AddWithValue("@ID_Number", id);
                                    cmdUpdate.Parameters.AddWithValue("@Log_Date", date);
                                    cmdUpdate.Parameters.AddWithValue("@OldTime_out", " ");
                                    cmdUpdate.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Insert a new log if no entry exists for today
                                readerLog.Close(); // Close reader before executing another command

                                string insertQuery = "INSERT into fcstafflogs_table (ID_Number,Full_Name,Role,Log_date,Time_in) VALUES(@ID_Number,@Full_Name,@Role,@Log_date,@Time_in)";
                                using (var cmdInsert = new MySqlCommand(insertQuery, con))
                                {
                                    cmdInsert.Parameters.AddWithValue("@ID_Number", id);
                                    cmdInsert.Parameters.AddWithValue("@Full_Name", name);
                                    cmdInsert.Parameters.AddWithValue("@Role", position);
                                    cmdInsert.Parameters.AddWithValue("@Log_date", date);
                                    cmdInsert.Parameters.AddWithValue("@Time_in", time);
                                    cmdInsert.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void StaffrScan()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            using (var con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();

                    // Query to get faculty details
                    string query = "SELECT ID_Number, Full_Name, Role FROM staff_table WHERE Full_Name = @Full_Name";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Full_Name", labelName.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate
                                id = reader["ID_Number"].ToString();
                                name = reader["Full_Name"].ToString();
                                position = reader["Role"].ToString();
                                date = DateTime.Now.ToString("MM/dd/yyyy");
                                time = DateTime.Now.ToString("hh:mm tt");
                            }
                            else
                            {
                                return;
                            }
                        }
                    }

                    // Check if a log exists for today
                    string logQuery = "SELECT * FROM stafflogs_table WHERE ID_Number = @ID_Number AND Log_Date = @Log_Date AND Time_out = @Time_out";
                    using (var cmdLog = new MySqlCommand(logQuery, con))
                    {
                        cmdLog.Parameters.AddWithValue("@ID_Number", id);
                        cmdLog.Parameters.AddWithValue("@Log_Date", date);
                        cmdLog.Parameters.AddWithValue("@Time_out", " ");

                        using (var readerLog = cmdLog.ExecuteReader())
                        {
                            if (readerLog.Read())
                            {
                                // Update the Time_out if a log exists
                                readerLog.Close(); // Close reader before executing another command

                                string updateQuery = "UPDATE stafflogs_table SET Time_out = @Time_out WHERE  ID_Number = @ID_Number AND Log_Date = @Log_Date AND Time_out = @OldTime_out";
                                using (var cmdUpdate = new MySqlCommand(updateQuery, con))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@Time_out", time);
                                    cmdUpdate.Parameters.AddWithValue("@ID_Number", id);
                                    cmdUpdate.Parameters.AddWithValue("@Log_Date", date);
                                    cmdUpdate.Parameters.AddWithValue("@OldTime_out", " ");
                                    cmdUpdate.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Insert a new log if no entry exists for today
                                readerLog.Close(); // Close reader before executing another command

                                string insertQuery = "INSERT into stafflogs_table (ID_Number,Full_Name,Role,Log_date,Time_in) VALUES(@ID_Number,@Full_Name,@Role,@Log_date,@Time_in)";
                                using (var cmdInsert = new MySqlCommand(insertQuery, con))
                                {
                                    cmdInsert.Parameters.AddWithValue("@ID_Number", id);
                                    cmdInsert.Parameters.AddWithValue("@Full_Name", name);
                                    cmdInsert.Parameters.AddWithValue("@Role", position);
                                    cmdInsert.Parameters.AddWithValue("@Log_date", date);
                                    cmdInsert.Parameters.AddWithValue("@Time_in", time);
                                    cmdInsert.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void StudrScan()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            using (var con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();

                    // Query to get faculty details
                    string query = "SELECT ID_Number, Full_Name, Program, Year, Section, Role FROM studinfo_table WHERE Full_Name = @Full_Name";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Full_Name", labelName.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate
                                id = reader["ID_Number"].ToString();
                                name = reader["Full_Name"].ToString();
                                college = reader["Program"].ToString();
                                year = reader["Year"].ToString();
                                section = reader["Section"].ToString();
                                position = reader["Role"].ToString();
                                date = DateTime.Now.ToString("MM/dd/yyyy");
                                time = DateTime.Now.ToString("hh:mm tt");
                            }
                            else
                            {
                                return;
                            }
                        }
                    }

                    // Check if a log exists for today
                    string logQuery = "SELECT * FROM studlogs_table WHERE ID_Number = @ID_Number AND Log_Date = @Log_Date AND Time_out = @Time_out";
                    using (var cmdLog = new MySqlCommand(logQuery, con))
                    {
                        cmdLog.Parameters.AddWithValue("@ID_Number", id);
                        cmdLog.Parameters.AddWithValue("@Log_Date", date);
                        cmdLog.Parameters.AddWithValue("@Time_out", " ");

                        using (var readerLog = cmdLog.ExecuteReader())
                        {
                            if (readerLog.Read())
                            {
                                // Update the Time_out if a log exists
                                readerLog.Close(); // Close reader before executing another command

                                string updateQuery = "UPDATE studlogs_table SET Time_out = @Time_out WHERE  ID_Number = @ID_Number AND Log_Date = @Log_Date AND Time_out = @OldTime_out";
                                using (var cmdUpdate = new MySqlCommand(updateQuery, con))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@Time_out", time);
                                    cmdUpdate.Parameters.AddWithValue("@ID_Number", id);
                                    cmdUpdate.Parameters.AddWithValue("@Log_Date", date);
                                    cmdUpdate.Parameters.AddWithValue("@OldTime_out", " ");
                                    cmdUpdate.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Insert a new log if no entry exists for today
                                readerLog.Close(); // Close reader before executing another command

                                string insertQuery = "INSERT into studlogs_table (ID_Number,Full_Name,Program,Year,Section,Log_date,Time_in) VALUES(@ID_Number,@Full_Name,@Program,@Year,@Section,@Log_date,@Time_in)";
                                using (var cmdInsert = new MySqlCommand(insertQuery, con))
                                {
                                    cmdInsert.Parameters.AddWithValue("@ID_Number", id);
                                    cmdInsert.Parameters.AddWithValue("@Full_Name", name);
                                    cmdInsert.Parameters.AddWithValue("@Program", college);
                                    cmdInsert.Parameters.AddWithValue("@Year", year);
                                    cmdInsert.Parameters.AddWithValue("@Section", section);
                                    cmdInsert.Parameters.AddWithValue("@Log_date", date);
                                    cmdInsert.Parameters.AddWithValue("@Time_in", time);
                                    cmdInsert.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void FacrScan()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            using (var con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();

                    // Query to get faculty details
                    string query = "SELECT ID_Number, Full_Name,Program, Role FROM faculty_table WHERE Full_Name = @Full_Name";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Full_Name", labelName.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate
                                id = reader["ID_Number"].ToString();
                                name = reader["Full_Name"].ToString();
                                position = reader["Role"].ToString();
                                college = reader["Program"].ToString();
                                date = DateTime.Now.ToString("MM/dd/yyyy");
                                time = DateTime.Now.ToString("hh:mm tt");
                            }
                            else
                            {
                                return;
                            }
                        }
                    }

                    // Check if a log exists for today
                    string logQuery = "SELECT * FROM facultylogs_table WHERE ID_Number = @ID_Number AND Log_Date = @Log_Date AND Time_out = @Time_out";
                    using (var cmdLog = new MySqlCommand(logQuery, con))
                    {
                        cmdLog.Parameters.AddWithValue("@ID_Number", id);
                        cmdLog.Parameters.AddWithValue("@Log_Date", date);
                        cmdLog.Parameters.AddWithValue("@Time_out", " ");

                        using (var readerLog = cmdLog.ExecuteReader())
                        {
                            if (readerLog.Read())
                            {
                                // Update the Time_out if a log exists
                                readerLog.Close(); // Close reader before executing another command

                                string updateQuery = "UPDATE facultylogs_table SET Time_out = '@Time_out WHERE  ID_Number = @ID_Number AND Log_Date = @Log_Date AND Time_out = @OldTime_out";
                                using (var cmdUpdate = new MySqlCommand(updateQuery, con))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@Time_out", time);
                                    cmdUpdate.Parameters.AddWithValue("@ID_Number", id);
                                    cmdUpdate.Parameters.AddWithValue("@Log_Date", date);
                                    cmdUpdate.Parameters.AddWithValue("@OldTime_out", " ");
                                    cmdUpdate.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Insert a new log if no entry exists for today
                                readerLog.Close(); // Close reader before executing another command

                                string insertQuery = "INSERT into facultylogs_table (ID_Number,Full_Name,Program,Log_date,Time_in) VALUES(@ID_Number,@Full_Name,@Program,@Log_date,@Time_in)";
                                using (var cmdInsert = new MySqlCommand(insertQuery, con))
                                {
                                    cmdInsert.Parameters.AddWithValue("@ID_Number", id);
                                    cmdInsert.Parameters.AddWithValue("@Full_Name", name);
                                    cmdInsert.Parameters.AddWithValue("@Program", college);
                                    cmdInsert.Parameters.AddWithValue("@Log_date", date);
                                    cmdInsert.Parameters.AddWithValue("@Time_in", time);
                                    cmdInsert.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void CancelPerson() 
        {
            try 
            {
                labelID.Text = "ID Number";
                labelName.Text = "Full Name";
                labelCollege.Text = "Program";
                labelPos.Text = "Position";
                tbPrfid.Text = null;
                labelYear.Text = "Year";
                labelSection.Text = "Section";
                labelDate.Text = "Date";
                labelTime.Text = "Time";
                pictureBox1.Image = Properties.Resources.Splash_AG;

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FStaffScan()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            using (var con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();

                    // Query to get details
                    string query = "SELECT ID_Number, Full_Name, Role, Picture FROM foodcourtstaff_table WHERE RFID_tag = @RFID_tag";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RFID_tag", tbPrfid.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate labels and image
                                labelID.Text = reader["ID_Number"].ToString();
                                labelName.Text = reader["Full_Name"].ToString();
                                labelPos.Text = reader["Role"].ToString();
                                labelCollege.Text = "College";
                                labelYear.Text = "Year";
                                labelSection.Text = "Section";
                                labelDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
                                labelTime.Text = DateTime.Now.ToString("hh:mm tt");

                                if (reader["Picture"] != DBNull.Value)
                                {
                                    byte[] img = (byte[])reader["Picture"];
                                    using (var ms = new MemoryStream(img))
                                    {
                                        pictureBox1.Image = Image.FromStream(ms);
                                    }
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                    }

                    // Check if a log exists for today
                    string logQuery = "SELECT * FROM fcstafflogs_table WHERE ID_Number = @ID_Number AND Log_Date = @Log_Date AND Time_out = @Time_out";
                    using (var cmdLog = new MySqlCommand(logQuery, con))
                    {
                        cmdLog.Parameters.AddWithValue("@ID_Number", labelID.Text);
                        cmdLog.Parameters.AddWithValue("@Log_Date", labelDate.Text);
                        cmdLog.Parameters.AddWithValue("@Time_out", " ");

                        using (var readerLog = cmdLog.ExecuteReader())
                        {
                            if (readerLog.Read())
                            {
                                // Update the Time_out if a log exists
                                readerLog.Close(); // Close reader before executing another command

                                string updateQuery = "UPDATE fcstafflogs_table SET Time_out = @Time_out WHERE ID_Number = @ID_Number AND Log_Date = @Log_Date AND Time_out = @OldTime_out";
                                using (var cmdUpdate = new MySqlCommand(updateQuery, con))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@Time_out", labelTime.Text);
                                    cmdUpdate.Parameters.AddWithValue("@ID_Number", labelID.Text);
                                    cmdUpdate.Parameters.AddWithValue("@Log_Date", labelDate.Text);
                                    cmdUpdate.Parameters.AddWithValue("@OldTime_out", " ");
                                    cmdUpdate.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Insert a new log if no entry exists for today
                                readerLog.Close(); // Close reader before executing another command

                                string insertQuery = "INSERT into fcstafflogs_table (ID_Number,Full_Name,Role,Log_date,Time_in) VALUES(@ID_Number,@Full_Name,@Role,@Log_date,@Time_in)";
                                using (var cmdInsert = new MySqlCommand(insertQuery, con))
                                {
                                    cmdInsert.Parameters.AddWithValue("@ID_Number", labelID.Text);
                                    cmdInsert.Parameters.AddWithValue("@Full_Name", labelName.Text);
                                    cmdInsert.Parameters.AddWithValue("@Role", labelPos.Text);
                                    cmdInsert.Parameters.AddWithValue("@Log_date", labelDate.Text);
                                    cmdInsert.Parameters.AddWithValue("@Time_in", labelTime.Text);
                                    cmdInsert.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Access Granted", "Access", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CancelPerson();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void StaffScan()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            using (var con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();

                    // Query to get details
                    string query = "SELECT ID_Number, Full_Name, Role, Picture FROM staff_table WHERE RFID_tag = @RFID_tag";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RFID_tag", tbPrfid.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate labels and image
                                labelID.Text = reader["ID_Number"].ToString();
                                labelName.Text = reader["Full_Name"].ToString();
                                labelPos.Text = reader["Role"].ToString();
                                labelCollege.Text = "College";
                                labelYear.Text = "Year";
                                labelSection.Text = "Section";
                                labelDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
                                labelTime.Text = DateTime.Now.ToString("hh:mm tt");

                                if (reader["Picture"] != DBNull.Value)
                                {
                                    byte[] img = (byte[])reader["Picture"];
                                    using (var ms = new MemoryStream(img))
                                    {
                                        pictureBox1.Image = Image.FromStream(ms);
                                    }
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                    }

                    // Check if a log exists for today
                    string logQuery = "SELECT * FROM stafflogs_table WHERE ID_Number = @ID_Number AND Log_Date = @Log_Date AND Time_out = @Time_out";
                    using (var cmdLog = new MySqlCommand(logQuery, con))
                    {
                        cmdLog.Parameters.AddWithValue("@ID_Number", labelID.Text);
                        cmdLog.Parameters.AddWithValue("@Log_Date", labelDate.Text);
                        cmdLog.Parameters.AddWithValue("@Time_out", " ");

                        using (var readerLog = cmdLog.ExecuteReader())
                        {
                            if (readerLog.Read())
                            {
                                // Update the Time_out if a log exists
                                readerLog.Close(); // Close reader before executing another command

                                string updateQuery = "UPDATE stafflogs_table SET Time_out = @Time_out WHERE ID_Number = @ID_Number AND Log_Date = @Log_Date AND Time_out = @OldTime_out";
                                using (var cmdUpdate = new MySqlCommand(updateQuery, con))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@Time_out", labelTime.Text);
                                    cmdUpdate.Parameters.AddWithValue("@ID_Number", labelID.Text);
                                    cmdUpdate.Parameters.AddWithValue("@Log_Date", labelDate.Text);
                                    cmdUpdate.Parameters.AddWithValue("@OldTime_out", " ");
                                    cmdUpdate.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Insert a new log if no entry exists for today
                                readerLog.Close(); // Close reader before executing another command

                                string insertQuery = "INSERT into stafflogs_table (ID_Number,Full_Name,Role,Log_date,Time_in) VALUES(@ID_Number,@Full_Name,@Role,@Log_date,@Time_in)";
                                using (var cmdInsert = new MySqlCommand(insertQuery, con))
                                {
                                    cmdInsert.Parameters.AddWithValue("@ID_Number", labelID.Text);
                                    cmdInsert.Parameters.AddWithValue("@Full_Name", labelName.Text);
                                    cmdInsert.Parameters.AddWithValue("@Role", labelPos.Text);
                                    cmdInsert.Parameters.AddWithValue("@Log_date", labelDate.Text);
                                    cmdInsert.Parameters.AddWithValue("@Time_in", labelTime.Text);
                                    cmdInsert.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Access Granted", "Access", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CancelPerson();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void StudScan()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            using (var con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();

                    // Query to get details
                    string query ="SELECT ID_Number, Full_Name, Program, Year, Section, Role, Picture FROM studinfo_table WHERE RFID_tag = @RFID_tag";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RFID_tag", tbPrfid.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate labels and image
                                labelID.Text = reader["ID_Number"].ToString();
                                labelName.Text = reader["Full_Name"].ToString();
                                labelCollege.Text = reader["Program"].ToString();
                                labelYear.Text = reader["Year"].ToString();
                                labelSection.Text = reader["Section"].ToString();
                                labelPos.Text = reader["Role"].ToString();
                                labelDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
                                labelTime.Text = DateTime.Now.ToString("hh:mm tt");

                                if (reader["Picture"] != DBNull.Value)
                                {
                                    byte[] img = (byte[])reader["Picture"];
                                    using (var ms = new MemoryStream(img))
                                    {
                                        pictureBox1.Image = Image.FromStream(ms);
                                    }
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                    }

                    // Check if a log exists for today
                    string logQuery = "SELECT * FROM studlogs_table WHERE ID_Number = @ID_Number AND Log_Date = @Log_Date AND Time_out = @Time_out";
                    using (var cmdLog = new MySqlCommand(logQuery, con))
                    {
                        cmdLog.Parameters.AddWithValue("@ID_Number", labelID.Text);
                        cmdLog.Parameters.AddWithValue("@Log_Date", labelDate.Text);
                        cmdLog.Parameters.AddWithValue("@Time_out", " ");

                        using (var readerLog = cmdLog.ExecuteReader())
                        {
                            if (readerLog.Read())
                            {
                                // Update the Time_out if a log exists
                                readerLog.Close(); // Close reader before executing another command

                                string updateQuery = "UPDATE studlogs_table SET Time_out = @Time_out WHERE ID_Number = @ID_Number AND Log_Date = @Log_Date AND Time_out = @OldTime_out";
                                using (var cmdUpdate = new MySqlCommand(updateQuery, con))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@Time_out", labelTime.Text);
                                    cmdUpdate.Parameters.AddWithValue("@ID_Number", labelID.Text);
                                    cmdUpdate.Parameters.AddWithValue("@Log_Date", labelDate.Text);
                                    cmdUpdate.Parameters.AddWithValue("@OldTime_out", " ");
                                    cmdUpdate.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Insert a new log if no entry exists for today
                                readerLog.Close(); // Close reader before executing another command

                                string insertQuery = "INSERT into studlogs_table (ID_Number,Full_Name,Program,Year,Section,Log_date,Time_in) VALUES(@ID_Number,@Full_Name,@Program,@Year,@Section,@Log_date,@Time_in)";
                                using (var cmdInsert = new MySqlCommand(insertQuery, con))
                                {
                                    cmdInsert.Parameters.AddWithValue("@ID_Number", labelID.Text);
                                    cmdInsert.Parameters.AddWithValue("@Full_Name", labelName.Text);
                                    cmdInsert.Parameters.AddWithValue("@Program", labelCollege.Text);
                                    cmdInsert.Parameters.AddWithValue("@Year", labelYear.Text);
                                    cmdInsert.Parameters.AddWithValue("@Section", labelSection.Text);
                                    cmdInsert.Parameters.AddWithValue("@Log_date", labelDate.Text);
                                    cmdInsert.Parameters.AddWithValue("@Time_in", labelTime.Text);
                                    cmdInsert.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Access Granted", "Access", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CancelPerson();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void FacScan()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            using (var con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();

                    // Query to get faculty details
                    string query = "SELECT ID_Number, Full_Name, Program, Role, Picture FROM faculty_table WHERE RFID_tag = @RFID_tag";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RFID_tag", tbPrfid.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate labels and image
                                labelID.Text = reader["ID_Number"].ToString();
                                labelName.Text = reader["Full_Name"].ToString();
                                labelPos.Text = reader["Role"].ToString();
                                labelCollege.Text = reader["Program"].ToString();
                                labelYear.Text = "Year";
                                labelSection.Text = "Section";
                                labelDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
                                labelTime.Text = DateTime.Now.ToString("hh:mm tt");

                                if (reader["Picture"] != DBNull.Value)
                                {
                                    byte[] img = (byte[])reader["Picture"];
                                    using (var ms = new MemoryStream(img))
                                    {
                                        pictureBox1.Image = Image.FromStream(ms);
                                    }
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                    }

                    // Check if a log exists for today
                    string logQuery = "SELECT * FROM facultylogs_table WHERE ID_Number = @ID_Number AND Log_Date = @Log_Date AND Time_out = @Time_out";
                    using (var cmdLog = new MySqlCommand(logQuery, con))
                    {
                        cmdLog.Parameters.AddWithValue("@ID_Number", labelID.Text);
                        cmdLog.Parameters.AddWithValue("@Log_Date", labelDate.Text);
                        cmdLog.Parameters.AddWithValue("@Time_out", " ");

                        using (var readerLog = cmdLog.ExecuteReader())
                        {
                            if (readerLog.Read())
                            {
                                // Update the Time_out if a log exists
                                readerLog.Close(); // Close reader before executing another command

                                string updateQuery = "UPDATE facultylogs_table SET Time_out = @Time_out WHERE ID_Number = @ID_Number AND Log_Date = @Log_Date AND Time_out = @OldTime_out";
                                using (var cmdUpdate = new MySqlCommand(updateQuery, con))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@Time_out", labelTime.Text);
                                    cmdUpdate.Parameters.AddWithValue("@ID_Number", labelID.Text);
                                    cmdUpdate.Parameters.AddWithValue("@Log_Date", labelDate.Text);
                                    cmdUpdate.Parameters.AddWithValue("@OldTime_out", " ");
                                    cmdUpdate.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Insert a new log if no entry exists for today
                                readerLog.Close(); // Close reader before executing another command

                                string insertQuery = "INSERT INTO facultylogs_table (ID_Number, Full_Name, Program, Log_date, Time_in) VALUES(@ID_Number, @Full_Name, @Program, @Log_date, @Time_in)";
                                using (var cmdInsert = new MySqlCommand(insertQuery, con))
                                {
                                    cmdInsert.Parameters.AddWithValue("@ID_Number", labelID.Text);
                                    cmdInsert.Parameters.AddWithValue("@Full_Name", labelName.Text);
                                    cmdInsert.Parameters.AddWithValue("@Program", labelCollege.Text);
                                    cmdInsert.Parameters.AddWithValue("@Log_date", labelDate.Text);
                                    cmdInsert.Parameters.AddWithValue("@Time_in", labelTime.Text);
                                    cmdInsert.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Access Granted", "Access", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CancelPerson();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void VecScan()
        {
            string cs = @"server=localhost;userid=root;password=;database=authentigate";
            using (var con = new MySqlConnection(cs))
            {
                try
                {
                    con.Open();

                    // Query to get faculty details
                    string query = "SELECT Plate_Number, Owner_Name, Category, Model FROM vehicle_table WHERE RFID_tag = @RFID_tag";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RFID_tag", tbVrfid.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate labels and image
                                labelPlate.Text = reader["Plate_Number"].ToString();
                                labelOwner.Text = reader["Owner_Name"].ToString();
                                labelCategory.Text = reader["Category"].ToString();
                                labelModel.Text = reader["Model"].ToString();
                                labelVDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
                                labelVTime.Text = DateTime.Now.ToString("hh:mm tt");
                            }
                            else
                            {
                                return;
                            }
                        }
                    }

                    // Check if a log exists for today
                    string logQuery = "SELECT * FROM passedvehicle_table WHERE Plate_Number = @Plate_Number AND Log_Date = @Log_Date AND Time_out = @Time_out";
                    using (var cmdLog = new MySqlCommand(logQuery, con))
                    {
                        cmdLog.Parameters.AddWithValue("@Plate_Number", labelPlate.Text);
                        cmdLog.Parameters.AddWithValue("@Log_Date", labelDate.Text);
                        cmdLog.Parameters.AddWithValue("@Time_out", " ");

                        using (var readerLog = cmdLog.ExecuteReader())
                        {
                            if (readerLog.Read())
                            {
                                // Update the Time_out if a log exists
                                readerLog.Close(); // Close reader before executing another command

                                string updateQuery = "UPDATE passedvehicle_table SET Time_Out = @Time_out WHERE  Plate_Number = @Plate_Number AND Log_Date = @Log_Date AND Time_out = @OldTime_out";
                                using (var cmdUpdate = new MySqlCommand(updateQuery, con))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@Time_out", labelVTime.Text);
                                    cmdUpdate.Parameters.AddWithValue("@Plate_Number", labelPlate.Text);
                                    cmdUpdate.Parameters.AddWithValue("@Log_Date", labelVDate.Text);
                                    cmdUpdate.Parameters.AddWithValue("@OldTime_out", " ");
                                    cmdUpdate.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Insert a new log if no entry exists for today
                                readerLog.Close(); // Close reader before executing another command

                                string insertQuery = "INSERT into passedvehicle_table (Plate_Number,Owner_Name,Category,Model,Log_date,Time_In) VALUES(@Plate_Number,@Owner_Name,@Category,@Model,@Log_date,@Time_In)";
                                using (var cmdInsert = new MySqlCommand(insertQuery, con))
                                {
                                    cmdInsert.Parameters.AddWithValue("@Plate_Number", labelPlate.Text);
                                    cmdInsert.Parameters.AddWithValue("@Owner_Name", labelOwner.Text);
                                    cmdInsert.Parameters.AddWithValue("@Category", labelCategory.Text);
                                    cmdInsert.Parameters.AddWithValue("@Model", labelModel.Text);
                                    cmdInsert.Parameters.AddWithValue("@Log_date", labelVDate.Text);
                                    cmdInsert.Parameters.AddWithValue("@Time_In", labelVTime.Text);
                                    cmdInsert.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Access Granted", "Access", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CancelVec();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void CancelVec() 
        {
            try 
            {
                tbVrfid.Text = " ";
                labelPlate.Text = "Plate Number";
                labelOwner.Text = "Owner Name";
                labelCategory.Text = "Category";
                labelModel.Text = "Model";
                labelVDate.Text = "Date";
                labelVTime.Text = "Time";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public ScanForm()
        {
            InitializeComponent();
            serialPort1.PortName = "COM1";
            serialPort1.BaudRate = 9600;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

            serialPort2.PortName = "COM2";
            serialPort2.BaudRate = 9600;
            serialPort2.DataReceived += new SerialDataReceivedEventHandler(serialPort2_DataReceived);
            
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string PrfidData = serialPort1.ReadLine();
            this.Invoke(new Action(() => tbPrfid.Text = PrfidData));
        }
        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string VrfidData = serialPort1.ReadLine();
            this.Invoke(new Action(() => tbVrfid.Text = VrfidData));
        }
        private void guestBtn_Click(object sender, EventArgs e)
        {
            GuestForm guestForm = new GuestForm();
            guestForm.Show();
        }

        private void ScanForm_Load(object sender, EventArgs e)
        {
            tbPrfid.Focus();
            string[] availablePorts = SerialPort.GetPortNames();


            if (Array.Exists(availablePorts, port => port == serialPort1.PortName))
            {
                try
                {
                    serialPort1.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening serial port 1: " + ex.Message);
                }
            }

            if (Array.Exists(availablePorts, port => port == serialPort2.PortName))
            {
                try
                {
                    serialPort2.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening serial port 2: " + ex.Message);
                }
            }
        }

        private void tbPrfid_TextChanged(object sender, EventArgs e)
        {
            FacScan();
            FStaffScan();
            StaffScan();
            StudScan();
        }

        private void tbVrfid_TextChanged(object sender, EventArgs e)
        {
            VecScan();
            StudrScan();
            FacrScan();
            FStaffrScan();
            StaffrScan();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
