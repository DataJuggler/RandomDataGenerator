

#region using statements

using RandomMemberCreator.Enumerations;
using DataJuggler.Core.UltimateHelper;
using System;
using DataJuggler.Win.Controls.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataJuggler.Win.Controls;
using RandomMemberCreator;
using DataGateway;
using DTN = ObjectLibrary.BusinessObjects;
using EF = RandomData.EF.Data.Entities;
using RandomData.EF.Data;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;

#endregion

namespace RandomDataGenerator
{

    #region class MemberCreatorControl
    /// <summary>
    /// This control is used to create members
    /// </summary>
    public partial class MemberCreatorControl : UserControl, ICheckChangedListener, ITextChanged
    {
        
        #region Private Variables
        private RandomCreatorInfo info;
        private MemberGenerator memberGenerator;
        private bool loadingData;
        private bool creatingMembers;
        private bool creatingShufflers;
        private List<DTN.Member> dTNMembers;
        private List<EF.Member> eFMembers;
        private bool dataLoaded;
        private bool shufflersCreated;
        private bool membersCreated;
        private bool saved;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MemberCreatorControl' object.
        /// </summary>
        public MemberCreatorControl()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

            #region Button_EnabledChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Create Members Button _ Enabled Changed
            /// </summary>
            private void Button_EnabledChanged(object sender, EventArgs e)
            {
                // cast the sender as a button
                Button button = sender as Button;

                // if the button exists
                if (NullHelper.Exists(button))
                {
                    // if the button is enabled
                    if (button.Enabled)
                    {
                        // Use the Enabled Image
                        button.BackgroundImage = Properties.Resources.WoodButtonWidth640;
                    }
                    else
                    {
                        // Use the Disabled Image
                        button.BackgroundImage = Properties.Resources.WoodButtonWidth640Disabled;
                    }
                }
            }
            #endregion

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
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;
            }
            #endregion
            
            #region CreateMembersButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CreateMembersButton' is clicked.
            /// </summary>
            private void CreateMembersButton_Click(object sender, EventArgs e)
            {
                // if the value for HasMemberGenerator is true
                if (HasMemberGenerator)
                {
                    // Set to True
                    CreatingMembers = true;

                    // Enable or disable controls
                    UIEnable();

                    // Set the CallBack delegate so the graph can be updated during each section
                    MemberGenerator.CallBack = SetupGraph;

                    // if using DataTier.Net
                    if (Info.DataTechnology == DataTechnologyEnum.DataTierNet)
                    {
                        // create the members using DataTier.Net
                        this.DTNMembers = MemberGenerator.CreateMembersWithDTN();                        
                    }
                    else if (Info.DataTechnology == DataTechnologyEnum.EntityFramework)
                    {
                        // create the members using DataTier.Net
                        this.EFMembers = MemberGenerator.CreateMembersWithEF();                        
                    }
                }

                // Set to False
                CreatingMembers = false;

                // Now Set Members created to true if we have Members
                if (Info.DataTechnology == DataTechnologyEnum.DataTierNet)
                {
                    // Set to true if the DTNMembers exist and have at least one item
                    MembersCreated = (ListHelper.HasOneOrMoreItems(DTNMembers));
                }
                else if (info.DataTechnology == DataTechnologyEnum.EntityFramework)
                {
                    // Set to true if the EFMembers exist and have at least one item
                    MembersCreated = (ListHelper.HasOneOrMoreItems(EFMembers));
                }

                // if the value for MembersCreated is true
                if (MembersCreated)
                {
                    // Change the status label
                    StatusMessageLabel.Text = "Members Created";
                }

                // Enable or disable controls
                UIEnable();
            }
            #endregion
            
