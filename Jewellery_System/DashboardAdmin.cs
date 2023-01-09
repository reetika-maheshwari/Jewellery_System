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
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
            
        }
        private void DashboardAdmin_Load(object sender, EventArgs e)
        {

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Contact_Us cd = new Contact_Us() { TopLevel = false, TopMost = true };
            cd.FormBorderStyle = FormBorderStyle.None;
            paneladmin.Controls.Clear();
            paneladmin.Controls.Add(cd);
            cd.Show();
        }

        private void btnaddSells_Click(object sender, EventArgs e)
        {
            Add_Sells ads = new Add_Sells(); 
            ads.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnaddProduct_Click(object sender, EventArgs e)
        {
            Add_Product_Form apf = new Add_Product_Form();
            apf.Show();
        }

        private void btnAddProductType_Click(object sender, EventArgs e)
        {
            Add_Product_Type apt = new Add_Product_Type();
            apt.Show();
        }

        private void btnSellsReport_Click(object sender, EventArgs e)
        {
            Sell_Report sr = new Sell_Report();
            sr.Show();
        }

        private void btnProductReport_Click(object sender, EventArgs e)
        {
            Product_Report pr = new Product_Report();
            pr.Show();
        }

        private void btnProductTypeReport_Click(object sender, EventArgs e)
        {
            Product_Type_Report ptr = new Product_Type_Report();
            ptr.Show();
        }

        private void btnAddNewAdmin_Click(object sender, EventArgs e)
        {
            Add_NewAdmin newAdmin = new Add_NewAdmin();
            newAdmin.Show();
        }
    }
}
