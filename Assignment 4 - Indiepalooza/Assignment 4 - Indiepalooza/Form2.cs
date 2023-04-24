using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4___Indiepalooza
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void DisplaySummary (string [] BandsList, string[] VenuesList, int[,] StockLevels, int [,] SalesLevels)
        {
            string[,] FormattedStock = new string[BandsList.Length, VenuesList.Length];
            string[,] FormattedSales = new string[BandsList.Length, VenuesList.Length];
            //creating two string arrays, one is a formatted string
            // to display the stock remaining for individual gigs
            //the other shows the tickets sold for each gig so far

            for (int RowCounter = 0; RowCounter < BandsList.Length; RowCounter++)
            {
                for(int ColumnCounter =0; ColumnCounter < VenuesList.Length; ColumnCounter ++)
                {
                    FormattedStock[RowCounter, ColumnCounter] = BandsList[RowCounter] + " : "
                        + VenuesList[ColumnCounter] + " : " 
                        + StockLevels[RowCounter, ColumnCounter].ToString();
                }
            }
            //this creates a nice formatted stock string
            
                for (int Row = 0; Row < StockLevels.GetLength(0); Row++)
                {
                    for (int Col = 0; Col < StockLevels.GetLength(1); Col++)
                    {
                        StockListBox.Items.Add(FormattedStock[Row, Col]);
                    }

                }
                //this adds it to list box
            
            for (int RowCounter = 0; RowCounter < BandsList.Length; RowCounter++)
                {
                    for (int ColumnCounter = 0; ColumnCounter < VenuesList.Length; ColumnCounter++)
                    {
                        FormattedSales[RowCounter, ColumnCounter] = BandsList[RowCounter] + " : "
                            + VenuesList[ColumnCounter] + " : "
                            + SalesLevels[RowCounter, ColumnCounter].ToString();
                    }
                }
            //this does the same for sales

            for (int Row = 0; Row < StockLevels.GetLength(0); Row++)
            {
                for (int Col = 0; Col < StockLevels.GetLength(1); Col++)
                {
                    SalesListBox.Items.Add(FormattedSales[Row, Col]);
                }

            }
            // and again adds it to list box

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            StockListBox.Visible = false;
            SalesListBox.Visible = true;
            TicketsLabel.Visible = false;
            TicketsSoldLabel.Visible = true;
            //toggle visibility between stock and sales list box

        }

        private void SwitchToStockButton_Click(object sender, EventArgs e)
        {
            StockListBox.Visible = true;
            SalesListBox.Visible = false;
            TicketsLabel.Visible = true;
            TicketsSoldLabel.Visible = false;
            //toggle visibility between stock and sales list box
        }
    }
}
