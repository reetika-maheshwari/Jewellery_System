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
    public partial class LogIn_Form : Form
    {
        public LogIn_Form()
        {
            InitializeComponent();
        }

        private void LogIn_Form_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            panelloginpage.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Boolean labelVisible = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(labelVisible == true)
            {
                lblLogInHere.Visible = true;
                labelVisible = false;
            }
            else
            {
                lblLogInHere.Visible = false;
                labelVisible = true;
            }
        }

        private void lblRegisterMe_Click(object sender, EventArgs e)
        {
            new SignUp_Form().Show();
            this.Hide();
        }

        private void chkboxShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxShowpass.Checked)
            {
                txtPasswordLogin.PasswordChar = '\0';
            }
            else
            {
                txtPasswordLogin.PasswordChar = '*';
            }
        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            new ResetPassword().Show();
            this.Hide();
        }

        private void chkboxRemember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select * FROM admin_login where Username ='" + txtUserNameLogIn.Text + "' and Password ='" + txtPasswordLogin.Text + " ' ");
            if(ds==null || ds.Tables.Count<=0 || ds.Tables[0].Rows.Count<=0)
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserNameLogIn.Text = string.Empty;
                txtPasswordLogin.Text = string.Empty;
                txtUserNameLogIn.Focus();
            }
            else
            {
                this.Hide();
                new MainDashboard().Show();
            } 
        }
    }
}
