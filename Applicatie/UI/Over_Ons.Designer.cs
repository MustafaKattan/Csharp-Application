namespace Applicatie
{
    partial class Over_Ons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Over_Ons));
            this.header = new System.Windows.Forms.Panel();
            this.MenuSoorten = new System.Windows.Forms.Label();
            this.MenuUitloggen = new System.Windows.Forms.Label();
            this.MenuAccount = new System.Windows.Forms.Label();
            this.MenuProducten = new System.Windows.Forms.Label();
            this.MenuHome = new System.Windows.Forms.Label();
            this.HeaderLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.header.Location = new System.Drawing.Point(4, 2);
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
            // MenuAccount
            // 
            this.MenuAccount.AutoSize = true;
            this.MenuAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuAccount.Font = new System.Drawing.Font("Roboto", 16F);
            this.MenuAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuAccount.ImeMode = System.Windows.Forms.ImeMode.Off;
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
            this.MenuProducten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuProducten.Font = new System.Drawing.Font("Roboto", 16F);
            this.MenuProducten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuProducten.ImeMode = System.Windows.Forms.ImeMode.Off;
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
            this.MenuHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuHome.Font = new System.Drawing.Font("Roboto", 16F);
            this.MenuHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuHome.ImeMode = System.Windows.Forms.ImeMode.Off;
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
            this.HeaderLogo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.HeaderLogo.Location = new System.Drawing.Point(12, 5);
            this.HeaderLogo.Name = "HeaderLogo";
            this.HeaderLogo.Size = new System.Drawing.Size(100, 50);
            this.HeaderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeaderLogo.TabIndex = 1;
            this.HeaderLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.label1.Location = new System.Drawing.Point(333, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "Over ons";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 16F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.button1.Location = new System.Drawing.Point(168, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(458, 315);
            this.button1.TabIndex = 16;
            this.button1.Text = resources.GetString("button1.Text");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Over_Ons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header);
            this.Name = "Over_Ons";
            this.Text = "Over_Ons";
            this.Load += new System.EventHandler(this.Over_Ons_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}