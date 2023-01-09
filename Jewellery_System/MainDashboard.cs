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
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }
              
        private void btnhome_Click_1(object sender, EventArgs e)
        {
            Home hm = new Home() { TopLevel = false, TopMost = true };
            hm.FormBorderStyle = FormBorderStyle.None;
            phomepage.Controls.Clear();
            phomepage.Controls.Add(hm);
            hm.Show();
             
          }
     

        private void btnabout_Click(object sender, EventArgs e)
        {
            About_Us ab = new About_Us() { TopLevel = false, TopMost = true };
            ab.FormBorderStyle = FormBorderStyle.None;
            phomepage.Controls.Clear();
            phomepage.Controls.Add(ab);
            ab.Show();
            
            
        }

        private void btnadminlogin_Click(object sender, EventArgs e)
        {
            AdminLogin adlog = new AdminLogin() { TopLevel = false, TopMost = true };
            adlog.FormBorderStyle = FormBorderStyle.None;
            phomepage.Controls.Clear();
            phomepage.Controls.Add(adlog);
            adlog.Show();

        }

        private void btncontactus_Click(object sender, EventArgs e)
        {
            Contact_Us cd = new Contact_Us() { TopLevel = false, TopMost = true };
            cd.FormBorderStyle = FormBorderStyle.None;
            phomepage.Controls.Clear();
            phomepage.Controls.Add(cd);
            cd.Show();

        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            Home hm = new Home() { TopLevel = false, TopMost = true };
            hm.FormBorderStyle = FormBorderStyle.None;
            phomepage.Controls.Clear();
            phomepage.Controls.Add(hm);
            hm.Show();
        }
    }
}
