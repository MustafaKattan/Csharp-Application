namespace Applicatie
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbUitloggen = new System.Windows.Forms.Label();
            this.MenuSoort = new System.Windows.Forms.Label();
            this.MenuProduct = new System.Windows.Forms.Label();
            this.LbHome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gebruikerIdH201DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gebruikerNaamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wachtwoordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gebruikerRolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblGebruikerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deSorteerMeneerDataSet = new Applicatie.DeSorteerMeneerDataSet();
            this.tblGebruikerTableAdapter = new Applicatie.DeSorteerMeneerDataSetTableAdapters.tblGebruikerTableAdapter();
            this.CombRol = new System.Windows.Forms.ComboBox();
            this.TBNaam = new System.Windows.Forms.TextBox();
            this.TBWachtwoord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.lbMelding = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGebruikerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSorteerMeneerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LbUitloggen);
            this.panel1.Controls.Add(this.MenuSoort);
            this.panel1.Controls.Add(this.MenuProduct);
            this.panel1.Controls.Add(this.LbHome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 60);
            this.panel1.TabIndex = 0;
            // 
            // LbUitloggen
            // 
            this.LbUitloggen.AutoSize = true;
            this.LbUitloggen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LbUitloggen.Font = new System.Drawing.Font("Roboto", 16F);
            this.LbUitloggen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.LbUitloggen.Location = new System.Drawing.Point(666, 15);
            this.LbUitloggen.Name = "LbUitloggen";
            this.LbUitloggen.Size = new System.Drawing.Size(105, 29);
            this.LbUitloggen.TabIndex = 5;
            this.LbUitloggen.Text = "Uitloggen";
            this.LbUitloggen.Click += new System.EventHandler(this.LbUitloggen_Click);
            // 
            // MenuSoort
            // 
            this.MenuSoort.AutoSize = true;
            this.MenuSoort.Font = new System.Drawing.Font("Roboto", 16F);
            this.MenuSoort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuSoort.Location = new System.Drawing.Point(486, 15);
            this.MenuSoort.Name = "MenuSoort";
            this.MenuSoort.Size = new System.Drawing.Size(91, 29);
            this.MenuSoort.TabIndex = 3;
            this.MenuSoort.Text = "Soorten";
            this.MenuSoort.Click += new System.EventHandler(this.MenuSoort_Click);
            // 
            // MenuProduct
            // 
            this.MenuProduct.AutoSize = true;
            this.MenuProduct.Font = new System.Drawing.Font("Roboto", 16F);
            this.MenuProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.MenuProduct.Location = new System.Drawing.Point(353, 15);
            this.MenuProduct.Name = "MenuProduct";
            this.MenuProduct.Size = new System.Drawing.Size(114, 29);
            this.MenuProduct.TabIndex = 2;
            this.MenuProduct.Text = "Producten";
            this.MenuProduct.Click += new System.EventHandler(this.MenuProduct_Click);
            // 
            // LbHome
            // 
            this.LbHome.AutoSize = true;
            this.LbHome.Font = new System.Drawing.Font("Roboto", 16F);
            this.LbHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.LbHome.Location = new System.Drawing.Point(259, 15);
            this.LbHome.Name = "LbHome";
            this.LbHome.Size = new System.Drawing.Size(73, 29);
            this.LbHome.TabIndex = 1;
            this.LbHome.Text = "Home";
            this.LbHome.Click += new System.EventHandler(this.LbHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gebruikerIdH201DataGridViewTextBoxColumn,
            this.gebruikerNaamDataGridViewTextBoxColumn,
            this.wachtwoordDataGridViewTextBoxColumn,
            this.gebruikerRolDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblGebruikerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(335, 135);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(437, 393);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // gebruikerIdH201DataGridViewTextBoxColumn
            // 
            this.gebruikerIdH201DataGridViewTextBoxColumn.DataPropertyName = "gebruikerIdH201";
            this.gebruikerIdH201DataGridViewTextBoxColumn.HeaderText = "GebruikerId";
            this.gebruikerIdH201DataGridViewTextBoxColumn.Name = "gebruikerIdH201DataGridViewTextBoxColumn";
            this.gebruikerIdH201DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gebruikerNaamDataGridViewTextBoxColumn
            // 
            this.gebruikerNaamDataGridViewTextBoxColumn.DataPropertyName = "gebruikerNaam";
            this.gebruikerNaamDataGridViewTextBoxColumn.HeaderText = "GebruikerNaam";
            this.gebruikerNaamDataGridViewTextBoxColumn.Name = "gebruikerNaamDataGridViewTextBoxColumn";
            // 
            // wachtwoordDataGridViewTextBoxColumn
            // 
            this.wachtwoordDataGridViewTextBoxColumn.DataPropertyName = "wachtwoord";
            this.wachtwoordDataGridViewTextBoxColumn.HeaderText = "Wachtwoord";
            this.wachtwoordDataGridViewTextBoxColumn.Name = "wachtwoordDataGridViewTextBoxColumn";
            // 
            // gebruikerRolDataGridViewTextBoxColumn
            // 
            this.gebruikerRolDataGridViewTextBoxColumn.DataPropertyName = "gebruikerRol";
            this.gebruikerRolDataGridViewTextBoxColumn.HeaderText = "GebruikerRol";
            this.gebruikerRolDataGridViewTextBoxColumn.Name = "gebruikerRolDataGridViewTextBoxColumn";
            // 
            // tblGebruikerBindingSource
            // 
            this.tblGebruikerBindingSource.DataMember = "tblGebruiker";
            this.tblGebruikerBindingSource.DataSource = this.deSorteerMeneerDataSet;
            // 
            // deSorteerMeneerDataSet
            // 
            this.deSorteerMeneerDataSet.DataSetName = "DeSorteerMeneerDataSet";
            this.deSorteerMeneerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblGebruikerTableAdapter
            // 
            this.tblGebruikerTableAdapter.ClearBeforeFill = true;
            // 
            // CombRol
            // 
            this.CombRol.Font = new System.Drawing.Font("Lora", 14F);
            this.CombRol.FormattingEnabled = true;
            this.CombRol.Location = new System.Drawing.Point(42, 344);
            this.CombRol.Name = "CombRol";
            this.CombRol.Size = new System.Drawing.Size(248, 34);
            this.CombRol.TabIndex = 3;
            // 
            // TBNaam
            // 
            this.TBNaam.Font = new System.Drawing.Font("Lora", 14F);
            this.TBNaam.Location = new System.Drawing.Point(42, 208);
            this.TBNaam.Name = "TBNaam";
            this.TBNaam.Size = new System.Drawing.Size(248, 32);
            this.TBNaam.TabIndex = 4;
            // 
            // TBWachtwoord
            // 
            this.TBWachtwoord.Font = new System.Drawing.Font("Lora", 14F);
            this.TBWachtwoord.Location = new System.Drawing.Point(42, 275);
            this.TBWachtwoord.Name = "TBWachtwoord";
            this.TBWachtwoord.Size = new System.Drawing.Size(248, 32);
            this.TBWachtwoord.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.label1.Location = new System.Drawing.Point(39, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "GebruikersNaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.label2.Location = new System.Drawing.Point(39, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wachtwoord:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.label3.Location = new System.Drawing.Point(39, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 20F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.label4.Location = new System.Drawing.Point(36, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gegevens beheren";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Roboto", 18F);
            this.BtnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.BtnUpdate.Location = new System.Drawing.Point(41, 384);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(249, 46);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Roboto", 18F);
            this.BtnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.BtnDelete.Location = new System.Drawing.Point(41, 436);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(249, 46);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // lbMelding
            // 
            this.lbMelding.AutoSize = true;
            this.lbMelding.Font = new System.Drawing.Font("Lora", 8.25F);
            this.lbMelding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(173)))), ((int)(((byte)(123)))));
            this.lbMelding.Location = new System.Drawing.Point(41, 489);
            this.lbMelding.Name = "lbMelding";
            this.lbMelding.Size = new System.Drawing.Size(0, 14);
            this.lbMelding.TabIndex = 12;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbMelding);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBWachtwoord);
            this.Controls.Add(this.TBNaam);
            this.Controls.Add(this.CombRol);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGebruikerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSorteerMeneerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbHome;
        private System.Windows.Forms.Label LbUitloggen;
        private System.Windows.Forms.Label MenuSoort;
        private System.Windows.Forms.Label MenuProduct;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DeSorteerMeneerDataSet deSorteerMeneerDataSet;
        private System.Windows.Forms.BindingSource tblGebruikerBindingSource;
        private DeSorteerMeneerDataSetTableAdapters.tblGebruikerTableAdapter tblGebruikerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gebruikerIdH201DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gebruikerNaamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wachtwoordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gebruikerRolDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox CombRol;
        private System.Windows.Forms.TextBox TBNaam;
        private System.Windows.Forms.TextBox TBWachtwoord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label lbMelding;
    }
}