using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authenti_Gate.Dashboards;
using Authenti_Gate.Logins;

namespace Authenti_Gate
{
    public partial class ContinueAsForm : Form
    {
        public ContinueAsForm()
        {
            InitializeComponent();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            AdminLoginForm loginForm = new AdminLoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void superAdminBtn_Click(object sender, EventArgs e)
        {
            SuperAdminLoginForm loginForm = new SuperAdminLoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            DialogResult dlgR = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo);
            if (dlgR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
