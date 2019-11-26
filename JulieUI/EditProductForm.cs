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
    public partial class EditProductForm : Form
    {
        public EditProductForm()
        {
            InitializeComponent();
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            textBoxCode.Text = UCProducts.selectedProduct.Code;
            textBoxName.Text = UCProducts.selectedProduct.Name;
            textBoxExpDate.Text = UCProducts.selectedProduct.ExpDate;
            textBoxCompany.Text = UCProducts.selectedProduct.Company;
            textBoxMfgYear.Text = UCProducts.selectedProduct.MfgYear.ToString();

            CategoryAccess category = new CategoryAccess();
            comboBoxCategory.DataSource = category.ShowCategory();
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.Text = UCProducts.selectedProduct.Category;
        }

        private void buttonEditProductOK_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Code = textBoxCode.Text;
            product.Name = textBoxName.Text;
            product.ExpDate = textBoxExpDate.Text;
            product.Company = textBoxCompany.Text;
            product.MfgYear = int.Parse(textBoxMfgYear.Text);
            product.Category = comboBoxCategory.Text;
            ProductAccess.UpdateProduct(UCProducts.selectedProduct.ID, product);
            this.Close();
        }
    }
}
