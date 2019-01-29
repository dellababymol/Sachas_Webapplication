using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IDA
{
    public interface IProductsDA
    {
        DataTable GetDataItems();
        DataTable GetDatatable(String ProductID);
    }
}
