namespace RestaurantApplication
{
    partial class CustomizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomizeForm));
            this.detailTextBox = new System.Windows.Forms.TextBox();
            this.editGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.ammountButton = new System.Windows.Forms.Button();
            this.newPriceButton = new System.Windows.Forms.Button();
            this.addDetailButton = new System.Windows.Forms.Button();
            this.ammountTextBox = new System.Windows.Forms.TextBox();
            this.newPriceEuroLabel = new System.Windows.Forms.Label();
            this.newPriceTextBox = new System.Windows.Forms.TextBox();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.quitCustomizeButton = new System.Windows.Forms.Button();
            this.editGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailTextBox
            // 
            this.detailTextBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailTextBox.Location = new System.Drawing.Point(16, 28);
            this.detailTextBox.Name = "detailTextBox";
            this.detailTextBox.Size = new System.Drawing.Size(221, 29);
            this.detailTextBox.TabIndex = 1;
            // 
            // editGroupBox
            // 
            this.editGroupBox.Controls.Add(this.addButton);
            this.editGroupBox.Controls.Add(this.ammountButton);
            this.editGroupBox.Controls.Add(this.newPriceButton);
            this.editGroupBox.Controls.Add(this.addDetailButton);
            this.editGroupBox.Controls.Add(this.ammountTextBox);
            this.editGroupBox.Controls.Add(this.newPriceEuroLabel);
            this.editGroupBox.Controls.Add(this.newPriceTextBox);
            this.editGroupBox.Controls.Add(this.detailTextBox);
            this.editGroupBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.editGroupBox.Location = new System.Drawing.Point(12, 58);
            this.editGroupBox.Name = "editGroupBox";
            this.editGroupBox.Size = new System.Drawing.Size(444, 220);
            this.editGroupBox.TabIndex = 2;
            this.editGroupBox.TabStop = false;
            this.editGroupBox.Text = "Edit";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addButton.Location = new System.Drawing.Point(278, 140);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(146, 51);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ammountButton
            // 
            this.ammountButton.Location = new System.Drawing.Point(99, 156);
            this.ammountButton.Name = "ammountButton";
            this.ammountButton.Size = new System.Drawing.Size(138, 35);
            this.ammountButton.TabIndex = 18;
            this.ammountButton.Text = "Set Ammount";
            this.ammountButton.UseVisualStyleBackColor = true;
            this.ammountButton.Click += new System.EventHandler(this.ammountButton_Click);
            // 
            // newPriceButton
            // 
            this.newPriceButton.Location = new System.Drawing.Point(278, 63);
            this.newPriceButton.Name = "newPriceButton";
            this.newPriceButton.Size = new System.Drawing.Size(146, 35);
            this.newPriceButton.TabIndex = 17;
            this.newPriceButton.Text = "New price";
            this.newPriceButton.UseVisualStyleBackColor = true;
            this.newPriceButton.Click += new System.EventHandler(this.newPriceButton_Click);
            // 
            // addDetailButton
            // 
            this.addDetailButton.Location = new System.Drawing.Point(16, 63);
            this.addDetailButton.Name = "addDetailButton";
            this.addDetailButton.Size = new System.Drawing.Size(221, 35);
            this.addDetailButton.TabIndex = 16;
            this.addDetailButton.Text = "Add Detail";
            this.addDetailButton.UseVisualStyleBackColor = true;
            this.addDetailButton.Click += new System.EventHandler(this.addDetailButton_Click);
            // 
            // ammountTextBox
            // 
            this.ammountTextBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammountTextBox.Location = new System.Drawing.Point(16, 159);
            this.ammountTextBox.Name = "ammountTextBox";
            this.ammountTextBox.Size = new System.Drawing.Size(77, 29);
            this.ammountTextBox.TabIndex = 14;
            this.ammountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // newPriceEuroLabel
            // 
            this.newPriceEuroLabel.AutoSize = true;
            this.newPriceEuroLabel.Location = new System.Drawing.Point(402, 31);
            this.newPriceEuroLabel.Name = "newPriceEuroLabel";
            this.newPriceEuroLabel.Size = new System.Drawing.Size(22, 23);
            this.newPriceEuroLabel.TabIndex = 13;
            this.newPriceEuroLabel.Text = "€";
            // 
            // newPriceTextBox
            // 
            this.newPriceTextBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPriceTextBox.Location = new System.Drawing.Point(278, 28);
            this.newPriceTextBox.Name = "newPriceTextBox";
            this.newPriceTextBox.Size = new System.Drawing.Size(118, 29);
            this.newPriceTextBox.TabIndex = 11;
            this.newPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // productTextBox
            // 
            this.productTextBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTextBox.Location = new System.Drawing.Point(28, 12);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.ReadOnly = true;
            this.productTextBox.Size = new System.Drawing.Size(428, 29);
            this.productTextBox.TabIndex = 3;
            // 
            // quitCustomizeButton
            // 
            this.quitCustomizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitCustomizeButton.ForeColor = System.Drawing.Color.DarkRed;
            this.quitCustomizeButton.Location = new System.Drawing.Point(351, 299);
            this.quitCustomizeButton.Name = "quitCustomizeButton";
            this.quitCustomizeButton.Size = new System.Drawing.Size(105, 47);
            this.quitCustomizeButton.TabIndex = 7;
            this.quitCustomizeButton.Text = "Quit";
            this.quitCustomizeButton.UseVisualStyleBackColor = true;
            this.quitCustomizeButton.Click += new System.EventHandler(this.quitCustomizeButton_Click);
            // 
            // CustomizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 360);
            this.Controls.Add(this.quitCustomizeButton);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(this.editGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomizeForm";
            this.Text = "Customize";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomizeForm_FormClosed);
            this.editGroupBox.ResumeLayout(false);
            this.editGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox detailTextBox;
        private System.Windows.Forms.GroupBox editGroupBox;
        private System.Windows.Forms.TextBox newPriceTextBox;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.Label newPriceEuroLabel;
        private System.Windows.Forms.TextBox ammountTextBox;
        private System.Windows.Forms.Button ammountButton;
        private System.Windows.Forms.Button newPriceButton;
        private System.Windows.Forms.Button addDetailButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button quitCustomizeButton;
    }
}