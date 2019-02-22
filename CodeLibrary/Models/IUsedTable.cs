using System.Collections.Generic;

namespace CodeLibrary.Models
{
    public interface IUsedTable :ITable
    {
        List<IProduct> Products { get; set; }
    }
}