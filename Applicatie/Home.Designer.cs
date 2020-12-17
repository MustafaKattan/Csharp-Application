namespace Applicatie
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.header = new System.Windows.Forms.Panel();
            this.MenuSoorten = new System.Windows.Forms.Label();
            this.MenuUitloggen = new System.Windows.Forms.Label();
            this.MenuAccount = new System.Windows.Forms.Label();
            this.MenuProducten = new System.Windows.Forms.Label();
            this.MenuHome = new System.Windows.Forms.Label();
            this.HeaderLogo = new System.Windows.Forms.PictureBox();
            this.BtnProducten = new System.Windows.Forms.Button();
            this.BtnOverOns = new System.Windows.Forms.Button();
            this.BtnSoorten = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.header, "header");
            this.header.Name = "header";
            // 
            // MenuSoorten
            // 
            resources.ApplyResources(this.MenuSoorten, "MenuSoorten");
            this.MenuSoorten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuSoorten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuSoorten.Name = "MenuSoorten";
            this.MenuSoorten.Click += new System.EventHandler(this.MenuSoorten_Click);
            // 
            // MenuUitloggen
            // 
            resources.ApplyResources(this.MenuUitloggen, "MenuUitloggen");
            this.MenuUitloggen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuUitloggen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuUitloggen.Name = "MenuUitloggen";
            this.MenuUitloggen.Click += new System.EventHandler(this.MenuUitloggen_Click);
            // 
            // MenuAccount
            // 
            resources.ApplyResources(this.MenuAccount, "MenuAccount");
            this.MenuAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuAccount.Name = "MenuAccount";
            this.MenuAccount.Click += new System.EventHandler(this.MenuAccount_Click);
            // 
            // MenuProducten
            // 
            resources.ApplyResources(this.MenuProducten, "MenuProducten");
            this.MenuProducten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuProducten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuProducten.Name = "MenuProducten";
            this.MenuProducten.Click += new System.EventHandler(this.MenuProducten_Click);
            // 
            // MenuHome
            // 
            resources.ApplyResources(this.MenuHome, "MenuHome");
            this.MenuHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuHome.Name = "MenuHome";
            // 
            // HeaderLogo
            // 
            resources.ApplyResources(this.HeaderLogo, "HeaderLogo");
            this.HeaderLogo.Name = "HeaderLogo";
            this.HeaderLogo.TabStop = false;
            // 
            // BtnProducten
            // 
            this.BtnProducten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.BtnProducten.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            resources.ApplyResources(this.BtnProducten, "BtnProducten");
            this.BtnProducten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.BtnProducten.Name = "BtnProducten";
            this.BtnProducten.UseVisualStyleBackColor = false;
            this.BtnProducten.Click += new System.EventHandler(this.BtnProducten_Click);
            // 
            // BtnOverOns
            // 
            this.BtnOverOns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.BtnOverOns.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            resources.ApplyResources(this.BtnOverOns, "BtnOverOns");
            this.BtnOverOns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.BtnOverOns.Name = "BtnOverOns";
            this.BtnOverOns.UseVisualStyleBackColor = false;
            this.BtnOverOns.Click += new System.EventHandler(this.BtnOverOns_Click);
            // 
            // BtnSoorten
            // 
            this.BtnSoorten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.BtnSoorten.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            resources.ApplyResources(this.BtnSoorten, "BtnSoorten");
            this.BtnSoorten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.BtnSoorten.Name = "BtnSoorten";
            this.BtnSoorten.UseVisualStyleBackColor = false;
            this.BtnSoorten.Click += new System.EventHandler(this.BtnSoorten_Click);
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.BtnSoorten);
            this.Controls.Add(this.BtnOverOns);
            this.Controls.Add(this.BtnProducten);
            this.Controls.Add(this.header);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Home_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label MenuUitloggen;
        private System.Windows.Forms.Label MenuAccount;
        private System.Windows.Forms.Label MenuProducten;
        private System.Windows.Forms.Label MenuHome;
        private System.Windows.Forms.PictureBox HeaderLogo;
        private System.Windows.Forms.Button BtnProducten;
        private System.Windows.Forms.Button BtnOverOns;
        private System.Windows.Forms.Button BtnSoorten;
        private System.Windows.Forms.Label MenuSoorten;
    }
}

