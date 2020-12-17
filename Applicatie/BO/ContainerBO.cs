using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatie
{
    class ContainerBO
    {
        private int _containerIdH204;
        private string _containerNaam;

        public int ContainerIdH204 { get; set; }

        public string ContainerNaam { get; set; }


        public ContainerBO()
        {
            // Hieronder komt wat niet leeg moet zijn.
            ContainerNaam = "Niet bekend";
        }
    }
}