            #region CreateShufflersButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CreateShufflersButton' is clicked.
            /// </summary>
            private void CreateShufflersButton_Click(object sender, EventArgs e)
            {
                // if the value for HasMemberGenerator is true
                if (HasMemberGenerator)
                {
                     // Set to True
                    CreatingShufflers = true;

                    // Enable or disable controls
                    UIEnable();

                    // Set the CallBack delegate so the graph can be updated during each section
                    MemberGenerator.CallBack = SetupGraph;

                    // Create the Shufflers
                    MemberGenerator.CreateShufflers();
                    
                    // Set the value
                    ShufflersCreated = MemberGenerator.ShufflersCreated;

                    // Enable controls
                    UIEnable();
                }
            }
            #endregion
            
            #region DoneButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'DoneButton' is clicked.
            /// </summary>
            private void DoneButton_Click(object sender, EventArgs e)
            {
                // End this app
                Application.Exit();
            }
            #endregion
            
            #region LoadDataButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'LoadDataButton' is clicked.
            /// </summary>
            private void LoadDataButton_Click(object sender, EventArgs e)
            {
                // if the Info exists
                if (HasInfo)
                {
                    // Set to true
                    LoadingData = true;

                    // Enable or disable controls
                    UIEnable();

                    // create a new memberGenerator
                    MemberGenerator = new MemberGenerator(Info);

                    // Set the Callback
                    MemberGenerator.CallBack = SetupGraph;

                    // determine which method to call
                    if (Info.DataTechnology == DataTechnologyEnum.DataTierNet)
                    {
                        // Call the LoadDataWithDataTierNet method
                        MemberGenerator.LoadDataWithDataTierNet();
                    }
                    else if (info.DataTechnology == DataTechnologyEnum.EntityFramework)
                    {
                        // Call the LoadDataWithEntityFramework method
                        MemberGenerator.LoadDataWithEntityFramework();
                    }

                    // Retrieve the info that has the values with the counts
                    Info = MemberGenerator.Info;

                    // Setup the counts
                    this.FirstNamesCountControl.Text = String.Format("{0:n0}", info.FirstNamesCount);
                    this.LastNamesCountControl.Text = String.Format("{0:n0}", info.LastNamesCount);
                    this.StreetNamesCountControl.Text =  String.Format("{0:n0}", info.StreetNamesCount);
                    this.ZipCodesCountControl.Text =  String.Format("{0:n0}", info.ZipCodesCount);

                    // finished loading data
                    LoadingData = false;

                    // Set to true
                    DataLoaded = MemberGenerator.DataLoaded;
                }

                // Enable controls
                UIEnable();
            }
            #endregion
            
            #region OnCheckChanged(LabelCheckBoxControl sender, bool isChecked)
            /// <summary>
            /// event is fired when On Check Changed
            /// </summary>
            public void OnCheckChanged(LabelCheckBoxControl sender, bool isChecked)
            {
                // if isChecked
                if ((isChecked) && (HasInfo))
                {
                    // determine which control is checked, so we know which control to uncheck
                    if (sender.Name == this.UseDataTierNetCheckBox.Name)
                    {
                        // Uncheck UseEntityFrameworkCheckBox
                        UseEntityFrameworkCheckBox.Checked = false;

                        // Use DataTier.Net to load the data
                        Info.DataTechnology = DataTechnologyEnum.DataTierNet;
                    }
                    else if (sender.Name == this.UseEntityFrameworkCheckBox.Name)
                    {
                        // Uncheck UseDataTierNetCheckBox
                        UseDataTierNetCheckBox.Checked = false;

                        // Use EntityFramework.Net to load the data
                        Info.DataTechnology = DataTechnologyEnum.EntityFramework;
                    }
                }
            }
            #endregion
            
