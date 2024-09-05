using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authenti_Gate.SuperAdminManageAccount.ManageAccount;

namespace Authenti_Gate.SuperAdminManageAccount
{
    public partial class ManageAccountForm : Form
    {
        public ManageAccountForm()
        {
            InitializeComponent();

            ManageAdminForm admin = new ManageAdminForm();
            managePanel.Controls.Clear();
            admin.TopLevel = false;
            managePanel.Controls.Add(admin);
            admin.Dock = DockStyle.Fill;
            admin.Show();


            adminBtn.BackColor = Color.White;
            adminBtn.ForeColor = Color.MidnightBlue;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            ManageAdminForm admin = new ManageAdminForm();
            managePanel.Controls.Clear();
            admin.TopLevel = false;
            managePanel.Controls.Add(admin);
            admin.Dock = DockStyle.Fill;
            admin.Show();


            adminBtn.BackColor = Color.White;
            superAdminBtn.BackColor = Color.MidnightBlue;

            adminBtn.ForeColor = Color.MidnightBlue;
            superAdminBtn.ForeColor = Color.White;
        }

        private void superAdminBtn_Click(object sender, EventArgs e)
        {
            ManageSuperAdminForm superadmin = new ManageSuperAdminForm();
            managePanel.Controls.Clear();
            superadmin.TopLevel = false;
            managePanel.Controls.Add(superadmin);
            superadmin.Dock = DockStyle.Fill;
            superadmin.Show();


            adminBtn.BackColor = Color.MidnightBlue;
            superAdminBtn.BackColor = Color.White;

            adminBtn.ForeColor = Color.White;
            superAdminBtn.ForeColor = Color.MidnightBlue;
        }
    }
}
