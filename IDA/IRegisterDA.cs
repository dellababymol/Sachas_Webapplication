using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA
{
    public interface IRegisterDA
    {
        bool validateUserName(string _firstname, string _lastname, string _username, string _password, string _email);

    }
}
