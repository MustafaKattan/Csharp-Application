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
    public partial class Registareren : Form
    {
        public Registareren()
        {
            InitializeComponent();

        }
        public override System.Drawing.Color BackColor { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnInloggen_Click(object sender, EventArgs e)
        {
            GebruikerBO gebruikerBO = new GebruikerBO();
            GebruikerBLL gebruikerBLL = new GebruikerBLL();


            gebruikerBO.GebruikerNaam = TbGebruikersnaam.Text.Trim();
            gebruikerBO.Wachtwoord = TbWachtwoord.Text.Trim();

            bool success = gebruikerBLL.GebruikersNaam(gebruikerBO);

            if (success == false || gebruikerBLL.Create(gebruikerBO) == 0)
            {
                lbMelding.Text = "Gebruiksnaam bestaat al!";
            }
            else
            {
                // Account is aangemaakt
                var myForm = new Inloggen();
                myForm.Show();
                this.Visible = false;

            }
        }

        private void lbAlAccount_Click(object sender, EventArgs e)
        {
            // Heeft al een account
            var myForm = new Inloggen();
            myForm.Show();
            this.Visible = false;
        }
    }
}
