using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLibrary.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public decimal Price { get; set; }

        public string Detail { get; set; }

        public int Ammount { get; set; } = 1;

        public string DisplayText {
            get
            {
                return $"{Name}: {Price:C}   {Detail}";
            }
        }

        public string DisplayText2
        {
            get
            {
                return $"{Name}: {Price:C}   Category: {Category.Name}";
            }
        }

        public string DisplayText3
        {
            get
            {
                return $"{Ammount} » {Name}: {Price:C}";
            }
        }
    }
}
