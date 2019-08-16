

#region using statements

using DataJuggler.Core.UltimateHelper;
using DataJuggler.Core.RandomShuffler;
using DataJuggler.Core.RandomShuffler.Enumerations;
using RandomMemberCreator.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGateway;
using DTN = ObjectLibrary.BusinessObjects;
using EF = RandomData.EF.Data.Entities;
using RandomData.EF.Data;

#endregion

namespace RandomMemberCreator
{

    #region class MemberGenerator
    /// <summary>
    /// This class is used to handle the random member creation for both types of object.
    /// </summary>
    public class MemberGenerator
    {

        #region Private Variables
        private LargeNumberShuffler firstNameShuffler;
        private LargeNumberShuffler lastNameShuffler;
        private LargeNumberShuffler addressNumberShuffler;
        private LargeNumberShuffler streetNameShuffler;
        private LargeNumberShuffler zipCodeShuffler;
        private List<DTN.FirstName> dTNFirstNames;
        private List<DTN.LastName> dTNLastNames;
        private List<DTN.StreetName> dTNStreetNames;
        private List<DTN.ZipCode> dTNZipCodes;
        private List<EF.FirstName> eFFirstNames;
        private List<EF.LastName> eFLastNames;
        private List<EF.StreetName> eFStreetNames;
        private List<EF.ZipCode> eFZipCodes;
        private RandomCreatorInfo info;
        private SetupGraphCallBack callBack;        
        private bool shufflersCreated;
        private bool dataLoaded;
        #endregion

        #region Constructor()

            #region Default Constructor
            /// <summary>
            /// Create a new instance of a MemberGenerator object
            /// </summary>
            public MemberGenerator()
            {
            
            }
            #endregion

            #region MemberGenerator(int minAddressNumber, int maxAddressNumber, int streetNameShufflerCount, int zipCodeShufflerCount, int membersToCreate, DataTechnologyEnum dataTechnology, double percentInApartments = 20, double percentUnitNumeric = 80)
            /// <summary>
            /// Create a new instance of a MemberGenerator object
            /// </summary>
            public MemberGenerator(int minAddressNumber, int maxAddressNumber, int membersToCreate, DataTechnologyEnum dataTechnology, int percentInApartments = 20, int percentUnitNumeric = 80)
            {
                this.Info = new RandomCreatorInfo();

                // Store the args
                Info.MinAddressNumber = minAddressNumber;
                Info.MaxAddressNumber = maxAddressNumber;
                Info.MembersToCreate = membersToCreate;
                Info.PercentInApartments = percentInApartments;
                Info.PercentUnitNumeric = percentUnitNumeric;
                Info.DataTechnology = dataTechnology;
            }
            #endregion

            #region MemberGenerator(int minAddressNumber, int maxAddressNumber, int streetNameShufflerCount, int zipCodeShufflerCount, int membersToCreate, DataTechnologyEnum dataTechnology, double percentInApartments = 20, double percentUnitNumeric = 80)
            /// <summary>
            /// Create a new instance of a MemberGenerator object
            /// </summary>
            public MemberGenerator(RandomCreatorInfo info)
            {
                // Store the args
                this.Info = info;
            }
            #endregion

        #endregion

        #region Methods

            #region CreateMembersWithDTN()
            /// <summary>
            /// This method Create Members With DTN
            /// </summary>
            public List<DTN.Member> CreateMembersWithDTN()
            {
                // initial value
                List<DTN.Member> members = null;

                // local 
                DTN.Member member = null;

                // if the data has been loaded
                if ((ShufflersCreated) && (DataLoaded) && (info.MembersToCreate > 0))
                {
                    // create the members
                    members = new List<DTN.Member>();

                    // iterate the MembersToCreate
                    for (int x = 0; x < info.MembersToCreate; x++)
                    {
                        // Create the member with DTN
                        member = CreateMemberWithDTN();

                        // If the member object exists
                        if (NullHelper.Exists(member))
                        {
                            // add this member
                            members.Add(member);
                        }
                    }
                }

                // return value
                return members;
            }
            #endregion
            
