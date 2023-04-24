namespace Assignment_4___Indiepalooza
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BookingGroupBox = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DoorCostPromptLabel = new System.Windows.Forms.Label();
            this.VenuePromptLabel = new System.Windows.Forms.Label();
            this.TicketCostPromptLabel = new System.Windows.Forms.Label();
            this.BandPromptLabel = new System.Windows.Forms.Label();
            this.TransactionNumberPromptLabel = new System.Windows.Forms.Label();
            this.NumberTicketsPromptLabel = new System.Windows.Forms.Label();
            this.TotalCostPromptLabel = new System.Windows.Forms.Label();
            this.TelephonePromptLabel = new System.Windows.Forms.Label();
            this.EmailPromptLabel = new System.Windows.Forms.Label();
            this.NamePromptLabel = new System.Windows.Forms.Label();
            this.TransactionNumberLabel = new System.Windows.Forms.Label();
            this.TelephoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.EmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.Outputlabel = new System.Windows.Forms.Label();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.NumberTicketsTextBox = new System.Windows.Forms.TextBox();
            this.VenuesListBox = new System.Windows.Forms.ListBox();
            this.BandsListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SummaryViewButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.SearchByDateRadioButton = new System.Windows.Forms.RadioButton();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.SummaryListBox = new System.Windows.Forms.ListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.EmailRadioButton = new System.Windows.Forms.RadioButton();
            this.TransactionNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.CheckoutPromptLabel = new System.Windows.Forms.Label();
            this.BookingGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BookingGroupBox
            // 
            this.BookingGroupBox.Controls.Add(this.CheckoutPromptLabel);
            this.BookingGroupBox.Controls.Add(this.ExitButton);
            this.BookingGroupBox.Controls.Add(this.DoorCostPromptLabel);
            this.BookingGroupBox.Controls.Add(this.VenuePromptLabel);
            this.BookingGroupBox.Controls.Add(this.TicketCostPromptLabel);
            this.BookingGroupBox.Controls.Add(this.BandPromptLabel);
            this.BookingGroupBox.Controls.Add(this.TransactionNumberPromptLabel);
            this.BookingGroupBox.Controls.Add(this.NumberTicketsPromptLabel);
            this.BookingGroupBox.Controls.Add(this.TotalCostPromptLabel);
            this.BookingGroupBox.Controls.Add(this.TelephonePromptLabel);
            this.BookingGroupBox.Controls.Add(this.EmailPromptLabel);
            this.BookingGroupBox.Controls.Add(this.NamePromptLabel);
            this.BookingGroupBox.Controls.Add(this.TransactionNumberLabel);
            this.BookingGroupBox.Controls.Add(this.TelephoneNumberTextBox);
            this.BookingGroupBox.Controls.Add(this.EmailAddressTextBox);
            this.BookingGroupBox.Controls.Add(this.FullNameTextBox);
            this.BookingGroupBox.Controls.Add(this.ClearButton);
            this.BookingGroupBox.Controls.Add(this.BookButton);
            this.BookingGroupBox.Controls.Add(this.Outputlabel);
            this.BookingGroupBox.Controls.Add(this.DisplayButton);
            this.BookingGroupBox.Controls.Add(this.NumberTicketsTextBox);
            this.BookingGroupBox.Controls.Add(this.VenuesListBox);
            this.BookingGroupBox.Controls.Add(this.BandsListBox);
            this.BookingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingGroupBox.Location = new System.Drawing.Point(0, 0);
            this.BookingGroupBox.Name = "BookingGroupBox";
            this.BookingGroupBox.Size = new System.Drawing.Size(949, 385);
            this.BookingGroupBox.TabIndex = 0;
            this.BookingGroupBox.TabStop = false;
            this.BookingGroupBox.Text = "Please select a band and a venue";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(797, 306);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(114, 55);
            this.ExitButton.TabIndex = 21;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DoorCostPromptLabel
            // 
            this.DoorCostPromptLabel.AutoSize = true;
            this.DoorCostPromptLabel.Location = new System.Drawing.Point(442, 22);
            this.DoorCostPromptLabel.Name = "DoorCostPromptLabel";
            this.DoorCostPromptLabel.Size = new System.Drawing.Size(107, 20);
            this.DoorCostPromptLabel.TabIndex = 20;
            this.DoorCostPromptLabel.Text = "Cover charge:";
            // 
            // VenuePromptLabel
            // 
            this.VenuePromptLabel.AutoSize = true;
            this.VenuePromptLabel.Location = new System.Drawing.Point(256, 22);
            this.VenuePromptLabel.Name = "VenuePromptLabel";
            this.VenuePromptLabel.Size = new System.Drawing.Size(60, 20);
            this.VenuePromptLabel.TabIndex = 19;
            this.VenuePromptLabel.Text = "Venue:";
            // 
            // TicketCostPromptLabel
            // 
            this.TicketCostPromptLabel.AutoSize = true;
            this.TicketCostPromptLabel.Location = new System.Drawing.Point(124, 31);
            this.TicketCostPromptLabel.Name = "TicketCostPromptLabel";
            this.TicketCostPromptLabel.Size = new System.Drawing.Size(93, 20);
            this.TicketCostPromptLabel.TabIndex = 18;
            this.TicketCostPromptLabel.Text = "Ticket price:";
            // 
            // BandPromptLabel
            // 
            this.BandPromptLabel.AutoSize = true;
            this.BandPromptLabel.Location = new System.Drawing.Point(12, 31);
            this.BandPromptLabel.Name = "BandPromptLabel";
            this.BandPromptLabel.Size = new System.Drawing.Size(51, 20);
            this.BandPromptLabel.TabIndex = 17;
            this.BandPromptLabel.Text = "Band:";
            // 
            // TransactionNumberPromptLabel
            // 
            this.TransactionNumberPromptLabel.AutoSize = true;
            this.TransactionNumberPromptLabel.Location = new System.Drawing.Point(566, 213);
            this.TransactionNumberPromptLabel.Name = "TransactionNumberPromptLabel";
            this.TransactionNumberPromptLabel.Size = new System.Drawing.Size(156, 20);
            this.TransactionNumberPromptLabel.TabIndex = 16;
            this.TransactionNumberPromptLabel.Text = "Transaction Number:";
            // 
            // NumberTicketsPromptLabel
            // 
            this.NumberTicketsPromptLabel.AutoSize = true;
            this.NumberTicketsPromptLabel.Location = new System.Drawing.Point(57, 210);
            this.NumberTicketsPromptLabel.Name = "NumberTicketsPromptLabel";
            this.NumberTicketsPromptLabel.Size = new System.Drawing.Size(141, 20);
            this.NumberTicketsPromptLabel.TabIndex = 15;
            this.NumberTicketsPromptLabel.Text = "Number of Tickets:";
            // 
            // TotalCostPromptLabel
            // 
            this.TotalCostPromptLabel.AutoSize = true;
            this.TotalCostPromptLabel.Location = new System.Drawing.Point(638, 266);
            this.TotalCostPromptLabel.Name = "TotalCostPromptLabel";
            this.TotalCostPromptLabel.Size = new System.Drawing.Size(85, 20);
            this.TotalCostPromptLabel.TabIndex = 14;
            this.TotalCostPromptLabel.Text = "Total Cost:";
            // 
            // TelephonePromptLabel
            // 
            this.TelephonePromptLabel.AutoSize = true;
            this.TelephonePromptLabel.Location = new System.Drawing.Point(574, 163);
            this.TelephonePromptLabel.Name = "TelephonePromptLabel";
            this.TelephonePromptLabel.Size = new System.Drawing.Size(148, 20);
            this.TelephonePromptLabel.TabIndex = 13;
            this.TelephonePromptLabel.Text = "Telephone Number:";
            // 
            // EmailPromptLabel
            // 
            this.EmailPromptLabel.AutoSize = true;
            this.EmailPromptLabel.Location = new System.Drawing.Point(670, 122);
            this.EmailPromptLabel.Name = "EmailPromptLabel";
            this.EmailPromptLabel.Size = new System.Drawing.Size(52, 20);
            this.EmailPromptLabel.TabIndex = 12;
            this.EmailPromptLabel.Text = "Email:";
            // 
            // NamePromptLabel
            // 
            this.NamePromptLabel.AutoSize = true;
            this.NamePromptLabel.Location = new System.Drawing.Point(638, 74);
            this.NamePromptLabel.Name = "NamePromptLabel";
            this.NamePromptLabel.Size = new System.Drawing.Size(84, 20);
            this.NamePromptLabel.TabIndex = 11;
            this.NamePromptLabel.Text = "Full Name:";
            // 
            // TransactionNumberLabel
            // 
            this.TransactionNumberLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TransactionNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransactionNumberLabel.Location = new System.Drawing.Point(728, 210);
            this.TransactionNumberLabel.Name = "TransactionNumberLabel";
            this.TransactionNumberLabel.Size = new System.Drawing.Size(203, 26);
            this.TransactionNumberLabel.TabIndex = 10;
            this.TransactionNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelephoneNumberTextBox
            // 
            this.TelephoneNumberTextBox.Location = new System.Drawing.Point(728, 160);
            this.TelephoneNumberTextBox.Name = "TelephoneNumberTextBox";
            this.TelephoneNumberTextBox.Size = new System.Drawing.Size(203, 26);
            this.TelephoneNumberTextBox.TabIndex = 9;
            // 
            // EmailAddressTextBox
            // 
            this.EmailAddressTextBox.Location = new System.Drawing.Point(728, 116);
            this.EmailAddressTextBox.Name = "EmailAddressTextBox";
            this.EmailAddressTextBox.Size = new System.Drawing.Size(203, 26);
            this.EmailAddressTextBox.TabIndex = 8;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(728, 74);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(203, 26);
            this.FullNameTextBox.TabIndex = 7;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(156, 297);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(114, 55);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.Clear_Click);
            // 
            // BookButton
            // 
            this.BookButton.Enabled = false;
            this.BookButton.Location = new System.Drawing.Point(642, 306);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(114, 55);
            this.BookButton.TabIndex = 5;
            this.BookButton.Text = "&Checkout";
            this.BookButton.UseVisualStyleBackColor = true;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // Outputlabel
            // 
            this.Outputlabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Outputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Outputlabel.Location = new System.Drawing.Point(729, 263);
            this.Outputlabel.Name = "Outputlabel";
            this.Outputlabel.Size = new System.Drawing.Size(202, 26);
            this.Outputlabel.TabIndex = 4;
            this.Outputlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(12, 297);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(114, 55);
            this.DisplayButton.TabIndex = 3;
            this.DisplayButton.Text = "&Add to Order";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // NumberTicketsTextBox
            // 
            this.NumberTicketsTextBox.Location = new System.Drawing.Point(79, 247);
            this.NumberTicketsTextBox.Name = "NumberTicketsTextBox";
            this.NumberTicketsTextBox.Size = new System.Drawing.Size(100, 26);
            this.NumberTicketsTextBox.TabIndex = 2;
            // 
            // VenuesListBox
            // 
            this.VenuesListBox.FormattingEnabled = true;
            this.VenuesListBox.ItemHeight = 20;
            this.VenuesListBox.Location = new System.Drawing.Point(260, 45);
            this.VenuesListBox.Name = "VenuesListBox";
            this.VenuesListBox.Size = new System.Drawing.Size(289, 244);
            this.VenuesListBox.TabIndex = 1;
            // 
            // BandsListBox
            // 
            this.BandsListBox.FormattingEnabled = true;
            this.BandsListBox.ItemHeight = 20;
            this.BandsListBox.Location = new System.Drawing.Point(12, 63);
            this.BandsListBox.Name = "BandsListBox";
            this.BandsListBox.Size = new System.Drawing.Size(242, 144);
            this.BandsListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SummaryViewButton);
            this.groupBox1.Controls.Add(this.LogoPictureBox);
            this.groupBox1.Controls.Add(this.SearchByDateRadioButton);
            this.groupBox1.Controls.Add(this.SummaryButton);
            this.groupBox1.Controls.Add(this.SummaryListBox);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.EmailRadioButton);
            this.groupBox1.Controls.Add(this.TransactionNumberRadioButton);
            this.groupBox1.Controls.Add(this.SearchTextBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Transactions:";
            // 
            // SummaryViewButton
            // 
            this.SummaryViewButton.Location = new System.Drawing.Point(688, 221);
            this.SummaryViewButton.Name = "SummaryViewButton";
            this.SummaryViewButton.Size = new System.Drawing.Size(161, 72);
            this.SummaryViewButton.TabIndex = 15;
            this.SummaryViewButton.Text = "&Stock and Sales Summary View";
            this.SummaryViewButton.UseVisualStyleBackColor = true;
            this.SummaryViewButton.Click += new System.EventHandler(this.SummaryViewButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Assignment_4___Indiepalooza.Properties.Resources._562px_Rough_Trade_Records_logo_svg;
            this.LogoPictureBox.Location = new System.Drawing.Point(632, 25);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(269, 190);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 14;
            this.LogoPictureBox.TabStop = false;
            // 
            // SearchByDateRadioButton
            // 
            this.SearchByDateRadioButton.AutoSize = true;
            this.SearchByDateRadioButton.Location = new System.Drawing.Point(6, 72);
            this.SearchByDateRadioButton.Name = "SearchByDateRadioButton";
            this.SearchByDateRadioButton.Size = new System.Drawing.Size(145, 24);
            this.SearchByDateRadioButton.TabIndex = 13;
            this.SearchByDateRadioButton.TabStop = true;
            this.SearchByDateRadioButton.Text = "Search by date:";
            this.SearchByDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(146, 176);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(114, 55);
            this.SummaryButton.TabIndex = 12;
            this.SummaryButton.Text = "&Daily Summary";
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // SummaryListBox
            // 
            this.SummaryListBox.FormattingEnabled = true;
            this.SummaryListBox.ItemHeight = 20;
            this.SummaryListBox.Location = new System.Drawing.Point(301, 38);
            this.SummaryListBox.Name = "SummaryListBox";
            this.SummaryListBox.Size = new System.Drawing.Size(275, 204);
            this.SummaryListBox.TabIndex = 11;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(6, 176);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(114, 55);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "&Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EmailRadioButton
            // 
            this.EmailRadioButton.AutoSize = true;
            this.EmailRadioButton.Location = new System.Drawing.Point(6, 102);
            this.EmailRadioButton.Name = "EmailRadioButton";
            this.EmailRadioButton.Size = new System.Drawing.Size(215, 24);
            this.EmailRadioButton.TabIndex = 9;
            this.EmailRadioButton.Text = "Search by Email Address:";
            this.EmailRadioButton.UseVisualStyleBackColor = true;
            // 
            // TransactionNumberRadioButton
            // 
            this.TransactionNumberRadioButton.AutoSize = true;
            this.TransactionNumberRadioButton.Checked = true;
            this.TransactionNumberRadioButton.Location = new System.Drawing.Point(6, 42);
            this.TransactionNumberRadioButton.Name = "TransactionNumberRadioButton";
            this.TransactionNumberRadioButton.Size = new System.Drawing.Size(256, 24);
            this.TransactionNumberRadioButton.TabIndex = 8;
            this.TransactionNumberRadioButton.TabStop = true;
            this.TransactionNumberRadioButton.Text = "Search by Transaction Number:";
            this.TransactionNumberRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(6, 132);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(163, 26);
            this.SearchTextBox.TabIndex = 7;
            // 
            // CheckoutPromptLabel
            // 
            this.CheckoutPromptLabel.AutoSize = true;
            this.CheckoutPromptLabel.Location = new System.Drawing.Point(601, 9);
            this.CheckoutPromptLabel.Name = "CheckoutPromptLabel";
            this.CheckoutPromptLabel.Size = new System.Drawing.Size(342, 20);
            this.CheckoutPromptLabel.TabIndex = 22;
            this.CheckoutPromptLabel.Text = "Please enter your details to complete checkout:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 776);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BookingGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rough Trade Bookings";
            this.BookingGroupBox.ResumeLayout(false);
            this.BookingGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BookingGroupBox;
        private System.Windows.Forms.ListBox VenuesListBox;
        private System.Windows.Forms.ListBox BandsListBox;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.TextBox NumberTicketsTextBox;
        private System.Windows.Forms.Label Outputlabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.TextBox TelephoneNumberTextBox;
        private System.Windows.Forms.TextBox EmailAddressTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label TransactionNumberLabel;
        private System.Windows.Forms.Label TransactionNumberPromptLabel;
        private System.Windows.Forms.Label NumberTicketsPromptLabel;
        private System.Windows.Forms.Label TotalCostPromptLabel;
        private System.Windows.Forms.Label TelephonePromptLabel;
        private System.Windows.Forms.Label EmailPromptLabel;
        private System.Windows.Forms.Label NamePromptLabel;
        private System.Windows.Forms.Label DoorCostPromptLabel;
        private System.Windows.Forms.Label VenuePromptLabel;
        private System.Windows.Forms.Label TicketCostPromptLabel;
        private System.Windows.Forms.Label BandPromptLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox SummaryListBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RadioButton EmailRadioButton;
        private System.Windows.Forms.RadioButton TransactionNumberRadioButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.RadioButton SearchByDateRadioButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button SummaryViewButton;
        private System.Windows.Forms.Label CheckoutPromptLabel;
    }
}

