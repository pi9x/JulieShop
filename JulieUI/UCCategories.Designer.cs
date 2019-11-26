namespace JulieUI
{
    partial class UCCategories
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCategories));
            this.panelProductsData = new System.Windows.Forms.Panel();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.panelCategoriesButtons = new System.Windows.Forms.Panel();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttonEditCategory = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProductsData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.panelCategoriesButtons.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProductsData
            // 
            this.panelProductsData.Controls.Add(this.dataGridViewCategories);
            this.panelProductsData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductsData.Location = new System.Drawing.Point(0, 32);
            this.panelProductsData.Name = "panelProductsData";
            this.panelProductsData.Size = new System.Drawing.Size(730, 392);
            this.panelProductsData.TabIndex = 3;
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.AllowUserToAddRows = false;
            this.dataGridViewCategories.AllowUserToDeleteRows = false;
            this.dataGridViewCategories.AllowUserToResizeColumns = false;
            this.dataGridViewCategories.AllowUserToResizeRows = false;
            this.dataGridViewCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(197)))), ((int)(((byte)(201)))));
            this.dataGridViewCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCategories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(197)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(197)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCategories.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCategories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(197)))), ((int)(((byte)(201)))));
            this.dataGridViewCategories.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCategories.MultiSelect = false;
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.ReadOnly = true;
            this.dataGridViewCategories.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewCategories.RowHeadersVisible = false;
            this.dataGridViewCategories.RowTemplate.Height = 24;
            this.dataGridViewCategories.RowTemplate.ReadOnly = true;
            this.dataGridViewCategories.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategories.Size = new System.Drawing.Size(730, 392);
            this.dataGridViewCategories.TabIndex = 3;
            // 
            // panelCategoriesButtons
            // 
            this.panelCategoriesButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panelCategoriesButtons.Controls.Add(this.buttonDeleteCategory);
            this.panelCategoriesButtons.Controls.Add(this.buttonEditCategory);
            this.panelCategoriesButtons.Controls.Add(this.buttonAddCategory);
            this.panelCategoriesButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCategoriesButtons.Location = new System.Drawing.Point(0, 424);
            this.panelCategoriesButtons.Name = "panelCategoriesButtons";
            this.panelCategoriesButtons.Size = new System.Drawing.Size(730, 44);
            this.panelCategoriesButtons.TabIndex = 2;
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonDeleteCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeleteCategory.BackgroundImage")));
            this.buttonDeleteCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonDeleteCategory.Location = new System.Drawing.Point(471, 6);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(115, 32);
            this.buttonDeleteCategory.TabIndex = 5;
            this.buttonDeleteCategory.UseVisualStyleBackColor = false;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // buttonEditCategory
            // 
            this.buttonEditCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonEditCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditCategory.BackgroundImage")));
            this.buttonEditCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonEditCategory.Location = new System.Drawing.Point(308, 6);
            this.buttonEditCategory.Name = "buttonEditCategory";
            this.buttonEditCategory.Size = new System.Drawing.Size(115, 32);
            this.buttonEditCategory.TabIndex = 4;
            this.buttonEditCategory.UseVisualStyleBackColor = false;
            this.buttonEditCategory.Click += new System.EventHandler(this.buttonEditCategory_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonAddCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddCategory.BackgroundImage")));
            this.buttonAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonAddCategory.Location = new System.Drawing.Point(145, 6);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(115, 32);
            this.buttonAddCategory.TabIndex = 3;
            this.buttonAddCategory.UseVisualStyleBackColor = false;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panelTopBar.Controls.Add(this.label1);
            this.panelTopBar.Controls.Add(this.buttonSearch);
            this.panelTopBar.Controls.Add(this.textBoxSearchCategory);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(730, 32);
            this.panelTopBar.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.buttonSearch.Location = new System.Drawing.Point(701, 4);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(24, 24);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.TabStop = false;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchCategory
            // 
            this.textBoxSearchCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.textBoxSearchCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchCategory.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchCategory.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSearchCategory.Location = new System.Drawing.Point(457, 3);
            this.textBoxSearchCategory.Name = "textBoxSearchCategory";
            this.textBoxSearchCategory.Size = new System.Drawing.Size(270, 27);
            this.textBoxSearchCategory.TabIndex = 2;
            this.textBoxSearchCategory.Text = "Enter category name to search...";
            this.textBoxSearchCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSearchCategory_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "CATEGORIES";
            // 
            // UCCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(197)))), ((int)(((byte)(201)))));
            this.Controls.Add(this.panelProductsData);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.panelCategoriesButtons);
            this.Name = "UCCategories";
            this.Size = new System.Drawing.Size(730, 468);
            this.Load += new System.EventHandler(this.UCCategories_Load);
            this.panelProductsData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.panelCategoriesButtons.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelProductsData;
        private System.Windows.Forms.Panel panelCategoriesButtons;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.TextBox textBoxSearchCategory;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.Button buttonEditCategory;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.Label label1;
    }
}
