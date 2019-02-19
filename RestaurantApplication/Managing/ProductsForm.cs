﻿using CodeLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeLibrary.DataAccess;

namespace RestaurantApplication
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            List<Category> categories = GlobalConfig.connection.ReadAllCategories();

            newProductCategoryComboBox.DataSource = null;
            newProductCategoryComboBox.DataSource = categories;
            newProductCategoryComboBox.DisplayMember = "Name";

        }

        private void addNewCategoryButton_Click(object sender, EventArgs e)
        {
            
            if (CheckValidCategoryData())
            {
                Category category = new Category();
                category.Name = newCategoryNameTextBox.Text;
                GlobalConfig.connection.AddNewCategory(category);
                newCategoryNameTextBox.Text = "";

                List<Category> categories = GlobalConfig.connection.ReadAllCategories();
                UpdateCategoriesComboBox(categories);
                UpdateCategoriesList(categories);

            }
            else
            {
                MessageBox.Show("You must insert a valid category name for a group of products.", "Wrong Data");
            }

        }

        private bool CheckValidCategoryData()
        {
            bool isValid = true;
            char[] symbols = { '^', '|' };

            if (newCategoryNameTextBox.TextLength < 1 || newCategoryNameTextBox.TextLength > 99)
            {
                isValid = false;
            }

            if (newCategoryNameTextBox.Text.IndexOfAny(symbols) > 0)
            {
                isValid = false;
            }

            return isValid;
        }

        private void seeListCategoriesButton_Click(object sender, EventArgs e)
        {
            List<Category> categories = GlobalConfig.connection.ReadAllCategories();
            UpdateCategoriesList(categories);
            UpdateCategoriesComboBox(categories);
        }

        private void UpdateCategoriesList(List<Category> categories)
        {
            productsList.DataSource = null;
            productsList.DataSource = categories;
            productsList.DisplayMember = "Name";
            productsCategoriesLabel.Text = "Categories";

        }

        private void UpdateCategoriesComboBox(List<Category> categories)
        {
            newProductCategoryComboBox.DataSource = null;
            newProductCategoryComboBox.DataSource = categories;
            newProductCategoryComboBox.DisplayMember = "Name";
        }

        private void seeListProductsButton_Click(object sender, EventArgs e)
        {
            List<Product> products = GlobalConfig.connection.ReadAllProducts();
            UpdateProductsList(products);
        }

        private void UpdateProductsList (List<Product> products)
        {
            productsList.DataSource = null;
            productsList.DataSource = products;
            productsList.DisplayMember = "DisplayText2";
            productsCategoriesLabel.Text = "Products";
        }

        private void addNewProductButton_Click(object sender, EventArgs e)
        {
            if (CheckValidProductData())
            {
                Product product = new Product();
                product.Name = newProductNameTextBox.Text;
                product.Price = decimal.Parse(newProductPriceTextBox.Text);
                product.Category = (Category)newProductCategoryComboBox.SelectedItem;
                product.CategoryId = product.Category.Id;

                GlobalConfig.connection.AddNewProduct(product);

                newProductNameTextBox.Text = "";
                newProductPriceTextBox.Text = "";

                List<Product> productsByCategory = GlobalConfig.connection.ReadProductByCategory(product.Category);
                UpdateProductsList(productsByCategory);

            }
            else
            {
                MessageBox.Show("You must insert valid product data in the fields.", "Wrong Data");
            }
        }

        private bool CheckValidProductData()
        {
            bool isValid = true;
            decimal auxValid;
            char[] symbols = { '^', '|' };

            if (newProductNameTextBox.TextLength < 1 || newProductNameTextBox.TextLength > 99)
            {
                isValid = false;
            }

            if (decimal.TryParse(newProductPriceTextBox.Text, out auxValid) == false || newProductPriceTextBox.TextLength < 1)
            {
                isValid = false;
            }

            if (newProductNameTextBox.Text.IndexOfAny(symbols) > 0)
            {
                isValid = false;
            }

            if (newProductCategoryComboBox.SelectedItem == null)
            {
                isValid = false;
            }

            return isValid;
        }

        private void newProductCategoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)newProductCategoryComboBox.SelectedItem;

            if (selectedCategory != null)
            {
                List<Product> productsByCategory = GlobalConfig.connection.ReadProductByCategory(selectedCategory);
                UpdateProductsList(productsByCategory);
            }
        }

        private void deleteProductsItemButton_Click(object sender, EventArgs e)
        {
            if (productsList.SelectedItem is Product)
            {
                Product selected = (Product)productsList.SelectedItem;
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the {selected.DisplayText}?",
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    GlobalConfig.connection.DeleteProduct(selected);

                    List<Product> products = GlobalConfig.connection.ReadProductByCategory(selected.Category);
                    UpdateProductsList(products); 
                }
            }
            else if (productsList.SelectedItem is Category)
            {
                Category selected = (Category)productsList.SelectedItem;
                List<Product> products = GlobalConfig.connection.ReadProductByCategory(selected);
                int amountOfProducts = products.Count;

                DialogResult result = MessageBox.Show($"Are you sure you want to delete the {selected.Name} category and all its {amountOfProducts} products?",
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    GlobalConfig.connection.DeleteCategoryAndAllItsProducts(selected);

                    List<Category> categories = GlobalConfig.connection.ReadAllCategories();
                    UpdateCategoriesList(categories);
                    UpdateCategoriesComboBox(categories); 
                }
            }
        }

        private void quitProductsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
