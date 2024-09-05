using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authenti_Gate.SuperAdminTransaction.Transactions;

namespace Authenti_Gate.SuperAdminTransaction
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();

            studBtn.BackColor = Color.White;
            studBtn.ForeColor = Color.MidnightBlue;

            StudentTransacForm studTransac = new StudentTransacForm();
            transacPanel.Controls.Clear();
            studTransac.TopLevel = false;
            transacPanel.Controls.Add(studTransac);
            studTransac.Dock = DockStyle.Fill;
            studTransac.Show();

        }

        private void studBtn_Click(object sender, EventArgs e)
        {
            StudentTransacForm studTransac = new StudentTransacForm();
            transacPanel.Controls.Clear();
            studTransac.TopLevel = false;
            transacPanel.Controls.Add(studTransac);
            studTransac.Dock = DockStyle.Fill;
            studTransac.Show();


            studBtn.BackColor = Color.White;
            facStaffBtn.BackColor = Color.MidnightBlue;
            vehicleBtn.BackColor = Color.MidnightBlue;

            studBtn.ForeColor = Color.MidnightBlue;
            facStaffBtn.ForeColor = Color.White;
            vehicleBtn.ForeColor = Color.White;
        }

        private void facStaffBtn_Click(object sender, EventArgs e)
        {
            FacultyStaffTransacForm facultyStaffTransac = new FacultyStaffTransacForm();
            transacPanel.Controls.Clear();
            facultyStaffTransac.TopLevel = false;
            transacPanel.Controls.Add(facultyStaffTransac);
            facultyStaffTransac.Dock = DockStyle.Fill;
            facultyStaffTransac.Show();

            studBtn.BackColor = Color.MidnightBlue;
            facStaffBtn.BackColor = Color.White;
            vehicleBtn.BackColor = Color.MidnightBlue;

            studBtn.ForeColor = Color.White;
            facStaffBtn.ForeColor = Color.MidnightBlue;
            vehicleBtn.ForeColor = Color.White;
        }

        private void vehicleBtn_Click(object sender, EventArgs e)
        {
            VehicleTransacForm vehicleTransac = new VehicleTransacForm();
            transacPanel.Controls.Clear();
            vehicleTransac.TopLevel = false;
            transacPanel.Controls.Add(vehicleTransac);
            vehicleTransac.Dock = DockStyle.Fill;
            vehicleTransac.Show();

            studBtn.BackColor = Color.MidnightBlue;
            facStaffBtn.BackColor = Color.MidnightBlue;
            vehicleBtn.BackColor = Color.White;

            studBtn.ForeColor = Color.White;
            facStaffBtn.ForeColor = Color.White;
            vehicleBtn.ForeColor = Color.MidnightBlue;
        }
    }
}
