using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatie
{
    class SoortBO
    {
        private int _soortIdH203;
        private string _soortNaam;
        private int _containerIdD204;

        public int SoortIdH203 { get; set; }

        public string SoortNaam { get; set; }

        public int ContainerIdD204 { get; set; }

        public SoortBO()
        {
            // Hieronder komt wat niet leeg moet zijn.
            SoortNaam = "Niet bekend";
            ContainerIdD204 = 0;
        }
    }
}
