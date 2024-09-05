using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authenti_Gate.SuperAdminReports.Logs;

namespace Authenti_Gate.SuperAdminReports
{
    public partial class SuperAdminReportsForm : Form
    {
        public SuperAdminReportsForm()
        {
            InitializeComponent();

            UserLogsForm userLogs = new UserLogsForm();
            reportsPanel.Controls.Clear();
            userLogs.TopLevel = false;
            reportsPanel.Controls.Add(userLogs);
            userLogs.Dock = DockStyle.Fill;
            userLogs.Show();

            userLogsBtn.BackColor = Color.White;
            userLogsBtn.ForeColor = Color.MidnightBlue;
        }

        private void userLogsBtn_Click(object sender, EventArgs e)
        {
            UserLogsForm userLogs = new UserLogsForm();
            reportsPanel.Controls.Clear();
            userLogs.TopLevel = false;
            reportsPanel.Controls.Add(userLogs);
            userLogs.Dock = DockStyle.Fill;
            userLogs.Show();

            userLogsBtn.BackColor = Color.White;
            studLogsBtn.BackColor = Color.MidnightBlue;
            facLogsBtn.BackColor = Color.MidnightBlue;
            vehicleBtn.BackColor = Color.MidnightBlue;
            guestLogs.BackColor = Color.MidnightBlue;
            fcStaffBtn.BackColor = Color.MidnightBlue;
            staffLogsBtn.BackColor = Color.MidnightBlue;

            userLogsBtn.ForeColor = Color.MidnightBlue;
            studLogsBtn.ForeColor = Color.White;
            facLogsBtn.ForeColor = Color.White;
            vehicleBtn.ForeColor = Color.White;
            guestLogs.ForeColor = Color.White;
            fcStaffBtn.ForeColor = Color.White;
            staffLogsBtn.ForeColor = Color.White;
        }

        private void studLogsBtn_Click(object sender, EventArgs e)
        {
            StudentLogsForm studLogs = new StudentLogsForm();
            reportsPanel.Controls.Clear();
            studLogs.TopLevel = false;
            reportsPanel.Controls.Add(studLogs);
            studLogs.Dock = DockStyle.Fill;
            studLogs.Show();

            userLogsBtn.BackColor = Color.MidnightBlue;
            studLogsBtn.BackColor = Color.White;
            facLogsBtn.BackColor = Color.MidnightBlue;
            vehicleBtn.BackColor = Color.MidnightBlue;
            guestLogs.BackColor = Color.MidnightBlue;
            fcStaffBtn.BackColor = Color.MidnightBlue;
            staffLogsBtn.BackColor = Color.MidnightBlue;

            userLogsBtn.ForeColor = Color.White;
            studLogsBtn.ForeColor = Color.MidnightBlue;
            facLogsBtn.ForeColor = Color.White;
            vehicleBtn.ForeColor = Color.White;
            guestLogs.ForeColor = Color.White;
            fcStaffBtn.ForeColor = Color.White;
            staffLogsBtn.ForeColor = Color.White;
        }

        private void facLogsBtn_Click(object sender, EventArgs e)
        {
            FacultyLogsForm facStaffLogs = new FacultyLogsForm();
            reportsPanel.Controls.Clear();
            facStaffLogs.TopLevel = false;
            reportsPanel.Controls.Add(facStaffLogs);
            facStaffLogs.Dock = DockStyle.Fill;
            facStaffLogs.Show();

            userLogsBtn.BackColor = Color.MidnightBlue;
            studLogsBtn.BackColor = Color.MidnightBlue;
            facLogsBtn.BackColor = Color.White;
            vehicleBtn.BackColor = Color.MidnightBlue;
            guestLogs.BackColor = Color.MidnightBlue;
            fcStaffBtn.BackColor = Color.MidnightBlue;
            staffLogsBtn.BackColor = Color.MidnightBlue;

            userLogsBtn.ForeColor = Color.White;
            studLogsBtn.ForeColor = Color.White;
            facLogsBtn.ForeColor = Color.MidnightBlue;
            vehicleBtn.ForeColor = Color.White;
            guestLogs.ForeColor = Color.White;
            fcStaffBtn.ForeColor = Color.White;
            staffLogsBtn.ForeColor = Color.White;
        }

