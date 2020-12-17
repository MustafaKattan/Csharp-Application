namespace Applicatie
{
    partial class Inloggen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inloggen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMelding = new System.Windows.Forms.Label();
            this.LbMaakAccount = new System.Windows.Forms.Label();
            this.BtnInloggen = new System.Windows.Forms.Button();
            this.TbWachtwoord = new System.Windows.Forms.TextBox();
            this.TbGebruikersnaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.lbMelding);
            this.panel1.Controls.Add(this.LbMaakAccount);
            this.panel1.Controls.Add(this.BtnInloggen);
            this.panel1.Controls.Add(this.TbWachtwoord);
            this.panel1.Controls.Add(this.TbGebruikersnaam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(250, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 400);
            this.panel1.TabIndex = 0;
            // 
            // lbMelding
            // 
            this.lbMelding.AutoSize = true;
            this.lbMelding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.lbMelding.Location = new System.Drawing.Point(51, 365);
            this.lbMelding.Name = "lbMelding";
            this.lbMelding.Size = new System.Drawing.Size(0, 13);
            this.lbMelding.TabIndex = 7;
            // 
            // LbMaakAccount
            // 
            this.LbMaakAccount.AutoSize = true;
            this.LbMaakAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LbMaakAccount.Font = new System.Drawing.Font("Lora", 8.25F);
            this.LbMaakAccount.Location = new System.Drawing.Point(48, 268);
            this.LbMaakAccount.Name = "LbMaakAccount";
            this.LbMaakAccount.Size = new System.Drawing.Size(101, 14);
            this.LbMaakAccount.TabIndex = 6;
            this.LbMaakAccount.Text = "Nog geen account?";
            this.LbMaakAccount.Click += new System.EventHandler(this.LbMaakAccount_Click);
            // 
            // BtnInloggen
            // 
            this.BtnInloggen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.BtnInloggen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInloggen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.BtnInloggen.FlatAppearance.BorderSize = 3;
            this.BtnInloggen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInloggen.Font = new System.Drawing.Font("Roboto", 12F);
            this.BtnInloggen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnInloggen.Location = new System.Drawing.Point(93, 294);
            this.BtnInloggen.Name = "BtnInloggen";
            this.BtnInloggen.Padding = new System.Windows.Forms.Padding(5);
            this.BtnInloggen.Size = new System.Drawing.Size(120, 50);
            this.BtnInloggen.TabIndex = 5;
            this.BtnInloggen.Text = "Inloggen";
            this.BtnInloggen.UseVisualStyleBackColor = false;
            this.BtnInloggen.Click += new System.EventHandler(this.BtnInloggen_Click);
            // 
            // TbWachtwoord
            // 
            this.TbWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbWachtwoord.Location = new System.Drawing.Point(51, 235);
            this.TbWachtwoord.Name = "TbWachtwoord";
            this.TbWachtwoord.Size = new System.Drawing.Size(200, 30);
            this.TbWachtwoord.TabIndex = 4;
            // 
            // TbGebruikersnaam
            // 
            this.TbGebruikersnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbGebruikersnaam.Location = new System.Drawing.Point(51, 188);
            this.TbGebruikersnaam.Name = "TbGebruikersnaam";
            this.TbGebruikersnaam.Size = new System.Drawing.Size(200, 30);
            this.TbGebruikersnaam.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.label1.Location = new System.Drawing.Point(87, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inloggen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Inloggen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Inloggen";
            this.ShowInTaskbar = false;
            this.Text = "Inloggen";
            this.Load += new System.EventHandler(this.Inloggen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnInloggen;
        private System.Windows.Forms.TextBox TbWachtwoord;
        private System.Windows.Forms.TextBox TbGebruikersnaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbMaakAccount;
        private System.Windows.Forms.Label lbMelding;
    }
}