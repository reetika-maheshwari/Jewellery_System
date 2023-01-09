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
    public partial class ChangePassword : Form
    {
        //string m_user_name = "";
        public ChangePassword()//string username)
        {
            InitializeComponent();
           // m_user_name = username;
        }

        private void labeloldpass_Click(object sender, EventArgs e)
        {

        }

        private void btnChangepassword_Click(object sender, EventArgs e)
        {
            //if (txtNewPassword.Text == txtConfirmPassword.Text)
            //{
            //    String error = Connection.SetData("Update mainadmin_login Set Password = '" + txtNewPassword.Text + "' where User_Name = '" + m_user_name + "'");
            //    txtNewPassword.Text = "";
            //    txtConfirmPassword.Text = "";
            //    txtNewPassword.Focus();
            //    MessageBox.Show("Reset Your Password Successfully.");
            //}
            //else
            //{
            //    MessageBox.Show("The new password do not match so enter the same password.");
            //}
        }
    }
}
