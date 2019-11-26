using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JulieLibrary;
using JulieLibrary.DataModel;

namespace JulieUI
{
    public partial class UCCategories : UserControl
    {
        public UCCategories()
        {
            InitializeComponent();
        }

        private void LoadCategory()
        {
            CategoryAccess categories = new CategoryAccess();
            dataGridViewCategories.DataSource = categories.ShowCategory();
        }

        private void UCCategories_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            CategoryAccess searchResult = new CategoryAccess();
            dataGridViewCategories.DataSource = searchResult.SearchCategory(textBoxSearchCategory.Text);
        }

        private void textBoxSearchCategory_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxSearchCategory.Text == "Enter category name to search...")
                textBoxSearchCategory.Clear();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.ShowDialog();
            LoadCategory();
        }

        public static Category selectedCategory = new Category();

        private void buttonEditCategory_Click(object sender, EventArgs e)
        {
            selectedCategory.ID = int.Parse(dataGridViewCategories.SelectedRows[0].Cells[0].Value.ToString());
            selectedCategory.Name = dataGridViewCategories.SelectedRows[0].Cells[1].Value.ToString();
            EditCategoryForm editCategoryForm = new EditCategoryForm();
            editCategoryForm.ShowDialog();
            LoadCategory();
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            string categoryName = dataGridViewCategories.SelectedRows[0].Cells[1].Value.ToString();
            DialogResult confirm = MessageBox.Show($"Do you want to delete all products in \"{categoryName}\"?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                int id = int.Parse(dataGridViewCategories.SelectedRows[0].Cells[0].Value.ToString());
                CategoryAccess.DeleteCategory(id);
                LoadCategory();
            }
        }
    }
}
