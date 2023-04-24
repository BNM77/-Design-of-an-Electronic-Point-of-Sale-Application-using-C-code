namespace Assignment_4___Indiepalooza
{
    partial class SummaryForm
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
            this.StockListBox = new System.Windows.Forms.ListBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BandLabel = new System.Windows.Forms.Label();
            this.VenueLabel = new System.Windows.Forms.Label();
            this.TicketsLabel = new System.Windows.Forms.Label();
            this.SalesButton = new System.Windows.Forms.Button();
            this.SalesListBox = new System.Windows.Forms.ListBox();
            this.SwitchToStockButton = new System.Windows.Forms.Button();
            this.TicketsSoldLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StockListBox
            // 
            this.StockListBox.FormattingEnabled = true;
            this.StockListBox.ItemHeight = 20;
            this.StockListBox.Location = new System.Drawing.Point(64, 92);
            this.StockListBox.Name = "StockListBox";
            this.StockListBox.Size = new System.Drawing.Size(461, 344);
            this.StockListBox.TabIndex = 2;
            this.StockListBox.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(353, 517);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(128, 54);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "&Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BandLabel
            // 
            this.BandLabel.AutoSize = true;
            this.BandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BandLabel.Location = new System.Drawing.Point(60, 58);
            this.BandLabel.Name = "BandLabel";
            this.BandLabel.Size = new System.Drawing.Size(62, 22);
            this.BandLabel.TabIndex = 4;
            this.BandLabel.Text = "Band:";
            // 
            // VenueLabel
            // 
            this.VenueLabel.AutoSize = true;
            this.VenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenueLabel.Location = new System.Drawing.Point(209, 58);
            this.VenueLabel.Name = "VenueLabel";
            this.VenueLabel.Size = new System.Drawing.Size(73, 22);
            this.VenueLabel.TabIndex = 5;
            this.VenueLabel.Text = "Venue:";
            // 
            // TicketsLabel
            // 
            this.TicketsLabel.AutoSize = true;
            this.TicketsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketsLabel.Location = new System.Drawing.Point(324, 58);
            this.TicketsLabel.Name = "TicketsLabel";
            this.TicketsLabel.Size = new System.Drawing.Size(174, 22);
            this.TicketsLabel.TabIndex = 6;
            this.TicketsLabel.Text = "Tickets remaining:";
            // 
            // SalesButton
            // 
            this.SalesButton.Location = new System.Drawing.Point(64, 517);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(128, 54);
            this.SalesButton.TabIndex = 7;
            this.SalesButton.Text = "&Switch to Sales View";
            this.SalesButton.UseVisualStyleBackColor = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // SalesListBox
            // 
            this.SalesListBox.FormattingEnabled = true;
            this.SalesListBox.ItemHeight = 20;
            this.SalesListBox.Location = new System.Drawing.Point(64, 92);
            this.SalesListBox.Name = "SalesListBox";
            this.SalesListBox.Size = new System.Drawing.Size(461, 344);
            this.SalesListBox.TabIndex = 8;
            this.SalesListBox.Visible = false;
            // 
            // SwitchToStockButton
            // 
            this.SwitchToStockButton.Location = new System.Drawing.Point(213, 517);
            this.SwitchToStockButton.Name = "SwitchToStockButton";
            this.SwitchToStockButton.Size = new System.Drawing.Size(128, 54);
            this.SwitchToStockButton.TabIndex = 9;
            this.SwitchToStockButton.Text = "&Switch to Stock View";
            this.SwitchToStockButton.UseVisualStyleBackColor = true;
            this.SwitchToStockButton.Click += new System.EventHandler(this.SwitchToStockButton_Click);
            // 
            // TicketsSoldLabel
            // 
            this.TicketsSoldLabel.AutoSize = true;
            this.TicketsSoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketsSoldLabel.Location = new System.Drawing.Point(324, 58);
            this.TicketsSoldLabel.Name = "TicketsSoldLabel";
            this.TicketsSoldLabel.Size = new System.Drawing.Size(127, 22);
            this.TicketsSoldLabel.TabIndex = 10;
            this.TicketsSoldLabel.Text = "Tickets Sold:";
            this.TicketsSoldLabel.Visible = false;
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 643);
            this.Controls.Add(this.TicketsSoldLabel);
            this.Controls.Add(this.SwitchToStockButton);
            this.Controls.Add(this.SalesListBox);
            this.Controls.Add(this.SalesButton);
            this.Controls.Add(this.TicketsLabel);
            this.Controls.Add(this.VenueLabel);
            this.Controls.Add(this.BandLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StockListBox);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox StockListBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label BandLabel;
        private System.Windows.Forms.Label VenueLabel;
        private System.Windows.Forms.Label TicketsLabel;
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.ListBox SalesListBox;
        private System.Windows.Forms.Button SwitchToStockButton;
        private System.Windows.Forms.Label TicketsSoldLabel;
    }
}