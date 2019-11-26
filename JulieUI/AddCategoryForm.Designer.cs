namespace JulieUI
{
    partial class AddCategoryForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAddCategoryOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCloseWindow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelAddProductTopBar = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelAddProductTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.textBoxName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(100, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 132);
            this.panel3.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(6, 47);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(235, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonAddCategoryOK
            // 
            this.buttonAddCategoryOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.buttonAddCategoryOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddCategoryOK.BackgroundImage")));
            this.buttonAddCategoryOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddCategoryOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCategoryOK.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCategoryOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.buttonAddCategoryOK.Location = new System.Drawing.Point(145, 2);
            this.buttonAddCategoryOK.Name = "buttonAddCategoryOK";
            this.buttonAddCategoryOK.Size = new System.Drawing.Size(60, 32);
            this.buttonAddCategoryOK.TabIndex = 0;
            this.buttonAddCategoryOK.UseVisualStyleBackColor = false;
            this.buttonAddCategoryOK.Click += new System.EventHandler(this.buttonAddCategoryOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(151)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.buttonAddCategoryOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(151)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(0, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 36);
            this.panel1.TabIndex = 5;
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.buttonCloseWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCloseWindow.BackgroundImage")));
            this.buttonCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(93)))), ((int)(((byte)(175)))));
            this.buttonCloseWindow.Location = new System.Drawing.Point(314, 0);
            this.buttonCloseWindow.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCloseWindow.Name = "buttonCloseWindow";
            this.buttonCloseWindow.Size = new System.Drawing.Size(36, 32);
            this.buttonCloseWindow.TabIndex = 1;
            this.buttonCloseWindow.TabStop = false;
            this.buttonCloseWindow.UseVisualStyleBackColor = false;
            this.buttonCloseWindow.Click += new System.EventHandler(this.buttonCloseWindow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "ADD NEW CATEGORY";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 132);
            this.panel2.TabIndex = 6;
            // 
            // panelAddProductTopBar
            // 
            this.panelAddProductTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.panelAddProductTopBar.Controls.Add(this.buttonCloseWindow);
            this.panelAddProductTopBar.Controls.Add(this.label3);
            this.panelAddProductTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddProductTopBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.panelAddProductTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelAddProductTopBar.Name = "panelAddProductTopBar";
            this.panelAddProductTopBar.Size = new System.Drawing.Size(350, 32);
            this.panelAddProductTopBar.TabIndex = 4;
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAddProductTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCategoryForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelAddProductTopBar.ResumeLayout(false);
            this.panelAddProductTopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAddCategoryOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCloseWindow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelAddProductTopBar;
    }
}