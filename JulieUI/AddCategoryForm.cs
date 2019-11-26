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
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddCategoryOK_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length > 0)
            {
                Category category = new Category();
                category.Name = textBoxName.Text;
                CategoryAccess.AddCategory(category);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter category name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
