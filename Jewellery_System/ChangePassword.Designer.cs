
namespace Jewellery_System
{
    partial class ChangePassword
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChangepassword = new Guna.UI2.WinForms.Guna2Button();
            this.labelConfirmpass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labeloldpass = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelContactus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOldPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkboxShowpass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.chkboxShowpass);
            this.panel3.Controls.Add(this.txtConfirmPassword);
            this.panel3.Controls.Add(this.txtNewPassword);
            this.panel3.Controls.Add(this.txtOldPassword);
            this.panel3.Controls.Add(this.btnChangepassword);
            this.panel3.Controls.Add(this.labelConfirmpass);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.labeloldpass);
            this.panel3.Controls.Add(this.labelEmail);
            this.panel3.Controls.Add(this.labelContactus);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 513);
            this.panel3.TabIndex = 11;
            // 
            // btnChangepassword
            // 
            this.btnChangepassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangepassword.BorderRadius = 12;
            this.btnChangepassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangepassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangepassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangepassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangepassword.FillColor = System.Drawing.Color.RosyBrown;
            this.btnChangepassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnChangepassword.ForeColor = System.Drawing.Color.White;
            this.btnChangepassword.Location = new System.Drawing.Point(48, 387);
            this.btnChangepassword.Name = "btnChangepassword";
            this.btnChangepassword.Size = new System.Drawing.Size(198, 45);
            this.btnChangepassword.TabIndex = 32;
            this.btnChangepassword.Text = "Change Password";
            this.btnChangepassword.Click += new System.EventHandler(this.btnChangepassword_Click);
            // 
            // labelConfirmpass
            // 
            this.labelConfirmpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConfirmpass.AutoSize = true;
            this.labelConfirmpass.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmpass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelConfirmpass.Location = new System.Drawing.Point(45, 271);
            this.labelConfirmpass.Name = "labelConfirmpass";
            this.labelConfirmpass.Size = new System.Drawing.Size(154, 22);
            this.labelConfirmpass.TabIndex = 29;
            this.labelConfirmpass.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(195, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "*";
            // 
            // labeloldpass
            // 
            this.labeloldpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeloldpass.AutoSize = true;
            this.labeloldpass.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeloldpass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labeloldpass.Location = new System.Drawing.Point(45, 101);
            this.labeloldpass.Name = "labeloldpass";
            this.labeloldpass.Size = new System.Drawing.Size(117, 22);
            this.labeloldpass.TabIndex = 23;
            this.labeloldpass.Text = "Old Password";
            this.labeloldpass.Click += new System.EventHandler(this.labeloldpass_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelEmail.Location = new System.Drawing.Point(45, 185);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(124, 22);
            this.labelEmail.TabIndex = 24;
            this.labelEmail.Text = "New Password";
            // 
            // labelContactus
            // 
            this.labelContactus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContactus.AutoSize = true;
            this.labelContactus.Font = new System.Drawing.Font("Californian FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelContactus.Location = new System.Drawing.Point(44, 25);
            this.labelContactus.Name = "labelContactus";
            this.labelContactus.Size = new System.Drawing.Size(237, 27);
            this.labelContactus.TabIndex = 21;
            this.labelContactus.Text = "Change Your Password";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(45, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(696, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "_________________________________________________________________________________" +
    "_____";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(158, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(165, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "*";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOldPassword.Animated = true;
            this.txtOldPassword.AutoRoundedCorners = true;
            this.txtOldPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtOldPassword.BorderColor = System.Drawing.Color.Transparent;
            this.txtOldPassword.BorderRadius = 18;
            this.txtOldPassword.BorderThickness = 0;
            this.txtOldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPassword.DefaultText = "";
            this.txtOldPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOldPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOldPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPassword.FillColor = System.Drawing.Color.RosyBrown;
            this.txtOldPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldPassword.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.txtOldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtOldPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldPassword.Location = new System.Drawing.Point(48, 128);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '\0';
            this.txtOldPassword.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txtOldPassword.PlaceholderText = "Enter Your Old Password";
            this.txtOldPassword.SelectedText = "";
            this.txtOldPassword.Size = new System.Drawing.Size(693, 39);
            this.txtOldPassword.TabIndex = 33;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPassword.Animated = true;
            this.txtNewPassword.AutoRoundedCorners = true;
            this.txtNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPassword.BorderColor = System.Drawing.Color.Transparent;
            this.txtNewPassword.BorderRadius = 18;
            this.txtNewPassword.BorderThickness = 0;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.FillColor = System.Drawing.Color.RosyBrown;
            this.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Location = new System.Drawing.Point(48, 212);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '\0';
            this.txtNewPassword.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txtNewPassword.PlaceholderText = "Enter Your New Name";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(693, 39);
            this.txtNewPassword.TabIndex = 34;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmPassword.Animated = true;
            this.txtConfirmPassword.AutoRoundedCorners = true;
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.BorderRadius = 18;
            this.txtConfirmPassword.BorderThickness = 0;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FillColor = System.Drawing.Color.RosyBrown;
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(48, 298);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '\0';
            this.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txtConfirmPassword.PlaceholderText = "Enter Confirm New Password";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(693, 39);
            this.txtConfirmPassword.TabIndex = 35;
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
            this.chkboxShowpass.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxShowpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chkboxShowpass.Location = new System.Drawing.Point(604, 345);
            this.chkboxShowpass.Name = "chkboxShowpass";
            this.chkboxShowpass.Size = new System.Drawing.Size(137, 23);
            this.chkboxShowpass.TabIndex = 36;
            this.chkboxShowpass.Text = "Show Password";
            this.chkboxShowpass.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.chkboxShowpass.UncheckedState.BorderRadius = 0;
            this.chkboxShowpass.UncheckedState.BorderThickness = 0;
            this.chkboxShowpass.UncheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.chkboxShowpass.UseVisualStyleBackColor = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(859, 519);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelConfirmpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labeloldpass;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelContactus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnChangepassword;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtOldPassword;
        private Guna.UI2.WinForms.Guna2CheckBox chkboxShowpass;
    }
}