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
    public partial class SoortenDetail : Form
    {
        public SoortenDetail()
        {
            InitializeComponent();
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

        private void MenuAccount_Click(object sender, EventArgs e)
        {
            var myForm = new MyAccount();
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

        private void SoortenDetail_Load(object sender, EventArgs e)
        {
            SoortBO soortBO = new SoortBO();
            SoortBLL soortBLL = new SoortBLL();

           

            soortBO.SoortIdH203 = Soorten.soortID;


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

                    lvSoorten.Items.Add(lvlItem);

                }
            }
            lvSoorten.Sort();

        }

        private void listviewRefresh(int soortID)
        {
            lvSoorten.Items.Clear();

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

                    lvSoorten.Items.Add(lvlItem);

                }
            }
            lvSoorten.Sort();
        }

        private void BtnGegevens_Click(object sender, EventArgs e)
        {
            
            listviewRefresh(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listviewRefresh(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listviewRefresh(4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listviewRefresh(5);
        }
    }
}
