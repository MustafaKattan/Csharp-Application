namespace Applicatie
{
    partial class MyAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAccount));
            this.header = new System.Windows.Forms.Panel();
            this.MenuSoorten = new System.Windows.Forms.Label();
            this.MenuUitloggen = new System.Windows.Forms.Label();
            this.MenuProducten = new System.Windows.Forms.Label();
            this.MenuHome = new System.Windows.Forms.Label();
            this.HeaderLogo = new System.Windows.Forms.PictureBox();
            this.BtnGegevens = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LbNaam = new System.Windows.Forms.Label();
            this.LbRol = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LvProducten = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvEigenProducten = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Container = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Barcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.MenuSoorten);
            this.header.Controls.Add(this.MenuUitloggen);
            this.header.Controls.Add(this.MenuProducten);
            this.header.Controls.Add(this.MenuHome);
            this.header.Controls.Add(this.HeaderLogo);
            this.header.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.header.Location = new System.Drawing.Point(0, 1);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(784, 60);
            this.header.TabIndex = 1;
            // 
            // MenuSoorten
            // 
            this.MenuSoorten.AutoSize = true;
            this.MenuSoorten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuSoorten.Font = new System.Drawing.Font("Roboto", 16F);
            this.MenuSoorten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuSoorten.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MenuSoorten.Location = new System.Drawing.Point(454, 15);
            this.MenuSoorten.Name = "MenuSoorten";
            this.MenuSoorten.Size = new System.Drawing.Size(91, 29);
            this.MenuSoorten.TabIndex = 6;
            this.MenuSoorten.Text = "Soorten";
            this.MenuSoorten.Click += new System.EventHandler(this.MenuSoorten_Click);
            // 
            // MenuUitloggen
            // 
            this.MenuUitloggen.AutoSize = true;
            this.MenuUitloggen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuUitloggen.Font = new System.Drawing.Font("Roboto", 16F);
            this.MenuUitloggen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuUitloggen.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MenuUitloggen.Location = new System.Drawing.Point(667, 15);
            this.MenuUitloggen.Name = "MenuUitloggen";
            this.MenuUitloggen.Size = new System.Drawing.Size(105, 29);
            this.MenuUitloggen.TabIndex = 5;
            this.MenuUitloggen.Text = "Uitloggen";
            this.MenuUitloggen.Click += new System.EventHandler(this.MenuUitloggen_Click);
            // 
            // MenuProducten
            // 
            this.MenuProducten.AutoSize = true;
            this.MenuProducten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuProducten.Font = new System.Drawing.Font("Roboto", 16F);
            this.MenuProducten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuProducten.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MenuProducten.Location = new System.Drawing.Point(322, 15);
            this.MenuProducten.Name = "MenuProducten";
            this.MenuProducten.Size = new System.Drawing.Size(114, 29);
            this.MenuProducten.TabIndex = 3;
            this.MenuProducten.Text = "Producten";
            this.MenuProducten.Click += new System.EventHandler(this.MenuProducten_Click);
            // 
            // MenuHome
            // 
            this.MenuHome.AutoSize = true;
            this.MenuHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuHome.Font = new System.Drawing.Font("Roboto", 16F);
            this.MenuHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuHome.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MenuHome.Location = new System.Drawing.Point(233, 15);
            this.MenuHome.Name = "MenuHome";
            this.MenuHome.Size = new System.Drawing.Size(73, 29);
            this.MenuHome.TabIndex = 2;
            this.MenuHome.Text = "Home";
            this.MenuHome.Click += new System.EventHandler(this.MenuHome_Click);
            // 
            // HeaderLogo
            // 
            this.HeaderLogo.Image = ((System.Drawing.Image)(resources.GetObject("HeaderLogo.Image")));
            this.HeaderLogo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.HeaderLogo.Location = new System.Drawing.Point(12, 5);
            this.HeaderLogo.Name = "HeaderLogo";
            this.HeaderLogo.Size = new System.Drawing.Size(100, 50);
            this.HeaderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeaderLogo.TabIndex = 1;
            this.HeaderLogo.TabStop = false;
            // 
            // BtnGegevens
            // 
            this.BtnGegevens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.BtnGegevens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGegevens.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.BtnGegevens.FlatAppearance.BorderSize = 3;
            this.BtnGegevens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGegevens.Font = new System.Drawing.Font("Roboto", 18F);
            this.BtnGegevens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.BtnGegevens.Location = new System.Drawing.Point(524, 85);
            this.BtnGegevens.Name = "BtnGegevens";
            this.BtnGegevens.Padding = new System.Windows.Forms.Padding(5);
            this.BtnGegevens.Size = new System.Drawing.Size(260, 60);
            this.BtnGegevens.TabIndex = 6;
            this.BtnGegevens.Text = "Beheren";
            this.BtnGegevens.UseVisualStyleBackColor = false;
            this.BtnGegevens.Visible = false;
            this.BtnGegevens.Click += new System.EventHandler(this.BtnGegevens_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lora", 18F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.label2.Location = new System.Drawing.Point(43, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Naam:";
            // 
            // LbNaam
            // 
            this.LbNaam.AutoSize = true;
            this.LbNaam.Font = new System.Drawing.Font("Lora", 18F);
            this.LbNaam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.LbNaam.Location = new System.Drawing.Point(141, 244);
            this.LbNaam.Name = "LbNaam";
            this.LbNaam.Size = new System.Drawing.Size(81, 32);
            this.LbNaam.TabIndex = 9;
            this.LbNaam.Text = "Naam";
            // 
            // LbRol
            // 
            this.LbRol.AutoSize = true;
            this.LbRol.Font = new System.Drawing.Font("Lora", 18F);
            this.LbRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.LbRol.Location = new System.Drawing.Point(141, 295);
            this.LbRol.Name = "LbRol";
            this.LbRol.Size = new System.Drawing.Size(50, 32);
            this.LbRol.TabIndex = 11;
            this.LbRol.Text = "Rol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lora", 18F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.label6.Location = new System.Drawing.Point(45, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rol:";
            // 
            // LvProducten
            // 
            this.LvProducten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.LvProducten.HideSelection = false;
            this.LvProducten.Location = new System.Drawing.Point(290, 244);
            this.LvProducten.Name = "LvProducten";
            this.LvProducten.Size = new System.Drawing.Size(482, 288);
            this.LvProducten.TabIndex = 12;
            this.LvProducten.UseCompatibleStateImageBehavior = false;
            this.LvProducten.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 20F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.label4.Location = new System.Drawing.Point(37, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 35);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gegevens:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.label1.Location = new System.Drawing.Point(284, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Toegevoegde Producten:";
            // 
            // lvEigenProducten
            // 
            this.lvEigenProducten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.Soort,
            this.Container,
            this.Barcode});
            this.lvEigenProducten.HideSelection = false;
            this.lvEigenProducten.Location = new System.Drawing.Point(290, 244);
            this.lvEigenProducten.Name = "lvEigenProducten";
            this.lvEigenProducten.Size = new System.Drawing.Size(482, 288);
            this.lvEigenProducten.TabIndex = 20;
            this.lvEigenProducten.UseCompatibleStateImageBehavior = false;
            this.lvEigenProducten.View = System.Windows.Forms.View.Details;
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 137;
            // 
            // Soort
            // 
            this.Soort.Text = "Soort";
            this.Soort.Width = 97;
            // 
            // Container
            // 
            this.Container.Text = "Container";
            this.Container.Width = 103;
            // 
            // Barcode
            // 
            this.Barcode.Text = "Barcode";
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lvEigenProducten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LvProducten);
            this.Controls.Add(this.LbRol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LbNaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGegevens);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MyAccount";
            this.Text = "MyAccount";
            this.Load += new System.EventHandler(this.MyAccount_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label MenuSoorten;
        private System.Windows.Forms.Label MenuUitloggen;
        private System.Windows.Forms.Label MenuProducten;
        private System.Windows.Forms.Label MenuHome;
        private System.Windows.Forms.PictureBox HeaderLogo;
        private System.Windows.Forms.Button BtnGegevens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbNaam;
        private System.Windows.Forms.Label LbRol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView LvProducten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvEigenProducten;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Soort;
        private System.Windows.Forms.ColumnHeader Container;
        private System.Windows.Forms.ColumnHeader Barcode;
    }
}