            #region OnTextChanged(Control sender, string text)
            /// <summary>
            /// event is fired when On Text Changed
            /// </summary>
            public void OnTextChanged(Control sender, string text)
            {
                // cast the control as a LabelTextBoxControl
                LabelTextBoxControl textControl = sender as LabelTextBoxControl;

                // If the textControl object exists
                if (NullHelper.Exists(textControl, this.Info))
                {
                    // if this is the FirstNamesControl
                    if (textControl.Name == this.FirstNamesCountControl.Name)
                    {
                        // Set the FirstNamesCount
                        Info.FirstNamesCount = FirstNamesCountControl.IntValue;
                    }
                    else if (textControl.Name == this.LastNamesCountControl.Name)
                    {
                        // Set the LastNamesCount
                        Info.LastNamesCount = LastNamesCountControl.IntValue;
                    }
                    else if (textControl.Name == PercentApartmentsControl.Name)
                    {
                        // parse out the percent in apartments
                        info.PercentInApartments = PercentApartmentsControl.IntValue;
                    }
                    else if (textControl.Name == PercentUnitNumericControl.Name)
                    {
                        // parse out the percent units numeric
                        info.PercentUnitNumeric = PercentUnitNumericControl.IntValue;
                    }
                    else if (textControl.Name == this.FirstNamesCountControl.Name)
                    {
                        // Set the FirstNamesCount
                        info.FirstNamesCount = FirstNamesCountControl.IntValue;
                    }
                    else if (textControl.Name == this.LastNamesCountControl.Name)
                    {
                        // Set the LastNamesCount
                        info.LastNamesCount = LastNamesCountControl.IntValue;
                    }
                    else if (textControl.Name == this.StreetNamesCountControl.Name)
                    {
                        // Set the StreetNamesCount
                        info.StreetNamesCount = StreetNamesCountControl.IntValue;
                    }
                    else if (textControl.Name == this.ZipCodesCountControl.Name)
                    {
                        // Set the ZipCodesCount
                        info.ZipCodesCount = ZipCodesCountControl.IntValue;
                    }
                    else if (textControl.Name == this.MembersToCreateControl.Name)
                    {
                        // set the MembersToCreate
                        info.MembersToCreate = MembersToCreateControl.IntValue;
                    }
                }
            }
            #endregion
            
            #region PercentApartmentsSlider_ValueChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Percent Apartments Slider _ Value Changed
            /// </summary>
            private void PercentApartmentsSlider_ValueChanged(object sender, EventArgs e)
            {
                // Display the value as a percentage
                this.PercentApartmentsControl.Text = (PercentApartmentsSlider.Value * 10).ToString() + "%";
            }
            #endregion
            
            #region PercentNumericSlider_ValueChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Percent Numeric Slider _ Value Changed
            /// </summary>
            private void PercentNumericSlider_ValueChanged(object sender, EventArgs e)
            {
                // Display the value as a percentage
                this.PercentUnitNumericControl.Text = (PercentNumericSlider.Value * 10).ToString() + "%";
            }
            #endregion
            
            #region SaveButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SaveButton' is clicked.
            /// </summary>
            private void SaveButton_Click(object sender, EventArgs e)
            {
                // If DataTier.Net
                if ((HasInfo) && (Info.DataTechnology == DataTechnologyEnum.DataTierNet))
                {
                    // Save the DataTier.Net members
                    SaveMembers(this.DTNMembers);
                }
                else if ((HasInfo) && (Info.DataTechnology == DataTechnologyEnum.EntityFramework))
                {
                    // Save the Entity Framework members
                    SaveMembers(this.EFMembers);
                }

                // Disable the Save button at this point becase we are Done
                UIEnable();
            }
            #endregion
            
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// This method  This method performs initializations for this object.
            /// /// </summary>
            public void Init()
            {
                // Setup the listeners
                FirstNamesCountControl.OnTextChangedListener = this;
                LastNamesCountControl.OnTextChangedListener = this;
                MinAddressNumberControl.OnTextChangedListener = this;
                MaxAddressNumberControl.OnTextChangedListener = this;
                PercentApartmentsControl.OnTextChangedListener = this;
                PercentUnitNumericControl.OnTextChangedListener = this;
                StreetNamesCountControl.OnTextChangedListener = this;
                ZipCodesCountControl.OnTextChangedListener = this;
                MembersToCreateControl.OnTextChangedListener = this;
                UseDataTierNetCheckBox.CheckChangedListener = this;
                UseEntityFrameworkCheckBox.CheckChangedListener = this;

               // Create a new instance of a 'RandomCreatorInfo' object.
               this.Info = new RandomCreatorInfo();

                // Setup the default values
                this.MinAddressNumberControl.Text = "1";
                this.MaxAddressNumberControl.Text = "19,999";
                this.PercentApartmentsControl.Text = "20%";
                this.PercentApartmentsSlider.Value = 2;
                this.PercentUnitNumericControl.Text = "80%";
                this.PercentNumericSlider.Value = 8;
                this.MembersToCreateControl.Text = "10,000";

                // Set the same properties on the current Info
                Info.MinAddressNumber = 1;
                Info.MaxAddressNumber = 19999;
                Info.PercentInApartments = 20;
                Info.PercentUnitNumeric = 80;
                Info.MembersToCreate = 10000;

               // Defaut to DataTier.Net because it is checked
               info.DataTechnology = DataTechnologyEnum.DataTierNet;

               // Enable or disable controls
               UIEnable();
            }
            #endregion

