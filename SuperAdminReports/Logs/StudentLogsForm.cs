﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySqlConnector;

namespace Authenti_Gate.SuperAdminReports.Logs
{
    public partial class StudentLogsForm : Form
    {
        string prog = " ";
        public void FilldataAllDate()
        {
            string cs = @"server=localhost; userid=root; password=; database=authentigate;";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM studlogs_table WHERE Log_date = '"+dateTimePicker1.Value.ToString("MM/dd/yyyy")+"'", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.AllowUserToAddRows = false;

            con.Close();
        }
        public void FilldataAll()
        {
            string cs = @"server=localhost; userid=root; password=; database=authentigate;";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM studlogs_table", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.AllowUserToAddRows = false;

            con.Close();
        }
        public string FilldataDate(string condition)
        {
            string cs = @"server=localhost; userid=root; password=; database=authentigate;";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM studlogs_table WHERE Program = '"+condition +"' AND Log_date = '"+dateTimePicker1.Value.ToString("MM/dd/yyyy")+"'", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.AllowUserToAddRows = false;

            con.Close();

            return condition;
        }
        public string Filldata(string condition)
        {
            string cs = @"server=localhost; userid=root; password=; database=authentigate;";
            var con = new MySqlConnection(cs);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM studlogs_table WHERE Program = '" + condition + "'", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.AllowUserToAddRows = false;

            con.Close();

            return condition;
        }
        public StudentLogsForm()
        {
            InitializeComponent();

            allBtn.BackColor = Color.White;
            allBtn.ForeColor = Color.MidnightBlue;
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            prog = "ALL";
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
            prog = "BSIT";
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
            Filldata(prog);
        }

        private void chmBtn_Click(object sender, EventArgs e)
        {
            prog = "BSHM";
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
            Filldata(prog);
        }

        private void ctedBtn_Click(object sender, EventArgs e)
        {
            prog = "BSED";
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
            Filldata(prog);
        }

        private void coaBtn_Click(object sender, EventArgs e)
        {
            prog = "BSA";
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
            Filldata(prog);
        }

        private void StudentLogsForm_Load(object sender, EventArgs e)
        {
            prog = "ALL";
            FilldataAllDate();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (prog.Equals("ALL"))
            {
                FilldataAllDate();
            }
            else if (prog.Equals("BSIT"))
            {
                FilldataDate(prog);
            }
            else if (prog.Equals("BSHM"))
            {
                FilldataDate(prog);
            }
            else if (prog.Equals("BSED"))
            {
                FilldataDate(prog);
            }
            else if (prog.Equals("BSA")) 
            {
                FilldataDate(prog);
            }
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            if (prog.Equals("ALL"))
            {
                FilldataAll();
            }
            else if (prog.Equals("BSIT"))
            {
                Filldata(prog);
            }
            else if (prog.Equals("BSHM"))
            {
                Filldata(prog);
            }
            else if (prog.Equals("BSED"))
            {
                Filldata(prog);
            }
            else if (prog.Equals("BSA"))
            {
                Filldata(prog);
            }
        }
        ReportDataSource rs = new ReportDataSource();
        private void studBtn_Click(object sender, EventArgs e)
        {
            List<Student> list = new List<Student>();
            list.Clear();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                list.Add(new Student
                {
                    Number = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    IDNum = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    Fullname = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    Program = dataGridView1.Rows[i].Cells[3].Value.ToString(),
                    Year = dataGridView1.Rows[i].Cells[4].Value.ToString(),
                    Section = dataGridView1.Rows[i].Cells[5].Value.ToString(),
                    Logdate = dataGridView1.Rows[i].Cells[6].Value.ToString(),
                    timein = dataGridView1.Rows[i].Cells[7].Value.ToString(),
                    timeout = dataGridView1.Rows[i].Cells[8].Value.ToString()
                });
            }
            rs.Name = "DataSet1";
            rs.Value = list;
            FormReport fr = new FormReport();
            fr.reportViewer1.LocalReport.DataSources.Clear();
            fr.reportViewer1.LocalReport.DataSources.Add(rs);
            fr.reportViewer1.LocalReport.ReportEmbeddedResource = "Authenti_Gate.SuperAdminReports.Reports.StudReports.rdlc";
            fr.ShowDialog();
        }
    }
    public class Student 
    {
        public string Number { get; set; }
        public string IDNum { get; set; }
        public string Fullname { get; set; }
        public string Program { get; set; }
        public string Year { get; set; }
        public string Section { get; set; }
        public string Logdate { get; set; }
        public string timein { get; set; }
        public string timeout { get; set; }
    }
}