using CodeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace CodeLibrary.DataAccess
{
    public class SQLServerDataAccess : IDataConnection
    {
        public void AddNewAreaOfTables(AreaOfTables area)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string insertArea = "INSERT INTO [dbo].[Areas] ([AreaName]) VALUES (@AreaName)";
                db.Execute(insertArea, area);
            }
        }

        public void AddNewCategory(Category category)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string insertCategory = "INSERT INTO [dbo].[Categories] ([Name]) VALUES (@Name)";
                db.Execute(insertCategory, category);
            }
        }

        public void AddNewProduct(Product product)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string insertProduct = "INSERT INTO [dbo].[Products] ([Name], [Price], [CategoryId]) VALUES (@Name, @Price, @CategoryId)";
                db.Execute(insertProduct, product);
            }
        }

        public void AddNewTables(List<Table> tables)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string insertTable = "INSERT INTO [dbo].[Tables] ([NumberOfTable], [AreaId]) VALUES (@NumberOfTable, @AreaId)";

                foreach (Table table in tables)
                {
                    db.Execute(insertTable, table);
                }
            }
        }

        public void DeleteAreaAndAllItsTables(AreaOfTables area)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string deleteArea = "DELETE FROM [dbo].[Areas] Where [id] = @areaID";
                string deleteTables = "DELETE FROM [dbo].[Tables] Where [AreaId] = @areaId";

                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@areaId", area.Id);

                db.Execute(deleteTables, parameter);
                db.Execute(deleteArea, parameter);
            }
        }

        public void DeleteCategoryAndAllItsProducts(Category category)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string deleteCategory = "DELETE FROM [dbo].[Categories] Where [id] = @categoryID";
                string deleteProducts = "DELETE FROM [dbo].[Products] Where [CategoryId] = @categoryID";

                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@categoryID", category.Id);

                db.Execute(deleteProducts, parameter);
                db.Execute(deleteCategory, parameter);
            }
        }

        public void DeleteProduct(Product product)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string deleteProduct = "DELETE FROM [dbo].[Products] Where [id] = @productID";
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@productID", product.Id);
                db.Execute(deleteProduct, parameter);
            }
        }

        public void DeleteTable(Table table)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string deleteTable = "DELETE FROM [dbo].[tables] Where [id] = @tableID";
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@tableID", table.Id);
                db.Execute(deleteTable, parameter);
            }
        }

        public List<AreaOfTables> ReadAllAreas()
        {
            List<AreaOfTables> list = new List<AreaOfTables>();

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string readAreas = "SELECT * FROM [dbo].[Areas]";
                list = db.Query<AreaOfTables>(readAreas).ToList();
            }

            return list;
        }

        public List<Category> ReadAllCategories()
        {
            List<Category> list = new List<Category>();

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string readCategories = "SELECT * FROM [dbo].[Categories]";
                list = db.Query<Category>(readCategories).ToList();  
            }

            return list;
        }

        public List<Product> ReadAllProducts()
        {
            List<Product> listP = new List<Product>();

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string readProducts = "SELECT * FROM [dbo].[Products];";
                string readCategories = "SELECT * FROM [dbo].[Categories] Where [id] = @CategoryID";
                DynamicParameters parameter = new DynamicParameters();

                listP = db.Query<Product>(readProducts).ToList();

                foreach (Product p in listP)
                {
                    parameter.Add("@CategoryId", p.CategoryId);
                    p.Category = db.Query<Category>(readCategories, parameter).FirstOrDefault();
                }
            }

            return listP;
        }

        public List<Table> ReadAllTables()
        {
            List<Table> listT = new List<Table>();

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string readTables = "SELECT * FROM [dbo].[Tables];";
                string readAreas = "SELECT * FROM [dbo].[Areas] Where [id] = @AreaId";
                DynamicParameters parameter = new DynamicParameters();

                listT = db.Query<Table>(readTables).ToList();

                foreach (Table t in listT)
                {
                    parameter.Add("@AreaId", t.AreaId);
                    t.Area = db.Query<AreaOfTables>(readAreas, parameter).FirstOrDefault();
                }
            }

            return listT;
        }

        public List<Product> ReadProductByCategory(Category category)
        {
            List<Product> list = new List<Product>();

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string readProducts = "SELECT * FROM [dbo].[Products] Where [CategoryId] = @idCategory";
                DynamicParameters parameter = new DynamicParameters();

                parameter.Add("@idCategory", category.Id);
                list = db.Query<Product>(readProducts, parameter).ToList();

                foreach (Product p in list)
                {
                    p.Category = category;
                }
            }

            return list;
        }

        public List<Table> ReadTablesByArea(AreaOfTables area)
        {
            List<Table> list = new List<Table>();

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string readTables = "SELECT * FROM [dbo].[Tables] Where [AreaId] = @idArea";
                DynamicParameters parameter = new DynamicParameters();

                parameter.Add("@idArea", area.Id);
                list = db.Query<Table>(readTables, parameter).ToList();

                foreach (Table p in list)
                {
                    p.Area = area;
                }
            }
            return list;
        }
    }
}
