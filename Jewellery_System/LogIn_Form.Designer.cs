
namespace Jewellery_System
{
    partial class LogIn_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn_Form));
            this.panelloginpage = new System.Windows.Forms.Panel();
            this.lblRegisterMe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblForgotPass = new System.Windows.Forms.Label();
            this.btnLogIn = new Guna.UI2.WinForms.Guna2Button();
            this.chkboxRemember = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkboxShowpass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtPasswordLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserNameLogIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogInHere = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelloginpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelloginpage
            // 
            this.panelloginpage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelloginpage.BackColor = System.Drawing.SystemColors.Control;
            this.panelloginpage.Controls.Add(this.lblLogInHere);
            this.panelloginpage.Controls.Add(this.lblRegisterMe);
            this.panelloginpage.Controls.Add(this.label5);
            this.panelloginpage.Controls.Add(this.lblForgotPass);
            this.panelloginpage.Controls.Add(this.btnLogIn);
            this.panelloginpage.Controls.Add(this.chkboxRemember);
            this.panelloginpage.Controls.Add(this.chkboxShowpass);
            this.panelloginpage.Controls.Add(this.txtPasswordLogin);
            this.panelloginpage.Controls.Add(this.txtUserNameLogIn);
            this.panelloginpage.Controls.Add(this.label3);
            this.panelloginpage.Controls.Add(this.label2);
            this.panelloginpage.Location = new System.Drawing.Point(193, 1);
            this.panelloginpage.Name = "panelloginpage";
            this.panelloginpage.Size = new System.Drawing.Size(400, 448);
            this.panelloginpage.TabIndex = 0;
            // 
            // lblRegisterMe
            // 
            this.lblRegisterMe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegisterMe.AutoSize = true;
            this.lblRegisterMe.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegisterMe.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRegisterMe.Location = new System.Drawing.Point(192, 396);
            this.lblRegisterMe.Name = "lblRegisterMe";
            this.lblRegisterMe.Size = new System.Drawing.Size(106, 20);
            this.lblRegisterMe.TabIndex = 10;
            this.lblRegisterMe.Text = "Register Here";
            this.lblRegisterMe.Click += new System.EventHandler(this.lblRegisterMe_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(94, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "New User ?";
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForgotPass.AutoSize = true;
            this.lblForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPass.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblForgotPass.Location = new System.Drawing.Point(216, 349);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(104, 17);
            this.lblForgotPass.TabIndex = 8;
            this.lblForgotPass.Text = "Forgot Password";
            this.lblForgotPass.Click += new System.EventHandler(this.lblForgotPass_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.BorderRadius = 5;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogIn.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(69, 311);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(251, 35);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.Text = "LOGIN";
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // chkboxRemember
            // 
            this.chkboxRemember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkboxRemember.AutoSize = true;
            this.chkboxRemember.BackColor = System.Drawing.Color.Transparent;
            this.chkboxRemember.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkboxRemember.CheckedState.BorderRadius = 0;
            this.chkboxRemember.CheckedState.BorderThickness = 0;
            this.chkboxRemember.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkboxRemember.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxRemember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chkboxRemember.Location = new System.Drawing.Point(211, 264);
            this.chkboxRemember.Name = "chkboxRemember";
            this.chkboxRemember.Size = new System.Drawing.Size(109, 19);
            this.chkboxRemember.TabIndex = 6;
            this.chkboxRemember.Text = "Remember Me";
            this.chkboxRemember.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.chkboxRemember.UncheckedState.BorderRadius = 0;
            this.chkboxRemember.UncheckedState.BorderThickness = 0;
            this.chkboxRemember.UncheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.chkboxRemember.UseVisualStyleBackColor = false;
            this.chkboxRemember.CheckedChanged += new System.EventHandler(this.chkboxRemember_CheckedChanged);
            // 
            // chkboxShowpass
            // 
            this.chkboxShowpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkboxShowpass.AutoSize = true;
            this.chkboxShowpass.BackColor = System.Drawing.Color.Transparent;
            this.chkboxShowpass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkboxShowpass.CheckedState.BorderRadius = 0;
            this.chkboxShowpass.CheckedState.BorderThickness = 0;
            this.chkboxShowpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkboxShowpass.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxShowpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chkboxShowpass.Location = new System.Drawing.Point(211, 245);
            this.chkboxShowpass.Name = "chkboxShowpass";
            this.chkboxShowpass.Size = new System.Drawing.Size(113, 19);
            this.chkboxShowpass.TabIndex = 5;
            this.chkboxShowpass.Text = "Show Password";
            this.chkboxShowpass.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.chkboxShowpass.UncheckedState.BorderRadius = 0;
            this.chkboxShowpass.UncheckedState.BorderThickness = 0;
            this.chkboxShowpass.UncheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.chkboxShowpass.UseVisualStyleBackColor = false;
            this.chkboxShowpass.CheckedChanged += new System.EventHandler(this.chkboxShowpass_CheckedChanged);
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordLogin.Animated = true;
            this.txtPasswordLogin.AutoRoundedCorners = true;
            this.txtPasswordLogin.BackColor = System.Drawing.Color.Transparent;
            this.txtPasswordLogin.BorderColor = System.Drawing.Color.Transparent;
            this.txtPasswordLogin.BorderRadius = 14;
            this.txtPasswordLogin.BorderThickness = 0;
            this.txtPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordLogin.DefaultText = "";
            this.txtPasswordLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasswordLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswordLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordLogin.FillColor = System.Drawing.Color.RosyBrown;
            this.txtPasswordLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordLogin.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.txtPasswordLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPasswordLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordLogin.Location = new System.Drawing.Point(69, 198);
            this.txtPasswordLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txtPasswordLogin.PlaceholderText = "Enter Your Password";
            this.txtPasswordLogin.SelectedText = "";
            this.txtPasswordLogin.Size = new System.Drawing.Size(251, 31);
            this.txtPasswordLogin.TabIndex = 4;
            // 
            // txtUserNameLogIn
            // 
            this.txtUserNameLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserNameLogIn.Animated = true;
            this.txtUserNameLogIn.AutoRoundedCorners = true;
            this.txtUserNameLogIn.BackColor = System.Drawing.Color.Transparent;
            this.txtUserNameLogIn.BorderColor = System.Drawing.Color.Transparent;
            this.txtUserNameLogIn.BorderRadius = 14;
            this.txtUserNameLogIn.BorderThickness = 0;
            this.txtUserNameLogIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserNameLogIn.DefaultText = "";
            this.txtUserNameLogIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserNameLogIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserNameLogIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameLogIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameLogIn.FillColor = System.Drawing.Color.RosyBrown;
            this.txtUserNameLogIn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserNameLogIn.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.txtUserNameLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUserNameLogIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserNameLogIn.Location = new System.Drawing.Point(69, 115);
            this.txtUserNameLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserNameLogIn.Name = "txtUserNameLogIn";
            this.txtUserNameLogIn.PasswordChar = '\0';
            this.txtUserNameLogIn.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txtUserNameLogIn.PlaceholderText = "Enter Your Name";
            this.txtUserNameLogIn.SelectedText = "";
            this.txtUserNameLogIn.Size = new System.Drawing.Size(251, 31);
            this.txtUserNameLogIn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(74, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(74, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(765, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLogInHere
            // 
            this.lblLogInHere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogInHere.AutoSize = true;
            this.lblLogInHere.BackColor = System.Drawing.Color.Transparent;
            this.lblLogInHere.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogInHere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLogInHere.Location = new System.Drawing.Point(124, 16);
            this.lblLogInHere.Name = "lblLogInHere";
            this.lblLogInHere.Size = new System.Drawing.Size(173, 25);
            this.lblLogInHere.TabIndex = 11;
            this.lblLogInHere.Text = "LOG IN HERE";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelloginpage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LogIn_Form_Load);
            this.panelloginpage.ResumeLayout(false);
            this.panelloginpage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelloginpage;
        private System.Windows.Forms.Label lblRegisterMe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblForgotPass;
        private Guna.UI2.WinForms.Guna2Button btnLogIn;
        private Guna.UI2.WinForms.Guna2CheckBox chkboxRemember;
        private Guna.UI2.WinForms.Guna2CheckBox chkboxShowpass;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtUserNameLogIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogInHere;
        private System.Windows.Forms.Timer timer1;
    }
}