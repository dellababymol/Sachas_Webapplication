using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using IDA;

namespace DA
{
   public class ProductsDA : IProductsDA
    {
        public DataTable GetDataItems()
        {
            //string CS = ConfigurationManager.AppSettings["Sql"];
            string CS = ConfigurationManager.ConnectionStrings["BakersConnectionString"].ConnectionString;
            string queryString = "SELECT * FROM dbo.tblProduct";
            using (SqlConnection connection = new SqlConnection(CS))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataAdapter adpData = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adpData.Fill(dt);
                    //DataList1.DataSource = dt;
                    //DataList1.DataBind();
                    connection.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public DataTable GetDatatable(string ProductID)
        {
            string query = "select * from dbo.tblProduct where ProductID = " + ProductID;
            string CS = ConfigurationManager.AppSettings["Sql"];
            //string queryString = "SELECT * FROM dbo.tblProduct where ProductID =" + query;
            using (SqlConnection connection = new SqlConnection(CS))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataAdapter adpData = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adpData.Fill(dt);
                    connection.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

        }
    }
}
