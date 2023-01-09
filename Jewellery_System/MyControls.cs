using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Jewellery_System
{
    public enum textInputType
    {

    }

    
    public partial class MyControls : UserControl
    {
        public MyControls()
        {
            InitializeComponent();
        }

        private void MyControls_Load(object sender, EventArgs e)
        {

        }

        private void txtbox_MouseHover(object sender, EventArgs e)
        {
            txtbox.BackColor = Color.Red;
        }

        private void txtbox_MouseLeave(object sender, EventArgs e)
        {
            txtbox.BackColor = Color.Cyan;
        }
    }
}