            #region SaveMembers()

                #region SaveMembers()
                /// <summary>
                /// This method Save Members
                /// </summary>
                public bool SaveMembers(List<DTN.Member> members)
                {
                    // initial value
                    bool saved = false;

                    // locals
                    bool addressSaved = false;
                    bool memberSaved = false;
                    int savedCount = 0;
                    Gateway gateway = new Gateway();
                    string message = "Saving Members With DataTier.Net";

                    // If the members collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(members))
                    {
                        // Setup the Graph
                        SetupGraph(message, members.Count, 0);

                        // iterate the members                    
                        foreach (DTN.Member currentMember in members)
                        {
                            // get a local copy
                            DTN.Member member = currentMember;

                            // save this member
                            memberSaved = gateway.SaveMember(ref member);

                            // if the value for memberSaved is true and the new MemberId is set
                            if ((memberSaved) && (!member.IsNew))
                            {
                                // If the value for the property currentMember.HasAddress is true
                                if (currentMember.HasAddress)
                                {
                                    // get a local copy of the address
                                    DTN.Address address = currentMember.Address;

                                    // Set the memberId
                                    address.MemberId = member.Id;

                                    // save the address
                                    addressSaved = gateway.SaveAddress(ref address);

                                    // if the value for addressSaved is true
                                    if (addressSaved)
                                    {
                                        // Increment the value for savedCount
                                        savedCount++;

                                        // Update the graph every 50
                                        if (savedCount % 50 == 0)
                                        {
                                            // Setup the Graph
                                            SetupGraph(message, members.Count, savedCount);
                                        }
                                    }
                                    else
                                    {
                                        // for debugging only
                                        Exception exception = gateway.GetLastException();

                                        // Write to the console
                                        DebugHelper.WriteDebugError("SaveMembers", "MemberCreatorControl", exception);
                                    }
                                }
                                else
                                {
                                    // for debugging only
                                    Exception exception = gateway.GetLastException();

                                    // Write to the console
                                    DebugHelper.WriteDebugError("SaveMembers", "MemberCreatorControl", exception);
                                }
                            }
                        }

                        // Show a message to the user
                        MessageBoxHelper.ShowMessage("Save Members Has Finished", "Save Complete");
                    }

                    // return value
                    return saved;
                }
                #endregion

