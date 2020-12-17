namespace Applicatie
{
    partial class SoortenDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoortenDetail));
            this.header = new System.Windows.Forms.Panel();
            this.MenuSoorten = new System.Windows.Forms.Label();
            this.MenuUitloggen = new System.Windows.Forms.Label();
            this.MenuAccount = new System.Windows.Forms.Label();
            this.MenuProducten = new System.Windows.Forms.Label();
            this.MenuHome = new System.Windows.Forms.Label();
            this.HeaderLogo = new System.Windows.Forms.PictureBox();
            this.BtnGegevens = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lvSoorten = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Container = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Toegevoegd_door = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
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
            this.header.Location = new System.Drawing.Point(1, 1);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(783, 60);
            this.header.TabIndex = 2;
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
            this.MenuSoorten.Click += new System.EventHandler(this.MenuSoorten_Click);
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
            this.MenuUitloggen.Click += new System.EventHandler(this.MenuUitloggen_Click);
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
            this.MenuAccount.Click += new System.EventHandler(this.MenuAccount_Click);
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
            // BtnGegevens
            // 
            this.BtnGegevens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.BtnGegevens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGegevens.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.BtnGegevens.FlatAppearance.BorderSize = 3;
            this.BtnGegevens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGegevens.Font = new System.Drawing.Font("Roboto", 18F);
            this.BtnGegevens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.BtnGegevens.Location = new System.Drawing.Point(12, 63);
            this.BtnGegevens.Name = "BtnGegevens";
            this.BtnGegevens.Padding = new System.Windows.Forms.Padding(5);
            this.BtnGegevens.Size = new System.Drawing.Size(224, 120);
            this.BtnGegevens.TabIndex = 7;
            this.BtnGegevens.Text = "Plastic";
            this.BtnGegevens.UseVisualStyleBackColor = false;
            this.BtnGegevens.Click += new System.EventHandler(this.BtnGegevens_Click);
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
            this.button1.Location = new System.Drawing.Point(12, 189);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(224, 120);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ijzer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto", 18F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.button2.Location = new System.Drawing.Point(12, 315);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5);
            this.button2.Size = new System.Drawing.Size(224, 120);
            this.button2.TabIndex = 9;
            this.button2.Text = "Hout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto", 18F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.button3.Location = new System.Drawing.Point(12, 441);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(5);
            this.button3.Size = new System.Drawing.Size(224, 120);
            this.button3.TabIndex = 10;
            this.button3.Text = "Batterijen";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lvSoorten
            // 
            this.lvSoorten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.Soort,
            this.Container,
            this.Toegevoegd_door});
            this.lvSoorten.HideSelection = false;
            this.lvSoorten.Location = new System.Drawing.Point(262, 205);
            this.lvSoorten.Name = "lvSoorten";
            this.lvSoorten.Size = new System.Drawing.Size(496, 344);
            this.lvSoorten.TabIndex = 11;
            this.lvSoorten.UseCompatibleStateImageBehavior = false;
            this.lvSoorten.View = System.Windows.Forms.View.Details;
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
            // Toegevoegd_door
            // 
            this.Toegevoegd_door.Text = "Toegevoegd door";
            this.Toegevoegd_door.Width = 124;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 20F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.label4.Location = new System.Drawing.Point(436, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Producten";
            // 
            // SoortenDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvSoorten);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnGegevens);
            this.Controls.Add(this.header);
            this.Name = "SoortenDetail";
            this.Text = "SoortenDetail";
            this.Load += new System.EventHandler(this.SoortenDetail_Load);
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
        private System.Windows.Forms.Button BtnGegevens;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lvSoorten;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Soort;
        private System.Windows.Forms.ColumnHeader Container;
        private System.Windows.Forms.ColumnHeader Toegevoegd_door;
        private System.Windows.Forms.Label label4;
    }
}