            #region CreateMembersWithEF()
            /// <summary>
            /// This method Create Members With EF
            /// </summary>
            public List<EF.Member> CreateMembersWithEF()
            {
                // initial value
                List<EF.Member> members = new List<EF.Member>();

                // local
                EF.Member member = null;

                // iterate the MembersToCreate
                for (int x = 0; x < info.MembersToCreate; x++)
                {
                    // Create the member with EF
                    member = CreateMemberWithEF();

                    // If the member object exists
                    if (NullHelper.Exists(member))
                    {
                        // add this member
                        members.Add(member);
                    }
                }

                // return value
                return members;
            }
            #endregion
            
            #region CreateMemberWithDTN()
            /// <summary>
            /// This method returns the Member With DTN
            /// </summary>
            public DTN.Member CreateMemberWithDTN()
            {
                // initial value
                DTN.Member member = new DTN.Member();

                // Locals
                DTN.ZipCode zipCode = null;
                
                // locals
                string unit = "";
                
                try
                {
                    // set each property
                    member.Active = true;

                    // Create Address
                    member.Address = new DTN.Address();
                    
                    // get the AddressNumber
                    int addressNumber = AddressNumberShuffler.PullNumber();

                    // if the AddressNumber
                    if (addressNumber % 100 < Info.PercentInApartments)
                    { 
                        // now get a number % 26
                        int isUnitNumericValue = ((addressNumber * 67) % 100) + 1;

                        // If this value is higher than percent needed for UnitNumeric
                        if (isUnitNumericValue > Info.PercentUnitNumeric)
                        {
                            // This is a letter instead of a number
                            unit = "Unit " + ((char) ((isUnitNumericValue % 26) + 65)).ToString();
                        }
                        else
                        {
                            // split half up to say 'Apt.' and half up to say #'
                            if (addressNumber % 2 == 0)
                            {
                                unit = "Apt. #" + isUnitNumericValue.ToString();
                            }
                            else if (addressNumber % 3 == 1)
                            {
                                unit = "#" + isUnitNumericValue.ToString();
                            }
                        }
                    }

                     // Set the properties on the Address
                    member.Address.StreetAddress = (addressNumber.ToString() + " " + DTNStreetNames[StreetNameShuffler.PullNumber()].Name);
                    member.Address.Unit = unit;

                    // set the ZipCode
                    zipCode = DTNZipCodes[ZipCodeShuffler.PullNumber()];

                    // if the zipCode exists
                    if (NullHelper.Exists(zipCode))
                    {
                        // Set the City
                        member.Address.City = zipCode.CityName;
                        member.Address.StateId = zipCode.StateId;
                        member.Address.ZipCode = zipCode.Name;
                    }

                    // Seft the FirstName & LastName
                    member.FirstName = DTNFirstNames[FirstNameShuffler.PullNumber()].Name;
                    member.LastName = DTNLastNames[LastNameShuffler.PullNumber()].Name;
                }
                catch (Exception error)
                {
                    // for debugging only
                    DebugHelper.WriteDebugError("CreateMemberWithDTN", "MemberGenerator", error);
                }

                // return value
                return member;
            }
            #endregion
            
            #region CreateMemberWithEF()
            /// <summary>
            /// This method returns the Member With EF
            /// </summary>
            public EF.Member CreateMemberWithEF()
            {
                // initial value
                EF.Member member = new EF.Member();

                // Locals
                EF.ZipCode zipCode = null;
                
                // locals
                string unit = "";
                
                try
                {
                    // set each property
                    member.Active = true;

                    // Create Address
                    member.Address = new EF.Address();
                    
                    // get the AddressNumber
                    int addressNumber = AddressNumberShuffler.PullNumber();

                    // if the AddressNumber
                    if (addressNumber % 100 < Info.PercentInApartments)
                    { 
                        // now get a number % 26
                        int isUnitNumericValue = ((addressNumber * 67) % 100) + 1;

                        // If this value is higher than percent needed for UnitNumeric
                        if (isUnitNumericValue > Info.PercentUnitNumeric)
                        {
                            // This is a letter instead of a number
                            unit = "Unit " + ((char) ((isUnitNumericValue % 26) + 65)).ToString();
                        }
                        else
                        {
                            // split half up to say 'Apt.' and half up to say #'
                            if (addressNumber % 2 == 0)
                            {
                                unit = "Apt. #" + isUnitNumericValue.ToString();
                            }
                            else if (addressNumber % 3 == 1)
                            {
                                unit = "#" + isUnitNumericValue.ToString();
                            }
                        }
                    }

                     // Set the properties on the Address
                    member.Address.StreetAddress = (addressNumber.ToString() + " " + EFStreetNames[StreetNameShuffler.PullNumber()].Name);
                    member.Address.Unit = unit;

                    // set the ZipCode
                    zipCode = EFZipCodes[ZipCodeShuffler.PullNumber()];

                    // if the zipCode exists
                    if (NullHelper.Exists(zipCode))
                    {
                        // Set the City
                        member.Address.City = zipCode.CityName;
                        member.Address.StateId = zipCode.StateId;
                        member.Address.ZipCode = zipCode.Name;
                    }

                    // Seft the FirstName & LastName
                    member.FirstName = EFFirstNames[FirstNameShuffler.PullNumber()].Name;
                    member.LastName = EFLastNames[LastNameShuffler.PullNumber()].Name;
                }
                catch (Exception error)
                {
                    // for debugging only
                    DebugHelper.WriteDebugError("CreateMemberWithEF", "MemberGenerator", error);
                }

                // return value
                return member;
            }
            #endregion
            
