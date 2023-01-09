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
    public partial class Product_Report : Form
    {
        public Product_Report()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Product_Report_Load(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("select Product_Id, Product_Name, Model_No, Product_Price from product_table");
            gunaDataGridProductReport.DataSource = ds.Tables[0];
        }
    }
}
