using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace Assignment_4___Indiepalooza
{
    public partial class Form1 : Form
    {
        readonly static string[] BANDS = { "The Stone Roses", "The Smiths", "Dinosaur Jr.", "The Replacements",
        "Sonic Youth", "New Order"};
        //string array to hold the bands
        readonly static decimal[] BANDPRICES = {20.75M, 30.60M, 24.50M, 17.35M, 12.95M, 35.15M };
        //decimal array to hold individual band prices to 
        readonly static decimal[] VENUEDOORFEES = {7.35M, 6.55M, 7.30M, 6.65M, 6.05M, 6.20M,
        8.35M, 8.75M, 8.15M, 9.50M, 9.25M};
        //decimal array to hold venue door fees
        readonly static string[] VENUES = {"Whelans Bar, DUBLIN", "Roisin Dubh, GALWAY",
        "Crane Lane Theatre, CORK", "Dolan's Pub, LIMERICK", "Empire Music Hall, BELFAST",
        "The Glassworks, DERRY", "The Boardwalk, SHEFFIELD", "Hacienda, MANCHESTER",
        "The Lousiana, BRISTOL", "CBGB's, NEW TORK CITY", "9:30 Club, WASHINGTON"};
        //string array for the venues
        int NumberTicketsIndividualTrans, IndividualStock, TransactionNumber, ClosingStock;
        //these varaiables are used to calculate transactions
        int UniqueProducts = 0;
        //this is used to track the amount of gigs a user books
        const int ROWS = 6;
        const int COLUMNS = 11;
        //these are used to keep track of 2d arrays
        const string TRANSACTIONS_FILE = "Long Form Transactions.txt";
        const string STOCKLEVELS_FILE = "StockLevels.txt";
        //used as string varaibles for the files we will be using
        string Band, Venue, IndividualGigBooking, TelephoneNumber;
        //used for customer's information at checkout
        decimal IndividualGigCost, OverallBookingCost;
        //used at checkout
        char Comma = ',';
        //this will be the seperator in the transx file
        string Error;
        //used in the writing and reading stock methods
        Boolean UniqueNumber = false;
        // to ensure it is unique
        DateTime CurrentDateTime = DateTime.Now;
        //to process the date
        Random Rand = new Random();
        bool SearchMatch = false;
        //used in search and summary
        int OverallIndividualBooking;
        //used to track individual booking costs
        int[,] STOCKLEVELS = new int[BANDS.Length, VENUES.Length];
        int[,] SALES = new int[BANDS.Length, VENUES.Length];
        //this is the int array that will hold stock levels
        List<string> ResultsList = new List<string>();
        //this is the list we will use to get search results
        readonly static decimal[,] TOTALGIGPRICES = { 
                                  {28.10m, 27.30m, 28.05m, 27.40m, 26.80m, 26.95m, 29.10m, 29.50m, 28.90m, 30.25m, 30.00m},
                                  {37.95m, 37.15m, 37.90m, 37.25m, 36.65m, 36.80m, 38.95m, 39.35m, 38.75m, 40.10m, 39.85m},
                                  {31.85m, 31.05m, 31.80m, 31.15m, 30.55m, 30.70m, 32.85m, 33.25m, 32.65m, 34.00m, 33.75m},
                                  {24.70m, 23.90m, 24.65m, 24.00m, 23.40m, 23.55m, 25.70m, 26.10m, 25.50m, 26.85m, 26.60m},
                                  {20.30m, 19.50m, 20.25m, 19.60m, 19.00m, 19.15m, 21.30m, 21.70m, 21.10m, 22.45m, 22.20m},
                                  {42.50m, 41.70m, 42.45m, 41.80m, 41.20m, 41.35m, 43.50m, 43.90m, 43.30m, 44.65m, 44.40m}
                                                       };
        //this is the 2d array holding prices for each individual gig. driven by user selection
        decimal DailyRevenue, DailyTransactionsAmount, DailyAverageTickets, DailyAverageTransactionValue;
        int DailyUniqueProducts, DailyOverallTicketSales, OverallNumberTickets;
        //this is used for the daily sales reports
        int RECORDLENGTH = 11;
        //used to read files correctly

        public Form1()
        {
            InitializeComponent();
            DateTime date = DateTime.Now;
            //this is used to get daily transactions firther down
            
            for (int i = 0; i < BANDS.Length; i++)
            {
                BandsListBox.Items.Add(BANDS[i] + "\t" + BANDPRICES[i]);
            }
            //adding our band array and their individual prices
            for (int i = 0; i < VENUES.Length; i++)
            {
                VenuesListBox.Items.Add(VENUES[i] + "\t" + VENUEDOORFEES[i]);
            }
            //adding our venues array and their individual door prices
            StreamWriter BandsFile;
            // Create the file and get a StreamWriter object.
            BandsFile = File.CreateText("BandPrices.txt");
            // Write the array's contents to the file.
            for (int index = 0; index < BANDPRICES.Length; index++)
            {
                BandsFile.WriteLine(BANDPRICES[index]);
            }
            // Close the file.
            BandsFile.Close();

            StreamWriter VenuesFile;
            // Create the file and get a StreamWriter object.
            VenuesFile = File.CreateText("VenueDoorPrices.txt");
            // Write the array's contents to the file.
            for (int index = 0; index < VENUEDOORFEES.Length; index++)
            {
                VenuesFile.WriteLine(VENUEDOORFEES[index]);
            }
            // Close the file.
            VenuesFile.Close();
            ReadStockLevels("StockLevels.txt", ref STOCKLEVELS, out Error, Comma);
            ReadSalesLevels("Sales.txt", ref SALES, out Error, Comma);
            //if we read stock amounts at load time then the StockLevels varaible will 
            //always be accurate



        }
        public bool ReadStockLevels (string InputFile, ref int [,] Records, out String ErrorMessage, char Seperator)
        {
            int Row = 0;
            StreamReader DataStream;
            string[] RecordStrings;
            //these are used to read stock levels, keep track of row, column etc
            try
            {
                using (DataStream = File.OpenText(InputFile))// input file will be transx file
                {
                    while (!DataStream.EndOfStream && Row < Records.Length)
                    {//using and while statemets to prevent error
                        RecordStrings = DataStream.ReadLine().Split(Seperator);
                        for(int Col = 0; Col < RecordStrings.Length; Col++)
                        {
                            Records[Row, Col] = int.Parse(RecordStrings[Col]);
                        }
                        Row++;
                        //The records varaiable will be passed into stocklevels by reference
                        //using a loop to assign values one by one
                    }
                }
                   
            }
            catch(Exception ex)
            {
                ErrorMessage = String.Format("Exception body:\n{0}", ex.Message);
                return false;
                //to catch file errors
                
            }
            ErrorMessage = "";
            return true;
            //if all is well, return true with no errors
            
            
            
            
        }
        
        private void SearchButton_Click(object sender, EventArgs e)
        {

            if (TransactionNumberRadioButton.Checked)
            {
                if (SearchTextBox.Text != "")
                {// don't need a blank text box
                    SummaryListBox.Items.Clear();
                    SearchMatch = false;
                    //resets the search at the top
                    try
                    {
                        StreamReader InputFile;
                        string SearchQuery = SearchTextBox.Text;

                        //variables to hold the values we want
                        InputFile = File.OpenText("Traxfile.txt");
                        Search(SearchQuery, "Traxfile.txt");
                        //the search method is launced
                        //if we have a search match, we get the ResultsList back
                        if (SearchMatch)
                        {
                            string Format = string.Join(",", ResultsList.ToArray());
                            string[] FullFormat = Format.Split(',');
                            //this is turning the results list into a string array 
                            //for ease of use. Split by the comma
                            for(int i = 0; i < FullFormat.Length; i++)
                            {
                                SummaryListBox.Items.Add(FullFormat[i]);
                                //add the split string to summary one by one
                            }
                            


                        }

                        if (!SearchMatch)
                        {//give the user a message if no results found
                            MessageBox.Show("Transaction Number not found", "No results",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InputFile.Close();
                        }
                       

                    }
                    catch
                    {
                        MessageBox.Show("Error reading data from file", "Data error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Search term is blank, please enter a " +
                        "transaction number in the space provided", "Empty search",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else if (EmailRadioButton.Checked)
            {
                if (SearchTextBox.Text != "")
                {// don't need a blank text box
                    SummaryListBox.Items.Clear();
                    SearchMatch = false;
                    //resets the search at the top
                    try
                    {
                        StreamReader InputFile;
                        string SearchQuery = SearchTextBox.Text;

                        //variables to hold the values we want
                        InputFile = File.OpenText("Traxfile.txt");
                        Search(SearchQuery, "Traxfile.txt");
                        //same as before, search method is called
                        //if we have a match, Results List is returned
                        //Split this into a string array and add to listbox
                        if (SearchMatch)
                        {
                            string Format = string.Join(",", ResultsList.ToArray());
                            string[] FullFormat = Format.Split(',');
                            for (int i = 0; i < FullFormat.Length; i++)
                            {
                                SummaryListBox.Items.Add(FullFormat[i]);
                            }

                        }

                        if (!SearchMatch)
                        {//give the user a message if no results found
                            MessageBox.Show("Email Address not found", "No results",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InputFile.Close();
                        }


                    }
                    catch
                    {
                        MessageBox.Show("Error reading data from file", "Data error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Search term is blank, please enter an " +
                        "email address in the space provided", "Empty search",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                if (SearchTextBox.Text != "")
                {// don't need a blank text box
                    SummaryListBox.Items.Clear();
                    SearchMatch = false;
                    //resets the search at the top
                    try
                    {
                        StreamReader InputFile;
                        string SearchQuery = SearchTextBox.Text;

                        //variables to hold the values we want
                        InputFile = File.OpenText("Traxfile.txt");
                        Search(SearchQuery, "Traxfile.txt");
                        //same as before, search method is called
                        //if we have a match, Results List is returned
                        //Split this into a string array and add to listbox
                        if (SearchMatch)
                        {
                            string Format = string.Join(",", ResultsList.ToArray());
                            string[] FullFormat = Format.Split(',');
                            for (int i = 0; i < FullFormat.Length; i++)
                            {
                                SummaryListBox.Items.Add(FullFormat[i]);
                            }


                        }

                        if (!SearchMatch)
                        {//give the user a message if no results found
                            MessageBox.Show("No transactions found on date specified", "No results",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InputFile.Close();
                        }


                    }
                    catch
                    {
                        MessageBox.Show("Error reading data from file", "Data error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Search term is blank, please enter a " +
                        "date in the space provided", "Empty search",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            try
            {
                SearchMatch = false;
                string SearchQuery = CurrentDateTime.ToString("d");
                //Its a daily summary to the search parameter is set to today automatically
                //search method is called
                DailyTransactionsAmount = 0;
                DailyUniqueProducts = 0;
                DailyOverallTicketSales = 0;
                DailyRevenue = 0;
                //initialising values as zero to avoid lingering values
                Search(SearchQuery, "Traxfile.txt");
                if (SearchMatch)
                {
                    string Format = string.Join(",", ResultsList.ToArray());
                    string[] FullFormat = Format.Split(',');
                    StreamWriter LogsFile;
                    LogsFile = File.CreateText("DailyTransactionsLog.txt");
                    //creating a rewritable daily log of transacations
                    //on current day
                    for (int j = 0; j < FullFormat.Length; j++)
                    {
                        LogsFile.WriteLine(FullFormat[j]);
                    }
                    LogsFile.Close();
                    SummaryListBox.Items.Clear();
                    for (int i = 0; i < FullFormat.Length; i++)
                    {
                        SummaryListBox.Items.Add(FullFormat[i]);
                        //adding all daily transactions to the listbox
                    }
                    
                }

                if (!SearchMatch)
                {//give the user a message if no results found
                    MessageBox.Show("No transactions so far today", "No results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch
            {
                MessageBox.Show("Error reading data from file", "Data error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                StreamReader InputFile;
                InputFile = File.OpenText("DailyTransactionsLog.txt");
                //we have crated a daily log of all transactions
                //this will now be easy to get values from readline
                //of daily log
                while (!InputFile.EndOfStream)
                {
                    for (int i = 0; i < RECORDLENGTH - 5; i++)
                    {
                        InputFile.ReadLine();
                        //these values are trashed immediately
                    }
                    DailyOverallTicketSales += int.Parse(InputFile.ReadLine());
                    InputFile.ReadLine();
                    DailyUniqueProducts += int.Parse(InputFile.ReadLine());
                    DailyRevenue += decimal.Parse(InputFile.ReadLine());
                    InputFile.ReadLine();
                    DailyTransactionsAmount++;
                    //daily values parsed from daily log

                }
            }
            catch
            {
                MessageBox.Show("Error reading data from file", "Data error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                //now we have calculated daily values
                //we create a daily sales log from those values
                DailyAverageTickets = (DailyOverallTicketSales / DailyTransactionsAmount);
                DailyAverageTransactionValue = (DailyRevenue / DailyTransactionsAmount);
                StreamWriter OutputFile;
                OutputFile = File.CreateText("DailySalesReport.txt");
                OutputFile.WriteLine(CurrentDateTime.ToString());
                OutputFile.WriteLine("Overall Daily Revenue:");
                OutputFile.WriteLine(DailyRevenue.ToString("c"));
                OutputFile.WriteLine("Daily Total Transactions Amount:");
                OutputFile.WriteLine(DailyTransactionsAmount.ToString());
                OutputFile.WriteLine("Amount of individual gigs booked:");
                OutputFile.WriteLine(DailyUniqueProducts.ToString());
                OutputFile.WriteLine("Daily amount of tickets sold:");
                OutputFile.WriteLine(DailyOverallTicketSales.ToString());
                OutputFile.WriteLine("Average amount of tickets sold per transaction:");
                OutputFile.WriteLine(DailyAverageTickets.ToString());
                OutputFile.WriteLine("Average total spend per transaction:");
                OutputFile.WriteLine(DailyAverageTransactionValue.ToString("c"));
                OutputFile.Close();
                MessageBox.Show("Daily Sales Report created in debug folder", "Report created",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error reading data from file", "Data error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //closes the form
        }

        private void SummaryViewButton_Click(object sender, EventArgs e)
        {
            SummaryForm MySummaryForm = new SummaryForm();
            MySummaryForm.DisplaySummary(BANDS, VENUES, STOCKLEVELS, SALES);
            MySummaryForm.ShowDialog();
            //this is calling my summary method in SummaryForm / Form 2
        }
        private void Search(string SearchString, string TransFile)
        {
            ResultsList.Clear();
            //clear old searches
            string[] ReadText = File.ReadAllLines(TransFile);
            foreach (string Str in ReadText)
            {
                if(Str.Contains(SearchString))
                {
                    ResultsList.Add(Str);
                    SearchMatch = true;
                    //create a long list with all matches
                    //we will format this later
                }
            }
        }

        public bool WriteStockLevels (string InputFile, ref int [,] Records, out string ErrorMessage, char Seperator)
        {
            StreamWriter DataStream;
            string[] RecordLines = new string[Records.GetLength(1)];
            //after a duccessful transaction, we need to rewrite stock levels
            //we will use a method using streamwriter to do this
                try
            {
                using (DataStream = File.CreateText(InputFile))
                {//input file will be stock levels
                    for (int Row = 0; Row<Records.GetLength(0); Row++ )
                    {
                        for(int Col = 0;Col <Records.GetLength(1); Col ++)
                        {
                            RecordLines[Col] = Records[Row, Col].ToString();
                        }
                        DataStream.WriteLine(String.Join(",", RecordLines));
                        //this method goes through array one by one and rewrites it
                        //from StockLevels array
                        //stock levels array is updated every time something is added
                        //to cart, but it resets if user selects 'no' at checkout
                    }
                    
                }

            }
            catch (Exception ex)
            {
                ErrorMessage = String.Format("Exception body:\n{0}", ex.Message);
                return false;

            }
            ErrorMessage = "";
            return true;

        }
        public bool WriteSalesLevels(string InputFile, ref int[,] Records, out string ErrorMessage, char Seperator)
        {
            StreamWriter DataStream;
            string[] RecordLines = new string[Records.GetLength(1)];
            //after a duccessful transaction, we need to rewrite sales levels
            //we will use a method using streamwriter to do this
            try
            {
                using (DataStream = File.CreateText(InputFile))
                {//input file will be stock levels
                    for (int Row = 0; Row < Records.GetLength(0); Row++)
                    {
                        for (int Col = 0; Col < Records.GetLength(1); Col++)
                        {
                            RecordLines[Col] = Records[Row, Col].ToString();
                        }
                        DataStream.WriteLine(String.Join(",", RecordLines));
                        //this method goes through array one by one and rewrites it
                        //from SalesLevels array
                        //sales levels array is updated every time something is added
                        //to cart, but it resets if user selects 'no' at checkout
                    }

                }

            }
            catch (Exception ex)
            {
                ErrorMessage = String.Format("Exception body:\n{0}", ex.Message);
                return false;

            }
            ErrorMessage = "";
            return true;

        }
        public bool ReadSalesLevels(string InputFile, ref int[,] Records, out String ErrorMessage, char Seperator)
        {
            int Row = 0;
            StreamReader DataStream;
            string[] RecordStrings;
            //these are used to read sales levels, keep track of row, column etc
            try
            {
                using (DataStream = File.OpenText(InputFile))// input file will be transx file
                {
                    while (!DataStream.EndOfStream && Row < Records.Length)
                    {//using and while statemets to prevent error
                        RecordStrings = DataStream.ReadLine().Split(Seperator);
                        for (int Col = 0; Col < RecordStrings.Length; Col++)
                        {
                            Records[Row, Col] = int.Parse(RecordStrings[Col]);
                        }
                        Row++;
                        //The records varaiable will be passed into saleslevels by reference
                        //using a loop to assign values one by one
                    }
                }

            }
            catch (Exception ex)
            {
                ErrorMessage = String.Format("Exception body:\n{0}", ex.Message);
                return false;
                //to catch file errors

            }
            ErrorMessage = "";
            return true;
            //if all is well, return true with no errors




        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            if (NumberTicketsTextBox.Text != "")
            {
                if(int.TryParse(NumberTicketsTextBox.Text, out NumberTicketsIndividualTrans))
                {
                    if (NumberTicketsIndividualTrans > 0)
                    {
                        if (BandsListBox.SelectedIndex!= -1)
                        {
                            if (VenuesListBox.SelectedIndex!= -1)
                            {//exception handling, don't want
                                //blank strings or negative values

                                try
                                {

                                    //derives value from Stock levels array
                                    //index taken from user selection on listboxes
                                    
                                    IndividualStock = STOCKLEVELS[BandsListBox.SelectedIndex, VenuesListBox.SelectedIndex];
                                    OverallIndividualBooking += NumberTicketsIndividualTrans;
                                    //this tracks total amount of tickets bought
                                    if (NumberTicketsIndividualTrans <= IndividualStock)
                                    {//if the amount of tickets is less than stock
                                        //transaction can proceed
                                        IndividualGigCost =
                                        ((TOTALGIGPRICES[BandsListBox.SelectedIndex, VenuesListBox.SelectedIndex])
                                        * NumberTicketsIndividualTrans);
                                        //this draws value from total prices array
                                        //driven by user selection
                                        Band = BANDS[BandsListBox.SelectedIndex];
                                        Venue = VENUES[VenuesListBox.SelectedIndex];
                                        //also drawn by user selection
                                        OverallBookingCost += IndividualGigCost;
                                        OverallNumberTickets += NumberTicketsIndividualTrans;
                                        //calculating values for checkout
                                        ClosingStock = IndividualStock - NumberTicketsIndividualTrans;
                                        //updating stock levels
                                        STOCKLEVELS[BandsListBox.SelectedIndex, VenuesListBox.SelectedIndex] = ClosingStock;
                                        NumberTicketsTextBox.Text = "";
                                        SALES[BandsListBox.SelectedIndex, VenuesListBox.SelectedIndex] = NumberTicketsIndividualTrans;
                                        //clearing ticket box to prevent error
                                        Outputlabel.Text = OverallBookingCost.ToString("c");
                                        string Booking = "You have sucessfully added " + Band + " at the "
                                            + Venue +
                                            " to your cart and your total cost so far is "
                                            + OverallBookingCost.ToString("c");
                                        MessageBox.Show(Booking, "Added to cart",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        //giving user a nice formatted string
                                        //so they can keep track of transactions
                                        IndividualGigBooking += Band + "\n" + Venue + "\n" +
                                        NumberTicketsIndividualTrans.ToString() + " tickets" + "\n"
                                        + "______________________" + "\n";
                                        UniqueProducts++;
                                        //This tracks the amount of different gigs user
                                        //books in one transaction
                                        BookButton.Enabled = true;


                                    }
                                    else
                                    {
                                        string StockError = "Insufficient stock to purchase " +
                                                             "amount of tickets specified, there are " + IndividualStock
                                                                                    + " ticket(s) remaining";
                                        MessageBox.Show(StockError, "Stock error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                       
                                    }

                                }
                                catch
                                {
                                    MessageBox.Show("Error reading data from file, " +
                                                            "please contact a systems administartor", "File data error",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                

                            }
                            else
                            {
                                MessageBox.Show("Please select a venue from the list provided" +
                                " to proceed",
                    "Input error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                                NumberTicketsTextBox.Focus();
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Please select a band from the list provided " +
                                "to proceed",
                    "Input error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                            NumberTicketsTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a value greater than zero for the amount" +
                        " of tickets that you would like to purchase in the box provided",
                    "Input error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        NumberTicketsTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid decimal value for the amount" +
                        " of tickets that you would like to purchase in the box provided",
                    "Input error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    NumberTicketsTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter the amount of tickets that you" +
                    " would like to purchase in the box provided",
                    "Input error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                NumberTicketsTextBox.Focus();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            NumberTicketsTextBox.Text = "";
            IndividualGigBooking = "";
            BandsListBox.SelectedIndex = -1;
            VenuesListBox.SelectedIndex = -1;
            BookButton.Enabled = false;
            NumberTicketsIndividualTrans = 0;
            UniqueProducts = 0;
            FullNameTextBox.Text = "";
            EmailAddressTextBox.Text = "";
            TelephoneNumberTextBox.Text = "";
            Outputlabel.Text = "";
            TransactionNumberLabel.Text = "";
            OverallBookingCost = 0;
            OverallIndividualBooking = 0;
            OverallNumberTickets = 0;
            ReadStockLevels("StockLevels.txt", ref STOCKLEVELS, out Error, Comma);
            ReadSalesLevels("Sales.txt", ref SALES, out Error, Comma);

            //wipe the form and reset the varaibles

        }
        private Boolean IsUnique(string SearchString, string Filename)
        {
            try
            {
                string [] ReadText = File.ReadAllLines(Filename);
                StreamReader InputFile = File.OpenText(Filename);
                for (int i = 0; i < ReadText.Length; i++)
                {
                    if (ReadText[i].Contains(SearchString))
                    {
                        InputFile.Close();
                        SearchMatch = true;
                        return false;
                        //check the file for a matching number
                    }
                }
                
                //close and return if true if no match found
                InputFile.Close();
                SearchMatch = false;
                return true;
                
            }
            catch
            {
                MessageBox.Show("No input file");
                return false;
            }
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            int PhoneNumber;
            string EmailAddress, CustomerName;
            //storing the data that the user provides
            bool ForbiddenCharacters = FullNameTextBox.Text.Contains("?")
                 || FullNameTextBox.Text.Contains("@") || FullNameTextBox.Text.Contains(",")
                 || FullNameTextBox.Text.Contains(".") || FullNameTextBox.Text.Contains("£")
                 || FullNameTextBox.Text.Contains("$") || FullNameTextBox.Text.Contains("€")
                 || FullNameTextBox.Text.Contains("/") || FullNameTextBox.Text.Contains("*")
                 || FullNameTextBox.Text.Contains("%") || FullNameTextBox.Text.Contains("!")
                 || FullNameTextBox.Text.Contains("#") || FullNameTextBox.Text.Contains(";")
                 || FullNameTextBox.Text.Contains(":") || FullNameTextBox.Text.Contains("(")
                 || FullNameTextBox.Text.Contains(")") || FullNameTextBox.Text.Contains("^")
                 || FullNameTextBox.Text.Contains("0-9");
            //creating a bool with characters that we don't want the user 
            //using when writing their fulll name
            string Ampersand = ("@");
            string FullStop = (".");
            //characters that are required for an email address
            bool EmailRequisites = EmailAddressTextBox.Text.Contains(Ampersand)
                && EmailAddressTextBox.Text.Contains(FullStop);
            //email must contain both


            if (FullNameTextBox.Text != "" && !ForbiddenCharacters)
            {//Name text box cannot be blank or contain forbidden characters
                //if this occurs, store name in variable
                CustomerName = FullNameTextBox.Text.ToString();


                if (EmailAddressTextBox.Text != "" && EmailRequisites)

                {// email cannot be blank and must contain both
                    // amperesand and full stop. If it does, store it in variable
                    EmailAddress = EmailAddressTextBox.Text.ToString();
                    if (TelephoneNumberTextBox.Text != "" &&
                        int.TryParse(TelephoneNumberTextBox.Text, out PhoneNumber))
                    {// we only want digits for a telephone number
                        //if it can be parsed, store it in a variable
                        {
                            do
                            {
                                TransactionNumber = Rand.Next(10000000, 99999999);
                                UniqueNumber = IsUnique(TransactionNumber.ToString(), "Long Form Transactions.txt");
                                TransactionNumberLabel.Text = TransactionNumber.ToString();
                            } while (!UniqueNumber);
                            // create a dialog yes/no block to confirm is user wishes to proceed
                            DialogResult dialogResult = MessageBox.Show("Are you sure that you would like to confirm your transaction?",
                                "Confirm transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.Yes)
                            {

                                try
                                {
                                    //making sure number is random and unique
                                    //calling the is unique method
                                    //also changing the form view and width to transaction details
                                    TelephoneNumber = TelephoneNumberTextBox.Text;
                                    //storing telephone as a string
                                    StreamWriter OutputFile;
                                    OutputFile = File.AppendText("Long Form Transactions.txt");
                                    OutputFile.WriteLine(TransactionNumber.ToString());
                                    OutputFile.WriteLine(CurrentDateTime.ToString("d"));
                                    OutputFile.WriteLine(CustomerName.ToString());
                                    OutputFile.WriteLine(TelephoneNumber);
                                    OutputFile.WriteLine(EmailAddress.ToString());
                                    OutputFile.WriteLine(IndividualGigBooking.ToString());
                                    OutputFile.WriteLine(OverallBookingCost.ToString());
                                    OutputFile.WriteLine("------------------------");
                                    OutputFile.Close();
                                    //this will be a long form store of all transaction details
                                    //in a file
                                    WriteStockLevels("StockLevels.txt", ref STOCKLEVELS, out Error, Comma);
                                    WriteSalesLevels("Sales.txt", ref SALES, out Error, Comma);
                                    //rewriting stock levels after a successful sale
                                    StreamWriter ShortOutputFile;
                                    ShortOutputFile = File.AppendText("Traxfile.txt");
                                    ShortOutputFile.WriteLine(TransactionNumber.ToString()
                                    + Comma + EmailAddress.ToString()
                                    + Comma + CurrentDateTime.ToString()
                                    + Comma + CustomerName.ToString()
                                    + Comma + TelephoneNumber.ToString()
                                    + Comma + "Tickets bought:"
                                    + Comma + OverallNumberTickets.ToString()
                                    + Comma + "Gigs:"
                                    + Comma + UniqueProducts.ToString()
                                    + Comma + OverallBookingCost.ToString()
                                    + Comma + "-----------------------");
                                    ShortOutputFile.Close();
                                    //if we have a valid proceed event and all the user submitted data
                                    // is valid and user confirms they wish to proceed
                                    // store data to a shorter file
                                    //this is easier for searches and summary
                                    string FullBooking = "Congratulations! You have booked " +
                                        OverallNumberTickets.ToString() + " tickets for " +
                                        UniqueProducts.ToString() + " gigs and your total cost is "
                                        +OverallBookingCost.ToString("c") + "\n"
                                        + "Your transaction number is " +
                                        TransactionNumber.ToString();
                                    MessageBox.Show(FullBooking, "Checkout complete",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //nice formatted string for user with their details
                                    Clear_Click(null, null);
                                }
                                catch
                                {
                                    MessageBox.Show("Error reading data from file, " +
                                        "please contact a systems administartor", "File data error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }




                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                try
                                {
                                    ReadStockLevels("StockLevels.txt", ref STOCKLEVELS, out Error, Comma);
                                    Clear_Click(null, null);
                                    ReadSalesLevels("Sales.txt", ref SALES, out Error, Comma);
                                    //if we have no sale, we need to reset our StockLevels variable
                                }
                                catch
                                {
                                    MessageBox.Show("Error reading data from file, " +
                                        "please contact a systems administartor", "File data error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                
                            }
                                
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a numeric value for your" +
                            " telephone number in the space provided to proceed.",
                            "Input error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid email address" +
                        " in the space provided to proceed.",
                            "Input error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter your full name in the" +
                            " space provided using only alphanumerical " +
                            "characters to proceed.",
                            "Input error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }

        }
        
        
    }
}
