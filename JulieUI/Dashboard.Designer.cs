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
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.labelLogo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.panelLeftBar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLeftBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserControls
            // 
            this.panelUserControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(197)))), ((int)(((byte)(201)))));
            this.panelUserControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserControls.Location = new System.Drawing.Point(170, 0);
            this.panelUserControls.Name = "panelUserControls";
            this.panelUserControls.Size = new System.Drawing.Size(730, 500);
            this.panelUserControls.TabIndex = 3;
            // 
            // buttonCategory
            // 
            this.buttonCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCategory.BackgroundImage")));
            this.buttonCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonCategory.Location = new System.Drawing.Point(0, 176);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Size = new System.Drawing.Size(170, 40);
            this.buttonCategory.TabIndex = 2;
            this.buttonCategory.TabStop = false;
            this.buttonCategory.UseVisualStyleBackColor = true;
            this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHome.BackgroundImage")));
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonHome.Location = new System.Drawing.Point(0, 132);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(170, 40);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonProduct.BackgroundImage")));
            this.buttonProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.buttonProduct.Location = new System.Drawing.Point(0, 220);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(170, 40);
            this.buttonProduct.TabIndex = 3;
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLogo.Location = new System.Drawing.Point(5, 3);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(161, 59);
            this.labelLogo.TabIndex = 4;
            this.labelLogo.Text = "JULIE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 450);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelName.Location = new System.Drawing.Point(50, 456);
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
            this.labelStudentID.Location = new System.Drawing.Point(50, 476);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(74, 15);
            this.labelStudentID.TabIndex = 7;
            this.labelStudentID.Text = "ID: 1988010";
            // 
            // panelLeftBar
            // 
            this.panelLeftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.panelLeftBar.Controls.Add(this.labelStudentID);
            this.panelLeftBar.Controls.Add(this.labelName);
            this.panelLeftBar.Controls.Add(this.pictureBox1);
            this.panelLeftBar.Controls.Add(this.labelLogo);
            this.panelLeftBar.Controls.Add(this.buttonProduct);
            this.panelLeftBar.Controls.Add(this.buttonHome);
            this.panelLeftBar.Controls.Add(this.buttonCategory);
            this.panelLeftBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftBar.Location = new System.Drawing.Point(0, 0);
            this.panelLeftBar.Name = "panelLeftBar";
            this.panelLeftBar.Size = new System.Drawing.Size(170, 500);
            this.panelLeftBar.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.ControlBox = false;
            this.Controls.Add(this.panelUserControls);
            this.Controls.Add(this.panelLeftBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLeftBar.ResumeLayout(false);
            this.panelLeftBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelUserControls;
        private System.Windows.Forms.Button buttonCategory;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Panel panelLeftBar;
    }
}

