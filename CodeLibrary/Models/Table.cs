using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLibrary.Models
{
    public class Table
    {
        public int Id { get; set; }

        public int NumberOfTable { get; set; }

        public AreaOfTables Area { get; set; }

        public int AreaId { get; set; }

        public string ShowOccupied { get; set; }

        public string ShowText
        {
            get
            {
                return $"{NumberOfTable}                                             {ShowOccupied}";
            }
        }

        public string DisplayText {
            get
            {
                return $"{NumberOfTable} : {Area.AreaName}";
            }
        }
    }
}
