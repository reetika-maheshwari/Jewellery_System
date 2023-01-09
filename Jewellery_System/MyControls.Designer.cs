
namespace Jewellery_System
{
    partial class MyControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(0, 1);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(343, 20);
            this.txtbox.TabIndex = 0;
            this.txtbox.MouseLeave += new System.EventHandler(this.txtbox_MouseLeave);
            this.txtbox.MouseHover += new System.EventHandler(this.txtbox_MouseHover);
            // 
            // MyControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtbox);
            this.Name = "MyControls";
            this.Size = new System.Drawing.Size(428, 24);
            this.Load += new System.EventHandler(this.MyControls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox;
    }
}
