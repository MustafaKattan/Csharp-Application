using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Applicatie
{
    public partial class Inloggen : Form
    {
        public static string gebruikerNaam;
        public static int gebruikerID;
        public static string gebruikerRol;
        public Inloggen()
        {
            InitializeComponent();
            
        }

        private void Inloggen_Load(object sender, EventArgs e)
        {

        }

        private void BtnInloggen_Click(object sender, EventArgs e)
        {
            GebruikerBO gebruikerBO = new GebruikerBO();
            GebruikerBLL gebruikerBLL = new GebruikerBLL();
           
            
            gebruikerBO.GebruikerNaam = TbGebruikersnaam.Text.Trim();
            gebruikerBO.Wachtwoord = TbWachtwoord.Text.Trim();

            bool success = gebruikerBLL.Gebruikersgegevens(gebruikerBO);

            if (success == false)
            {
               lbMelding.Text = "Gebruiksnaam of wachtwoord kloppen niet!";
            }
            else
            {
                gebruikerNaam = TbGebruikersnaam.Text.Trim();
                gebruikerID = gebruikerBLL.GetID(gebruikerBO);
                gebruikerRol = gebruikerBLL.GetRol(gebruikerBO);
                var myForm = new Home();
                myForm.Show();
                this.Visible = false;
               
              

            }


        }

        private void LbMaakAccount_Click(object sender, EventArgs e)
        {
            var myForm = new Registareren();
            myForm.Show();
            this.Visible = false;

        }
    }
}
