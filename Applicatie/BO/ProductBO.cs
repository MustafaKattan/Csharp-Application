using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatie
{
    class ProductBO
    {
        private int     _productIdH202;
        private string  _productNaam;
        private int     _soortIdD203;
        private int     _gebruikerIdD201;
        private string  _productBarcode;

        public int ProductIdH202 { get; set; }

        public string ProductNaam { get; set; }

        public int SoortIdD203 { get; set; }

        public int GebruikerIdD201 { get; set; }

        public string ProductBarcode { get; set; }
        public ProductBO()
        {
            // Hieronder komt wat niet leeg moet zijn.
            ProductNaam = "Niet bekend";
            SoortIdD203 = 0;
            GebruikerIdD201 = 0;

        }
    }
}
