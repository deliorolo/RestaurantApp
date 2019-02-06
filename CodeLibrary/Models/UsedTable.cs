using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLibrary.Models
{
    public class UsedTable
    {
        public Table table { get; set; }

        public List<Product> Products { get; set; }

        public UsedTable()
        {
            Products = new List<Product>();
        }
    }
}
