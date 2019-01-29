using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;
using IDA;

namespace DA
{
    public class RegisterDA : IRegisterDA
    {
        private string CS = ConfigurationManager.AppSettings["Sql"];
        public bool validateUserName(string _firstname, string _lastname, string _username, string _password, string _email)
        {

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spRegisterUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter firstname = new SqlParameter("@FirstName", _firstname);
                SqlParameter lastname = new SqlParameter("@LastName", _lastname);
                SqlParameter username = new SqlParameter("@UserName", _username);               
                string encryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(_password, "SHA1");
                SqlParameter password = new SqlParameter("@Password", encryptedPassword);
                SqlParameter email = new SqlParameter("@Email", _email);
                cmd.Parameters.Add(firstname);
                cmd.Parameters.Add(lastname);
                cmd.Parameters.Add(username);
                cmd.Parameters.Add(password);
                cmd.Parameters.Add(email);
                con.Open();
                int ReturnCode = (int)cmd.ExecuteScalar();
                if (ReturnCode == -1)
                {                    
                    return false;
                }
                else
                {                    
                    return true;
                }
            }
        }
    }
}
