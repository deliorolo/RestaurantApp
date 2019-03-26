using CodeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLibrary
{
    public static class Factory
    {
        public static ITable InstanceTable()
        {
            return new Table();
        }

        public static IProduct InstanceProduct()
        {
            return new Product();
        }

        public static IAreaOfTables InstanceAreaOfTables()
        {
            return new AreaOfTables();
        }

        public static ICategory InstanceCategory()
        {
            return new Category();
        }

        public static IUsedTable InstanceUsedTable()
        {
            return new UsedTable();
        }

        public static List<ITable> InstanceListTable()
        {
            return new List<ITable>();
        }

        public static List<IProduct> InstanceListProduct()
        {
            return new List<IProduct>();
        }

        public static List<IUsedTable> InstanceListUsedTable()
        {
            return new List<IUsedTable>();
        }

        public static List<ICategory> InstanceListCategory()
        {
            return new List<ICategory>();
        }

        public static List<IAreaOfTables> InstanceListAreaOfTables()
        {
            return new List<IAreaOfTables>();
        }

    }
}
