namespace RestaurantApplication
{
    partial class TablesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablesForm));
            this.addTablesBox = new System.Windows.Forms.GroupBox();
            this.newTableToTextBox = new System.Windows.Forms.TextBox();
            this.newTableToLabel = new System.Windows.Forms.Label();
            this.seeListTablesButton = new System.Windows.Forms.Button();
            this.newTableFromTextBox = new System.Windows.Forms.TextBox();
            this.newTableAreaComboBox = new System.Windows.Forms.ComboBox();
            this.addNewTableButton = new System.Windows.Forms.Button();
            this.newTableAreaLabel = new System.Windows.Forms.Label();
            this.newTableFromLabel = new System.Windows.Forms.Label();
            this.addAreasBox = new System.Windows.Forms.GroupBox();
            this.newAreaNameTextBox = new System.Windows.Forms.TextBox();
            this.newAreaNameLabel = new System.Windows.Forms.Label();
            this.seeListAreasButton = new System.Windows.Forms.Button();
            this.addNewAreaButton = new System.Windows.Forms.Button();
            this.listVisualizationTablesBox = new System.Windows.Forms.GroupBox();
            this.tablesAreasLabel = new System.Windows.Forms.Label();
            this.deleteTablesItemButton = new System.Windows.Forms.Button();
            this.tablesList = new System.Windows.Forms.ListBox();
            this.quitTablesButton = new System.Windows.Forms.Button();
            this.addTablesBox.SuspendLayout();
            this.addAreasBox.SuspendLayout();
            this.listVisualizationTablesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTablesBox
            // 
            this.addTablesBox.Controls.Add(this.newTableToTextBox);
            this.addTablesBox.Controls.Add(this.newTableToLabel);
            this.addTablesBox.Controls.Add(this.seeListTablesButton);
            this.addTablesBox.Controls.Add(this.newTableFromTextBox);
            this.addTablesBox.Controls.Add(this.newTableAreaComboBox);
            this.addTablesBox.Controls.Add(this.addNewTableButton);
            this.addTablesBox.Controls.Add(this.newTableAreaLabel);
            this.addTablesBox.Controls.Add(this.newTableFromLabel);
            this.addTablesBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTablesBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addTablesBox.Location = new System.Drawing.Point(12, 12);
            this.addTablesBox.Name = "addTablesBox";
            this.addTablesBox.Size = new System.Drawing.Size(380, 227);
            this.addTablesBox.TabIndex = 1;
            this.addTablesBox.TabStop = false;
            this.addTablesBox.Text = "Add Tables";
            // 
            // newTableToTextBox
            // 
            this.newTableToTextBox.Location = new System.Drawing.Point(263, 52);
            this.newTableToTextBox.Name = "newTableToTextBox";
            this.newTableToTextBox.Size = new System.Drawing.Size(68, 29);
            this.newTableToTextBox.TabIndex = 10;
            // 
            // newTableToLabel
            // 
            this.newTableToLabel.AutoSize = true;
            this.newTableToLabel.Location = new System.Drawing.Point(207, 55);
            this.newTableToLabel.Name = "newTableToLabel";
            this.newTableToLabel.Size = new System.Drawing.Size(32, 23);
            this.newTableToLabel.TabIndex = 9;
            this.newTableToLabel.Text = "To";
            // 
            // seeListTablesButton
            // 
            this.seeListTablesButton.Location = new System.Drawing.Point(183, 165);
            this.seeListTablesButton.Name = "seeListTablesButton";
            this.seeListTablesButton.Size = new System.Drawing.Size(148, 35);
            this.seeListTablesButton.TabIndex = 8;
            this.seeListTablesButton.Text = "See All Tables";
            this.seeListTablesButton.UseVisualStyleBackColor = true;
            this.seeListTablesButton.Click += new System.EventHandler(this.seeListTablesButton_Click);
            // 
            // newTableFromTextBox
            // 
            this.newTableFromTextBox.Location = new System.Drawing.Point(105, 52);
            this.newTableFromTextBox.Name = "newTableFromTextBox";
            this.newTableFromTextBox.Size = new System.Drawing.Size(68, 29);
            this.newTableFromTextBox.TabIndex = 5;
            // 
            // newTableAreaComboBox
            // 
            this.newTableAreaComboBox.FormattingEnabled = true;
            this.newTableAreaComboBox.Location = new System.Drawing.Point(105, 104);
            this.newTableAreaComboBox.Name = "newTableAreaComboBox";
            this.newTableAreaComboBox.Size = new System.Drawing.Size(226, 31);
            this.newTableAreaComboBox.TabIndex = 4;
            this.newTableAreaComboBox.SelectionChangeCommitted += new System.EventHandler(this.newTableAreaComboBox_SelectionChangeCommitted);
            // 
            // addNewTableButton
            // 
            this.addNewTableButton.Location = new System.Drawing.Point(29, 165);
            this.addNewTableButton.Name = "addNewTableButton";
            this.addNewTableButton.Size = new System.Drawing.Size(81, 35);
            this.addNewTableButton.TabIndex = 3;
            this.addNewTableButton.Text = "Add";
            this.addNewTableButton.UseVisualStyleBackColor = true;
            this.addNewTableButton.Click += new System.EventHandler(this.addNewTableButton_Click);
            // 
            // newTableAreaLabel
            // 
            this.newTableAreaLabel.AutoSize = true;
            this.newTableAreaLabel.Location = new System.Drawing.Point(25, 112);
            this.newTableAreaLabel.Name = "newTableAreaLabel";
            this.newTableAreaLabel.Size = new System.Drawing.Size(50, 23);
            this.newTableAreaLabel.TabIndex = 2;
            this.newTableAreaLabel.Text = "Area";
            // 
            // newTableFromLabel
            // 
            this.newTableFromLabel.AutoSize = true;
            this.newTableFromLabel.Location = new System.Drawing.Point(25, 55);
            this.newTableFromLabel.Name = "newTableFromLabel";
            this.newTableFromLabel.Size = new System.Drawing.Size(56, 23);
            this.newTableFromLabel.TabIndex = 0;
            this.newTableFromLabel.Text = "From";
            // 
            // addAreasBox
            // 
            this.addAreasBox.Controls.Add(this.newAreaNameTextBox);
            this.addAreasBox.Controls.Add(this.newAreaNameLabel);
            this.addAreasBox.Controls.Add(this.seeListAreasButton);
            this.addAreasBox.Controls.Add(this.addNewAreaButton);
            this.addAreasBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAreasBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addAreasBox.Location = new System.Drawing.Point(12, 254);
            this.addAreasBox.Name = "addAreasBox";
            this.addAreasBox.Size = new System.Drawing.Size(380, 179);
            this.addAreasBox.TabIndex = 2;
            this.addAreasBox.TabStop = false;
            this.addAreasBox.Text = "Add Areas";
            // 
            // newAreaNameTextBox
            // 
            this.newAreaNameTextBox.Location = new System.Drawing.Point(105, 56);
            this.newAreaNameTextBox.Name = "newAreaNameTextBox";
            this.newAreaNameTextBox.Size = new System.Drawing.Size(226, 29);
            this.newAreaNameTextBox.TabIndex = 10;
            // 
            // newAreaNameLabel
            // 
            this.newAreaNameLabel.AutoSize = true;
            this.newAreaNameLabel.Location = new System.Drawing.Point(25, 59);
            this.newAreaNameLabel.Name = "newAreaNameLabel";
            this.newAreaNameLabel.Size = new System.Drawing.Size(61, 23);
            this.newAreaNameLabel.TabIndex = 9;
            this.newAreaNameLabel.Text = "Name";
            // 
            // seeListAreasButton
            // 
            this.seeListAreasButton.Location = new System.Drawing.Point(183, 112);
            this.seeListAreasButton.Name = "seeListAreasButton";
            this.seeListAreasButton.Size = new System.Drawing.Size(148, 35);
            this.seeListAreasButton.TabIndex = 8;
            this.seeListAreasButton.Text = "See List";
            this.seeListAreasButton.UseVisualStyleBackColor = true;
            this.seeListAreasButton.Click += new System.EventHandler(this.seeListAreasButton_Click);
            // 
            // addNewAreaButton
            // 
            this.addNewAreaButton.Location = new System.Drawing.Point(29, 112);
            this.addNewAreaButton.Name = "addNewAreaButton";
            this.addNewAreaButton.Size = new System.Drawing.Size(81, 35);
            this.addNewAreaButton.TabIndex = 3;
            this.addNewAreaButton.Text = "Add";
            this.addNewAreaButton.UseVisualStyleBackColor = true;
            this.addNewAreaButton.Click += new System.EventHandler(this.addNewAreaButton_Click);
            // 
            // listVisualizationTablesBox
            // 
            this.listVisualizationTablesBox.Controls.Add(this.tablesAreasLabel);
            this.listVisualizationTablesBox.Controls.Add(this.deleteTablesItemButton);
            this.listVisualizationTablesBox.Controls.Add(this.tablesList);
            this.listVisualizationTablesBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVisualizationTablesBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listVisualizationTablesBox.Location = new System.Drawing.Point(429, 12);
            this.listVisualizationTablesBox.Name = "listVisualizationTablesBox";
            this.listVisualizationTablesBox.Size = new System.Drawing.Size(420, 421);
            this.listVisualizationTablesBox.TabIndex = 7;
            this.listVisualizationTablesBox.TabStop = false;
            this.listVisualizationTablesBox.Text = "List Visualization";
            // 
            // tablesAreasLabel
            // 
            this.tablesAreasLabel.AutoSize = true;
            this.tablesAreasLabel.Location = new System.Drawing.Point(23, 43);
            this.tablesAreasLabel.Name = "tablesAreasLabel";
            this.tablesAreasLabel.Size = new System.Drawing.Size(65, 23);
            this.tablesAreasLabel.TabIndex = 12;
            this.tablesAreasLabel.Text = "Tables";
            // 
            // deleteTablesItemButton
            // 
            this.deleteTablesItemButton.ForeColor = System.Drawing.Color.DarkRed;
            this.deleteTablesItemButton.Location = new System.Drawing.Point(26, 370);
            this.deleteTablesItemButton.Name = "deleteTablesItemButton";
            this.deleteTablesItemButton.Size = new System.Drawing.Size(148, 35);
            this.deleteTablesItemButton.TabIndex = 10;
            this.deleteTablesItemButton.Text = "Delete item";
            this.deleteTablesItemButton.UseVisualStyleBackColor = true;
            this.deleteTablesItemButton.Click += new System.EventHandler(this.deleteTablesItemButton_Click);
            // 
            // tablesList
            // 
            this.tablesList.FormattingEnabled = true;
            this.tablesList.ItemHeight = 23;
            this.tablesList.Location = new System.Drawing.Point(26, 73);
            this.tablesList.Name = "tablesList";
            this.tablesList.Size = new System.Drawing.Size(364, 280);
            this.tablesList.TabIndex = 0;
            // 
            // quitTablesButton
            // 
            this.quitTablesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitTablesButton.ForeColor = System.Drawing.Color.DarkRed;
            this.quitTablesButton.Location = new System.Drawing.Point(745, 453);
            this.quitTablesButton.Name = "quitTablesButton";
            this.quitTablesButton.Size = new System.Drawing.Size(105, 47);
            this.quitTablesButton.TabIndex = 8;
            this.quitTablesButton.Text = "Quit";
            this.quitTablesButton.UseVisualStyleBackColor = true;
            this.quitTablesButton.Click += new System.EventHandler(this.quitTablesButton_Click);
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 512);
            this.Controls.Add(this.quitTablesButton);
            this.Controls.Add(this.listVisualizationTablesBox);
            this.Controls.Add(this.addAreasBox);
            this.Controls.Add(this.addTablesBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TablesForm";
            this.Text = "Tables";
            this.addTablesBox.ResumeLayout(false);
            this.addTablesBox.PerformLayout();
            this.addAreasBox.ResumeLayout(false);
            this.addAreasBox.PerformLayout();
            this.listVisualizationTablesBox.ResumeLayout(false);
            this.listVisualizationTablesBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addTablesBox;
        private System.Windows.Forms.Button seeListTablesButton;
        private System.Windows.Forms.TextBox newTableFromTextBox;
        private System.Windows.Forms.ComboBox newTableAreaComboBox;
        private System.Windows.Forms.Button addNewTableButton;
        private System.Windows.Forms.Label newTableAreaLabel;
        private System.Windows.Forms.Label newTableFromLabel;
        private System.Windows.Forms.TextBox newTableToTextBox;
        private System.Windows.Forms.Label newTableToLabel;
        private System.Windows.Forms.GroupBox addAreasBox;
        private System.Windows.Forms.Button seeListAreasButton;
        private System.Windows.Forms.Button addNewAreaButton;
        private System.Windows.Forms.TextBox newAreaNameTextBox;
        private System.Windows.Forms.Label newAreaNameLabel;
        private System.Windows.Forms.GroupBox listVisualizationTablesBox;
        private System.Windows.Forms.Button deleteTablesItemButton;
        private System.Windows.Forms.ListBox tablesList;
        private System.Windows.Forms.Label tablesAreasLabel;
        private System.Windows.Forms.Button quitTablesButton;
    }
}