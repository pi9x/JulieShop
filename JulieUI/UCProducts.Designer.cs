namespace JulieUI
{
    partial class UCProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelProductsButtons = new System.Windows.Forms.Panel();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.panelProductsData = new System.Windows.Forms.Panel();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProductsButtons.SuspendLayout();
            this.panelProductsData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProductsButtons
            // 
            this.panelProductsButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panelProductsButtons.Controls.Add(this.buttonDeleteProduct);
            this.panelProductsButtons.Controls.Add(this.buttonEditProduct);
            this.panelProductsButtons.Controls.Add(this.buttonAddProduct);
            this.panelProductsButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProductsButtons.Location = new System.Drawing.Point(0, 424);
            this.panelProductsButtons.Name = "panelProductsButtons";
            this.panelProductsButtons.Size = new System.Drawing.Size(730, 44);
            this.panelProductsButtons.TabIndex = 0;
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonDeleteProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeleteProduct.BackgroundImage")));
            this.buttonDeleteProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonDeleteProduct.Location = new System.Drawing.Point(471, 6);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(115, 32);
            this.buttonDeleteProduct.TabIndex = 2;
            this.buttonDeleteProduct.UseVisualStyleBackColor = false;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonEditProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditProduct.BackgroundImage")));
            this.buttonEditProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonEditProduct.Location = new System.Drawing.Point(308, 6);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(115, 32);
            this.buttonEditProduct.TabIndex = 1;
            this.buttonEditProduct.UseVisualStyleBackColor = false;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonAddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddProduct.BackgroundImage")));
            this.buttonAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonAddProduct.Location = new System.Drawing.Point(145, 6);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(115, 32);
            this.buttonAddProduct.TabIndex = 0;
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // panelProductsData
            // 
            this.panelProductsData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(197)))), ((int)(((byte)(201)))));
            this.panelProductsData.Controls.Add(this.dataGridViewProducts);
            this.panelProductsData.Controls.Add(this.panel1);
            this.panelProductsData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductsData.Location = new System.Drawing.Point(0, 0);
            this.panelProductsData.Name = "panelProductsData";
            this.panelProductsData.Size = new System.Drawing.Size(730, 424);
            this.panelProductsData.TabIndex = 1;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToResizeColumns = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(197)))), ((int)(((byte)(201)))));
            this.dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(197)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(197)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(197)))), ((int)(((byte)(201)))));
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.RowTemplate.ReadOnly = true;
            this.dataGridViewProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(730, 392);
            this.dataGridViewProducts.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.textBoxSearchProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 32);
            this.panel1.TabIndex = 3;
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
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.TabStop = false;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.textBoxSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchProduct.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchProduct.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSearchProduct.Location = new System.Drawing.Point(457, 3);
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.Size = new System.Drawing.Size(270, 27);
            this.textBoxSearchProduct.TabIndex = 4;
            this.textBoxSearchProduct.Text = "Enter product name to search...";
            this.textBoxSearchProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSearchProduct_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "PRODUCTS";
            // 
            // UCProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(197)))), ((int)(((byte)(201)))));
            this.Controls.Add(this.panelProductsData);
            this.Controls.Add(this.panelProductsButtons);
            this.Name = "UCProducts";
            this.Size = new System.Drawing.Size(730, 468);
            this.Load += new System.EventHandler(this.UCProducts_Load);
            this.panelProductsButtons.ResumeLayout(false);
            this.panelProductsData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProductsButtons;
        private System.Windows.Forms.Panel panelProductsData;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSearchProduct;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
    }
}
