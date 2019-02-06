﻿namespace RestaurantApplication
{
    partial class SallesControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SallesControlForm));
            this.todaysSaleGroupBox = new System.Windows.Forms.GroupBox();
            this.sallesControlTotalLabel = new System.Windows.Forms.Label();
            this.sallesControlEuroLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.soldProductsListBox = new System.Windows.Forms.ListBox();
            this.closeTheDayButton = new System.Windows.Forms.Button();
            this.historicGroupBox = new System.Windows.Forms.GroupBox();
            this.productsSoldButton = new System.Windows.Forms.Button();
            this.moneyIncomeButton = new System.Windows.Forms.Button();
            this.quitSallesControlButton = new System.Windows.Forms.Button();
            this.todaysSaleGroupBox.SuspendLayout();
            this.historicGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // todaysSaleGroupBox
            // 
            this.todaysSaleGroupBox.Controls.Add(this.sallesControlTotalLabel);
            this.todaysSaleGroupBox.Controls.Add(this.sallesControlEuroLabel);
            this.todaysSaleGroupBox.Controls.Add(this.totalTextBox);
            this.todaysSaleGroupBox.Controls.Add(this.soldProductsListBox);
            this.todaysSaleGroupBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaysSaleGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.todaysSaleGroupBox.Location = new System.Drawing.Point(12, 12);
            this.todaysSaleGroupBox.Name = "todaysSaleGroupBox";
            this.todaysSaleGroupBox.Size = new System.Drawing.Size(411, 420);
            this.todaysSaleGroupBox.TabIndex = 2;
            this.todaysSaleGroupBox.TabStop = false;
            this.todaysSaleGroupBox.Text = "Today\'s Sale";
            // 
            // sallesControlTotalLabel
            // 
            this.sallesControlTotalLabel.AutoSize = true;
            this.sallesControlTotalLabel.Location = new System.Drawing.Point(6, 386);
            this.sallesControlTotalLabel.Name = "sallesControlTotalLabel";
            this.sallesControlTotalLabel.Size = new System.Drawing.Size(54, 23);
            this.sallesControlTotalLabel.TabIndex = 13;
            this.sallesControlTotalLabel.Text = "Total";
            // 
            // sallesControlEuroLabel
            // 
            this.sallesControlEuroLabel.AutoSize = true;
            this.sallesControlEuroLabel.Location = new System.Drawing.Point(382, 383);
            this.sallesControlEuroLabel.Name = "sallesControlEuroLabel";
            this.sallesControlEuroLabel.Size = new System.Drawing.Size(22, 23);
            this.sallesControlEuroLabel.TabIndex = 12;
            this.sallesControlEuroLabel.Text = "€";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(98, 380);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(278, 29);
            this.totalTextBox.TabIndex = 11;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // soldProductsListBox
            // 
            this.soldProductsListBox.FormattingEnabled = true;
            this.soldProductsListBox.ItemHeight = 23;
            this.soldProductsListBox.Location = new System.Drawing.Point(6, 25);
            this.soldProductsListBox.Name = "soldProductsListBox";
            this.soldProductsListBox.Size = new System.Drawing.Size(395, 349);
            this.soldProductsListBox.TabIndex = 10;
            // 
            // closeTheDayButton
            // 
            this.closeTheDayButton.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeTheDayButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.closeTheDayButton.Location = new System.Drawing.Point(246, 438);
            this.closeTheDayButton.Name = "closeTheDayButton";
            this.closeTheDayButton.Size = new System.Drawing.Size(177, 51);
            this.closeTheDayButton.TabIndex = 6;
            this.closeTheDayButton.Text = "Close The Day";
            this.closeTheDayButton.UseVisualStyleBackColor = true;
            this.closeTheDayButton.Click += new System.EventHandler(this.closeTheDayButton_Click);
            // 
            // historicGroupBox
            // 
            this.historicGroupBox.Controls.Add(this.productsSoldButton);
            this.historicGroupBox.Controls.Add(this.moneyIncomeButton);
            this.historicGroupBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historicGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.historicGroupBox.Location = new System.Drawing.Point(441, 12);
            this.historicGroupBox.Name = "historicGroupBox";
            this.historicGroupBox.Size = new System.Drawing.Size(247, 137);
            this.historicGroupBox.TabIndex = 7;
            this.historicGroupBox.TabStop = false;
            this.historicGroupBox.Text = "Historic";
            // 
            // productsSoldButton
            // 
            this.productsSoldButton.Location = new System.Drawing.Point(22, 81);
            this.productsSoldButton.Name = "productsSoldButton";
            this.productsSoldButton.Size = new System.Drawing.Size(203, 35);
            this.productsSoldButton.TabIndex = 9;
            this.productsSoldButton.Text = "Products Sold Files";
            this.productsSoldButton.UseVisualStyleBackColor = true;
            this.productsSoldButton.Click += new System.EventHandler(this.productsSoldButton_Click);
            // 
            // moneyIncomeButton
            // 
            this.moneyIncomeButton.Location = new System.Drawing.Point(22, 40);
            this.moneyIncomeButton.Name = "moneyIncomeButton";
            this.moneyIncomeButton.Size = new System.Drawing.Size(203, 35);
            this.moneyIncomeButton.TabIndex = 8;
            this.moneyIncomeButton.Text = "Money Income File";
            this.moneyIncomeButton.UseVisualStyleBackColor = true;
            this.moneyIncomeButton.Click += new System.EventHandler(this.moneyIncomeButton_Click);
            // 
            // quitSallesControlButton
            // 
            this.quitSallesControlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitSallesControlButton.ForeColor = System.Drawing.Color.DarkRed;
            this.quitSallesControlButton.Location = new System.Drawing.Point(583, 442);
            this.quitSallesControlButton.Name = "quitSallesControlButton";
            this.quitSallesControlButton.Size = new System.Drawing.Size(105, 47);
            this.quitSallesControlButton.TabIndex = 14;
            this.quitSallesControlButton.Text = "Quit";
            this.quitSallesControlButton.UseVisualStyleBackColor = true;
            this.quitSallesControlButton.Click += new System.EventHandler(this.quitSallesControlButton_Click);
            // 
            // SallesControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 507);
            this.Controls.Add(this.quitSallesControlButton);
            this.Controls.Add(this.historicGroupBox);
            this.Controls.Add(this.closeTheDayButton);
            this.Controls.Add(this.todaysSaleGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SallesControlForm";
            this.Text = "Salles Control";
            this.todaysSaleGroupBox.ResumeLayout(false);
            this.todaysSaleGroupBox.PerformLayout();
            this.historicGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox todaysSaleGroupBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.ListBox soldProductsListBox;
        private System.Windows.Forms.Label sallesControlEuroLabel;
        private System.Windows.Forms.Label sallesControlTotalLabel;
        private System.Windows.Forms.Button closeTheDayButton;
        private System.Windows.Forms.GroupBox historicGroupBox;
        private System.Windows.Forms.Button moneyIncomeButton;
        private System.Windows.Forms.Button productsSoldButton;
        private System.Windows.Forms.Button quitSallesControlButton;
    }
}