                #region SaveMembers()
                /// <summary>
                /// This method Save Members
                /// </summary>
                public bool SaveMembers(List<EF.Member> members)
                {
                    // initial value
                    bool saved = false;

                    // locals
                    int count = 0;
                    DataContext context = new DataContext();

                    string message = "First Pass - Saving Members With Entity Framework";

                    // If the members collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(members))
                    {
                        // Setup the Graph
                        SetupGraph(message, members.Count, 0);

                        // iterate the members                    
                        foreach (EF.Member currentMember in members)
                        {
                            // increment the value for count
                            count++;

                            // get a local copy
                            EF.Member member = currentMember;

                            // Save any changes
                            context.Member.Add(member);

                            // save every 50 records
                            if (count % 50 == 0)
                            {  
                                try
                                {
                                    // Save the changes
                                    context.SaveChanges();

                                     // Setup the Graph
                                    SetupGraph(message, members.Count, count);
                                }
                                catch (DbEntityValidationException ex)
                                {
                                    // for debugging only
                                    DebugHelper.WriteDebugError("SaveMembers", "MembersCreatorControl", ex);
                                }
	                            catch (DbUpdateException ex)
	                           {
                                    // for debugging only
                                    DebugHelper.WriteDebugError("SaveMembers", "MembersCreatorControl", ex);
	                           }

                                 // Setup the Graph
                                SetupGraph(message, members.Count, count);
                            }
                        }

                        // now update the Address
                        message = "Saving Addresses";

                        // Setup the Graph
                        SetupGraph(message, members.Count, 0);

                        // reset
                        count = 0;

                         // iterate the members                    
                        foreach (EF.Member member in members)
                        {
                            // increment the value for count
                            count++;

                            // if the memberId is set and the Address exists
                            if ((member.Id > 0) && (member.Address != null))
                            {
                                // set the Address
                                member.Address.MemberId = member.Id;

                                // Add this address
                                context.Address.Add(member.Address);
                            }

                            // save every 50 records
                            if (count % 50 == 0)
                            {  
                                try
                                {
                                    // Save the changes
                                    context.SaveChanges();

                                     // Setup the Graph
                                    SetupGraph(message, members.Count, count);
                                }
                                catch (DbEntityValidationException ex)
                                {
                                    // for debugging only
                                    DebugHelper.WriteDebugError("SaveMembers", "MembersCreatorControl", ex);
                                }
	                            catch (DbUpdateException ex)
	                           {
                                    // for debugging only
                                    DebugHelper.WriteDebugError("SaveMembers", "MembersCreatorControl", ex);
	                           }

                                 // Setup the Graph
                                SetupGraph(message, members.Count, count);
                            }
                        }

                        // giving the benefit of the doubt
                        saved = true;

                        // Show a message to the user
                        MessageBoxHelper.ShowMessage("Save Members Has Finished", "Save Complete");
                    }

                    // return value
                    return saved;
                }
                #endregion

            #endregion

            #region SetupGraph(string statusMessage, int maxValue, int currentValue)
            /// <summary>
            /// This method is used as a delegate for the MemberGenerator so the progress can be reported back here
            /// </summary>
            /// <param name="statusMessage"></param>
            /// <param name="maxValue"></param>
            /// <param name="currentValue"></param>
            public void SetupGraph(string message, int maxValue, int currentValue)
            {
                // set the StatusMessage
                this.StatusMessageLabel.Text = message;
                Graph.Maximum = maxValue;
                Graph.Value = currentValue;

                // refresh everything
                this.Refresh();
            }
            #endregion
            
            #region UIEnable()
            /// <summary>
            /// This method enables controls
            /// </summary>
            public void UIEnable()
            {
                // Enable the LoadDataButton if the Data has not been loaded.
                LoadDataButton.Enabled = (!DataLoaded);

                // If the Info exists and is valid then enable the CreateShufflersButton
                CreateShufflersButton.Enabled = ((HasInfo && Info.IsValid()) && (!ShufflersCreated));

                // Enable the CreateMembersButton if the Shufflers have been created
                CreateMembersButton.Enabled = ((HasMemberGenerator) && (MemberGenerator.ShufflersCreated) && (!MembersCreated));

                // Set to true if the Members were created
                SaveButton.Enabled = (MembersCreated & !Saved);

                // if the value for CreatingMembers is true
                if ((CreatingMembers) || (LoadingData) || (CreatingShufflers))
                {
                    // show the Status and Graph
                    StatusLabel.Visible = true;
                    StatusMessageLabel.Visible = true;
                    Graph.Visible = true;
                }
                else
                {
                    // show the Status and Graph
                    StatusLabel.Visible = false;
                    StatusMessageLabel.Visible = false;
                    Graph.Visible = false;
                }
            }
            #endregion

