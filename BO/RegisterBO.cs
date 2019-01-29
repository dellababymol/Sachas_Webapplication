using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDA;
using DAFactory;
using System.Configuration;
using Factory;
using IExceptionLibrary;

namespace BO
{
    public class RegisterBO
    {
        private IEx obj = clsFactory.createException(Convert.ToInt16(ConfigurationManager.AppSettings["Exceptionkey"]));
        private IRegisterDA objregisterDA = factRegister.CreateRegisterDA();
        public bool validateBOUserName(string _firstname, string _lastname, string _username, string _password, string _email)
        {
            try
            {
                return objregisterDA.validateUserName(_firstname, _lastname, _username, _password, _email);
            }
            catch (Exception ex)
            {
                obj.LogError(ex);
                throw;
            }
        }
    }
}