        private void staffLogsBtn_Click(object sender, EventArgs e)
        {
            StaffLogsForm staffLogs = new StaffLogsForm();
            reportsPanel.Controls.Clear();
            staffLogs.TopLevel = false;
            reportsPanel.Controls.Add(staffLogs);
            staffLogs.Dock = DockStyle.Fill;
            staffLogs.Show();

            userLogsBtn.BackColor = Color.MidnightBlue;
            studLogsBtn.BackColor = Color.MidnightBlue;
            facLogsBtn.BackColor = Color.MidnightBlue;
            vehicleBtn.BackColor = Color.MidnightBlue;
            guestLogs.BackColor = Color.MidnightBlue;
            fcStaffBtn.BackColor = Color.MidnightBlue;
            staffLogsBtn.BackColor = Color.White;

            userLogsBtn.ForeColor = Color.White;
            studLogsBtn.ForeColor = Color.White;
            facLogsBtn.ForeColor = Color.White;
            vehicleBtn.ForeColor = Color.White;
            guestLogs.ForeColor = Color.White;
            fcStaffBtn.ForeColor = Color.White;
            staffLogsBtn.ForeColor = Color.MidnightBlue;
        }

        private void vehicleBtn_Click(object sender, EventArgs e)
        {
            VehicleLogsForm vehicleLogs = new VehicleLogsForm();
            reportsPanel.Controls.Clear();
            vehicleLogs.TopLevel = false;
            reportsPanel.Controls.Add(vehicleLogs);
            vehicleLogs.Dock = DockStyle.Fill;
            vehicleLogs.Show();

            userLogsBtn.BackColor = Color.MidnightBlue;
            studLogsBtn.BackColor = Color.MidnightBlue;
            facLogsBtn.BackColor = Color.MidnightBlue;
            vehicleBtn.BackColor = Color.White;
            guestLogs.BackColor = Color.MidnightBlue;
            fcStaffBtn.BackColor = Color.MidnightBlue;
            staffLogsBtn.BackColor = Color.MidnightBlue;

            userLogsBtn.ForeColor = Color.White;
            studLogsBtn.ForeColor = Color.White;
            facLogsBtn.ForeColor = Color.White;
            vehicleBtn.ForeColor = Color.MidnightBlue;
            guestLogs.ForeColor = Color.White;
            fcStaffBtn.ForeColor = Color.White;
            staffLogsBtn.ForeColor = Color.White;
        }

        private void guestLogs_Click(object sender, EventArgs e)
        {
            GuestLogsForm guestLog = new GuestLogsForm();
            reportsPanel.Controls.Clear();
            guestLog.TopLevel = false;
            reportsPanel.Controls.Add(guestLog);
            guestLog.Dock = DockStyle.Fill;
            guestLog.Show();

            userLogsBtn.BackColor = Color.MidnightBlue;
            studLogsBtn.BackColor = Color.MidnightBlue;
            facLogsBtn.BackColor = Color.MidnightBlue;
            vehicleBtn.BackColor = Color.MidnightBlue;
            guestLogs.BackColor = Color.White;
            fcStaffBtn.BackColor = Color.MidnightBlue;
            staffLogsBtn.BackColor = Color.MidnightBlue;

            userLogsBtn.ForeColor = Color.White;
            studLogsBtn.ForeColor = Color.White;
            facLogsBtn.ForeColor = Color.White;
            vehicleBtn.ForeColor = Color.White;
            guestLogs.ForeColor = Color.MidnightBlue;
            fcStaffBtn.ForeColor = Color.White;
            staffLogsBtn.ForeColor = Color.White;
        }

        private void fcStaffBtn_Click(object sender, EventArgs e)
        {
            FoodcourtStaffLogsForm fcStaffLogs = new FoodcourtStaffLogsForm();
            reportsPanel.Controls.Clear();
            fcStaffLogs.TopLevel = false;
            reportsPanel.Controls.Add(fcStaffLogs);
            fcStaffLogs.Dock = DockStyle.Fill;
            fcStaffLogs.Show();

            userLogsBtn.BackColor = Color.MidnightBlue;
            studLogsBtn.BackColor = Color.MidnightBlue;
            facLogsBtn.BackColor = Color.MidnightBlue;
            vehicleBtn.BackColor = Color.MidnightBlue;
            guestLogs.BackColor = Color.MidnightBlue;
            fcStaffBtn.BackColor = Color.White;
            staffLogsBtn.BackColor = Color.MidnightBlue;

            userLogsBtn.ForeColor = Color.White;
            studLogsBtn.ForeColor = Color.White;
            facLogsBtn.ForeColor = Color.White;
            vehicleBtn.ForeColor = Color.White;
            guestLogs.ForeColor = Color.White;
            fcStaffBtn.ForeColor = Color.MidnightBlue;
            staffLogsBtn.ForeColor = Color.White;
        }
    }
}
