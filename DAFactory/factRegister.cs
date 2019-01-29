using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using IDA;

namespace DAFactory
{
    public static class factRegister
    {
        public static dynamic CreateRegisterDA()
        {
            return new RegisterDA();
        }
    }
}
