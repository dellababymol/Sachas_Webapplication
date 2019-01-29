using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Factory;
using IExceptionLibrary;
using IDA;
using DAFactory;

namespace BO
{
    public class LoginBO
    {
        private IEx obj = clsFactory.createException(Convert.ToInt16(ConfigurationManager.AppSettings["Exceptionkey"]));
        private ILoginDA objloginDA = factLogin.CreateLoginDA();


        public bool AuthenticateExitingUser(string _username, string _password)
        {
            try
            {

                return objloginDA.AuthenticateUser(_username, _password);
            }
            catch (Exception ex)
            {
                obj.LogError(ex);
                throw;
            }
        }

    }
}
