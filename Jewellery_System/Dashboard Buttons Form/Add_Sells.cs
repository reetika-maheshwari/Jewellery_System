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
    public partial class Add_Sells : Form
    {
        public Add_Sells()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartBilling_Click(object sender, EventArgs e)
        {
            if (textBoxcustomername.Text != "" && txtContactnumber.Text != "")
            {
                String error = Connection.SetData("Insert Into et_sell(Customer_Name, Contact_Number) Values " +
                    "('" + textBoxcustomername.Text + "', '" + txtContactnumber.Text + "' )");
                if (error == "")
                {
                    MessageBox.Show("Data Saved Successfully.", " Successful..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxcustomername.Text = "";
                    txtContactnumber.Text = "";
                }
                else
                {
                    MessageBox.Show("Error in Saving : " + error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Product_Billing_Dashboard pbs = new Product_Billing_Dashboard();
            pbs.Show();

        }   
    }
}
