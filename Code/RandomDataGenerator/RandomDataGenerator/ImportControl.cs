

#region using statements

using DataGateway;
using dataObjects = ObjectLibrary.BusinessObjects;
using EF = RandomData.EF.Data.Entities;
using RandomData.EF.Data;
using DataJuggler.Core.UltimateHelper;
using DataJuggler.Core.UltimateHelper.Objects;
using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

#endregion

namespace RandomDataGenerator
{

    #region class ImportControl
    /// <summary>
    /// This control is used to import the raw data so the Random Data
    /// Generator has something to generate from
    /// </summary>
    public partial class ImportControl : UserControl, ITextChanged
    {
        
        #region Private Variables
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'ImportControl' object.
        /// </summary>
        public ImportControl()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion
        
        #region Events
            
            #region Button_Enter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Enter
            /// </summary>
            private void Button_Enter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_Leave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Leave
            /// </summary>
            private void Button_Leave(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region ImportFirstNamesButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ImportFirstNamesButton' is clicked.
            /// </summary>
            private void ImportFirstNamesButton_Click(object sender, EventArgs e)
            {
                // locals
                bool saved = false;
                string fileName = "";
            
                try
                {
                    // get the text of the firstNameText
                    string firstNamesTextFile = FirstNamesControl.Text;

                    // attempt to read all the text
                    string textFileContents = File.ReadAllText(firstNamesTextFile);

                    // If the textFileContents string exists
                    if (TextHelper.Exists(textFileContents))
                    {
                        // create the fileInfo
                        FileInfo fileInfo = new FileInfo(firstNamesTextFile);

                        // set the name of the file
                        fileName = fileInfo.Name;

                        // get the text lines (this file is one entry per row)
                        List<TextLine> lines = WordParser.GetTextLines(textFileContents);

                        // If the lines collection exists and has one or more items
                        if (ListHelper.HasOneOrMoreItems(lines))
                        {
                            // Setup the Graph
                            Graph.Visible = true;
                            Graph.Maximum = lines.Count;
                            Graph.Value = 0;
                            
                            // refresh everything
                            Refresh();

                            // Create a new instance of a 'Gateway' object.
                            Gateway gateway = new Gateway();

                            // Iterate the collection of TextLine objects
                            foreach (TextLine line in lines)
                            {
                                // Create a firstName instance
                                dataObjects.FirstName firstName = new dataObjects.FirstName();

                                // set the firstName
                                firstName.Name = line.Text.Trim();

                                // save this firstName
                                saved = gateway.SaveFirstName(ref firstName);

                                // if the value for saved is true
                                if (saved)
                                {
                                    // increment the value for the Graph
                                    Graph.Value++;
                                }
                            }

                            // Show finished
                            MessageBoxHelper.ShowMessage("The file '" + fileName + "' has been imported.", "Import Complete");
                        }
                    }
                    else
                    {
                        // Show an error
                        MessageBoxHelper.ShowMessage("The selected import file could not be read.", "Import File Error");
                    }
                }
                catch (Exception error)
                {
                    // for debugging only
                    DebugHelper.WriteDebugError("ImportFirstNameButton_Click", this.Name, error);
                }
            }
            #endregion
            
            #region Button_EnabledChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the button becomes enabled or disabled.
            /// </summary>
            private void Button_EnabledChanged(object sender, EventArgs e)
            {
                // button
                Button button = sender as Button;

                // If the button object exists
                if (NullHelper.Exists(button))
                {
                    // If the value for the property button.Enabled is true
                    if (button.Enabled)
                    {
                        // change the color for enabled
                        button.ForeColor = Color.LemonChiffon;
                    }
                    else
                    {
                        // change the color for disabled
                        button.ForeColor = Color.DarkGray;
                    }
                }
            }
            #endregion
            
            #region ImportLastNamesButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ImportLastNamesButton' is clicked.
            /// </summary>
            private void ImportLastNamesButton_Click(object sender, EventArgs e)
            {
                // locals
                bool saved = false;
                string fileName = "";
                List<Word> words = null;
                char[] delimiters = { ' ' };
                bool skipName = false;
            
                try
                {
                    // get the text of the LastNames.txt file
                    string LastNamesTextFile = LastNamesControl.Text;

                    // attempt to read all the text
                    string textFileContents = File.ReadAllText(LastNamesTextFile);

                    // If the textFileContents string exists
                    if (TextHelper.Exists(textFileContents))
                    {
                        // create the fileInfo
                        FileInfo fileInfo = new FileInfo(LastNamesTextFile);

                        // set the name of the file
                        fileName = fileInfo.Name;

                        // get the text lines (this file is one entry per row)
                        List<TextLine> lines = WordParser.GetTextLines(textFileContents);

                        // If the lines collection exists and has one or more items
                        if (ListHelper.HasOneOrMoreItems(lines))
                        {
                            // Setup Graph2
                            Graph2.Visible = true;
                            Graph2.Maximum = lines.Count;
                            Graph2.Value = 0;
                            
                            // refresh everything
                            Refresh();

                            // Create a new instance of a 'Gateway' object.
                            Gateway gateway = new Gateway();

                            // Iterate the collection of TextLine objects
                            foreach (TextLine line in lines)
                            {
                                // reset 
                                skipName = false;

                                // if this name contains weird symbols
                                if (line.Text.Contains("^"))
                                {
                                    // skip this name
                                    skipName = true;
                                }
                                else if (line.Text.Contains(" or "))
                                {
                                    // skip this name
                                    skipName = true;
                                }
                                else if (line.Text.Contains("-"))
                                {
                                    // skip any hyphenated names
                                    skipName = true;
                                }

                                // if the value for skipName is false
                                if (!skipName)
                                {
                                    // Create a LastName instance
                                    dataObjects.LastName LastName = new dataObjects.LastName();

                                    // get the words
                                    words = WordParser.GetWords(line.Text, delimiters);

                                    // if there is a space in the name
                                    if ((ListHelper.HasOneOrMoreItems(words)) && (words.Count > 1))
                                    {
                                        // Create a new instance of a 'StringBuilder' object.
                                        StringBuilder sb = new StringBuilder();

                                        // Iterate the collection of Word objects
                                        foreach (Word word in words)
                                        {
                                            // Capitalize each word
                                            sb.Append(TextHelper.CapitalizeFirstChar(word.Text));
                                            sb.Append(" ");
                                        }

                                        // set the LastName
                                        LastName.Name = sb.ToString().Trim();
                                    }
                                    else
                                    {
                                        // set the LastName
                                        LastName.Name = TextHelper.CapitalizeFirstChar(line.Text.Trim());
                                    }

                                    // save this LastName
                                    saved = gateway.SaveLastName(ref LastName);

                                    // if the value for saved is true
                                    if (saved)
                                    {
                                        // increment the value for Graph2
                                        Graph2.Value++;
                                    }
                                }
                            }

                            // Show finished
                            MessageBoxHelper.ShowMessage("The file '" + fileName + "' has been imported.", "Import Complete");
                        }
                    }
                    else
                    {
                        // Show an error
                        MessageBoxHelper.ShowMessage("The selected import file could not be read.", "Import File Error");
                    }
                }
                catch (Exception error)
                {
                    // for debugging only
                    DebugHelper.WriteDebugError("ImportLastNameButton_Click", this.Name, error);
                }
            }
            #endregion
            
            #region ImportStreetNamesButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ImportStreetNamesButton' is clicked.
            /// </summary>
            private void ImportStreetNamesButton_Click(object sender, EventArgs e)
            {
                // locals
                bool saved = false;
                string fileName = "";
                string temp = "";
                
                try
                {
                    // get the text of the StreetNames.txt file
                    string streetNamesTextFile = StreetNamesControl.Text;

                    // attempt to read all the text
                    string textFileContents = File.ReadAllText(streetNamesTextFile);

                    // If the textFileContents string exists
                    if (TextHelper.Exists(textFileContents))
                    {
                        // create the fileInfo
                        FileInfo fileInfo = new FileInfo(streetNamesTextFile);

                        // set the name of the file
                        fileName = fileInfo.Name;

                        // get the text lines (this file is one entry per row)
                        List<TextLine> lines = WordParser.GetTextLines(textFileContents);

                        // If the lines collection exists and has one or more items
                        if (ListHelper.HasOneOrMoreItems(lines))
                        {
                            // Setup Graph3
                            Graph3.Visible = true;
                            Graph3.Maximum = lines.Count;
                            Graph3.Value = 0;
                            
                            // refresh everything
                            Refresh();

                            // Create a new instance of a 'Gateway' object.
                            Gateway gateway = new Gateway();

                            // Iterate the collection of TextLine objects
                            foreach (TextLine line in lines)
                            {
                                // get the current line
                                temp = line.Text.Trim();

                                // Create a StreetName instance
                                dataObjects.StreetName streetName = new dataObjects.StreetName();

                                // set the LastName
                                streetName.Name = line.Text.Trim();

                                // save this LastName
                                saved = gateway.SaveStreetName(ref streetName);

                                // if the value for saved is true
                                if (saved)
                                {
                                    // increment the value for Graph3
                                    Graph3.Value++;
                                }
                            }

                            // Show finished
                            MessageBoxHelper.ShowMessage("The file '" + fileName + "' has been imported.", "Import Complete");
                        }
                    }
                    else
                    {
                        // Show an error
                        MessageBoxHelper.ShowMessage("The selected import file could not be read.", "Import File Error");
                    }
                }
                catch (Exception error)
                {
                    // for debugging only
                    DebugHelper.WriteDebugError("ImportStreetnamesButton_Click", this.Name, error);
                }
            }
            #endregion
            
            #region ImportZipButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ImportZipButton' is clicked.
            /// </summary>
            private void ImportZipButton_Click(object sender, EventArgs e)
            {
                // locals
                bool zipCodeSaved = false;
                string fileName = "";
                string temp = "";
                List<Word> words = null;
                char[] delimiter = { '\t' }; 
                string zip = "";
                string cityName = "";
                string stateName = "";
                int lineCount = 0;
                int stateId = 0;
                string lastStateName = "";
                
                try
                {
                    // get the text of the USA-Zip.txt file
                    string zipTextFile = ZipCodeControl.Text;

                    // attempt to read all the text
                    string textFileContents = File.ReadAllText(zipTextFile);

                    // If the textFileContents string exists
                    if (TextHelper.Exists(textFileContents))
                    {
                        // create the fileInfo
                        FileInfo fileInfo = new FileInfo(zipTextFile);

                        // set the name of the file
                        fileName = fileInfo.Name;

                        // get the text lines (this file is one entry per row)
                        List<TextLine> lines = WordParser.GetTextLines(textFileContents);

                        // If the lines collection exists and has one or more items
                        if (ListHelper.HasOneOrMoreItems(lines))
                        {
                            // Setup Graph4
                            Graph4.Visible = true;
                            Graph4.Maximum = lines.Count;
                            Graph4.Value = 0;

                            // refresh everything
                            Refresh();

                            // Create a new instance of a 'Gateway' object.
                            Gateway gateway = new Gateway();

                            // first pass handle only columns 0 - 3
                            // Iterate the collection of TextLine objects
                            foreach (TextLine line in lines)
                            {
                                // Increment the value for lineCount
                                lineCount++;

                                // get the current line
                                temp = line.Text.Trim();

                                // get the words
                                words = WordParser.GetWords(temp, delimiter);

                                // If the words collection exists and has one or more items
                                if ((ListHelper.HasOneOrMoreItems(words)) && (words.Count == 4))
                                {
                                    // Append columns 0 - 3
                                    zip = words[0].Text;
                                    cityName = words[1].Text;
                                    stateName = words[2].Text;

                                    // if we just reached a new stateId
                                    if (stateName != lastStateName)
                                    {
                                        // find the state
                                        dataObjects.State state = gateway.FindStateByName(stateName);

                                        // If the state object exists
                                        if (NullHelper.Exists(state))
                                        {
                                            // set the StateId
                                            stateId = state.Id;
                                        }
                                    }

                                    // if the stateId were set
                                    if (stateId > 0)
                                    {
                                        // insert a ZipCode object
                                        dataObjects.ZipCode zipCode = new dataObjects.ZipCode();

                                        // set the properties on the zipCode object
                                        zipCode.Name = zip;
                                        zipCode.CityName = cityName;
                                        zipCode.StateId = stateId;

                                        // perform the save
                                        zipCodeSaved = gateway.SaveZipCode(ref zipCode);
                                    }  

                                    // if the zipCode was saved
                                    if (zipCodeSaved)
                                    {   
                                        // increment the value for the graph
                                        Graph4.Value++;
                                    }

                                    // set the lastStateName
                                    lastStateName = stateName;
                                }                                
                            }

                            // Show finished
                            MessageBoxHelper.ShowMessage("The file '" + fileName + "' has been imported.", "Import Complete");
                        }
                    }
                    else
                    {
                        // Show an error
                        MessageBoxHelper.ShowMessage("The selected import file could not be read.", "Import File Error");
                    }
                }
                catch (Exception error)
                {
                    // for debugging only
                    DebugHelper.WriteDebugError("ImportZipButton_Click", this.Name, error);
                }
            }
            #endregion
            
            #region OnTextChanged(Control sender, string text)
            /// <summary>
            /// event is fired when On Text Changed
            /// </summary>
            public void OnTextChanged(Control sender, string text)
            {
                // cast the sender as a LabelTextBoxBrowserControl
                LabelTextBoxBrowserControl labelTextBoxBrowserControl = sender as LabelTextBoxBrowserControl;

                // If the labelTextBoxBrowserControl object exists
                if (NullHelper.Exists(labelTextBoxBrowserControl))
                {
                    // determine which control was modified
                    switch (labelTextBoxBrowserControl.Name)
                    {
                        case "FirstNamesControl":
    
                            // if the FirstNamesControl.Text is set and the file exists
                            if ((labelTextBoxBrowserControl.HasText) && (File.Exists(labelTextBoxBrowserControl.Text)))
                            {
                                // Enable the ImportFirstNamesButton 
                                ImportFirstNamesButton.Enabled = true;
                            }
                            else
                            {
                                // disable the ImportFirstNamesButton
                                ImportFirstNamesButton.Enabled = false;
                            }

                            // required
                            break;

                        case "LastNamesControl":

                            // if the LastNamesControl.Text is set and the file exists
                            if ((labelTextBoxBrowserControl.HasText) && (File.Exists(labelTextBoxBrowserControl.Text)))
                            {
                                // Enable the ImportLastNamesButton 
                                ImportLastNamesButton.Enabled = true;
                            }
                            else
                            {
                                // disable the ImportLastNamesButton
                                ImportLastNamesButton.Enabled = false;
                            }

                            // required
                            break;

                        case "StreetNamesControl":

                            // if the StreetNames.Text is set and the file exists
                            if ((labelTextBoxBrowserControl.HasText) && (File.Exists(labelTextBoxBrowserControl.Text)))
                            {
                                // Enable the ImportStreeNamesButton 
                                ImportStreetNamesButton.Enabled = true;
                            }
                            else
                            {
                                // disable the ImportStreetNamesButton
                                ImportStreetNamesButton.Enabled = false;
                            }

                            // required
                            break;

                       case "ZipCodeControl":

                            // if the StreetNames.Text is set and the file exists
                            if ((labelTextBoxBrowserControl.HasText) && (File.Exists(labelTextBoxBrowserControl.Text)))
                            {
                                // Enable the ImportZipButton 
                                ImportZipButton.Enabled = true;
                            }
                            else
                            {
                                // disable the ImportZipButton
                                ImportZipButton.Enabled = false;
                            }

                            // required
                            break;
                    }
                }
            }
            #endregion

        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Setup the listeners
                FirstNamesControl.OnTextChangedListener = this;

                // set the relativePath
                string relativePath = "../../../../../Input/FirstNames.txt";

                // get the fullPath
                string fullPath = Path.GetFullPath(relativePath);

                // Set the path to the text box
                FirstNamesControl.Text = fullPath;

                // Setup the listeners
                LastNamesControl.OnTextChangedListener = this;

                // set the relativePath
                relativePath = "../../../../../Input/LastNames.txt";

                // get the fullPath
                fullPath = Path.GetFullPath(relativePath);

                // Set the path to the text box for LastNames.txt
                LastNamesControl.Text = fullPath;

                // Setup the listeners
                StreetNamesControl.OnTextChangedListener = this;

                // set the relativePath
                relativePath = "../../../../../Input/StreetNames.txt";

                // get the fullPath
                fullPath = Path.GetFullPath(relativePath);

                // Set the path to the text box for LastNames.txt
                StreetNamesControl.Text = fullPath;

                 // Setup the listeners
                ZipCodeControl.OnTextChangedListener = this;

                // set the relativePath
                relativePath = "../../../../../Input/USA-Zip.txt";

                // get the fullPath
                fullPath = Path.GetFullPath(relativePath);

                // Set the path to the text box for LastNames.txt
                ZipCodeControl.Text = fullPath;
            }
            #endregion

        #endregion

    }
    #endregion

}
