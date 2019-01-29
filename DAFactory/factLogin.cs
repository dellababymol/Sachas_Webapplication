using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using IDA;

namespace DAFactory
{
    public static class factLogin
    {
        public static dynamic CreateLoginDA()
        {
            return new LoginDA();
        }
    }
}
