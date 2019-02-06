using CodeLibrary.DataAccess;
using CodeLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApplication
{
    public partial class TablesForm : Form
    {
        public TablesForm()
        {
            InitializeComponent();

            List<AreaOfTables> areas = GlobalConfig.connection.ReadAllAreas();

            newTableAreaComboBox.DataSource = null;
            newTableAreaComboBox.DataSource = areas;
            newTableAreaComboBox.DisplayMember = "AreaName";
        }

        private void addNewAreaButton_Click(object sender, EventArgs e)
        {
            if (CheckValidAreaData())
            {
                if (CheckLimitOfAreas())
                {
                    AreaOfTables area = new AreaOfTables();
                    area.AreaName = newAreaNameTextBox.Text;
                    GlobalConfig.connection.AddNewAreaOfTables(area);
                    newAreaNameTextBox.Text = "";

                    List<AreaOfTables> areas = GlobalConfig.connection.ReadAllAreas();
                    UpdateAreasComboBox(areas);
                    UpdateAreasList(areas); 
                }
                else
                {
                    MessageBox.Show("You have already reached the maximum number of areas, please delete some.", "Limit exceeded");
                }

            }
            else
            {
                MessageBox.Show("You must insert a valid Area name for a group of tables", "Wrong Data");
            }
        }

        private void UpdateAreasList(List<AreaOfTables> areas)
        {
            tablesList.DataSource = null;
            tablesList.DataSource = areas;
            tablesList.DisplayMember = "AreaName";
            tablesAreasLabel.Text = "Areas of Tables";
        }

        private void UpdateAreasComboBox(List<AreaOfTables> areas)
        {
            newTableAreaComboBox.DataSource = null;
            newTableAreaComboBox.DataSource = areas;
            newTableAreaComboBox.DisplayMember = "AreaName";
        }

        private void UpdateTablesList(List<Table> tables)
        {
            tables = tables.OrderBy(x => x.NumberOfTable).ToList();

            tablesList.DataSource = null;
            tablesList.DataSource = tables;
            tablesList.DisplayMember = "DisplayText";
            tablesAreasLabel.Text = "Tables";
        }

        private bool CheckValidAreaData()
        {
            bool isValid = true;
            char[] symbols = { '^', '|' };

            if (newAreaNameTextBox.TextLength < 1)
            {
                isValid = false;
            }

            if (newAreaNameTextBox.Text.IndexOfAny(symbols) > 0)
            {
                isValid = false;
            }

            return isValid;
        }

        private bool CheckLimitOfAreas()
        {
            bool isValid = false;
            int count = 0;

            List<AreaOfTables> areas = GlobalConfig.connection.ReadAllAreas();
            count = areas.Count;

            if (count < 10)
            {
                isValid = true;
            }

            return isValid;
        }

        private void seeListAreasButton_Click(object sender, EventArgs e)
        {
            List<AreaOfTables> areas = GlobalConfig.connection.ReadAllAreas();
            UpdateAreasList(areas);
            UpdateAreasComboBox(areas);
        }

        private void addNewTableButton_Click(object sender, EventArgs e)
        {
            if (CheckValidTablesData())
            {
                List<Table> tables = new List<Table>();
                int first = 0;
                int last = 0;

                int.TryParse(newTableFromTextBox.Text, out first);
                int.TryParse(newTableToTextBox.Text, out last);

                if (first == 0)
                {
                    first = last;
                }

                if (last == 0)
                {
                    last = first;
                }

                if (CheckIfTablesAreNew(first, last))
                {
                    for (int i = first; i <= last; i++)
                    {
                        Table table = new Table();
                        table.NumberOfTable = i;
                        table.Area = (AreaOfTables)newTableAreaComboBox.SelectedItem;
                        table.AreaId = table.Area.Id;

                        tables.Add(table);
                    }

                    GlobalConfig.connection.AddNewTables(tables);

                    newTableFromTextBox.Text = "";
                    newTableToTextBox.Text = "";

                    List<Table> productsByCategory = GlobalConfig.connection.ReadTablesByArea((tables.Where(x => x.NumberOfTable == first).FirstOrDefault()).Area);
                    UpdateTablesList(productsByCategory); 
                }
                else
                {
                    MessageBox.Show("One or more tables you want to add already exist in the system.", "Tables exist");
                }

            }
            else
            {
                MessageBox.Show("You must insert valid table numbers in the fields.", "Wrong Data");
            }
        }

        private bool CheckIfTablesAreNew(int first, int last)
        {
            bool tablesAreNew = false;
            List<Table> allTables = new List<Table>();
            allTables = GlobalConfig.connection.ReadAllTables();

            int j = 0;
            int k = 0;
            int[] numberOfTablesNew = new int[last-first+1];
            int[] numberOfTablesExisting = new int[allTables.Count];

            for (int i = first; i <= last; i++)
            {
                numberOfTablesNew[j] = i;
                j++;
            }

            foreach (Table t in allTables)
            {
                numberOfTablesExisting[k] = t.NumberOfTable;
                k++;
            }

            tablesAreNew = numberOfTablesNew.Intersect(numberOfTablesExisting).Count() == 0;

            return tablesAreNew;
        }

        private bool CheckValidTablesData()
        {
            bool isValid = true;
            int auxValid1;
            int auxValid2;

            if (int.TryParse(newTableFromTextBox.Text, out auxValid1) == false)
            {
                isValid = false;

                if (newTableFromTextBox.Text == "")
                {
                    isValid = true;
                }
            }

            if (int.TryParse(newTableToTextBox.Text, out auxValid2) == false)
            {
                isValid = false;

                if (newTableToTextBox.Text == "")
                {
                    isValid = true;
                }
            }

            if((auxValid1 > auxValid2 && auxValid1 != 0 && auxValid2 != 0) || (auxValid1 == 0 && auxValid2 == 0))
            {
                isValid = false;
            }

            if (newTableAreaComboBox.SelectedItem == null)
            {
                isValid = false;
            }

            return isValid;
        }

        private void newTableAreaComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AreaOfTables selectedArea = (AreaOfTables)newTableAreaComboBox.SelectedItem;

            if (selectedArea != null)
            {
                List<Table> tablesByArea = GlobalConfig.connection.ReadTablesByArea(selectedArea);
                UpdateTablesList(tablesByArea);
            }
        }

        private void seeListTablesButton_Click(object sender, EventArgs e)
        {
            List<Table> tables = GlobalConfig.connection.ReadAllTables();
            UpdateTablesList(tables);
        }

        private void deleteTablesItemButton_Click(object sender, EventArgs e)
        {
            if (tablesList.SelectedItem is Table)
            {
                Table selected = (Table)tablesList.SelectedItem;
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the table {selected.DisplayText}?",
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    GlobalConfig.connection.DeleteTable(selected);

                    List<Table> tables = GlobalConfig.connection.ReadTablesByArea(selected.Area);
                    UpdateTablesList(tables);
                }
            }
            else if (tablesList.SelectedItem is AreaOfTables)
            {
                AreaOfTables selected = (AreaOfTables)tablesList.SelectedItem;
                List<Table> products = GlobalConfig.connection.ReadTablesByArea(selected);
                int amountOfTables = products.Count;

                DialogResult result = MessageBox.Show($"Are you sure you want to delete the {selected.AreaName} area and all its {amountOfTables} tables?",
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    GlobalConfig.connection.DeleteAreaAndAllItsTables(selected);

                    List<AreaOfTables> areas = GlobalConfig.connection.ReadAllAreas();
                    UpdateAreasList(areas);
                    UpdateAreasComboBox(areas);
                }
            }
        }

        private void quitTablesButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
