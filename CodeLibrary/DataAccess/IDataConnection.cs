using CodeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLibrary.DataAccess
{
    public interface IDataConnection
    {
        void AddNewCategory(ICategory category);
        void AddNewProduct(IProduct product);
        List<ICategory> ReadAllCategories();
        List<IProduct> ReadAllProducts();
        List<IProduct> ReadProductByCategory(ICategory category);
        void DeleteProduct(IProduct product);
        void DeleteCategoryAndAllItsProducts(ICategory category);

        void AddNewAreaOfTables (IAreaOfTables area);
        void AddNewTables(List<ITable> tables);
        List<ITable> ReadAllTables();
        List<IAreaOfTables> ReadAllAreas();
        List<ITable> ReadTablesByArea(IAreaOfTables area);
        void DeleteTable(ITable table);
        void DeleteAreaAndAllItsTables(IAreaOfTables area);
        
    }
}
