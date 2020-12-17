using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicatie
{
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            if (Inloggen.gebruikerRol == "Admin")
            {
                BtnGegevens.Visible = true;
            }

            GebruikerBLL gebruikerBLL = new GebruikerBLL();
            GebruikerBO gebruikerBO = new GebruikerBO();

            gebruikerBO.GebruikerNaam = Inloggen.gebruikerNaam;
   
          
            LbNaam.Text = Inloggen.gebruikerNaam;
            LbRol.Text = Inloggen.gebruikerRol;


            lvEigenProducten.Items.Clear();

            ProductBO productBO = new ProductBO();
            ProductBLL productBLL = new ProductBLL();

            productBO.GebruikerIdD201 = Inloggen.gebruikerID;

            DataSet ds = productBLL.ReadEigeneProduct(productBO);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                DataRow row = ds.Tables[0].Rows[i];

                if (row.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvlItem = new ListViewItem()
                    {
                        Text = row["ProductNaam"].ToString()
                    };
                    for (int j = 1; j < ds.Tables[0].Columns.Count; j++)
                    {
                        lvlItem.SubItems.Add(row[j].ToString());
                    }

                    lvEigenProducten.Items.Add(lvlItem);

                }
            }
            lvEigenProducten.Sort();


        }

        private void BtnGegevens_Click(object sender, EventArgs e)
        {
            var myForm = new Admin();
            myForm.Show();
            this.Visible = false;
        }

        private void MenuUitloggen_Click(object sender, EventArgs e)
        {
            Inloggen.gebruikerID = 0;
            var myForm = new Inloggen();
            myForm.Show();
            this.Visible = false;
        }

        private void MenuHome_Click(object sender, EventArgs e)
        {
            var myForm = new Home();
            myForm.Show();
            this.Visible = false;
        }

        private void MenuProducten_Click(object sender, EventArgs e)
        {
            var myForm = new Producten();
            myForm.Show();
            this.Visible = false;
        }

        private void MenuSoorten_Click(object sender, EventArgs e)
        {
            var myForm = new Soorten();
            myForm.Show();
            this.Visible = false;
        }
    }
}
