using CodeLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLibrary.FilesAccess
{
    public static class ReadWriteFiles
    {
        public static List<Product> ReadSoldProductsFromFile()
        {
            bool fileExist = false;
            List<Product> soldProducts = new List<Product>();

            fileExist = File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\ProductsSold.txt");

            if (fileExist)
            {
                string text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\ProductsSold.txt", Encoding.UTF8);
                string[] lines = text.Split('\n');

                for (int i = 0; i < lines.Length - 1; i++)
                {
                    Product addingProduct = new Product();
                    Category addingCategory = new Category();

                    string[] elements = lines[i].Split('|');

                    addingProduct.Ammount = int.Parse(elements[0]);
                    addingProduct.Name = elements[1];
                    addingCategory.Name = elements[2];
                    addingProduct.Price = decimal.Parse(elements[3]);

                    addingProduct.Category = addingCategory;

                    soldProducts.Add(addingProduct);
                }
            }
            return soldProducts;
        }

        public static void DeleteSoldProductsFile()
        {
            bool fileExist = false;

            fileExist = File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\ProductsSold.txt");

            if (fileExist)
            {
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\ProductsSold.txt");
            }
        }

        public static void DeleteProductsOnTableFile()
        {
            bool fileExist = false;

            fileExist = File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\ProductsOnTables.txt");

            if (fileExist)
            {
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\ProductsOnTables.txt");
            }
        }

        public static void WriteInDailyIncomeFile(string day, string hours, decimal money)
        {
            bool fileExist = false;
            StringBuilder sb = new StringBuilder();
            string separator = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;

            fileExist = File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\DailyIncome.csv");

            if (fileExist)
            {
                string text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\DailyIncome.csv", Encoding.UTF8);

                sb.Append(text);
            }
            else
            {
                sb.Append("Day");
                sb.Append(separator);
                sb.Append("Time");
                sb.Append(separator);
                sb.Append("Income");
                sb.AppendLine();
            }

            sb.Append(day);
            sb.Append(separator);
            sb.Append(hours);
            sb.Append(separator);
            sb.Append(money);
            sb.Append(' ');
            sb.Append('€');
            sb.AppendLine();

            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\DailyIncome.csv", sb.ToString(), Encoding.UTF8);
        }

        public static void WriteSoldProductsToFile(List<Product> soldProducts)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Product p in soldProducts)
            {
                if (p.Name != "***null***")
                {
                    int ammount = soldProducts.FindAll(x => x.Name == p.Name).Sum(x => x.Ammount);
                    string name = p.Name;
                    decimal totalPrice = 0;

                    totalPrice = soldProducts.FindAll(x => x.Name == p.Name).Sum(x => x.Price);

                    sb.Append(ammount);
                    sb.Append('|');
                    sb.Append(p.Name);
                    sb.Append('|');
                    sb.Append(p.Category.Name);
                    sb.Append('|');
                    sb.Append(totalPrice);
                    sb.AppendLine();

                    while (soldProducts.Where(x => x.Name == name).FirstOrDefault() != null)
                    {
                        soldProducts.Where(x => x.Name == name).FirstOrDefault().Name = "***null***";
                    }
                }
            }

            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\ProductsSold.txt", sb.ToString());
        }

        public static void WriteProductsOnTableToFile(List<UsedTable> tablesInUse)
        {
            StringBuilder sb = new StringBuilder();

            foreach (UsedTable t in tablesInUse)
            {
                if (t.Products.Count > 0)
                {
                    sb.Append(t.table.Id);
                    sb.Append("^");
                    sb.Append(t.table.NumberOfTable);
                    sb.Append("^");
                    sb.Append(t.table.Area.AreaName);
                    sb.Append("^");
                    sb.Append(t.table.AreaId);
                    sb.Append("^");
                    sb.Append(t.table.ShowOccupied);
                    sb.Append("|");

                    foreach (Product p in t.Products)
                    {
                        sb.Append(p.Id);
                        sb.Append("^");
                        sb.Append(p.Name);
                        sb.Append("^");
                        sb.Append(p.Category.Name);
                        sb.Append("^");
                        sb.Append(p.CategoryId);
                        sb.Append("^");
                        sb.Append(p.Price);
                        sb.Append("^");
                        sb.Append(p.Detail);
                        sb.Append("|");
                    }
                    sb.AppendLine(); 
                }
            }

            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\ProductsOnTables.txt", sb.ToString());

        }

        public static void ReadProductsOnTableFromFile(List<UsedTable> tablesInUse)
        {
            bool fileExist = false;

            fileExist = File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\ProductsOnTables.txt");

            if (fileExist)
            {
                string text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\ProductsOnTables.txt", Encoding.UTF8);

                string[] lines = text.Split('\n');

                for (int i = 0; i < lines.Length - 1; i++)
                {
                    Table addingTable = new Table();
                    AreaOfTables addingArea = new AreaOfTables();
                    UsedTable addingFullTable = new UsedTable();

                    string[] groups = lines[i].Split('|');

                    string[] elements = groups[0].Split('^');

                    addingTable.Id = int.Parse(elements[0]);
                    addingTable.NumberOfTable = int.Parse(elements[1]);
                    addingArea.AreaName = elements[2];
                    addingArea.Id = int.Parse(elements[3]);
                    addingTable.AreaId = int.Parse(elements[3]);
                    addingTable.ShowOccupied = elements[4];

                    addingTable.Area = addingArea;
                    addingFullTable.table = addingTable;

                    for (int j = 1; j < groups.Length - 1; j++)
                    {
                        Product addingProduct = new Product();
                        Category addingCategory = new Category();

                        elements = groups[j].Split('^');

                        addingProduct.Id = int.Parse(elements[0]);
                        addingProduct.Name = elements[1];
                        addingCategory.Name = elements[2];
                        addingCategory.Id = int.Parse(elements[3]);
                        addingProduct.CategoryId = int.Parse(elements[3]);
                        addingProduct.Price = decimal.Parse(elements[4]);
                        addingProduct.Detail = elements[5];

                        addingProduct.Category = addingCategory;
                        addingFullTable.Products.Add(addingProduct);
                    }

                    tablesInUse.Add(addingFullTable);
                }
            }
        }

        public static void AddFileOfTodaySoldProducts(List<Product> soldProducts, DateTime time)
        {
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Products Sold List");

            StringBuilder sb = new StringBuilder();
            decimal totalPriceAll = 0;

            string day = time.ToString("yyyy-MM-dd");
            string hours = time.ToString("HH-mm");
            string fileName = day + " # " + hours + ".csv";

            sb.Append("Ammount");
            sb.Append(';');
            sb.Append("Name");
            sb.Append(';');
            sb.Append("Category");
            sb.Append(';');
            sb.Append("money");
            sb.AppendLine();
            sb.AppendLine();

            foreach (Product p in soldProducts)
            {
                if (p.Name != "***null***")
                {
                    int ammount = soldProducts.FindAll(x => x.Name == p.Name).Sum(x => x.Ammount);
                    string name = p.Name;
                    decimal totalPrice = 0;

                    totalPrice = soldProducts.FindAll(x => x.Name == p.Name).Sum(x => x.Price);
                    totalPriceAll += totalPrice;

                    sb.Append(ammount);
                    sb.Append(';');
                    sb.Append(p.Name);
                    sb.Append(';');
                    sb.Append(p.Category.Name);
                    sb.Append(';');
                    sb.Append(totalPrice);
                    sb.Append(" €");
                    sb.AppendLine();

                    while (soldProducts.Where(x => x.Name == name).FirstOrDefault() != null)
                    {
                        soldProducts.Where(x => x.Name == name).FirstOrDefault().Name = "***null***";
                    }
                }
            }

            sb.AppendLine();
            sb.Append("Total");
            sb.Append(";;;");
            sb.Append(totalPriceAll);
            sb.Append(" €");
            sb.AppendLine();

            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Products Sold List\" + fileName, sb.ToString(), Encoding.UTF8);
        }
    }
}
