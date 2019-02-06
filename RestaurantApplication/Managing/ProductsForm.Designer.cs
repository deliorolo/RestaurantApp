namespace RestaurantApplication
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.createNewProductBox = new System.Windows.Forms.GroupBox();
            this.seeListProductsButton = new System.Windows.Forms.Button();
            this.newProductEuroLabel = new System.Windows.Forms.Label();
            this.newProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.newProductNameTextBox = new System.Windows.Forms.TextBox();
            this.newProductCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.addNewProductButton = new System.Windows.Forms.Button();
            this.newProductCategoryLabel = new System.Windows.Forms.Label();
            this.newProductPriceLabel = new System.Windows.Forms.Label();
            this.newProductNameLabel = new System.Windows.Forms.Label();
            this.createNewCategoryBox = new System.Windows.Forms.GroupBox();
            this.newCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.seeListCategoriesButton = new System.Windows.Forms.Button();
            this.addNewCategoryButton = new System.Windows.Forms.Button();
            this.newCategoryNameLabel = new System.Windows.Forms.Label();
            this.listVisualizationProductsBox = new System.Windows.Forms.GroupBox();
            this.productsCategoriesLabel = new System.Windows.Forms.Label();
            this.deleteProductsItemButton = new System.Windows.Forms.Button();
            this.productsList = new System.Windows.Forms.ListBox();
            this.quitProductsButton = new System.Windows.Forms.Button();
            this.createNewProductBox.SuspendLayout();
            this.createNewCategoryBox.SuspendLayout();
            this.listVisualizationProductsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createNewProductBox
            // 
            this.createNewProductBox.Controls.Add(this.seeListProductsButton);
            this.createNewProductBox.Controls.Add(this.newProductEuroLabel);
            this.createNewProductBox.Controls.Add(this.newProductPriceTextBox);
            this.createNewProductBox.Controls.Add(this.newProductNameTextBox);
            this.createNewProductBox.Controls.Add(this.newProductCategoryComboBox);
            this.createNewProductBox.Controls.Add(this.addNewProductButton);
            this.createNewProductBox.Controls.Add(this.newProductCategoryLabel);
            this.createNewProductBox.Controls.Add(this.newProductPriceLabel);
            this.createNewProductBox.Controls.Add(this.newProductNameLabel);
            this.createNewProductBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewProductBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createNewProductBox.Location = new System.Drawing.Point(12, 12);
            this.createNewProductBox.Name = "createNewProductBox";
            this.createNewProductBox.Size = new System.Drawing.Size(436, 251);
            this.createNewProductBox.TabIndex = 0;
            this.createNewProductBox.TabStop = false;
            this.createNewProductBox.Text = "Create New Product";
            // 
            // seeListProductsButton
            // 
            this.seeListProductsButton.Location = new System.Drawing.Point(237, 199);
            this.seeListProductsButton.Name = "seeListProductsButton";
            this.seeListProductsButton.Size = new System.Drawing.Size(162, 35);
            this.seeListProductsButton.TabIndex = 8;
            this.seeListProductsButton.Text = "See All Products";
            this.seeListProductsButton.UseVisualStyleBackColor = true;
            this.seeListProductsButton.Click += new System.EventHandler(this.seeListProductsButton_Click);
            // 
            // newProductEuroLabel
            // 
            this.newProductEuroLabel.AutoSize = true;
            this.newProductEuroLabel.Location = new System.Drawing.Point(385, 100);
            this.newProductEuroLabel.Name = "newProductEuroLabel";
            this.newProductEuroLabel.Size = new System.Drawing.Size(22, 23);
            this.newProductEuroLabel.TabIndex = 7;
            this.newProductEuroLabel.Text = "€";
            // 
            // newProductPriceTextBox
            // 
            this.newProductPriceTextBox.Location = new System.Drawing.Point(136, 97);
            this.newProductPriceTextBox.Name = "newProductPriceTextBox";
            this.newProductPriceTextBox.Size = new System.Drawing.Size(243, 29);
            this.newProductPriceTextBox.TabIndex = 6;
            // 
            // newProductNameTextBox
            // 
            this.newProductNameTextBox.Location = new System.Drawing.Point(136, 52);
            this.newProductNameTextBox.Name = "newProductNameTextBox";
            this.newProductNameTextBox.Size = new System.Drawing.Size(263, 29);
            this.newProductNameTextBox.TabIndex = 5;
            // 
            // newProductCategoryComboBox
            // 
            this.newProductCategoryComboBox.FormattingEnabled = true;
            this.newProductCategoryComboBox.Location = new System.Drawing.Point(136, 141);
            this.newProductCategoryComboBox.Name = "newProductCategoryComboBox";
            this.newProductCategoryComboBox.Size = new System.Drawing.Size(263, 31);
            this.newProductCategoryComboBox.TabIndex = 4;
            this.newProductCategoryComboBox.SelectionChangeCommitted += new System.EventHandler(this.newProductCategoryComboBox_SelectionChangeCommitted);
            // 
            // addNewProductButton
            // 
            this.addNewProductButton.Location = new System.Drawing.Point(27, 199);
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(81, 35);
            this.addNewProductButton.TabIndex = 3;
            this.addNewProductButton.Text = "Add";
            this.addNewProductButton.UseVisualStyleBackColor = true;
            this.addNewProductButton.Click += new System.EventHandler(this.addNewProductButton_Click);
            // 
            // newProductCategoryLabel
            // 
            this.newProductCategoryLabel.AutoSize = true;
            this.newProductCategoryLabel.Location = new System.Drawing.Point(23, 149);
            this.newProductCategoryLabel.Name = "newProductCategoryLabel";
            this.newProductCategoryLabel.Size = new System.Drawing.Size(85, 23);
            this.newProductCategoryLabel.TabIndex = 2;
            this.newProductCategoryLabel.Text = "Category";
            // 
            // newProductPriceLabel
            // 
            this.newProductPriceLabel.AutoSize = true;
            this.newProductPriceLabel.Location = new System.Drawing.Point(25, 103);
            this.newProductPriceLabel.Name = "newProductPriceLabel";
            this.newProductPriceLabel.Size = new System.Drawing.Size(54, 23);
            this.newProductPriceLabel.TabIndex = 1;
            this.newProductPriceLabel.Text = "Price";
            // 
            // newProductNameLabel
            // 
            this.newProductNameLabel.AutoSize = true;
            this.newProductNameLabel.Location = new System.Drawing.Point(25, 55);
            this.newProductNameLabel.Name = "newProductNameLabel";
            this.newProductNameLabel.Size = new System.Drawing.Size(61, 23);
            this.newProductNameLabel.TabIndex = 0;
            this.newProductNameLabel.Text = "Name";
            // 
            // createNewCategoryBox
            // 
            this.createNewCategoryBox.Controls.Add(this.newCategoryNameTextBox);
            this.createNewCategoryBox.Controls.Add(this.seeListCategoriesButton);
            this.createNewCategoryBox.Controls.Add(this.addNewCategoryButton);
            this.createNewCategoryBox.Controls.Add(this.newCategoryNameLabel);
            this.createNewCategoryBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewCategoryBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createNewCategoryBox.Location = new System.Drawing.Point(12, 282);
            this.createNewCategoryBox.Name = "createNewCategoryBox";
            this.createNewCategoryBox.Size = new System.Drawing.Size(436, 152);
            this.createNewCategoryBox.TabIndex = 5;
            this.createNewCategoryBox.TabStop = false;
            this.createNewCategoryBox.Text = "Create New Category";
            // 
            // newCategoryNameTextBox
            // 
            this.newCategoryNameTextBox.Location = new System.Drawing.Point(136, 52);
            this.newCategoryNameTextBox.Name = "newCategoryNameTextBox";
            this.newCategoryNameTextBox.Size = new System.Drawing.Size(263, 29);
            this.newCategoryNameTextBox.TabIndex = 10;
            // 
            // seeListCategoriesButton
            // 
            this.seeListCategoriesButton.Location = new System.Drawing.Point(237, 103);
            this.seeListCategoriesButton.Name = "seeListCategoriesButton";
            this.seeListCategoriesButton.Size = new System.Drawing.Size(164, 35);
            this.seeListCategoriesButton.TabIndex = 9;
            this.seeListCategoriesButton.Text = "See List";
            this.seeListCategoriesButton.UseVisualStyleBackColor = true;
            this.seeListCategoriesButton.Click += new System.EventHandler(this.seeListCategoriesButton_Click);
            // 
            // addNewCategoryButton
            // 
            this.addNewCategoryButton.Location = new System.Drawing.Point(29, 100);
            this.addNewCategoryButton.Name = "addNewCategoryButton";
            this.addNewCategoryButton.Size = new System.Drawing.Size(81, 35);
            this.addNewCategoryButton.TabIndex = 3;
            this.addNewCategoryButton.Text = "Add";
            this.addNewCategoryButton.UseVisualStyleBackColor = true;
            this.addNewCategoryButton.Click += new System.EventHandler(this.addNewCategoryButton_Click);
            // 
            // newCategoryNameLabel
            // 
            this.newCategoryNameLabel.AutoSize = true;
            this.newCategoryNameLabel.Location = new System.Drawing.Point(25, 55);
            this.newCategoryNameLabel.Name = "newCategoryNameLabel";
            this.newCategoryNameLabel.Size = new System.Drawing.Size(61, 23);
            this.newCategoryNameLabel.TabIndex = 0;
            this.newCategoryNameLabel.Text = "Name";
            // 
            // listVisualizationProductsBox
            // 
            this.listVisualizationProductsBox.Controls.Add(this.productsCategoriesLabel);
            this.listVisualizationProductsBox.Controls.Add(this.deleteProductsItemButton);
            this.listVisualizationProductsBox.Controls.Add(this.productsList);
            this.listVisualizationProductsBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVisualizationProductsBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listVisualizationProductsBox.Location = new System.Drawing.Point(495, 12);
            this.listVisualizationProductsBox.Name = "listVisualizationProductsBox";
            this.listVisualizationProductsBox.Size = new System.Drawing.Size(484, 422);
            this.listVisualizationProductsBox.TabIndex = 6;
            this.listVisualizationProductsBox.TabStop = false;
            this.listVisualizationProductsBox.Text = "List Visualization";
            // 
            // productsCategoriesLabel
            // 
            this.productsCategoriesLabel.AutoSize = true;
            this.productsCategoriesLabel.Location = new System.Drawing.Point(22, 47);
            this.productsCategoriesLabel.Name = "productsCategoriesLabel";
            this.productsCategoriesLabel.Size = new System.Drawing.Size(86, 23);
            this.productsCategoriesLabel.TabIndex = 11;
            this.productsCategoriesLabel.Text = "Products";
            // 
            // deleteProductsItemButton
            // 
            this.deleteProductsItemButton.ForeColor = System.Drawing.Color.DarkRed;
            this.deleteProductsItemButton.Location = new System.Drawing.Point(26, 370);
            this.deleteProductsItemButton.Name = "deleteProductsItemButton";
            this.deleteProductsItemButton.Size = new System.Drawing.Size(148, 35);
            this.deleteProductsItemButton.TabIndex = 10;
            this.deleteProductsItemButton.Text = "Delete item";
            this.deleteProductsItemButton.UseVisualStyleBackColor = true;
            this.deleteProductsItemButton.Click += new System.EventHandler(this.deleteProductsItemButton_Click);
            // 
            // productsList
            // 
            this.productsList.FormattingEnabled = true;
            this.productsList.ItemHeight = 23;
            this.productsList.Location = new System.Drawing.Point(26, 73);
            this.productsList.Name = "productsList";
            this.productsList.Size = new System.Drawing.Size(432, 280);
            this.productsList.TabIndex = 0;
            // 
            // quitProductsButton
            // 
            this.quitProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitProductsButton.ForeColor = System.Drawing.Color.DarkRed;
            this.quitProductsButton.Location = new System.Drawing.Point(874, 457);
            this.quitProductsButton.Name = "quitProductsButton";
            this.quitProductsButton.Size = new System.Drawing.Size(105, 47);
            this.quitProductsButton.TabIndex = 7;
            this.quitProductsButton.Text = "Quit";
            this.quitProductsButton.UseVisualStyleBackColor = true;
            this.quitProductsButton.Click += new System.EventHandler(this.quitProductsButton_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 517);
            this.Controls.Add(this.quitProductsButton);
            this.Controls.Add(this.listVisualizationProductsBox);
            this.Controls.Add(this.createNewCategoryBox);
            this.Controls.Add(this.createNewProductBox);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductsForm";
            this.Text = "Products";
            this.createNewProductBox.ResumeLayout(false);
            this.createNewProductBox.PerformLayout();
            this.createNewCategoryBox.ResumeLayout(false);
            this.createNewCategoryBox.PerformLayout();
            this.listVisualizationProductsBox.ResumeLayout(false);
            this.listVisualizationProductsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox createNewProductBox;
        private System.Windows.Forms.Button seeListProductsButton;
        private System.Windows.Forms.Label newProductEuroLabel;
        private System.Windows.Forms.TextBox newProductPriceTextBox;
        private System.Windows.Forms.TextBox newProductNameTextBox;
        private System.Windows.Forms.ComboBox newProductCategoryComboBox;
        private System.Windows.Forms.Button addNewProductButton;
        private System.Windows.Forms.Label newProductCategoryLabel;
        private System.Windows.Forms.Label newProductPriceLabel;
        private System.Windows.Forms.Label newProductNameLabel;
        private System.Windows.Forms.GroupBox createNewCategoryBox;
        private System.Windows.Forms.TextBox newCategoryNameTextBox;
        private System.Windows.Forms.Button seeListCategoriesButton;
        private System.Windows.Forms.Button addNewCategoryButton;
        private System.Windows.Forms.Label newCategoryNameLabel;
        private System.Windows.Forms.GroupBox listVisualizationProductsBox;
        private System.Windows.Forms.ListBox productsList;
        private System.Windows.Forms.Button deleteProductsItemButton;
        private System.Windows.Forms.Label productsCategoriesLabel;
        private System.Windows.Forms.Button quitProductsButton;
    }
}

