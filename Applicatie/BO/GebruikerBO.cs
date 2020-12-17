using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatie
{
    class GebruikerBO
    {
        private int _gebruikerIdH201;
        private string _gebruikerNaam;
        private string _wachtwoord;
        private string _gebruikerRol;

        public int GebruikerIdH201 { get; set; }

        public string GebruikerNaam { get; set; }

        public string Wachtwoord { get; set; }

        public string GebruikerRol { get; set; }

        public GebruikerBO()
        {
            // Hieronder komt wat niet leeg moet zijn.
            GebruikerNaam = "Niet bekend";
            Wachtwoord = "admin";
            GebruikerRol = "Niet bekend";
        }



    }
}
