using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    // Needed for stream-based writing and reading.

namespace chap05_rostergenerator
{
    // Author: Michele Gay
    // Created Date: 3/27/2020
    // Purpose: Takes a user-edited roster and allows for exporting, importing
    //          printing, and moving players from one list box to another
    //          and within the selected player box. 

    // For the baseball field image, visit the IconsPedia site.
    // https://www.iconspedia.com/icon/baseball-field.html

    // To perform small tests or debugging, such as checking a variable
    // value or displaying a message box, try using the Immediate window.
    // https://docs.microsoft.com/en-us/visualstudio/ide/reference/immediate-window?view=vs-2017

    public partial class StartupForm : Form
    {
        private Font printFont;
        private StreamReader streamToPrint;
        public StartupForm()
        {
            InitializeComponent();
        }

        private void AddWriteInPlayerButton_Click(object sender, EventArgs e)
        {
            // Consult the Visio flowchart for this button's logic.
            if (WriteInPlayerTextBox.Text != "")
            {
                AvailPlayersListBox.Items.Add(WriteInPlayerTextBox.Text);
                WriteInPlayerTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Enter a player name first.");
            }
            WriteInPlayerTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Confirm the form exit by prompting the user first.
            if (MessageBox.Show("Are you sure you want to exit?",
                "Confirm exit...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MoveAllAvailButton_Click(object sender, EventArgs e)
        {
            if (AvailPlayersListBox.Items.Count != 0)
            {
                while (AvailPlayersListBox.Items.Count != 0)
                {
                    SelPlayersListBox.Items.Insert(0, AvailPlayersListBox.Items[0].ToString());
                    AvailPlayersListBox.Items.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("There are no players to be moved.");
            }
        }

        private void Move1SelButton_Click(object sender, EventArgs e)
        {
            if (SelPlayersListBox.SelectedIndex != -1)
            {
                AvailPlayersListBox.Items.Add(SelPlayersListBox.SelectedItem.ToString());
                SelPlayersListBox.Items.RemoveAt(SelPlayersListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Select a player name first.");
            }
        }

        private void MoveAllSelButton_Click(object sender, EventArgs e)
        {
            if (SelPlayersListBox.Items.Count != 0)
            {
                while (SelPlayersListBox.Items.Count != 0)
                {
                    AvailPlayersListBox.Items.Insert(0, SelPlayersListBox.Items[0].ToString());
                    SelPlayersListBox.Items.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("There are no players to be moved.");
            }
        }

        private void ImportRosterButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter DefaultRosterFile;

                // Create a file and get a StreamWriter object.
                DefaultRosterFile = File.CreateText("DefaultRosterFile.txt");

                // Write the default player(s) to the file.
                DefaultRosterFile.WriteLine("Anderson, Peter");
                DefaultRosterFile.WriteLine("Coggins, Rich");
                DefaultRosterFile.WriteLine("McAndrew, Jimmy");
                DefaultRosterFile.WriteLine("Williams, Ted");

                //Close the file and confirm the process has completed.
                DefaultRosterFile.Close();
                MessageBox.Show("Default roster file created.  Click \"OK\" to import this roster.");
            }
            catch (Exception GenericException)
            {
                MessageBox.Show(GenericException.Message);
                return;
            }

            try
            {
                string PlayerNameString;
                StreamReader InputFile;

                // Open the file and get a StreamReader object.
                InputFile = File.OpenText("DefaultRosterFile.txt");
                AvailPlayersListBox.Items.Clear();

                //Read the default players file contents until end of stream.
                while (!InputFile.EndOfStream)
                {
                    PlayerNameString = InputFile.ReadLine();
                    AvailPlayersListBox.Items.Add(PlayerNameString);
                }

                //Close the file and confirm the process has completed.
                InputFile.Close();
                MessageBox.Show("Default roster file imported.  Click \"OK\" to continue.");
            }
            catch (Exception GenericException)
            {
                MessageBox.Show(GenericException.Message);
                return;
            }
        }

        private void ExportRosterButton_Click(object sender, EventArgs e)
        {
            const String ExportedFilename = "\\" + "SelectedPlayersRosterFile.txt";//can i reference exported file name?
            int CurPlayerInteger = 0;

            //Verify there is at least one player to export.
            if (SelPlayersListBox.Items.Count == 0)
            {
                MessageBox.Show("No selected players to export.");
                return;
            }

            try
            {
                // Prompt the user for where to save the exported roster.
                string SelectedLocationString = "";

                ExportRosterFolderBrowserDialog.ShowDialog();
                SelectedLocationString = ExportRosterFolderBrowserDialog.SelectedPath;
                MessageBox.Show("SelectedLocationString: " + SelectedLocationString);

                //Now that we know htere is at least one player to export,
                // proceed ahead and create the selected players file.
                StreamWriter SelectedPlayersRosterFile;

                //Create a file and get a StreamWriter object.
                SelectedPlayersRosterFile = File.CreateText(SelectedLocationString + ExportedFilename);

                // Write the team name and selected player(s) to the file.
                SelectedPlayersRosterFile.WriteLine(TeamComboBox.SelectedItem.ToString() + " - Selected Player(s)");
                SelectedPlayersRosterFile.WriteLine(String.Empty.PadRight(50, '=').ToString());
                while (CurPlayerInteger < SelPlayersListBox.Items.Count)
                {
                    SelectedPlayersRosterFile.WriteLine((CurPlayerInteger + 1).ToString() +
                        "." + SelPlayersListBox.Items[CurPlayerInteger].ToString());
                    CurPlayerInteger = CurPlayerInteger + 1;
                }

                //Write some whitespace lines, a signature line, and current date to selected player(s) file.
                SelectedPlayersRosterFile.WriteLine("");
                SelectedPlayersRosterFile.WriteLine("");
                SelectedPlayersRosterFile.WriteLine("");
                SelectedPlayersRosterFile.WriteLine("Note:  Manager signature gets written below.");
                SelectedPlayersRosterFile.WriteLine("");
                SelectedPlayersRosterFile.WriteLine("");
                // Tip:  Use online help to learn more abou the PadRight method.
                SelectedPlayersRosterFile.Write(String.Empty.PadRight(40, '_').ToString() +
                    String.Empty.PadRight(10, ' ') + (DateTime.Now.ToString("MM/dd/yyyy")));

                //Close the file and confirm the process has completed.
                SelectedPlayersRosterFile.Close();
                MessageBox.Show("Selected player(s) roster file exported.  Click \"OK\" to continue.");
            }
            catch (Exception GenericException)
            {
                MessageBox.Show(GenericException.Message);
                return;
            }
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            TeamComboBox.SelectedIndex = 0;
        }

        private void DeleteAllAvail_Click(object sender, EventArgs e)
        {
            // Confirm the listbox clear by prompting the user first.
            if (MessageBox.Show("Are you sure you want to clear the available players?",
                "Confirm clear...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                AvailPlayersListBox.Items.Clear();
            }
        }

        private void Move1AvailButton_Click(object sender, EventArgs e)
        {
            if (AvailPlayersListBox.SelectedIndex != -1)
            {
                SelPlayersListBox.Items.Add(AvailPlayersListBox.SelectedItem.ToString());
                AvailPlayersListBox.Items.RemoveAt(AvailPlayersListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Select a player name first.");
            }
        }

        private void Delete1Avail_Click(object sender, EventArgs e)
        {
            if (AvailPlayersListBox.SelectedIndex != -1)
            {
                //Confirm the deletion by prompting the user first.
                if (MessageBox.Show("Are you sure you want to delete the selected player?",
                "Confirm clear...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    AvailPlayersListBox.Items.RemoveAt(AvailPlayersListBox.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Select a player name first.");
            }
        }

        private void PrintRosterButton_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
           // from fox yt video if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
               // printDocument1.Print();
            /*try
            {
                streamToPrint = new StreamReader
                    ();
                try
                {
                    printFont = new Font("Arial", 10);
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler
                        (this.pd_PrintPage);
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void pd_PrintPage (object sender, PrintPageEventArgs ev)
        {
            
            /* float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            //Calculate number of lines per page
            linesPerPage = ev.MarginBounds.Height /
                printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;*/
        }



        private void EditAvail_Click(object sender, EventArgs e)
        {

        }

        private void MoveUpButton()
        {
            
            //Verify there is at least one player selected to move up.
            if (SelPlayersListBox.SelectedIndex > 0)
            {
                int newIndex = SelPlayersListBox.SelectedIndex - 1;
                object selectedItem = SelPlayersListBox.SelectedItem;
                SelPlayersListBox.Items.Remove(selectedItem);
                SelPlayersListBox.Items.Insert(newIndex, selectedItem);
                SelPlayersListBox.SetSelected(newIndex, true);
            }
            else if (SelPlayersListBox.SelectedIndex == 0)
            {
                MessageBox.Show("Selected Player is already at the top of the list.");
            }
            else
            {
                MessageBox.Show("Select a player to move up.");
            }
            //SelPlayersListBox.Items.RemoveAt(SelPlayersListBox.SelectedIndex)
             
            //int selectedIndex = SelPlayersListBox.SelectedIndex;
            /*if (selectedIndex > 0)
            {
                SelPlayersListBox.Items.Insert(selectedIndex - 1, SelPlayersListBox.Items[selectedIndex]);
                SelPlayersListBox.Items.RemoveAt(selectedIndex + 1);
                SelPlayersListBox.SelectedIndex = selectedIndex - 1;
            }*/
            /* dougcode: if (SelPlayersListBox.SelectedIndex != -1)

            {
                int ind = SelPlayersListBox.SelectedIndex;
                string selectedPlayer = SelPlayersListBox.SelectedItem.ToString();
                SelPlayersListBox.Items.Insert(ind-1, selectedPlayer);
                SelPlayersListBox.Items.RemoveAt(ind+1);
                
            }*/
           
        }

        private void MoveDownButton()
        {
            if (SelPlayersListBox.Items.Count > 0)
            {
                //Verify there is at least one player selected to move down.
                if ((SelPlayersListBox.SelectedIndex != -1) && (SelPlayersListBox.SelectedIndex < SelPlayersListBox.Items.Count - 1))
                {
                    int newIndex = SelPlayersListBox.SelectedIndex + 1;
                    object selectedItem = SelPlayersListBox.SelectedItem;
                    SelPlayersListBox.Items.Remove(selectedItem);
                    SelPlayersListBox.Items.Insert(newIndex, selectedItem);
                    SelPlayersListBox.SetSelected(newIndex, true);
                }
                else if (SelPlayersListBox.SelectedIndex >= SelPlayersListBox.Items.Count - 1)
                {
                    MessageBox.Show("Selected player is already at the bottom of the list.");
                }
            }
            else
            {
                MessageBox.Show("Select a player to move down.");
            }
        }

        private void MoveSelUpButton_Click(object sender, EventArgs e)
        {
            MoveUpButton();
        }

        private void MoveSelDownButton_Click(object sender, EventArgs e)
        {
            MoveDownButton();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int selPlayerInteger = 0;
            //string selPlayerText = SelPlayersListBox.Items[selPlayerInteger].ToString();
            //save listbox text as a string??
            //so may have to do a loop! 
            //for (i=0, i< total item index, i++
            //drawstring and location
            string drawString = TeamComboBox.SelectedItem.ToString() + " - Selected Player(s)";
            e.Graphics.DrawString(drawString, new Font("Arial",12, FontStyle.Regular), Brushes.Black, new PointF(100, 100));
            string equalSigns = String.Empty.PadRight(50, '=').ToString();
            e.Graphics.DrawString(equalSigns, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(100, 120));

            // if (SelPlayersListBox.Items.Count > 0)
            //{
            /* while (selPlayerInteger < SelPlayersListBox.Items.Count)
             {
                 e.Graphics.DrawString(selPlayerText, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(120 + (selPlayerInteger*20), 120));
                 selPlayerInteger = selPlayerInteger + 1;
                 //((CurPlayerInteger + 1).ToString() +
                 //   "." + SelPlayersListBox.Items[CurPlayerInteger].ToString());
                 //CurPlayerInteger = CurPlayerInteger + 1;
             }*/
            for (selPlayerInteger = 0; selPlayerInteger < SelPlayersListBox.Items.Count; selPlayerInteger++)
            {
                string selPlayerText = SelPlayersListBox.Items[selPlayerInteger].ToString();
                e.Graphics.DrawString(selPlayerText, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(120 /*+ (selPlayerInteger * 20)*/, 140 + (selPlayerInteger * 20)));
                //selPlayerInteger = selPlayerInteger + 1;
                //where drawstring is...
                //another string for number of each playa
                //e.Graphics.DrawString(drawString, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
            }
           // }
           //if (SelPlayersListBox.Items.Count == 0)
           // {//or should this if/else go with print button?
           //MessageBox.Show("Please add a player to roster to print.");
           //}

/*SelectedPlayersRosterFile.WriteLine(TeamComboBox.SelectedItem.ToString() + " - Selected Player(s)");
    SelectedPlayersRosterFile.WriteLine(String.Empty.PadRight(50, '=').ToString());
    while (CurPlayerInteger < SelPlayersListBox.Items.Count)
    {
        SelectedPlayersRosterFile.WriteLine((CurPlayerInteger + 1).ToString() +
            "." + SelPlayersListBox.Items[CurPlayerInteger].ToString());
        CurPlayerInteger = CurPlayerInteger + 1;
    }

    //Write some whitespace lines, a signature line, and current date to selected player(s) file.
    SelectedPlayersRosterFile.WriteLine("");
    SelectedPlayersRosterFile.WriteLine("");
    SelectedPlayersRosterFile.WriteLine("");
    SelectedPlayersRosterFile.WriteLine("Note:  Manager signature gets written below.");
    SelectedPlayersRosterFile.WriteLine("");
    SelectedPlayersRosterFile.WriteLine("");
    // Tip:  Use online help to learn more abou the PadRight method.
    SelectedPlayersRosterFile.Write(String.Empty.PadRight(40, '_').ToString() +
        String.Empty.PadRight(10, ' ') + (DateTime.Now.ToString("MM/dd/yyyy")));*/
}

//Methods for context menus 
}
}
