
namespace Jewellery_System
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.panelResetPasswordpage = new System.Windows.Forms.Panel();
            this.btnBackToLogIn = new Guna.UI2.WinForms.Guna2Button();
            this.lblConfirmDetails = new System.Windows.Forms.Label();
            this.btnSendReset = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmailConfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserNameResetForm = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelResetPasswordpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResetPasswordpage
            // 
            this.panelResetPasswordpage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelResetPasswordpage.BackColor = System.Drawing.SystemColors.Control;
            this.panelResetPasswordpage.Controls.Add(this.btnBackToLogIn);
            this.panelResetPasswordpage.Controls.Add(this.lblConfirmDetails);
            this.panelResetPasswordpage.Controls.Add(this.btnSendReset);
            this.panelResetPasswordpage.Controls.Add(this.txtEmailConfirm);
            this.panelResetPasswordpage.Controls.Add(this.txtUserNameResetForm);
            this.panelResetPasswordpage.Controls.Add(this.label3);
            this.panelResetPasswordpage.Controls.Add(this.label2);
            this.panelResetPasswordpage.Location = new System.Drawing.Point(200, 1);
            this.panelResetPasswordpage.Name = "panelResetPasswordpage";
            this.panelResetPasswordpage.Size = new System.Drawing.Size(400, 448);
            this.panelResetPasswordpage.TabIndex = 5;
            // 
            // btnBackToLogIn
            // 
            this.btnBackToLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackToLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToLogIn.BorderRadius = 5;
            this.btnBackToLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToLogIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackToLogIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackToLogIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackToLogIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackToLogIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackToLogIn.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBackToLogIn.ForeColor = System.Drawing.Color.White;
            this.btnBackToLogIn.Location = new System.Drawing.Point(69, 345);
            this.btnBackToLogIn.Name = "btnBackToLogIn";
            this.btnBackToLogIn.Size = new System.Drawing.Size(251, 35);
            this.btnBackToLogIn.TabIndex = 12;
            this.btnBackToLogIn.Text = "BACK TO LOGIN";
            this.btnBackToLogIn.Click += new System.EventHandler(this.btnBackToLogIn_Click);
            // 
            // lblConfirmDetails
            // 
            this.lblConfirmDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmDetails.AutoSize = true;
            this.lblConfirmDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmDetails.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblConfirmDetails.Location = new System.Drawing.Point(4, 26);
            this.lblConfirmDetails.Name = "lblConfirmDetails";
            this.lblConfirmDetails.Size = new System.Drawing.Size(393, 25);
            this.lblConfirmDetails.TabIndex = 11;
            this.lblConfirmDetails.Text = "CONFIRM YOUR DETAILS HERE";
            // 
            // btnSendReset
            // 
            this.btnSendReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSendReset.BackColor = System.Drawing.Color.Transparent;
            this.btnSendReset.BorderRadius = 5;
            this.btnSendReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSendReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSendReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSendReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSendReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSendReset.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSendReset.ForeColor = System.Drawing.Color.White;
            this.btnSendReset.Location = new System.Drawing.Point(69, 304);
            this.btnSendReset.Name = "btnSendReset";
            this.btnSendReset.Size = new System.Drawing.Size(251, 35);
            this.btnSendReset.TabIndex = 7;
            this.btnSendReset.Text = "SEND";
            this.btnSendReset.Click += new System.EventHandler(this.btnSendReset_Click);
            // 
            // txtEmailConfirm
            // 
            this.txtEmailConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailConfirm.Animated = true;
            this.txtEmailConfirm.AutoRoundedCorners = true;
            this.txtEmailConfirm.BackColor = System.Drawing.Color.Transparent;
            this.txtEmailConfirm.BorderColor = System.Drawing.Color.Transparent;
            this.txtEmailConfirm.BorderRadius = 14;
            this.txtEmailConfirm.BorderThickness = 0;
            this.txtEmailConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailConfirm.DefaultText = "";
            this.txtEmailConfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailConfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailConfirm.FillColor = System.Drawing.Color.RosyBrown;
            this.txtEmailConfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailConfirm.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.txtEmailConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtEmailConfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailConfirm.Location = new System.Drawing.Point(69, 220);
            this.txtEmailConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailConfirm.Name = "txtEmailConfirm";
            this.txtEmailConfirm.PasswordChar = '\0';
            this.txtEmailConfirm.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txtEmailConfirm.PlaceholderText = "Enter Your Email Address";
            this.txtEmailConfirm.SelectedText = "";
            this.txtEmailConfirm.Size = new System.Drawing.Size(251, 31);
            this.txtEmailConfirm.TabIndex = 4;
            // 
            // txtUserNameResetForm
            // 
            this.txtUserNameResetForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserNameResetForm.Animated = true;
            this.txtUserNameResetForm.AutoRoundedCorners = true;
            this.txtUserNameResetForm.BackColor = System.Drawing.Color.Transparent;
            this.txtUserNameResetForm.BorderColor = System.Drawing.Color.Transparent;
            this.txtUserNameResetForm.BorderRadius = 14;
            this.txtUserNameResetForm.BorderThickness = 0;
            this.txtUserNameResetForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserNameResetForm.DefaultText = "";
            this.txtUserNameResetForm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserNameResetForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserNameResetForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameResetForm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameResetForm.FillColor = System.Drawing.Color.RosyBrown;
            this.txtUserNameResetForm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserNameResetForm.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.txtUserNameResetForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUserNameResetForm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserNameResetForm.Location = new System.Drawing.Point(69, 137);
            this.txtUserNameResetForm.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserNameResetForm.Name = "txtUserNameResetForm";
            this.txtUserNameResetForm.PasswordChar = '\0';
            this.txtUserNameResetForm.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txtUserNameResetForm.PlaceholderText = "Enter Your Name";
            this.txtUserNameResetForm.SelectedText = "";
            this.txtUserNameResetForm.Size = new System.Drawing.Size(251, 31);
            this.txtUserNameResetForm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(74, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(74, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelResetPasswordpage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.panelResetPasswordpage.ResumeLayout(false);
            this.panelResetPasswordpage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelResetPasswordpage;
        private System.Windows.Forms.Label lblConfirmDetails;
        private Guna.UI2.WinForms.Guna2Button btnSendReset;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailConfirm;
        private Guna.UI2.WinForms.Guna2TextBox txtUserNameResetForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnBackToLogIn;
        private System.Windows.Forms.Timer timer1;
    }
}