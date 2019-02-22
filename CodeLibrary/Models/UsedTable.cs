using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLibrary.Models
{
    public class UsedTable :Table,IUsedTable
    {
        public List<IProduct> Products { get; set; }

        public UsedTable()
        {
            Products = new List<IProduct>();
        }
    }
}
