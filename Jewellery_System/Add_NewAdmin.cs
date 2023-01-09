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
    public partial class Add_NewAdmin : Form
    {
        public Add_NewAdmin()
        {
            InitializeComponent();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserNameAdminLogin.Text == "" && txtPasswordAdmin.Text == "")
            {
                MessageBox.Show("Fields are empty.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String error = Connection.SetData("Insert into mainadmin_login(User_Name, Password)" +
                    "Values('" + txtUserNameAdminLogin.Text + "', '" + txtPasswordAdmin.Text + "')");
                txtUserNameAdminLogin.Text = "";
                txtPasswordAdmin.Text = "";

                MessageBox.Show("Your account has been created successfully.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
