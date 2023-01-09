using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewellery_System
{
    public partial class MainAdminForm : Form
    {
        public MainAdminForm()
        {
            InitializeComponent();
        }

        private void MainAdminForm_Load(object sender, EventArgs e)
        {
            Home hm = new Home() { TopLevel = false, TopMost = true };
            hm.FormBorderStyle = FormBorderStyle.None;
            phomepage.Controls.Clear();
            phomepage.Controls.Add(hm);
            hm.Show();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home hm = new Home() { TopLevel = false, TopMost = true };
            hm.FormBorderStyle = FormBorderStyle.None;
            phomepage.Controls.Clear();
            phomepage.Controls.Add(hm);
            hm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            DashboardAdmin da = new DashboardAdmin() { TopLevel = false, TopMost = true };
            da.FormBorderStyle = FormBorderStyle.None;
            phomepage.Controls.Clear();
            phomepage.Controls.Add(da);
            da.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainDashboard().Show();
        }

        private void btnchangepassword_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword() { TopLevel = false, TopMost = true };
            cp.FormBorderStyle = FormBorderStyle.None;
            phomepage.Controls.Clear();
            phomepage.Controls.Add(cp);
            cp.Show();
        }
    }
}
