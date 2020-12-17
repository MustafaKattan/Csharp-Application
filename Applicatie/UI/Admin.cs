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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deSorteerMeneerDataSet.tblGebruiker' table. You can move, or remove it, as needed.
            this.tblGebruikerTableAdapter.Fill(this.deSorteerMeneerDataSet.tblGebruiker);


            // Rollen Toevoegen
            CombRol.Items.Add("Admin");
            CombRol.Items.Add("Bezoeker");
            CombRol.Items.Add("Niet bekend");


        }

        private void LbHome_Click(object sender, EventArgs e)
        {
            var myForm = new Home();
            myForm.Show();
            this.Visible = false;
        }
        private void MenuProduct_Click(object sender, EventArgs e)
        {
            var myForm = new Inloggen();
            myForm.Show();
            this.Visible = false;
        }
        private void MenuSoort_Click(object sender, EventArgs e)
        {
            var myForm = new Soorten();
            myForm.Show();
            this.Visible = false;
        }

        private void LbUitloggen_Click(object sender, EventArgs e)
        {
            Inloggen.gebruikerID = 0;
            var myForm = new Inloggen();
            myForm.Show();
            this.Visible = false;
        }
        int geselecteerdGebruikerID;
        string geselecteerdeGebruikersNaam;
        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            int rowIndex = e.RowIndex;
            geselecteerdGebruikerID = Convert.ToInt32(dataGridView2.Rows[rowIndex].Cells[0].Value.ToString());
            geselecteerdeGebruikersNaam = dataGridView2.Rows[rowIndex].Cells[1].Value.ToString();
            TBNaam.Text = dataGridView2.Rows[rowIndex].Cells[1].Value.ToString();
            TBWachtwoord.Text = dataGridView2.Rows[rowIndex].Cells[2].Value.ToString();
            CombRol.Text = dataGridView2.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            GebruikerBO gebruikerBO = new GebruikerBO();
            GebruikerBLL gebruikerBLL = new GebruikerBLL();


            gebruikerBO.GebruikerIdH201 = geselecteerdGebruikerID;
            gebruikerBO.GebruikerNaam = TBNaam.Text.Trim();
            gebruikerBO.Wachtwoord = TBWachtwoord.Text.Trim();
            gebruikerBO.GebruikerRol = CombRol.Text.Trim();

            bool success = gebruikerBLL.GebruikersNaam(gebruikerBO);


            if (success == false && geselecteerdeGebruikersNaam != TBNaam.Text)
            {
                lbMelding.Text = "Gebruiksnaam bestaat al!";
            }
            else
            {
                // Ga updaten
                if (gebruikerBLL.Update(gebruikerBO) == false)
                {
                    lbMelding.Text = "Gebruikersgegevens is niet aangepast";
                }
                else
                {
                    lbMelding.Text = "Gebruikersgegevens is aangepast";
                    // TODO: This line of code loads data into the 'deSorteerMeneerDataSet.tblGebruiker' table. You can move, or remove it, as needed.
                    this.tblGebruikerTableAdapter.Fill(this.deSorteerMeneerDataSet.tblGebruiker);
                }
            }
           

            }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            GebruikerBO gebruikerBO = new GebruikerBO();
            GebruikerBLL gebruikerBLL = new GebruikerBLL();
            gebruikerBO.GebruikerIdH201 = geselecteerdGebruikerID;



            if (Inloggen.gebruikerID == geselecteerdGebruikerID)
            {
                lbMelding.Text = "Je kan je eigen account niet verwijderen!!";
            }
            else
            {
                // Ga updaten
                if (gebruikerBLL.Delete(gebruikerBO) == false)
                {
                    lbMelding.Text = "Gebruikersaccount is niet verwijderd";
                }
                else
                {
                    lbMelding.Text = "Gebruikersaccount is verwijderd";
                    // TODO: This line of code loads data into the 'deSorteerMeneerDataSet.tblGebruiker' table. You can move, or remove it, as needed.
                    this.tblGebruikerTableAdapter.Fill(this.deSorteerMeneerDataSet.tblGebruiker);
                }

            }
        }

      
    }
    }
