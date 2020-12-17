using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatie
{
    class SoortBLL
    {
        // Methods 
        // CREATE
        public int Create(SoortBO soort)
        {
            SoortDAL soortDAL = new SoortDAL();
            return soortDAL.Create(soort);
        }
        // READ
        public DataSet Read(SoortBO soort)
        {
            SoortDAL soortDAL = new SoortDAL();
            return soortDAL.Read(soort);
        }
        public DataSet ReadProductenSoorten(SoortBO soort)
        {
            SoortDAL soortDAL = new SoortDAL();
            return soortDAL.ReadProductenSoorten(soort);
        }
        public DataSet ReadSoortNaam()
        {
            SoortDAL soortDAL = new SoortDAL();
            return soortDAL.ReadSoortNaam();
        }
        public int ReadSoortID(SoortBO soort)
        {
            SoortDAL soortDAL = new SoortDAL();
            return soortDAL.ReadSoortID(soort);
        }
        // UPDATE
        public bool Update(SoortBO soort)
        {
            SoortDAL soortDAL = new SoortDAL();
            return soortDAL.Update(soort);
        }
        // DELETE
        public bool Delete(SoortBO soort)
        {
            SoortDAL soortDAL = new SoortDAL();
            return soortDAL.Delete(soort);
        }
    }
}
