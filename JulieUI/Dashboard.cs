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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        UserControl ucHome       = new UCHome();
        UserControl ucCategories = new UCCategories();
        UserControl ucProducts   = new UCProducts();

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panelUserControls.Controls.Clear();
            panelUserControls.Controls.Add(ucHome);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelUserControls.Controls.Clear();
            panelUserControls.Controls.Add(ucHome);
        }
        private void buttonCategory_Click(object sender, EventArgs e)
        {
            panelUserControls.Controls.Clear();
            panelUserControls.Controls.Add(ucCategories);
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            panelUserControls.Controls.Clear();
            panelUserControls.Controls.Add(ucProducts);
        }
    }
}
