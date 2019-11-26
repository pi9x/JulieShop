using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JulieLibrary.DataModel;
using JulieLibrary;

namespace JulieUI
{
    public partial class UCProducts : UserControl
    {
        public UCProducts()
        {
            InitializeComponent();
        }

        public static Product selectedProduct = new Product();

        public void LoadProduct()
        {
            ProductAccess products = new ProductAccess();
            dataGridViewProducts.DataSource = products.ShowProduct();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            LoadProduct();
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            selectedProduct.ID = int.Parse(dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString());
            selectedProduct.Code = dataGridViewProducts.SelectedRows[0].Cells[1].Value.ToString();
            selectedProduct.Name = dataGridViewProducts.SelectedRows[0].Cells[2].Value.ToString();
            selectedProduct.ExpDate = dataGridViewProducts.SelectedRows[0].Cells[3].Value.ToString();
            selectedProduct.Company = dataGridViewProducts.SelectedRows[0].Cells[4].Value.ToString();
            selectedProduct.MfgYear = int.Parse(dataGridViewProducts.SelectedRows[0].Cells[5].Value.ToString());
            selectedProduct.Category = dataGridViewProducts.SelectedRows[0].Cells[6].Value.ToString();
            EditProductForm editProductForm = new EditProductForm();
            editProductForm.ShowDialog();
            LoadProduct();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            string productName = dataGridViewProducts.SelectedRows[0].Cells[2].Value.ToString();
            DialogResult confirm = MessageBox.Show($"Do you want to delete \"{productName}\"?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                int id = int.Parse(dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString());
                ProductAccess.DeleteProduct(id);
                LoadProduct();
            }
        }

        private void UCProducts_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ProductAccess searchResult = new ProductAccess();
            dataGridViewProducts.DataSource = searchResult.SearchProduct(textBoxSearchProduct.Text);
        }

        private void textBoxSearchProduct_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxSearchProduct.Text == "Enter product name to search...")
                textBoxSearchProduct.Clear();
        }
    }
}
