using JulieLibrary;
using JulieLibrary.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JulieUI
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            CategoryAccess category = new CategoryAccess();
            comboBoxCategory.DataSource = category.ShowCategory();
            comboBoxCategory.DisplayMember = "Name";
        }

        private void buttonAddProductOK_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                Product product = new Product();
                product.Code = textBoxCode.Text;
                product.Name = textBoxName.Text;
                product.ExpDate = textBoxExpDate.Text;
                product.Company = textBoxCompany.Text;
                product.MfgYear = int.Parse(textBoxMfgYear.Text);
                ProductAccess.AddProduct(product);
                this.Close();
            }
            else
            {
                MessageBox.Show("Input data is not valid. Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidData()
        {
            return (textBoxCode.Text.Length > 0) && (textBoxName.Text.Length > 0) && DateTime.TryParse(textBoxExpDate.Text, out DateTime expDate) && (textBoxCompany.Text.Length > 0) && int.TryParse(textBoxMfgYear.Text, out int mfgYear);
        }
    }
}