            #region CreateShufflers()
            /// <summary>
            /// This method Creates the Shufflers
            /// </summary>
            public void CreateShufflers()
            {
                // if the Callback exists
                if (HasCallBack)
                {
                    // Notify the client the status
                    CallBack("Creating First Name Shuffler", 5, 0);
                }

                // Create AddressNumberShuffler
                FirstNameShuffler = new LargeNumberShuffler(4, 0, info.FirstNamesCount - 1, NumberOutOfRangeOptionEnum.ReturnModulus);

                // if the Callback exists
                if (HasCallBack)
                {
                    // Notify the client the status
                    CallBack("Creating Last Name Shuffler", 5, 1);
                }

                // Create a new instance of a 'LargeNumberShuffler' object.
                LastNameShuffler = new LargeNumberShuffler(4, 0, info.LastNamesCount - 1, NumberOutOfRangeOptionEnum.ReturnModulus);

                // if the Callback exists
                if (HasCallBack)
                {
                    // Notify the client the status
                    CallBack("Creating Address Number Shuffler", 5, 2);
                }

                // Create a new instance of a 'LargeNumberShuffler' object.
                AddressNumberShuffler = new LargeNumberShuffler(5, 1, info.MaxAddressNumber, NumberOutOfRangeOptionEnum.ReturnModulus);

                // if the Callback exists
                if (HasCallBack)
                {
                    // Notify the client the status
                    CallBack("Creating Street Names Shuffler", 5, 3);
                }

                // Create a new instance of a 'LargeNumberShuffler' object.
                StreetNameShuffler = new LargeNumberShuffler(5, 0, info.StreetNamesCount - 1, NumberOutOfRangeOptionEnum.ReturnModulus);

                // if the Callback exists
                if (HasCallBack)
                {
                    // Notify the client the status
                    CallBack("Creating Zip Codes Shuffler", 5, 4);
                }

                // Create a new instance of a 'LargeNumberShuffler' object.
                ZipCodeShuffler = new LargeNumberShuffler(5, 0, info.ZipCodesCount - 1, NumberOutOfRangeOptionEnum.ReturnModulus);

                // if the Callback exists
                if (HasCallBack)
                {
                    // Notify the client the status
                    CallBack("Shufflers Created", 5, 5);
                }
               
                // Set the value for ShufflersCreated
                ShufflersCreated = true;
            }
            #endregion
            
