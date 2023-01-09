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
    public partial class Add_Product_Type : Form
    {
        public Add_Product_Type()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartBilling_Click(object sender, EventArgs e)
        {
            if (textBoxproducttypetitle.Text != "" && textBoxdescription.Text != "")
            {
                string error = Connection.SetData("insert into product_type(Product_Type_Title, Description) values('" + textBoxproducttypetitle.Text + "', '" + textBoxdescription.Text + "')");
                if (error == "")
                {
                    MessageBox.Show("Data Saved", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxproducttypetitle.Text = "";
                    textBoxdescription.Text = "";
                }
                else
                {
                    MessageBox.Show("Error in saving:" + error);

                }
            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

