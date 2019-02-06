namespace RestaurantApplication
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.byDelioRoloLabel = new System.Windows.Forms.Label();
            this.mainMenuTitleLabel = new System.Windows.Forms.Label();
            this.manageProductsButton = new System.Windows.Forms.Button();
            this.manageTablesButton = new System.Windows.Forms.Button();
            this.workingMenuButton = new System.Windows.Forms.Button();
            this.quitMainMenubutton = new System.Windows.Forms.Button();
            this.sallesControlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // byDelioRoloLabel
            // 
            this.byDelioRoloLabel.AutoSize = true;
            this.byDelioRoloLabel.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byDelioRoloLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.byDelioRoloLabel.Location = new System.Drawing.Point(380, 9);
            this.byDelioRoloLabel.Name = "byDelioRoloLabel";
            this.byDelioRoloLabel.Size = new System.Drawing.Size(172, 39);
            this.byDelioRoloLabel.TabIndex = 2;
            this.byDelioRoloLabel.Text = "by Délio Rolo";
            // 
            // mainMenuTitleLabel
            // 
            this.mainMenuTitleLabel.AutoSize = true;
            this.mainMenuTitleLabel.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuTitleLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.mainMenuTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.mainMenuTitleLabel.Name = "mainMenuTitleLabel";
            this.mainMenuTitleLabel.Size = new System.Drawing.Size(319, 39);
            this.mainMenuTitleLabel.TabIndex = 1;
            this.mainMenuTitleLabel.Text = "Restaurant Management";
            // 
            // manageProductsButton
            // 
            this.manageProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageProductsButton.Location = new System.Drawing.Point(19, 175);
            this.manageProductsButton.Name = "manageProductsButton";
            this.manageProductsButton.Size = new System.Drawing.Size(249, 47);
            this.manageProductsButton.TabIndex = 3;
            this.manageProductsButton.Text = "Manage Products";
            this.manageProductsButton.UseVisualStyleBackColor = true;
            this.manageProductsButton.Click += new System.EventHandler(this.manageProductsButton_Click);
            // 
            // manageTablesButton
            // 
            this.manageTablesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageTablesButton.Location = new System.Drawing.Point(303, 175);
            this.manageTablesButton.Name = "manageTablesButton";
            this.manageTablesButton.Size = new System.Drawing.Size(249, 47);
            this.manageTablesButton.TabIndex = 4;
            this.manageTablesButton.Text = "Manage Tables";
            this.manageTablesButton.UseVisualStyleBackColor = true;
            this.manageTablesButton.Click += new System.EventHandler(this.manageTablesButton_Click);
            // 
            // workingMenuButton
            // 
            this.workingMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingMenuButton.Location = new System.Drawing.Point(19, 101);
            this.workingMenuButton.Name = "workingMenuButton";
            this.workingMenuButton.Size = new System.Drawing.Size(533, 47);
            this.workingMenuButton.TabIndex = 5;
            this.workingMenuButton.Text = "Working Menu";
            this.workingMenuButton.UseVisualStyleBackColor = true;
            this.workingMenuButton.Click += new System.EventHandler(this.workingMenuButton_Click);
            // 
            // quitMainMenubutton
            // 
            this.quitMainMenubutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitMainMenubutton.ForeColor = System.Drawing.Color.DarkRed;
            this.quitMainMenubutton.Location = new System.Drawing.Point(447, 243);
            this.quitMainMenubutton.Name = "quitMainMenubutton";
            this.quitMainMenubutton.Size = new System.Drawing.Size(105, 47);
            this.quitMainMenubutton.TabIndex = 6;
            this.quitMainMenubutton.Text = "Quit";
            this.quitMainMenubutton.UseVisualStyleBackColor = true;
            this.quitMainMenubutton.Click += new System.EventHandler(this.quitMainMenubutton_Click);
            // 
            // sallesControlButton
            // 
            this.sallesControlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sallesControlButton.Location = new System.Drawing.Point(19, 243);
            this.sallesControlButton.Name = "sallesControlButton";
            this.sallesControlButton.Size = new System.Drawing.Size(249, 47);
            this.sallesControlButton.TabIndex = 7;
            this.sallesControlButton.Text = "Salles Control";
            this.sallesControlButton.UseVisualStyleBackColor = true;
            this.sallesControlButton.Click += new System.EventHandler(this.sallesControlButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 309);
            this.Controls.Add(this.sallesControlButton);
            this.Controls.Add(this.quitMainMenubutton);
            this.Controls.Add(this.workingMenuButton);
            this.Controls.Add(this.manageTablesButton);
            this.Controls.Add(this.manageProductsButton);
            this.Controls.Add(this.byDelioRoloLabel);
            this.Controls.Add(this.mainMenuTitleLabel);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label byDelioRoloLabel;
        private System.Windows.Forms.Label mainMenuTitleLabel;
        private System.Windows.Forms.Button manageProductsButton;
        private System.Windows.Forms.Button manageTablesButton;
        private System.Windows.Forms.Button workingMenuButton;
        private System.Windows.Forms.Button quitMainMenubutton;
        private System.Windows.Forms.Button sallesControlButton;
    }
}