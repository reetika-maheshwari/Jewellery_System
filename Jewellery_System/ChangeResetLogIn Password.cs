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
    public partial class ChangeResetLogIn_Password : Form
    {
        string m_user_name = "";
        public ChangeResetLogIn_Password( string username)
        {
            InitializeComponent();
            m_user_name = username;
        }
        private void ChangeResetLogIn_Password_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            panelChangePassword.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void btnBackToLogIn_Click(object sender, EventArgs e)
        {
            new LogIn_Form().Show();
            this.Hide();
        }
        private void btnResetChange_Click(object sender, EventArgs e)
        {
            if(txtNewPasswordReset.Text == txtConfirmPassReset.Text)
            {
                String error = Connection.SetData("Update admin_login Set Password = '" + txtNewPasswordReset.Text + "' where Username = '" + m_user_name + "'");
                txtNewPasswordReset.Text = "";
                txtConfirmPassReset.Text = "";
                txtNewPasswordReset.Focus();
                MessageBox.Show("Reset Your Password Successfully.");
            }
            else
            {
                MessageBox.Show("The new password do not match so enter the same password.");
            }
        }
        private void chkboxShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxShowpass.Checked)
            {
                txtNewPasswordReset.PasswordChar = '\0';
                txtConfirmPassReset.PasswordChar = '\0';
            }
            else
            {
                txtNewPasswordReset.PasswordChar = '*';
                txtConfirmPassReset.PasswordChar = '*';
            }
        }
        Boolean labelVisibal = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (labelVisibal == true)
            {
                lblResetPassword.Visible = true;
                labelVisibal = false;
            }
            else
            {
                lblResetPassword.Visible = false;
                labelVisibal = true;
            }

        }
    }
}
