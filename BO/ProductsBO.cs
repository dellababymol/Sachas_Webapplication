using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using IDA;
using DAFactory;
using Factory;
using IExceptionLibrary;

namespace BO
{
   public class ProductsBO
    {
        private IEx obj = clsFactory.createException(Convert.ToInt16(ConfigurationManager.AppSettings["Exceptionkey"]));
        private IProductsDA objproductDA = FactProducts.CreateProductDA();
        public DataTable GetData()
        {
            try
            {
                return objproductDA.GetDataItems();
            }
            catch (Exception ex)
            {
                obj.LogError(ex);
                throw;
            }

        }
        public DataTable GetValue(string ProductID)
        {
            try
            {
                return objproductDA.GetDatatable(ProductID);
            }
            catch (Exception ex)
            {
                obj.LogError(ex);
                throw;
            }
        }
    }
}
