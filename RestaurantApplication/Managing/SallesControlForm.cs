using CodeLibrary.FilesAccess;
using CodeLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApplication
{
    public partial class SallesControlForm : Form
    {
        private List<IProduct> soldProducts = new List<IProduct>();

        public SallesControlForm()
        {
            InitializeComponent();

            try
            {
                soldProducts = ReadWriteFiles.ReadSoldProductsFromFile().OrderByDescending(x => x.Ammount).ToList();
            }
            catch (FormatException)
            {
                ReadWriteFiles.DeleteSoldProductsFile();
                MessageBox.Show("An error ocurred while loading the sold products list. The list was reset.", "Internal Error");
            }

            soldProductsListBox.DataSource = null;
            soldProductsListBox.DataSource = soldProducts;
            soldProductsListBox.DisplayMember = "DisplayText3";

            totalTextBox.Text = soldProducts.Sum(x => x.Price).ToString();
        }

        private void quitSallesControlButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeTheDayButton_Click(object sender, EventArgs e)
        {
            List<IUsedTable> usedTables = new List<IUsedTable>();
            try
            {
                ReadWriteFiles.ReadProductsOnTableFromFile(usedTables);
            }
            catch (FormatException)
            {
                usedTables = null;
                ReadWriteFiles.DeleteProductsOnTableFile();
                MessageBox.Show("An error ocurred when checking if there are still occupied tables. All occupied tables were reset.", "Internal Error");
            }

            if (soldProducts.Count > 0)
            {
                if (usedTables.Count == 0)
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to close the day and generate the data files?",
                                "Close the day", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        DateTime time = DateTime.Now;

                        string day = time.ToString("dd-MM-yyyy");
                        string hours = time.ToString("HH:mm");

                        decimal money = soldProducts.Sum(x => x.Price);

                        ReadWriteFiles.WriteInDailyIncomeFile(day, hours, money);
                        ReadWriteFiles.AddFileOfTodaySoldProducts(soldProducts, time);
                        ReadWriteFiles.DeleteSoldProductsFile();

                        soldProductsListBox.DataSource = null;
                        totalTextBox.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("You still have occupied tables on the system. Please do the payments or remove the items.", "Occupied tables");
                } 
            }
            else
            {
                MessageBox.Show("You haven't sold any product so far.", "Empty List");
            }
        }

        private void moneyIncomeButton_Click(object sender, EventArgs e)
        {
            bool fileExist = false;

            fileExist = File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\DailyIncome.csv");

            if (fileExist)
            {
                System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + @"\DailyIncome.csv");
            }
        }

        private void productsSoldButton_Click(object sender, EventArgs e)
        {
            bool folderExist = false;

            folderExist = Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Products Sold List");

            if (folderExist)
            {
                Process.Start(AppDomain.CurrentDomain.BaseDirectory + @"\Products Sold List"); 
            }
        }
    }
}
