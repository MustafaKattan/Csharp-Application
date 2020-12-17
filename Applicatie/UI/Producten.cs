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
    public partial class Producten : Form
    {
        public Producten()
        {
            InitializeComponent();
        }


        private void listviewRefresh(int soortID)
        {
            LvProducten.Items.Clear();

            SoortBO soortBO = new SoortBO();
            SoortBLL soortBLL = new SoortBLL();



            soortBO.SoortIdH203 = soortID;


            DataSet ds = soortBLL.ReadProductenSoorten(soortBO);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                DataRow row = ds.Tables[0].Rows[i];

                if (row.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvlItem = new ListViewItem()
                    {
                        Text = row["productNaam"].ToString()
                    };
                    for (int j = 1; j < ds.Tables[0].Columns.Count; j++)
                    {
                        lvlItem.SubItems.Add(row[j].ToString());
                    }

                    LvProducten.Items.Add(lvlItem);

                }
            }
            LvProducten.Sort();
        }

        private void BtnOverzicht_Click(object sender, EventArgs e)
        {
            LvProducten.Visible = true;
        }

        private void Producten_Load(object sender, EventArgs e)
        {
            LvProducten.Items.Clear();

            ProductBLL productBLL = new ProductBLL();

            DataSet ds = productBLL.Read();

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

                    LvProducten.Items.Add(lvlItem);

                }
            }
            LvProducten.Sort();
        }

        private void MenuProducten_Click(object sender, EventArgs e)
        {
            var myForm = new Producten();
            myForm.Show();
            this.Visible = false;
        }

        private void MenuSoorten_Click_1(object sender, EventArgs e)
        {
            var myForm = new Soorten();
            myForm.Show();
            this.Visible = false;
        }

        private void MenuAccount_Click_1(object sender, EventArgs e)
        {
            var myForm = new MyAccount();
            myForm.Show();
            this.Visible = false;
        }

        private void MenuUitloggen_Click_1(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new ProductenBeheren();
            myForm.Show();
            this.Visible = false;
        }

    }
}
