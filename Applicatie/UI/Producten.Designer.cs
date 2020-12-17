namespace Applicatie
{
    partial class Producten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producten));
            this.header = new System.Windows.Forms.Panel();
            this.MenuSoorten = new System.Windows.Forms.Label();
            this.MenuUitloggen = new System.Windows.Forms.Label();
            this.MenuAccount = new System.Windows.Forms.Label();
            this.MenuProducten = new System.Windows.Forms.Label();
            this.MenuHome = new System.Windows.Forms.Label();
            this.HeaderLogo = new System.Windows.Forms.PictureBox();
            this.BtnOverzicht = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LvProducten = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Container = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Barcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Toegevoegd_door = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbMelding = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.MenuSoorten);
            this.header.Controls.Add(this.MenuUitloggen);
            this.header.Controls.Add(this.MenuAccount);
            this.header.Controls.Add(this.MenuProducten);
            this.header.Controls.Add(this.MenuHome);
            this.header.Controls.Add(this.HeaderLogo);
            this.header.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.header.Location = new System.Drawing.Point(5, 2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(794, 60);
            this.header.TabIndex = 8;
            // 
            // MenuSoorten
            // 
            this.MenuSoorten.AutoSize = true;
            this.MenuSoorten.Font = new System.Drawing.Font("Roboto", 16F);
            this.MenuSoorten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuSoorten.Location = new System.Drawing.Point(386, 15);
            this.MenuSoorten.Name = "MenuSoorten";
            this.MenuSoorten.Size = new System.Drawing.Size(91, 29);
            this.MenuSoorten.TabIndex = 6;
            this.MenuSoorten.Text = "Soorten";
            this.MenuSoorten.Click += new System.EventHandler(this.MenuSoorten_Click_1);
            // 
            // MenuUitloggen
            // 
            this.MenuUitloggen.AutoSize = true;
            this.MenuUitloggen.Font = new System.Drawing.Font("Roboto", 16F);
            this.MenuUitloggen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuUitloggen.Location = new System.Drawing.Point(667, 15);
            this.MenuUitloggen.Name = "MenuUitloggen";
            this.MenuUitloggen.Size = new System.Drawing.Size(105, 29);
            this.MenuUitloggen.TabIndex = 5;
            this.MenuUitloggen.Text = "Uitloggen";
            this.MenuUitloggen.Click += new System.EventHandler(this.MenuUitloggen_Click_1);
            // 
            // MenuAccount
            // 
            this.MenuAccount.AutoSize = true;
            this.MenuAccount.Font = new System.Drawing.Font("Roboto", 16F);
            this.MenuAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuAccount.Location = new System.Drawing.Point(483, 15);
            this.MenuAccount.Name = "MenuAccount";
            this.MenuAccount.Size = new System.Drawing.Size(139, 29);
            this.MenuAccount.TabIndex = 4;
            this.MenuAccount.Text = "Mijn account";
            this.MenuAccount.Click += new System.EventHandler(this.MenuAccount_Click_1);
            // 
            // MenuProducten
            // 
            this.MenuProducten.AutoSize = true;
            this.MenuProducten.Font = new System.Drawing.Font("Roboto", 16F);
            this.MenuProducten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuProducten.Location = new System.Drawing.Point(269, 15);
            this.MenuProducten.Name = "MenuProducten";
            this.MenuProducten.Size = new System.Drawing.Size(114, 29);
            this.MenuProducten.TabIndex = 3;
            this.MenuProducten.Text = "Producten";
            this.MenuProducten.Click += new System.EventHandler(this.MenuProducten_Click);
            // 
            // MenuHome
            // 
            this.MenuHome.AutoSize = true;
            this.MenuHome.Font = new System.Drawing.Font("Roboto", 16F);
            this.MenuHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuHome.Location = new System.Drawing.Point(190, 15);
            this.MenuHome.Name = "MenuHome";
            this.MenuHome.Size = new System.Drawing.Size(73, 29);
            this.MenuHome.TabIndex = 2;
            this.MenuHome.Text = "Home";
            this.MenuHome.Click += new System.EventHandler(this.MenuHome_Click);
            // 
            // HeaderLogo
            // 
            this.HeaderLogo.Image = ((System.Drawing.Image)(resources.GetObject("HeaderLogo.Image")));
            this.HeaderLogo.Location = new System.Drawing.Point(12, 5);
            this.HeaderLogo.Name = "HeaderLogo";
            this.HeaderLogo.Size = new System.Drawing.Size(100, 50);
            this.HeaderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeaderLogo.TabIndex = 1;
            this.HeaderLogo.TabStop = false;
            // 
            // BtnOverzicht
            // 
            this.BtnOverzicht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.BtnOverzicht.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOverzicht.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.BtnOverzicht.FlatAppearance.BorderSize = 3;
            this.BtnOverzicht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOverzicht.Font = new System.Drawing.Font("Roboto", 18F);
            this.BtnOverzicht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.BtnOverzicht.Location = new System.Drawing.Point(12, 118);
            this.BtnOverzicht.Name = "BtnOverzicht";
            this.BtnOverzicht.Padding = new System.Windows.Forms.Padding(5);
            this.BtnOverzicht.Size = new System.Drawing.Size(384, 120);
            this.BtnOverzicht.TabIndex = 9;
            this.BtnOverzicht.Text = "Overzicht";
            this.BtnOverzicht.UseVisualStyleBackColor = false;
            this.BtnOverzicht.Click += new System.EventHandler(this.BtnOverzicht_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 18F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.button1.Location = new System.Drawing.Point(396, 118);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(376, 120);
            this.button1.TabIndex = 10;
            this.button1.Text = "Product Toevoegen/Zoeken";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LvProducten
            // 
            this.LvProducten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.Soort,
            this.Container,
            this.Barcode,
            this.Toegevoegd_door});
            this.LvProducten.HideSelection = false;
            this.LvProducten.Location = new System.Drawing.Point(12, 252);
            this.LvProducten.Name = "LvProducten";
            this.LvProducten.Size = new System.Drawing.Size(760, 305);
            this.LvProducten.TabIndex = 19;
            this.LvProducten.UseCompatibleStateImageBehavior = false;
            this.LvProducten.View = System.Windows.Forms.View.Details;
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
            // Toegevoegd_door
            // 
            this.Toegevoegd_door.Text = "Toegevoegd door";
            this.Toegevoegd_door.Width = 124;
            // 
            // lbMelding
            // 
            this.lbMelding.AutoSize = true;
            this.lbMelding.Font = new System.Drawing.Font("Lora", 8.25F);
            this.lbMelding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.lbMelding.Location = new System.Drawing.Point(233, 543);
            this.lbMelding.Name = "lbMelding";
            this.lbMelding.Size = new System.Drawing.Size(0, 14);
            this.lbMelding.TabIndex = 29;
            // 
            // Producten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbMelding);
            this.Controls.Add(this.LvProducten);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnOverzicht);
            this.Controls.Add(this.header);
            this.Name = "Producten";
            this.Text = "Producten";
            this.Load += new System.EventHandler(this.Producten_Load);
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
        private System.Windows.Forms.Label MenuAccount;
        private System.Windows.Forms.Label MenuProducten;
        private System.Windows.Forms.Label MenuHome;
        private System.Windows.Forms.PictureBox HeaderLogo;
        private System.Windows.Forms.Button BtnOverzicht;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView LvProducten;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Soort;
        private System.Windows.Forms.ColumnHeader Container;
        private System.Windows.Forms.ColumnHeader Toegevoegd_door;
        private System.Windows.Forms.Label lbMelding;
        private System.Windows.Forms.ColumnHeader Barcode;
    }
}