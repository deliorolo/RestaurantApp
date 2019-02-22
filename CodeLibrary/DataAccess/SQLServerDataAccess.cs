﻿using CodeLibrary.Models;
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
        public void AddNewAreaOfTables(IAreaOfTables area)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string insertArea = "INSERT INTO [dbo].[Areas] ([AreaName]) VALUES (@AreaName)";
                db.Execute(insertArea, area);
            }
        }

        public void AddNewCategory(ICategory category)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string insertCategory = "INSERT INTO [dbo].[Categories] ([Name]) VALUES (@Name)";
                db.Execute(insertCategory, category);
            }
        }

        public void AddNewProduct(IProduct product)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string insertProduct = "INSERT INTO [dbo].[Products] ([Name], [Price], [CategoryId]) VALUES (@Name, @Price, @CategoryId)";
                db.Execute(insertProduct, product);
            }
        }

        public void AddNewTables(List<ITable> tables)
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

        public void DeleteAreaAndAllItsTables(IAreaOfTables area)
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

        public void DeleteCategoryAndAllItsProducts(ICategory category)
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

        public void DeleteProduct(IProduct product)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string deleteProduct = "DELETE FROM [dbo].[Products] Where [id] = @productID";
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@productID", product.Id);
                db.Execute(deleteProduct, parameter);
            }
        }

        public void DeleteTable(ITable table)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string deleteTable = "DELETE FROM [dbo].[tables] Where [id] = @tableID";
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@tableID", table.Id);
                db.Execute(deleteTable, parameter);
            }
        }

        public List<IAreaOfTables> ReadAllAreas()
        {
            IEnumerable<IAreaOfTables> list = new List<IAreaOfTables>();
            List<IAreaOfTables> output = new List<IAreaOfTables>();

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string readAreas = "SELECT * FROM [dbo].[Areas]";
                list = db.Query<AreaOfTables>(readAreas).ToList();
            }

            foreach (IAreaOfTables area in list)
            {
                output.Add(area);
            }

            return output;
        }

        public List<ICategory> ReadAllCategories()
        {
            IEnumerable<ICategory> list = new List<ICategory>();
            List<ICategory> output = new List<ICategory>();

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string readCategories = "SELECT * FROM [dbo].[Categories]";
                list = db.Query<Category>(readCategories).ToList();  
            }

            foreach (ICategory category in list)
            {
                output.Add(category);
            }

            return output;
        }

        public List<IProduct> ReadAllProducts()
        {
            IEnumerable<IProduct> list = new List<IProduct>();
            List<IProduct> output = new List<IProduct>();

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string readProducts = "SELECT * FROM [dbo].[Products];";
                string readCategories = "SELECT * FROM [dbo].[Categories] Where [id] = @CategoryID";
                DynamicParameters parameter = new DynamicParameters();

                list = db.Query<Product>(readProducts).ToList();

                foreach (Product p in list)
                {
                    parameter.Add("@CategoryId", p.CategoryId);
                    p.Category = db.Query<Category>(readCategories, parameter).FirstOrDefault();
                }
            }

            foreach (IProduct product in list)
            {
                output.Add(product);
            }

            return output;
        }

        public List<ITable> ReadAllTables()
        {
            IEnumerable<ITable> list = new List<ITable>();
            List<ITable> output = new List<ITable>();

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string readTables = "SELECT * FROM [dbo].[Tables];";
                string readAreas = "SELECT * FROM [dbo].[Areas] Where [id] = @AreaId";
                DynamicParameters parameter = new DynamicParameters();

                list = db.Query<Table>(readTables).ToList();

                foreach (Table t in list)
                {
                    parameter.Add("@AreaId", t.AreaId);
                    t.Area = db.Query<AreaOfTables>(readAreas, parameter).FirstOrDefault();
                }
            }

            foreach (ITable table in list)
            {
                output.Add(table);
            }

            return output;
        }

        public List<IProduct> ReadProductByCategory(ICategory category)
        {
            IEnumerable<IProduct> list = new List<IProduct>();
            List<IProduct> output = new List<IProduct>();

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string readProducts = "SELECT * FROM [dbo].[Products] Where [CategoryId] = @idCategory";
                DynamicParameters parameter = new DynamicParameters();

                parameter.Add("@idCategory", category.Id);
                list = db.Query<Product>(readProducts, parameter).ToList();  
            }
            foreach (Product p in list)
            {
                p.Category = category;
            }

            foreach (IProduct product in list)
            {
                output.Add(product);
            }

            return output;
        }

        public List<ITable> ReadTablesByArea(IAreaOfTables area)
        {
            List<ITable> output = new List<ITable>();
            IEnumerable<ITable> list = new List<ITable>();

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
            {
                string readTables = "SELECT * FROM [dbo].[Tables] Where [AreaId] = @idArea";
                DynamicParameters parameter = new DynamicParameters();

                parameter.Add("@idArea", area.Id);
                list = db.Query<Table>(readTables, parameter).ToList();
            }

            foreach (Table p in list)
            {
                p.Area = area;
            }

            foreach (ITable table in list)
            {
                output.Add(table);
            }

            return output;
        }
    }
}
