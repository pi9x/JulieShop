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
            this.panelUserControls = new System.Windows.Forms.Panel();
            this.buttonCategory = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.labelLogo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.panelLeftBar = new System.Windows.Forms.Panel();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.buttonCloseWindow = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLeftBar.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserControls
            // 
            this.panelUserControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(197)))), ((int)(((byte)(201)))));
            this.panelUserControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserControls.Location = new System.Drawing.Point(170, 32);
            this.panelUserControls.Name = "panelUserControls";
            this.panelUserControls.Size = new System.Drawing.Size(730, 468);
            this.panelUserControls.TabIndex = 3;
            // 
            // buttonCategory
            // 
            this.buttonCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCategory.BackgroundImage")));
            this.buttonCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonCategory.Location = new System.Drawing.Point(0, 139);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Size = new System.Drawing.Size(170, 40);
            this.buttonCategory.TabIndex = 2;
            this.buttonCategory.TabStop = false;
            this.buttonCategory.UseVisualStyleBackColor = false;
            this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonProduct.BackgroundImage")));
            this.buttonProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonProduct.Location = new System.Drawing.Point(0, 185);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(170, 40);
            this.buttonProduct.TabIndex = 3;
            this.buttonProduct.UseVisualStyleBackColor = false;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.labelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLogo.Location = new System.Drawing.Point(4, 3);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(161, 59);
            this.labelLogo.TabIndex = 4;
            this.labelLogo.Text = "JULIE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 452);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelName.Location = new System.Drawing.Point(50, 458);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(117, 15);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "NGUYEN HAI DANG";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentID.ForeColor = System.Drawing.SystemColors.Window;
            this.labelStudentID.Location = new System.Drawing.Point(50, 478);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(74, 15);
            this.labelStudentID.TabIndex = 7;
            this.labelStudentID.Text = "ID: 1988010";
            // 
            // panelLeftBar
            // 
            this.panelLeftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.panelLeftBar.Controls.Add(this.labelStudentID);
            this.panelLeftBar.Controls.Add(this.labelName);
            this.panelLeftBar.Controls.Add(this.pictureBox1);
            this.panelLeftBar.Controls.Add(this.labelLogo);
            this.panelLeftBar.Controls.Add(this.buttonProduct);
            this.panelLeftBar.Controls.Add(this.buttonCategory);
            this.panelLeftBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftBar.Location = new System.Drawing.Point(0, 0);
            this.panelLeftBar.Name = "panelLeftBar";
            this.panelLeftBar.Size = new System.Drawing.Size(170, 500);
            this.panelLeftBar.TabIndex = 1;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.panelTopBar.Controls.Add(this.buttonCloseWindow);
            this.panelTopBar.Controls.Add(this.buttonMinimize);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(170, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(730, 32);
            this.panelTopBar.TabIndex = 4;
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonCloseWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCloseWindow.BackgroundImage")));
            this.buttonCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.buttonCloseWindow.Location = new System.Drawing.Point(694, 0);
            this.buttonCloseWindow.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCloseWindow.Name = "buttonCloseWindow";
            this.buttonCloseWindow.Size = new System.Drawing.Size(36, 32);
            this.buttonCloseWindow.TabIndex = 0;
            this.buttonCloseWindow.TabStop = false;
            this.buttonCloseWindow.UseVisualStyleBackColor = false;
            this.buttonCloseWindow.Click += new System.EventHandler(this.buttonCloseWindow_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.BackgroundImage")));
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.buttonMinimize.Location = new System.Drawing.Point(659, 0);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(36, 32);
            this.buttonMinimize.TabIndex = 0;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.ControlBox = false;
            this.Controls.Add(this.panelUserControls);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.panelLeftBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLeftBar.ResumeLayout(false);
            this.panelLeftBar.PerformLayout();
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelUserControls;
        private System.Windows.Forms.Button buttonCategory;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Panel panelLeftBar;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Button buttonCloseWindow;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
    }
}

