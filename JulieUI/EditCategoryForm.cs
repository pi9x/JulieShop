using JulieLibrary;
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
    public partial class EditCategoryForm : Form
    {
        public EditCategoryForm()
        {
            InitializeComponent();
        }

        private void EditCategory_Load(object sender, EventArgs e)
        {
            textBoxName.Text = UCCategories.selectedCategory.Name;
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditCategoryOK_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length > 0)
            {
                CategoryAccess.UpdateCategory(UCCategories.selectedCategory.ID, textBoxName.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter new category name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
