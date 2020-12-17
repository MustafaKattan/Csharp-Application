using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Applicatie
{
    class ProductBLL
    {
        // Methods 
        // CREATE
        public int Create(ProductBO product)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.Create(product);
        }
        // READ
        public DataSet Read()
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.Read();
        }
        // READ
        public DataTable ReadProducten()
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.ReadProducten();
        }

        public DataTable ReadOneProduct(ProductBO product)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.ReadOneProduct(product);
        }
        //Eigen producten
        public DataSet ReadEigeneProduct(ProductBO product)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.ReadEigeneProduct(product);
        }
        // barcode checken
        public bool ProductBarcode(ProductBO product)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.ProductBarcode(product);
        }
        // UPDATE
        public bool Update(ProductBO product)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.Update(product);
        }
        // DELETE
        public bool Delete(ProductBO product)
        {
            ProductDAL productDAL = new ProductDAL();
            return productDAL.Delete(product);
        }
    }
}
