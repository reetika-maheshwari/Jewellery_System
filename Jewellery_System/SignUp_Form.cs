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
    public partial class SignUp_Form : Form
    {
        public SignUp_Form()
        {
            InitializeComponent();
        }
        Boolean labelVisibal = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (labelVisibal == true)
            {
                lblSignUpHere.Visible = true;
                labelVisibal = false;
            }
            else
            {
                lblSignUpHere.Visible = false;
                labelVisibal = true;
            }
        }

        private void SignUp_Form_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            panelSignUpPage.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void LblBackToLogIn_Click(object sender, EventArgs e)
        {
            new LogIn_Form().Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtUserNameSignUp.Text=="" && txtEmailSignUp.Text=="" && txtMobileSignUp.Text=="" && txtPasswordSignUp.Text=="" && txtConfirmPassword.Text=="")
            {
                MessageBox.Show("Fields are empty.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtPasswordSignUp.Text==txtConfirmPassword.Text)
            {
                String error = Connection.SetData("Insert into admin_login(Username, Email, MobileNo, Password)" +
                    "Values('" + txtUserNameSignUp.Text + "', '" + txtEmailSignUp.Text + "', '" + txtMobileSignUp.Text + "', '" + txtPasswordSignUp.Text + "')");
                txtUserNameSignUp.Text = "";
                txtEmailSignUp.Text = "";
                txtMobileSignUp.Text = "";
                txtPasswordSignUp.Text = "";
                txtConfirmPassword.Text = "";
                MessageBox.Show("Your account has been created successfully.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password does not Match, Please Re-Enter Your Password.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPasswordSignUp.Text = "";
                txtConfirmPassword.Text = "";
                txtPasswordSignUp.Focus();
            }
        }

        private void chkboxShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkboxShowpass.Checked)
            {
                txtPasswordSignUp.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPasswordSignUp.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }
    }
}
