namespace JulieUI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonCloseWindow = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLeftBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCategory = new System.Windows.Forms.Button();
            this.panelTopBar.SuspendLayout();
            this.panelLeftBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.panelTopBar.Controls.Add(this.textBoxSearch);
            this.panelTopBar.Controls.Add(this.buttonCloseWindow);
            this.panelTopBar.Controls.Add(this.buttonBack);
            this.panelTopBar.Controls.Add(this.panel1);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(800, 32);
            this.panelTopBar.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxSearch.Location = new System.Drawing.Point(150, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(270, 27);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.Text = "Enter product name to search...";
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.buttonCloseWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCloseWindow.BackgroundImage")));
            this.buttonCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.buttonCloseWindow.Location = new System.Drawing.Point(751, 2);
            this.buttonCloseWindow.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCloseWindow.Name = "buttonCloseWindow";
            this.buttonCloseWindow.Size = new System.Drawing.Size(44, 28);
            this.buttonCloseWindow.TabIndex = 0;
            this.buttonCloseWindow.TabStop = false;
            this.buttonCloseWindow.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.buttonBack.Location = new System.Drawing.Point(705, 2);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(44, 28);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.TabStop = false;
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 549);
            this.panel1.TabIndex = 0;
            // 
            // panelLeftBar
            // 
            this.panelLeftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.panelLeftBar.Controls.Add(this.buttonCategory);
            this.panelLeftBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftBar.Location = new System.Drawing.Point(0, 32);
            this.panelLeftBar.Name = "panelLeftBar";
            this.panelLeftBar.Size = new System.Drawing.Size(150, 546);
            this.panelLeftBar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 578);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 22);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(197)))), ((int)(((byte)(201)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(150, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 546);
            this.panel3.TabIndex = 3;
            // 
            // buttonCategory
            // 
            this.buttonCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCategory.BackgroundImage")));
            this.buttonCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonCategory.Location = new System.Drawing.Point(1, 39);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Size = new System.Drawing.Size(150, 48);
            this.buttonCategory.TabIndex = 0;
            this.buttonCategory.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelLeftBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panelLeftBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLeftBar;
        private System.Windows.Forms.Button buttonCloseWindow;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonCategory;
    }
}

