using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IExceptionLibrary;
using ExceptionLibrary;


namespace Factory
{
    public class clsFactory
    {
        public static IEx createException(int i)
        {
            if (i == 0)
            {
                return new FileException();
            }
            else
            {
                return new FileException();
            }
        }
    }
}
