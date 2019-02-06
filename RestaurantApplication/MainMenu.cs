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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }

        private void manageProductsButton_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            productsForm.MaximizeBox = false;
            productsForm.MinimizeBox = false;
            productsForm.StartPosition = FormStartPosition.CenterScreen;
            productsForm.ShowDialog();
        }

        private void manageTablesButton_Click(object sender, EventArgs e)
        {
            TablesForm tablesForm = new TablesForm();
            tablesForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            tablesForm.MaximizeBox = false;
            tablesForm.MinimizeBox = false;
            tablesForm.StartPosition = FormStartPosition.CenterScreen;
            tablesForm.ShowDialog();
        }

        private void workingMenuButton_Click(object sender, EventArgs e)
        {
            WorkingMenu workingMenuForm = new WorkingMenu();
            workingMenuForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            workingMenuForm.MaximizeBox = false;
            workingMenuForm.MinimizeBox = false;
            workingMenuForm.StartPosition = FormStartPosition.CenterScreen;
            workingMenuForm.ShowDialog();
        }

        private void sallesControlButton_Click(object sender, EventArgs e)
        {
            SallesControlForm sallesControlFrom = new SallesControlForm();
            sallesControlFrom.FormBorderStyle = FormBorderStyle.FixedDialog;
            sallesControlFrom.MaximizeBox = false;
            sallesControlFrom.MinimizeBox = false;
            sallesControlFrom.StartPosition = FormStartPosition.CenterScreen;
            sallesControlFrom.ShowDialog();
        }

        private void quitMainMenubutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
