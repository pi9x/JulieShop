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

        private void LoadProduct()
        {
            ProductAccess products = new ProductAccess();
            dataGridViewProducts.DataSource = products.ShowProduct();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString());
            ProductAccess.DeleteProduct(id);
            LoadProduct();
        }

        private void UCProducts_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