            #region LoadDataWithDataTierNet()
            /// <summary>
            /// This method Loads With Data Tier Net
            /// </summary>
            public void LoadDataWithDataTierNet()
            {
                // Create a new instance of a 'Gateway' object.
                Gateway gateway = new Gateway();

                // if the value for HasCallBack is true
                if (HasCallBack)
                {
                    // Setup the Graph for this section
                    CallBack("Loading First Names...", 4, 0);
                }

                // Load each data object
                DTNFirstNames = gateway.LoadFirstNames();

                // if the value for HasCallBack is true
                if (HasCallBack)
                {
                   // Setup the Graph for this section
                    CallBack("Loading Last Names...", 4, 1);
                }

                // Load the LastNames
                DTNLastNames = gateway.LoadLastNames();

                // if the value for HasCallBack is true
                if (HasCallBack)
                {
                    // Setup the Graph for this section
                    CallBack("Loading Street Names...", 4, 2);
                }

                // Load the StreetNames
                DTNStreetNames = gateway.LoadStreetNames();

                // if the value for HasCallBack is true
                if (HasCallBack)
                {
                    // Setup the Graph for this section
                    CallBack("Loading Zip Codes...", 4, 3);
                }

                // Load the ZipCodes
                DTNZipCodes = gateway.LoadZipCodes();

                // set DataLoaded to true if all the data exists
                DataLoaded = ((ListHelper.HasOneOrMoreItems(DTNFirstNames, DTNLastNames)) && (ListHelper.HasOneOrMoreItems(DTNStreetNames)));

                // if the Data is loaded
                if (DataLoaded)
                {
                    // if the value for HasCallBack is true
                    if (HasCallBack)
                    {
                        // Setup the Graph for this section
                        CallBack("Data Loaded", 4, 4);
                    }

                    // Set the values for each property
                    Info.FirstNamesCount = DTNFirstNames.Count;
                    Info.LastNamesCount = DTNLastNames.Count;
                    info.StreetNamesCount = DTNStreetNames.Count;
                    info.ZipCodesCount = DTNZipCodes.Count;
                }
            }
            #endregion
            
            #region LoadDataWithEntityFramework()
            /// <summary>
            /// This method Load With Entity Framework
            /// </summary>
            public void LoadDataWithEntityFramework()
            {
                // Create a new instance of a 'DataContext' object.
                DataContext context = new DataContext();

                 // if the value for HasCallBack is true
                if (HasCallBack)
                {
                    // Setup the Graph for this section
                    CallBack("Loading First Names...", 4, 0);
                }

                // Load the FirstNames
                EFFirstNames = context.FirstName.ToList();

                 // if the value for HasCallBack is true
                if (HasCallBack)
                {
                   // Setup the Graph for this section
                    CallBack("Loading Last Names...", 4, 1);
                }

                // Load the Last name
                EFLastNames = context.LastName.ToList();

                 // if the value for HasCallBack is true
                if (HasCallBack)
                {
                    // Setup the Graph for this section
                    CallBack("Loading Street Names...", 4, 2);
                }

                // Load the StreetNames
                EFStreetNames = context.StreetName.ToList();

                // if the value for HasCallBack is true
                if (HasCallBack)
                {
                    // Setup the Graph for this section
                    CallBack("Loading Zip Codes...", 4, 3);
                }

                // Load the ZipCodes
                EFZipCodes = context.ZipCode.ToList();

                // set DataLoaded to true if all the data exists
                DataLoaded = ((ListHelper.HasOneOrMoreItems(EFFirstNames, EFLastNames)) && (ListHelper.HasOneOrMoreItems(EFStreetNames, EFZipCodes)));

                // if the Data is loaded
                if (DataLoaded)
                {
                    // if the value for HasCallBack is true
                    if (HasCallBack)
                    {
                        // Setup the Graph for this section
                        CallBack("Data Loaded", 4, 4);
                    }

                    // Set the values for each property
                    Info.FirstNamesCount = EFFirstNames.Count;
                    Info.LastNamesCount = EFLastNames.Count;
                    info.StreetNamesCount = EFStreetNames.Count;
                    info.ZipCodesCount = EFZipCodes.Count;
                }
            }
        #endregion

        #endregion

        #region Properties

            #region AddressNumberShuffler
            /// <summary>
            /// This property gets or sets the value for 'AddressNumberShuffler'.
            /// </summary>
            public LargeNumberShuffler AddressNumberShuffler
            {
                get { return addressNumberShuffler; }
                set { addressNumberShuffler = value; }
            }
            #endregion

