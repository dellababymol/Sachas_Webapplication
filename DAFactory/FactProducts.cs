using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using IDA;

namespace DAFactory
{
  public  class FactProducts
    {
        public static dynamic CreateProductDA()
        {
            return new ProductsDA();
        }
    }
}
