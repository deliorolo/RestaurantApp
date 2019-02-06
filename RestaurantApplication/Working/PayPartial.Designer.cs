namespace RestaurantApplication
{
    partial class PayPartial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayPartial));
            this.unpaiGroupBox = new System.Windows.Forms.GroupBox();
            this.unpaidValueBox = new System.Windows.Forms.TextBox();
            this.unpaidListBox = new System.Windows.Forms.ListBox();
            this.partialgroupBox = new System.Windows.Forms.GroupBox();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.partialValueBox = new System.Windows.Forms.TextBox();
            this.partialListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.quitPayPartialButton = new System.Windows.Forms.Button();
            this.unpaiGroupBox.SuspendLayout();
            this.partialgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // unpaiGroupBox
            // 
            this.unpaiGroupBox.Controls.Add(this.unpaidValueBox);
            this.unpaiGroupBox.Controls.Add(this.unpaidListBox);
            this.unpaiGroupBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unpaiGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.unpaiGroupBox.Location = new System.Drawing.Point(12, 12);
            this.unpaiGroupBox.Name = "unpaiGroupBox";
            this.unpaiGroupBox.Size = new System.Drawing.Size(416, 479);
            this.unpaiGroupBox.TabIndex = 3;
            this.unpaiGroupBox.TabStop = false;
            this.unpaiGroupBox.Text = "Unpaid";
            // 
            // unpaidValueBox
            // 
            this.unpaidValueBox.Location = new System.Drawing.Point(247, 386);
            this.unpaidValueBox.Name = "unpaidValueBox";
            this.unpaidValueBox.Size = new System.Drawing.Size(158, 29);
            this.unpaidValueBox.TabIndex = 11;
            this.unpaidValueBox.Text = "0,00 €";
            this.unpaidValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // unpaidListBox
            // 
            this.unpaidListBox.FormattingEnabled = true;
            this.unpaidListBox.ItemHeight = 23;
            this.unpaidListBox.Location = new System.Drawing.Point(10, 31);
            this.unpaidListBox.Name = "unpaidListBox";
            this.unpaidListBox.Size = new System.Drawing.Size(395, 349);
            this.unpaidListBox.TabIndex = 10;
            // 
            // partialgroupBox
            // 
            this.partialgroupBox.Controls.Add(this.PaymentButton);
            this.partialgroupBox.Controls.Add(this.partialValueBox);
            this.partialgroupBox.Controls.Add(this.partialListBox);
            this.partialgroupBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partialgroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.partialgroupBox.Location = new System.Drawing.Point(500, 12);
            this.partialgroupBox.Name = "partialgroupBox";
            this.partialgroupBox.Size = new System.Drawing.Size(416, 479);
            this.partialgroupBox.TabIndex = 4;
            this.partialgroupBox.TabStop = false;
            this.partialgroupBox.Text = "Partial Payment";
            // 
            // PaymentButton
            // 
            this.PaymentButton.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PaymentButton.Location = new System.Drawing.Point(193, 422);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(212, 51);
            this.PaymentButton.TabIndex = 12;
            this.PaymentButton.Text = "Confirm Payment";
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // partialValueBox
            // 
            this.partialValueBox.Location = new System.Drawing.Point(247, 386);
            this.partialValueBox.Name = "partialValueBox";
            this.partialValueBox.Size = new System.Drawing.Size(158, 29);
            this.partialValueBox.TabIndex = 11;
            this.partialValueBox.Text = "0,00 €";
            this.partialValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // partialListBox
            // 
            this.partialListBox.FormattingEnabled = true;
            this.partialListBox.ItemHeight = 23;
            this.partialListBox.Location = new System.Drawing.Point(10, 31);
            this.partialListBox.Name = "partialListBox";
            this.partialListBox.Size = new System.Drawing.Size(395, 349);
            this.partialListBox.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addButton.Location = new System.Drawing.Point(434, 105);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(60, 55);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "»";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeButton.Location = new System.Drawing.Point(434, 242);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(60, 55);
            this.removeButton.TabIndex = 14;
            this.removeButton.Text = "«";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // quitPayPartialButton
            // 
            this.quitPayPartialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitPayPartialButton.ForeColor = System.Drawing.Color.DarkRed;
            this.quitPayPartialButton.Location = new System.Drawing.Point(811, 510);
            this.quitPayPartialButton.Name = "quitPayPartialButton";
            this.quitPayPartialButton.Size = new System.Drawing.Size(105, 47);
            this.quitPayPartialButton.TabIndex = 15;
            this.quitPayPartialButton.Text = "Quit";
            this.quitPayPartialButton.UseVisualStyleBackColor = true;
            this.quitPayPartialButton.Click += new System.EventHandler(this.quitPayPartialButton_Click);
            // 
            // PayPartial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 570);
            this.Controls.Add(this.quitPayPartialButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.partialgroupBox);
            this.Controls.Add(this.unpaiGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PayPartial";
            this.Text = "PayPartial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PayPartial_FormClosed);
            this.unpaiGroupBox.ResumeLayout(false);
            this.unpaiGroupBox.PerformLayout();
            this.partialgroupBox.ResumeLayout(false);
            this.partialgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox unpaiGroupBox;
        private System.Windows.Forms.TextBox unpaidValueBox;
        private System.Windows.Forms.ListBox unpaidListBox;
        private System.Windows.Forms.GroupBox partialgroupBox;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.TextBox partialValueBox;
        private System.Windows.Forms.ListBox partialListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button quitPayPartialButton;
    }
}