        #endregion

        #region Properties

            #region CreatingMembers
            /// <summary>
            /// This property gets or sets the value for 'CreatingMembers'.
            /// </summary>
            public bool CreatingMembers
            {
                get { return creatingMembers; }
                set { creatingMembers = value; }
            }
            #endregion
            
            #region CreatingShufflers
            /// <summary>
            /// This property gets or sets the value for 'CreatingShufflers'.
            /// </summary>
            public bool CreatingShufflers
            {
                get { return creatingShufflers; }
                set { creatingShufflers = value; }
            }
            #endregion
            
            #region DataLoaded
            /// <summary>
            /// This property gets or sets the value for 'DataLoaded'.
            /// </summary>
            public bool DataLoaded
            {
                get { return dataLoaded; }
                set { dataLoaded = value; }
            }
            #endregion
            
            #region DTNMembers
            /// <summary>
            /// This property gets or sets the value for 'DTNMembers'.
            /// </summary>
            public List<DTN.Member> DTNMembers
            {
                get { return dTNMembers; }
                set { dTNMembers = value; }
            }
            #endregion
            
            #region EFMembers
            /// <summary>
            /// This property gets or sets the value for 'EFMembers'.
            /// </summary>
            public List<EF.Member> EFMembers
            {
                get { return eFMembers; }
                set { eFMembers = value; }
            }
            #endregion
            
            #region HasInfo
            /// <summary>
            /// This property returns true if this object has an 'Info'.
            /// </summary>
            public bool HasInfo
            {
                get
                {
                    // initial value
                    bool hasInfo = (this.Info != null);
                    
                    // return value
                    return hasInfo;
                }
            }
            #endregion
            
            #region HasMemberGenerator
            /// <summary>
            /// This property returns true if this object has a 'MemberGenerator'.
            /// </summary>
            public bool HasMemberGenerator
            {
                get
                {
                    // initial value
                    bool hasMemberGenerator = (this.MemberGenerator != null);
                    
                    // return value
                    return hasMemberGenerator;
                }
            }
            #endregion
            
            #region Info
            /// <summary>
            /// This property gets or sets the value for 'Info'.
            /// </summary>
            public RandomCreatorInfo Info
            {
                get { return info; }
                set { info = value; }
            }
        #endregion

            #region LoadingData
            /// <summary>
            /// This property gets or sets the value for 'LoadingData'.
            /// </summary>
            public bool LoadingData
            {
                get { return loadingData; }
                set { loadingData = value; }
            }
            #endregion
            
            #region MemberGenerator
            /// <summary>
            /// This property gets or sets the value for 'MemberGenerator'.
            /// </summary>
            public MemberGenerator MemberGenerator
            {
                get { return memberGenerator; }
                set { memberGenerator = value; }
            }
        #endregion

            #region MembersCreated
            /// <summary>
            /// This property gets or sets the value for 'MembersCreated'.
            /// </summary>
            public bool MembersCreated
            {
                get { return membersCreated; }
                set { membersCreated = value; }
            }
            #endregion
            
            #region Saved
            /// <summary>
            /// This property gets or sets the value for 'Saved'.
            /// </summary>
            public bool Saved
            {
                get { return saved; }
                set { saved = value; }
            }
            #endregion
            
            #region ShufflersCreated
            /// <summary>
            /// This property gets or sets the value for 'ShufflersCreated'.
            /// </summary>
            public bool ShufflersCreated
            {
                get { return shufflersCreated; }
                set { shufflersCreated = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}