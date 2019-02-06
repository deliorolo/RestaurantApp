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
        void AddNewCategory(Category category);
        void AddNewProduct(Product product);
        List<Category> ReadAllCategories();
        List<Product> ReadAllProducts();
        List<Product> ReadProductByCategory(Category category);
        void DeleteProduct(Product product);
        void DeleteCategoryAndAllItsProducts(Category category);

        void AddNewAreaOfTables (AreaOfTables area);
        void AddNewTables(List<Table> tables);
        List<Table> ReadAllTables();
        List<AreaOfTables> ReadAllAreas();
        List<Table> ReadTablesByArea(AreaOfTables area);
        void DeleteTable(Table table);
        void DeleteAreaAndAllItsTables(AreaOfTables area);
        
    }
}
