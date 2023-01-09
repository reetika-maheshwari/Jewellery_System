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
    public partial class Add_Product_Form : Form
    {
        public Add_Product_Form()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Product_Form_Load(object sender, EventArgs e)
        {
            SetControlProperty();
        }
        public void SetControlProperty()
        {

            cmbproducttype.DropDownStyle = ComboBoxStyle.DropDownList;
            DataSet ds = Connection.GetData("Select Product_Type_Title from product_type ");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cmbproducttype.Items.Add(dr["Product_Type_Title"]);
                }
            }
        }
        private void ClearAll()
        {
            txtboxProductName.Text = "";
            txtboxModelNo.Text = "";
            cmbproducttype.SelectedIndex = -1;
            txtproductPrice.Text = "";
            txtboxnoofstock.Text = "";
            txtboxdescription.Text = "";
        }

        private void btnSaveproduct_Click(object sender, EventArgs e)
        {
            if (txtboxProductName.Text != "" && txtboxModelNo.Text != "" && cmbproducttype.Text != "" && txtproductPrice.Text != "" && txtboxnoofstock.Text != "" && txtboxdescription.Text != "")
            {
                String error = Connection.SetData("Insert Into product_table(Product_Name, Model_No, Select_Product_Type, Product_Price, No_of_Stock, Description) Values " +
                    "('" + txtboxProductName.Text + "', '" + txtboxModelNo.Text + "', '" + cmbproducttype.Text + "', '" + txtproductPrice.Text + "', '" + txtboxnoofstock.Text + "', '" + txtboxdescription.Text + "' )");
                if (error == "")
                {
                    MessageBox.Show("Data Saved.", " Successful..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
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
        }
    }
}
