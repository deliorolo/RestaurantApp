namespace RestaurantApplication
{
    partial class PayTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayTotal));
            this.totalGroupBox = new System.Windows.Forms.GroupBox();
            this.paymentButton = new System.Windows.Forms.Button();
            this.totalValueBox = new System.Windows.Forms.TextBox();
            this.totalListBox = new System.Windows.Forms.ListBox();
            this.quitPayTotalButton = new System.Windows.Forms.Button();
            this.totalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalGroupBox
            // 
            this.totalGroupBox.Controls.Add(this.paymentButton);
            this.totalGroupBox.Controls.Add(this.totalValueBox);
            this.totalGroupBox.Controls.Add(this.totalListBox);
            this.totalGroupBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.totalGroupBox.Location = new System.Drawing.Point(12, 12);
            this.totalGroupBox.Name = "totalGroupBox";
            this.totalGroupBox.Size = new System.Drawing.Size(416, 479);
            this.totalGroupBox.TabIndex = 2;
            this.totalGroupBox.TabStop = false;
            this.totalGroupBox.Text = "Total";
            // 
            // paymentButton
            // 
            this.paymentButton.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.paymentButton.Location = new System.Drawing.Point(193, 422);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(212, 51);
            this.paymentButton.TabIndex = 12;
            this.paymentButton.Text = "Confirm Payment";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // totalValueBox
            // 
            this.totalValueBox.Location = new System.Drawing.Point(247, 386);
            this.totalValueBox.Name = "totalValueBox";
            this.totalValueBox.Size = new System.Drawing.Size(158, 29);
            this.totalValueBox.TabIndex = 11;
            this.totalValueBox.Text = "0,00 €";
            this.totalValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalListBox
            // 
            this.totalListBox.FormattingEnabled = true;
            this.totalListBox.ItemHeight = 23;
            this.totalListBox.Location = new System.Drawing.Point(10, 31);
            this.totalListBox.Name = "totalListBox";
            this.totalListBox.Size = new System.Drawing.Size(395, 349);
            this.totalListBox.TabIndex = 10;
            // 
            // quitPayTotalButton
            // 
            this.quitPayTotalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitPayTotalButton.ForeColor = System.Drawing.Color.DarkRed;
            this.quitPayTotalButton.Location = new System.Drawing.Point(323, 512);
            this.quitPayTotalButton.Name = "quitPayTotalButton";
            this.quitPayTotalButton.Size = new System.Drawing.Size(105, 47);
            this.quitPayTotalButton.TabIndex = 7;
            this.quitPayTotalButton.Text = "Quit";
            this.quitPayTotalButton.UseVisualStyleBackColor = true;
            this.quitPayTotalButton.Click += new System.EventHandler(this.quitPayTotalButton_Click);
            // 
            // PayTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 571);
            this.Controls.Add(this.quitPayTotalButton);
            this.Controls.Add(this.totalGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PayTotal";
            this.Text = "Pay Total";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PayTotal_FormClosed);
            this.totalGroupBox.ResumeLayout(false);
            this.totalGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox totalGroupBox;
        private System.Windows.Forms.TextBox totalValueBox;
        private System.Windows.Forms.ListBox totalListBox;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.Button quitPayTotalButton;
    }
}