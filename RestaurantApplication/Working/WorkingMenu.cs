using CodeLibrary.DataAccess;
using CodeLibrary.FilesAccess;
using CodeLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApplication
{
    public partial class WorkingMenu : Form, IPayTotal, IPayPartial, ICustomizeForm
    {
        List<ICategory> categories = new List<ICategory>();
        List<IAreaOfTables> areas = new List<IAreaOfTables>();
        List<IUsedTable> tablesInUse = new List<IUsedTable>();
        List<ITable> tables = new List<ITable>();
        List<IProduct> soldProducts = new List<IProduct>();
        ITable selectedTable = new Table();

        private PayTotal newFormPayTotal = null;
        private PayPartial newFormPayPartial = null;
        private CustomizeForm newFormCustomize = null;

        int pageCategories = 1;

        public WorkingMenu()
        {
            InitializeComponent();

            tablesListBox.Visible = false;
            productsListBox.Visible = false;

            SetAreasMenu();
            SetCategoriesMenu(pageCategories);

            try
            {
                ReadWriteFiles.ReadProductsOnTableFromFile(tablesInUse);
            }
            catch (FormatException)
            {
                ReadWriteFiles.DeleteProductsOnTableFile();
                MessageBox.Show("An error ocurred when checking occupied tables. All occupied tables were reset.", "Internal Error");
            }

            try
            {
                soldProducts = ReadWriteFiles.ReadSoldProductsFromFile();
            }
            catch (FormatException)
            {
                ReadWriteFiles.DeleteSoldProductsFile();
                MessageBox.Show("An error ocurred when loading the sold products list. The list was reset.", "Internal Error");
            }
        }

        private void SetAreasMenu()
        {
            int amount = 0;

            areas = GlobalConfig.connection.ReadAllAreas();
            amount = areas.Count;

            HideAllAreasButtons();

            if (amount == 0) goto EndButtons;
            areaTablebutton1.Text = areas[0].AreaName;
            areaTablebutton1.Visible = true;

            if (amount == 1) goto EndButtons;
            areaTablebutton2.Text = areas[1].AreaName;
            areaTablebutton2.Visible = true;

            if (amount == 2) goto EndButtons;
            areaTablebutton3.Text = areas[2].AreaName;
            areaTablebutton3.Visible = true;

            if (amount == 3) goto EndButtons;
            areaTablebutton4.Text = areas[3].AreaName;
            areaTablebutton4.Visible = true;

            if (amount == 4) goto EndButtons;
            areaTablebutton5.Text = areas[4].AreaName;
            areaTablebutton5.Visible = true;

            if (amount == 5) goto EndButtons;
            areaTablebutton6.Text = areas[5].AreaName;
            areaTablebutton6.Visible = true;

            if (amount == 6) goto EndButtons;
            areaTablebutton7.Text = areas[6].AreaName;
            areaTablebutton7.Visible = true;

            if (amount == 7) goto EndButtons;
            areaTablebutton8.Text = areas[7].AreaName;
            areaTablebutton8.Visible = true;

            if (amount == 8) goto EndButtons;
            areaTablebutton9.Text = areas[8].AreaName;
            areaTablebutton9.Visible = true;

            if (amount == 9) goto EndButtons;
            areaTablebutton10.Text = areas[9].AreaName;
            areaTablebutton10.Visible = true;

        EndButtons:
            returnButton.Enabled = false;
            payAllButton.Enabled = false;
            payPartialButton.Enabled = false;
            removeItemButton.Enabled = false;
        }

        private void SetCategoriesMenu(int page)
        {
            int amount = 0;
            int amountAux = 0;
            int pageAux = (page * 10) - 10;

            categories = GlobalConfig.connection.ReadAllCategories();
            amount = categories.Count;

            HideAllCategoryButtons();

            if ((page * 10) >= amount)
            {
                amountAux = amount % 10;
                nextButton.Enabled = false;
            }
            else
            {
                nextButton.Enabled = true;
            }

            if (page == 1)
            {
                backButton.Enabled = false;
            }
            else
            {
                backButton.Enabled = true;
            }

            if (amount == 0) goto EndButtons;
            categoryButton1.Text = categories[pageAux].Name;
            categoryButton1.Visible = true;

            if (amountAux == 1) goto EndButtons;
            categoryButton2.Text = categories[pageAux + 1].Name;
            categoryButton2.Visible = true;

            if (amountAux == 2) goto EndButtons;
            categoryButton3.Text = categories[pageAux + 2].Name;
            categoryButton3.Visible = true;

            if (amountAux == 3) goto EndButtons;
            categoryButton4.Text = categories[pageAux + 3].Name;
            categoryButton4.Visible = true;

            if (amountAux == 4) goto EndButtons;
            categoryButton5.Text = categories[pageAux + 4].Name;
            categoryButton5.Visible = true;

            if (amountAux == 5) goto EndButtons;
            categoryButton6.Text = categories[pageAux + 5].Name;
            categoryButton6.Visible = true;

            if (amountAux == 6) goto EndButtons;
            categoryButton7.Text = categories[pageAux + 6].Name;
            categoryButton7.Visible = true;

            if (amountAux == 7) goto EndButtons;
            categoryButton8.Text = categories[pageAux + 7].Name;
            categoryButton8.Visible = true;

            if (amountAux == 8) goto EndButtons;
            categoryButton9.Text = categories[pageAux + 8].Name;
            categoryButton9.Visible = true;

            if (amountAux == 9) goto EndButtons;
            categoryButton10.Text = categories[pageAux + 9].Name;
            categoryButton10.Visible = true;

        EndButtons:
            addButton.Enabled = false;
            customizeButton.Enabled = false;
        }

        private void HideAllAreasButtons()
        {
            areaTablebutton1.Visible = false;
            areaTablebutton2.Visible = false;
            areaTablebutton3.Visible = false;
            areaTablebutton4.Visible = false;
            areaTablebutton5.Visible = false;
            areaTablebutton6.Visible = false;
            areaTablebutton7.Visible = false;
            areaTablebutton8.Visible = false;
            areaTablebutton9.Visible = false;
            areaTablebutton10.Visible = false;

            returnButton.Enabled = true;
        }

        private void HideAllCategoryButtons()
        {
            categoryButton1.Visible = false;
            categoryButton2.Visible = false;
            categoryButton3.Visible = false;
            categoryButton4.Visible = false;
            categoryButton5.Visible = false;
            categoryButton6.Visible = false;
            categoryButton7.Visible = false;
            categoryButton8.Visible = false;
            categoryButton9.Visible = false;
            categoryButton10.Visible = false;

            backButton.Enabled = true;
            nextButton.Enabled = false;
        }

        private void DisplayTablesInList()
        {
            tablesListBox.DataSource = null;
            tablesListBox.DataSource = tables;
            tablesListBox.DisplayMember = "ShowText";
            tablesListBox.Visible = true;
        }

        private void DisplayProductsInList(List<IProduct> products)
        {
            productsListBox.DataSource = null;
            productsListBox.DataSource = products;
            productsListBox.DisplayMember = "DisplayText";
            productsListBox.Visible = true;

            if (tablesListBox.DataSource is List<IProduct> && productsListBox.Items.Count > 0 && tablesListBox.Visible == true)
            {
                addButton.Enabled = true;
                customizeButton.Enabled = true;
            }
        }

        private void ShowIfTablesAreOccupied(List<ITable> tables)
        {
            foreach (UsedTable t in tablesInUse)
            {
                if (t.ShowOccupied.Length > 0 && tables.Where(x => x.NumberOfTable == t.NumberOfTable).FirstOrDefault() != null)
                {
                    (tables.Where(x => x.NumberOfTable == t.NumberOfTable).FirstOrDefault()).ShowOccupied = "Occupied";
                }
            }
        }

        private void areaTablebutton1_Click(object sender, EventArgs e)
        {
            HideAllAreasButtons();

            tables = GlobalConfig.connection.ReadTablesByArea(areas[0]);

            ShowIfTablesAreOccupied(tables);

            DisplayTablesInList();
        }

        private void areaTablebutton2_Click(object sender, EventArgs e)
        {
            HideAllAreasButtons();

            tables = GlobalConfig.connection.ReadTablesByArea(areas[1]);

            ShowIfTablesAreOccupied(tables);

            DisplayTablesInList();
        }

        private void areaTablebutton3_Click(object sender, EventArgs e)
        {
            HideAllAreasButtons();

            tables = GlobalConfig.connection.ReadTablesByArea(areas[2]);

            ShowIfTablesAreOccupied(tables);

            DisplayTablesInList();
        }

        private void areaTablebutton4_Click(object sender, EventArgs e)
        {
            HideAllAreasButtons();

            tables = GlobalConfig.connection.ReadTablesByArea(areas[3]);

            ShowIfTablesAreOccupied(tables);

            DisplayTablesInList();
        }

        private void areaTablebutton5_Click(object sender, EventArgs e)
        {
            HideAllAreasButtons();

            tables = GlobalConfig.connection.ReadTablesByArea(areas[4]);

            ShowIfTablesAreOccupied(tables);

            DisplayTablesInList();
        }

        private void areaTablebutton6_Click(object sender, EventArgs e)
        {
            HideAllAreasButtons();

            tables = GlobalConfig.connection.ReadTablesByArea(areas[5]);

            ShowIfTablesAreOccupied(tables);

            DisplayTablesInList();
        }

        private void areaTablebutton7_Click(object sender, EventArgs e)
        {
            HideAllAreasButtons();

            tables = GlobalConfig.connection.ReadTablesByArea(areas[6]);

            ShowIfTablesAreOccupied(tables);

            DisplayTablesInList();
        }

        private void areaTablebutton8_Click(object sender, EventArgs e)
        {
            HideAllAreasButtons();

            tables = GlobalConfig.connection.ReadTablesByArea(areas[7]);

            ShowIfTablesAreOccupied(tables);

            DisplayTablesInList();
        }

        private void areaTablebutton9_Click(object sender, EventArgs e)
        {
            HideAllAreasButtons();

            tables = GlobalConfig.connection.ReadTablesByArea(areas[8]);

            ShowIfTablesAreOccupied(tables);

            DisplayTablesInList();
        }

        private void areaTablebutton10_Click(object sender, EventArgs e)
        {
            HideAllAreasButtons();

            tables = GlobalConfig.connection.ReadTablesByArea(areas[9]);

            ShowIfTablesAreOccupied(tables);

            DisplayTablesInList();
        }

        private void categoryButton1_Click(object sender, EventArgs e)
        {
            HideAllCategoryButtons();

            List<IProduct> products = new List<IProduct>();

            products = GlobalConfig.connection.ReadProductByCategory(categories[(pageCategories*10-10)]);

            DisplayProductsInList(products);
        }

        private void categoryButton2_Click(object sender, EventArgs e)
        {
            HideAllCategoryButtons();

            List<IProduct> products = new List<IProduct>();

            products = GlobalConfig.connection.ReadProductByCategory(categories[(pageCategories * 10 - 10)+1]);

            DisplayProductsInList(products);
        }

        private void categoryButton3_Click(object sender, EventArgs e)
        {
            HideAllCategoryButtons();

            List<IProduct> products = new List<IProduct>();

            products = GlobalConfig.connection.ReadProductByCategory(categories[(pageCategories * 10 - 10) + 2]);

            DisplayProductsInList(products);
        }

        private void categoryButton4_Click(object sender, EventArgs e)
        {
            HideAllCategoryButtons();

            List<IProduct> products = new List<IProduct>();

            products = GlobalConfig.connection.ReadProductByCategory(categories[(pageCategories * 10 - 10) + 3]);

            DisplayProductsInList(products);
        }

        private void categoryButton5_Click(object sender, EventArgs e)
        {
            HideAllCategoryButtons();

            List<IProduct> products = new List<IProduct>();

            products = GlobalConfig.connection.ReadProductByCategory(categories[(pageCategories * 10 - 10) + 4]);

            DisplayProductsInList(products);
        }

        private void categoryButton6_Click(object sender, EventArgs e)
        {
            HideAllCategoryButtons();

            List<IProduct> products = new List<IProduct>();

            products = GlobalConfig.connection.ReadProductByCategory(categories[(pageCategories * 10 - 10) + 5]);

            DisplayProductsInList(products);
        }

        private void categoryButton7_Click(object sender, EventArgs e)
        {
            HideAllCategoryButtons();

            List<IProduct> products = new List<IProduct>();

            products = GlobalConfig.connection.ReadProductByCategory(categories[(pageCategories * 10 - 10) + 6]);

            DisplayProductsInList(products);
        }

        private void categoryButton8_Click(object sender, EventArgs e)
        {
            HideAllCategoryButtons();

            List<IProduct> products = new List<IProduct>();

            products = GlobalConfig.connection.ReadProductByCategory(categories[(pageCategories * 10 - 10) + 7]);

            DisplayProductsInList(products);
        }

        private void categoryButton9_Click(object sender, EventArgs e)
        {
            HideAllCategoryButtons();

            List<IProduct> products = new List<IProduct>();

            products = GlobalConfig.connection.ReadProductByCategory(categories[(pageCategories * 10 - 10) + 8]);

            DisplayProductsInList(products);
        }

        private void categoryButton10_Click(object sender, EventArgs e)
        {
            HideAllCategoryButtons();

            List<IProduct> products = new List<IProduct>();

            products = GlobalConfig.connection.ReadProductByCategory(categories[(pageCategories * 10 - 10) + 9]);

            DisplayProductsInList(products);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (productsListBox.Visible == true)
            {
                productsListBox.Visible = false;
            }
            else
            {
                pageCategories--;
            }
            SetCategoriesMenu(pageCategories);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            pageCategories++;
            SetCategoriesMenu(pageCategories);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int numberOfTable = selectedTable.NumberOfTable;

            IUsedTable fullTable = new UsedTable();

            fullTable = tablesInUse.Where(x => x.NumberOfTable == numberOfTable).FirstOrDefault();

            tablesInUse.Remove(fullTable);
            fullTable.Products.Add((Product)productsListBox.SelectedItem);

            fullTable.ShowOccupied = "Occupied";
            tables.Where(x => x.Id == fullTable.Id).FirstOrDefault().ShowOccupied = "Occupied";

            tablesInUse.Add(fullTable);

            tablesListBox.DataSource = null;
            tablesListBox.DataSource = fullTable.Products;
            tablesListBox.DisplayMember = "DisplayText";

            payAllButton.Enabled = true;
            payPartialButton.Enabled = true;
        }

        private void customizeButton_Click(object sender, EventArgs e)
        {
            newFormCustomize = new CustomizeForm(this);
            newFormCustomize.SendData((Product)productsListBox.SelectedItem);
            newFormCustomize.FormBorderStyle = FormBorderStyle.FixedDialog;
            newFormCustomize.MaximizeBox = false;
            newFormCustomize.MinimizeBox = false;
            newFormCustomize.StartPosition = FormStartPosition.CenterScreen;
            newFormCustomize.ShowDialog();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (tablesListBox.DataSource is List<ITable>)
            {
                tablesListBox.Visible = false;
                SetAreasMenu();
            }
            else if (tablesListBox.DataSource is List<IProduct>)
            {
                DisplayTablesInList();

                if (tablesInUse.Where(x => x.NumberOfTable == selectedTable.NumberOfTable).FirstOrDefault() != null)
                {
                    if ((tablesInUse.Where(x => x.NumberOfTable == selectedTable.NumberOfTable).FirstOrDefault()).Products.Count < 1)
                    {
                        tablesInUse.Remove((tablesInUse.Where(x => x.NumberOfTable == selectedTable.NumberOfTable).FirstOrDefault()));
                    } 
                }
            }

            addButton.Enabled = false;
            customizeButton.Enabled = false;
            removeItemButton.Enabled = false;
        }

        private void payAllButton_Click(object sender, EventArgs e)
        {
            int numberOfTable = selectedTable.NumberOfTable;

            IUsedTable table = tablesInUse.Where(x => x.NumberOfTable == numberOfTable).FirstOrDefault();

            newFormPayTotal = new PayTotal(this);
            newFormPayTotal.SendData(table);
            newFormPayTotal.FormBorderStyle = FormBorderStyle.FixedDialog;
            newFormPayTotal.MaximizeBox = false;
            newFormPayTotal.MinimizeBox = false;
            newFormPayTotal.StartPosition = FormStartPosition.CenterScreen;
            newFormPayTotal.ShowDialog();
        }

        private void payPartialButton_Click(object sender, EventArgs e)
        {
            int numberOfTable = selectedTable.NumberOfTable;

            IUsedTable table = tablesInUse.Where(x => x.NumberOfTable == numberOfTable).FirstOrDefault();

            newFormPayPartial = new PayPartial(this);
            newFormPayPartial.SendData(table);
            newFormPayPartial.FormBorderStyle = FormBorderStyle.FixedDialog;
            newFormPayPartial.MaximizeBox = false;
            newFormPayPartial.MinimizeBox = false;
            newFormPayPartial.StartPosition = FormStartPosition.CenterScreen;
            newFormPayPartial.ShowDialog();
        }

        private void tablesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tablesListBox.SelectedItem is ITable)
            {
                selectedTable = (Table)tablesListBox.SelectedItem;

                tablesListBox.DataSource = null;

                if (tablesInUse.Where(x => x.NumberOfTable == selectedTable.NumberOfTable).FirstOrDefault() == null)
                {
                    IUsedTable fullTable = new UsedTable();
                    fullTable.Id = selectedTable.Id;
                    fullTable.NumberOfTable = selectedTable.NumberOfTable;
                    fullTable.ShowOccupied = selectedTable.ShowOccupied;
                    fullTable.Area = selectedTable.Area;
                    fullTable.AreaId = selectedTable.AreaId;

                    tablesInUse.Add(fullTable);
                }

                tablesListBox.DataSource = tablesInUse.Where(x => x.NumberOfTable == selectedTable.NumberOfTable).FirstOrDefault().Products;
                tablesListBox.DisplayMember = "DisplayText";

                if (productsListBox.Items.Count > 0)
                {
                    addButton.Enabled = true;
                    customizeButton.Enabled = true;
                }

                if (tablesListBox.SelectedItem is IProduct)
                {
                    removeItemButton.Enabled = true;
                }
            }
        }

        private void tablesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tablesListBox.DataSource is List<ITable>)
            {
                int numberOfTable = 0;

                selectedTable = (Table)tablesListBox.SelectedItem;
                numberOfTable = selectedTable.NumberOfTable;

                if (tablesInUse.Where(x => x.NumberOfTable == numberOfTable).FirstOrDefault() != null)
                {
                    payAllButton.Enabled = true;
                    payPartialButton.Enabled = true;
                }
                else
                {
                    payAllButton.Enabled = false;
                    payPartialButton.Enabled = false;
                }
            }
            else if (tablesListBox.SelectedItem is IProduct)
            {
                removeItemButton.Enabled = true;
            }
            
        }

        private void WorkingMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReadWriteFiles.WriteProductsOnTableToFile(tablesInUse);
            ReadWriteFiles.WriteSoldProductsToFile(soldProducts);
        }

        private void quitWorkingMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (tablesListBox.SelectedItem is IProduct)
            {
                int numberOfTable = selectedTable.NumberOfTable;

                IUsedTable fullTable = new UsedTable();

                fullTable = tablesInUse.Where(x => x.NumberOfTable == numberOfTable).FirstOrDefault();

                tablesInUse.Remove(fullTable);
                fullTable.Products.Remove((Product)tablesListBox.SelectedItem);

                if (fullTable.Products.Count == 0)
                {
                    payAllButton.Enabled = false;
                    payPartialButton.Enabled = false;
                    removeItemButton.Enabled = false;
                    (tables.Where(x => x.NumberOfTable == numberOfTable).FirstOrDefault()).ShowOccupied = "";
                }
                else
                {
                    tablesInUse.Add(fullTable);
                }

                tablesListBox.DataSource = null;
                tablesListBox.DataSource = fullTable.Products;
                tablesListBox.DisplayMember = "DisplayText";
            }
        }

        public void PayTotalPaymentDone()
        {
            foreach (Product p in newFormPayTotal.tableActual.Products)
            {
                soldProducts.Add(p);
            }

            tablesInUse.Remove(newFormPayTotal.tableActual);
            newFormPayTotal = null;

            SetAreasMenu();
            tablesListBox.Visible = false;

            SetCategoriesMenu(pageCategories);
            productsListBox.Visible = false; ;
        }

        public void PayTotalFormClosed()
        {
            newFormPayTotal = null;
        }

        public void PayPartialPaymentDone()
        {
            foreach (Product p in newFormPayPartial.tablePartial.Products)
            {
                soldProducts.Add(p);
                tablesInUse.Where(x =>
                x.NumberOfTable == newFormPayPartial.tablePartial.NumberOfTable).
                    FirstOrDefault().Products.Remove(p);
            }

            if (tablesInUse.Where(x =>
                x.NumberOfTable == newFormPayPartial.tablePartial.NumberOfTable).
                    FirstOrDefault().Products.Count == 0)
            {
                tablesInUse.Remove(tablesInUse.Where(x =>
                x.NumberOfTable == newFormPayPartial.tablePartial.NumberOfTable).
                FirstOrDefault());
            }

            newFormPayPartial = null;

            SetAreasMenu();
            tablesListBox.Visible = false;

            SetCategoriesMenu(pageCategories);
            productsListBox.Visible = false;
        }

        public void PayPartialFormClosed()
        {
            newFormPayPartial = null;
        }

        public void CustomizeAddDone()
        {
            int numberOfTable = selectedTable.NumberOfTable;

            IUsedTable fullTable = new UsedTable();
            IProduct modifiedProduct = new Product();

            modifiedProduct.Id = ((Product)productsListBox.SelectedItem).Id;
            modifiedProduct.Category = ((Product)productsListBox.SelectedItem).Category;
            modifiedProduct.CategoryId = ((Product)productsListBox.SelectedItem).CategoryId;
            modifiedProduct.Name = ((Product)productsListBox.SelectedItem).Name;
            modifiedProduct.Price = newFormCustomize.productInForm.Price;
            modifiedProduct.Detail = newFormCustomize.productInForm.Detail;

            fullTable = tablesInUse.Where(x => x.NumberOfTable == numberOfTable).FirstOrDefault();

            tablesInUse.Remove(fullTable);

            for (int i = 0; i < newFormCustomize.ammount; i++)
            {
                fullTable.Products.Add(modifiedProduct);
            }

            fullTable.ShowOccupied = "Occupied";

            tablesInUse.Add(fullTable);

            tablesListBox.DataSource = null;
            tablesListBox.DataSource = fullTable.Products;
            tablesListBox.DisplayMember = "DisplayText";

            payAllButton.Enabled = true;
            payPartialButton.Enabled = true;
        }

        public void CustomizeFormClosed()
        {
            newFormCustomize = null;
        }
    }
}
