using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatie
{
    class ContainerBLL
    {
        // Methods 
        // CREATE
        public int Create(ContainerBO container)
        {
            ContainerDAL containerDAL = new ContainerDAL();
            return containerDAL.Create(container);
        }
        // READ
        public DataSet Read()
        {
            ContainerDAL containerDAL = new ContainerDAL();
            return containerDAL.Read();
        }

        // READ
        public DataSet ReadContainernaam()
        {
            ContainerDAL containerDAL = new ContainerDAL();
            return containerDAL.ReadContainernaam();
        }
        // UPDATE
        public bool Update(ContainerBO container)
        {
            ContainerDAL containerDAL = new ContainerDAL();
            return containerDAL.Update(container);
        }
        // DELETE
        public bool Delete(ContainerBO container)
        {
            ContainerDAL containerDAL = new ContainerDAL();
            return containerDAL.Delete(container);
        }
    }
}
