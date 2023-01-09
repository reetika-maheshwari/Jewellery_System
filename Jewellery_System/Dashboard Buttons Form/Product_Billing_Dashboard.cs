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
    public partial class Product_Billing_Dashboard : Form
    {
        public Product_Billing_Dashboard()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Product_Billing_Dashboard_Load(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select * from et_sell where Order_ID='" + txtOrderID.Text + "', Customer_Name='" + txtCustomerName.Text + "', Contact_Number='" + txtContactNumber.Text + "', Order_Date= '" + txtOrderDate.Text + "' ");

            SetControlProperty();
        }
        public void SetControlProperty()
        {

            cmbproduct.DropDownStyle = ComboBoxStyle.DropDownList;
            DataSet ds = Connection.GetData("Select Product_Name from product_table ");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cmbproduct.Items.Add(dr["Product_Name"]);
                }
            }
        }

    }
}
