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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            panelResetPasswordpage.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        Boolean labelVisibal = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (labelVisibal == true)
            {
                lblConfirmDetails.Visible = true;
                labelVisibal = false;
            }
            else
            {
                lblConfirmDetails.Visible = false;
                labelVisibal = true;
            }
        }

        private void btnBackToLogIn_Click(object sender, EventArgs e)
        {
            new LogIn_Form().Show();
            this.Hide();
        }

        private void btnSendReset_Click(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select * FROM admin_login Where Username = '" + txtUserNameResetForm.Text + " ' and Email = '" + txtEmailConfirm.Text + " '");
            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Invalid Username or Email  , Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUserNameResetForm.Text = "";
                txtEmailConfirm.Text = "";
                txtUserNameResetForm.Focus();
            }
            else
            {
                this.Hide();
                new ChangeResetLogIn_Password(txtUserNameResetForm.Text).Show();
            }
        }
    }
}
