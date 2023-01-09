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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select * FROM mainadmin_login where User_Name ='" + txtUserNameAdminLogin.Text + "' and Password ='" + txtPasswordAdmin.Text + " ' ");
            if (ds == null || ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserNameAdminLogin.Text = string.Empty;
                txtPasswordAdmin.Text = string.Empty;
                txtUserNameAdminLogin.Focus();
            }
            else
            {
                this.Hide();
                new MainAdminForm().Show();
            }
            }           
            

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkboxShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxShowpass.Checked)
            {
                txtPasswordAdmin.PasswordChar = '\0';
            }
            else
            {
                txtPasswordAdmin.PasswordChar = '*';
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Add_NewAdmin newAdmin =  new Add_NewAdmin();
            newAdmin.Show();
        }
    }
}