            #region CallBack
            /// <summary>
            /// This property gets or sets the value for CallBack
            /// </summary>
            public SetupGraphCallBack CallBack
            {
                get
                {
                    // return value
                    return callBack;
                }
                set
                {
                    // set the value
                    callBack = value;
                }
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
            
            #region DTNFirstNames
            /// <summary>
            /// This property gets or sets the value for 'DTNFirstNames'.
            /// </summary>
            public List<DTN.FirstName> DTNFirstNames
            {
                get { return dTNFirstNames; }
                set { dTNFirstNames = value; }
            }
            #endregion
            
            #region DTNLastNames
            /// <summary>
            /// This property gets or sets the value for 'DTNLastNames'.
            /// </summary>
            public List<DTN.LastName> DTNLastNames
            {
                get { return dTNLastNames; }
                set { dTNLastNames = value; }
            }
            #endregion
            
            #region DTNStreetNames
            /// <summary>
            /// This property gets or sets the value for 'DTNStreetNames'.
            /// </summary>
            public List<DTN.StreetName> DTNStreetNames
            {
                get { return dTNStreetNames; }
                set { dTNStreetNames = value; }
            }
            #endregion
            
            #region DTNZipCodes
            /// <summary>
            /// This property gets or sets the value for 'DTNZipCodes'.
            /// </summary>
            public List<DTN.ZipCode> DTNZipCodes
            {
                get { return dTNZipCodes; }
                set { dTNZipCodes = value; }
            }
            #endregion
            
            #region EFFirstNames
            /// <summary>
            /// This property gets or sets the value for 'EFFirstNames'.
            /// </summary>
            public List<EF.FirstName> EFFirstNames
            {
                get { return eFFirstNames; }
                set { eFFirstNames = value; }
            }
            #endregion
            
            #region EFLastNames
            /// <summary>
            /// This property gets or sets the value for 'EFLastNames'.
            /// </summary>
            public List<EF.LastName> EFLastNames
            {
                get { return eFLastNames; }
                set { eFLastNames = value; }
            }
            #endregion
            
            #region EFStreetNames
            /// <summary>
            /// This property gets or sets the value for 'EFStreetNames'.
            /// </summary>
            public List<EF.StreetName> EFStreetNames
            {
                get { return eFStreetNames; }
                set { eFStreetNames = value; }
            }
            #endregion
            
            #region EFZipCodes
            /// <summary>
            /// This property gets or sets the value for 'EFZipCodes'.
            /// </summary>
            public List<EF.ZipCode> EFZipCodes
            {
                get { return eFZipCodes; }
                set { eFZipCodes = value; }
            }
            #endregion
            
            #region FirstNameShuffler
            /// <summary>
            /// This property gets or sets the value for 'FirstNameShuffler'.
            /// </summary>
            public LargeNumberShuffler FirstNameShuffler
            {
                get { return firstNameShuffler; }
                set { firstNameShuffler = value; }
            }
            #endregion
            
            #region HasCallBack
            /// <summary>
            /// This property returns true if this object has a 'CallBack'.
            /// </summary>
            public bool HasCallBack
            {
                get
                {
                    // initial value
                    bool hasCallBack = (this.CallBack != null);
                    
                    // return value
                    return hasCallBack;
                }
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
            
            #region HasStreetNameShuffler
            /// <summary>
            /// This property returns true if this object has a 'StreetNameShuffler'.
            /// </summary>
            public bool HasStreetNameShuffler
            {
                get
                {
                    // initial value
                    bool hasStreetNameShuffler = (this.StreetNameShuffler != null);
                    
                    // return value
                    return hasStreetNameShuffler;
                }
            }
            #endregion
            
            #region HasZipCodeShuffler
            /// <summary>
            /// This property returns true if this object has a 'ZipCodeShuffler'.
            /// </summary>
            public bool HasZipCodeShuffler
            {
                get
                {
                    // initial value
                    bool hasZipCodeShuffler = (this.ZipCodeShuffler != null);
                    
                    // return value
                    return hasZipCodeShuffler;
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
            
            #region LastNameShuffler
            /// <summary>
            /// This property gets or sets the value for 'LastNameShuffler'.
            /// </summary>
            public LargeNumberShuffler LastNameShuffler
            {
                get { return lastNameShuffler; }
                set { lastNameShuffler = value; }
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
            
            #region StreetNameShuffler
            /// <summary>
            /// This property gets or sets the value for 'StreetNameShuffler'.
            /// </summary>
            public LargeNumberShuffler StreetNameShuffler
            {
                get { return streetNameShuffler; }
                set { streetNameShuffler = value; }
            }
            #endregion
            
            #region ZipCodeShuffler
            /// <summary>
            /// This property gets or sets the value for 'ZipCodeShuffler'.
            /// </summary>
            public LargeNumberShuffler ZipCodeShuffler
            {
                get { return zipCodeShuffler; }
                set { zipCodeShuffler = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
