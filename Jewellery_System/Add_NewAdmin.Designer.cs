
namespace Jewellery_System
{
    partial class Add_NewAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.labelContactus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkboxShowpass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtPasswordAdmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserNameAdminLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelUsernme = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.chkboxShowpass);
            this.panel1.Controls.Add(this.txtPasswordAdmin);
            this.panel1.Controls.Add(this.txtUserNameAdminLogin);
            this.panel1.Controls.Add(this.labelUsernme);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.labelContactus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 424);
            this.panel1.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Californian FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(723, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 27);
            this.label12.TabIndex = 49;
            this.label12.Text = "X";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // labelContactus
            // 
            this.labelContactus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContactus.AutoSize = true;
            this.labelContactus.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelContactus.Location = new System.Drawing.Point(7, 35);
            this.labelContactus.Name = "labelContactus";
            this.labelContactus.Size = new System.Drawing.Size(136, 22);
            this.labelContactus.TabIndex = 23;
            this.labelContactus.Text = "Add New Admin";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(736, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "_________________________________________________________________________________" +
    "__________";
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
            this.chkboxShowpass.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.chkboxShowpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chkboxShowpass.Location = new System.Drawing.Point(534, 242);
            this.chkboxShowpass.Name = "chkboxShowpass";
            this.chkboxShowpass.Size = new System.Drawing.Size(137, 23);
            this.chkboxShowpass.TabIndex = 56;
            this.chkboxShowpass.Text = "Show Password";
            this.chkboxShowpass.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.chkboxShowpass.UncheckedState.BorderRadius = 0;
            this.chkboxShowpass.UncheckedState.BorderThickness = 0;
            this.chkboxShowpass.UncheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.chkboxShowpass.UseVisualStyleBackColor = false;
            this.chkboxShowpass.CheckedChanged += new System.EventHandler(this.chkboxShowpass_CheckedChanged);
            // 
            // txtPasswordAdmin
            // 
            this.txtPasswordAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordAdmin.Animated = true;
            this.txtPasswordAdmin.AutoRoundedCorners = true;
            this.txtPasswordAdmin.BackColor = System.Drawing.Color.Transparent;
            this.txtPasswordAdmin.BorderColor = System.Drawing.Color.Transparent;
            this.txtPasswordAdmin.BorderRadius = 18;
            this.txtPasswordAdmin.BorderThickness = 0;
            this.txtPasswordAdmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordAdmin.DefaultText = "";
            this.txtPasswordAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasswordAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswordAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordAdmin.FillColor = System.Drawing.Color.RosyBrown;
            this.txtPasswordAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordAdmin.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.txtPasswordAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPasswordAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordAdmin.Location = new System.Drawing.Point(79, 200);
            this.txtPasswordAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.txtPasswordAdmin.Name = "txtPasswordAdmin";
            this.txtPasswordAdmin.PasswordChar = '*';
            this.txtPasswordAdmin.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txtPasswordAdmin.PlaceholderText = "Enter Your Password";
            this.txtPasswordAdmin.SelectedText = "";
            this.txtPasswordAdmin.Size = new System.Drawing.Size(592, 39);
            this.txtPasswordAdmin.TabIndex = 55;
            // 
            // txtUserNameAdminLogin
            // 
            this.txtUserNameAdminLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserNameAdminLogin.Animated = true;
            this.txtUserNameAdminLogin.AutoRoundedCorners = true;
            this.txtUserNameAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.txtUserNameAdminLogin.BorderColor = System.Drawing.Color.Transparent;
            this.txtUserNameAdminLogin.BorderRadius = 18;
            this.txtUserNameAdminLogin.BorderThickness = 0;
            this.txtUserNameAdminLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserNameAdminLogin.DefaultText = "";
            this.txtUserNameAdminLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserNameAdminLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserNameAdminLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameAdminLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameAdminLogin.FillColor = System.Drawing.Color.RosyBrown;
            this.txtUserNameAdminLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserNameAdminLogin.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameAdminLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUserNameAdminLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserNameAdminLogin.Location = new System.Drawing.Point(78, 120);
            this.txtUserNameAdminLogin.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserNameAdminLogin.Name = "txtUserNameAdminLogin";
            this.txtUserNameAdminLogin.PasswordChar = '\0';
            this.txtUserNameAdminLogin.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txtUserNameAdminLogin.PlaceholderText = "Enter Your Name";
            this.txtUserNameAdminLogin.SelectedText = "";
            this.txtUserNameAdminLogin.Size = new System.Drawing.Size(593, 39);
            this.txtUserNameAdminLogin.TabIndex = 54;
            // 
            // labelUsernme
            // 
            this.labelUsernme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsernme.AutoSize = true;
            this.labelUsernme.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernme.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUsernme.Location = new System.Drawing.Point(75, 95);
            this.labelUsernme.Name = "labelUsernme";
            this.labelUsernme.Size = new System.Drawing.Size(88, 22);
            this.labelUsernme.TabIndex = 50;
            this.labelUsernme.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPassword.Location = new System.Drawing.Point(75, 177);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(84, 22);
            this.labelPassword.TabIndex = 51;
            this.labelPassword.Text = "Password";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(159, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 22);
            this.label5.TabIndex = 52;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(159, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 22);
            this.label6.TabIndex = 53;
            this.label6.Text = "*";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.RosyBrown;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(79, 306);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(592, 39);
            this.btnLogin.TabIndex = 57;
            this.btnLogin.Text = "Register";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Add_NewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(766, 434);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_NewAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_NewAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelContactus;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CheckBox chkboxShowpass;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordAdmin;
        private Guna.UI2.WinForms.Guna2TextBox txtUserNameAdminLogin;
        private System.Windows.Forms.Label labelUsernme;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
    }
}