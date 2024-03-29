

#region using statements

using DataAccessComponent.DataManager.Readers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager
{

    #region class DataManager
    /// <summary>
    /// This class manages data operations for this project.
    /// </summary>
    public class DataManager
    {

        #region Private Variables
        private DataConnector dataConnector;
        private AddressManager addressManager;
        private FirstNameManager firstnameManager;
        private LastNameManager lastnameManager;
        private MemberManager memberManager;
        private MemberAddressViewManager memberaddressviewManager;
        private StateManager stateManager;
        private StreetNameManager streetnameManager;
        private ZipCodeManager zipcodeManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new instance of a(n) 'DataManager' object.
        /// </summary>
        public DataManager()
        {
            // Perform Initializations For This Object.
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Perform Initializations For This Object.
            /// Create the DataConnector and the Child Object Managers.
            /// </summary>
            private void Init()
            {
                // Create New DataConnector
                this.DataConnector = new DataConnector();

                // Create Child Object Managers
                this.AddressManager = new AddressManager(this);
                this.FirstNameManager = new FirstNameManager(this);
                this.LastNameManager = new LastNameManager(this);
                this.MemberManager = new MemberManager(this);
                this.MemberAddressViewManager = new MemberAddressViewManager(this);
                this.StateManager = new StateManager(this);
                this.StreetNameManager = new StreetNameManager(this);
                this.ZipCodeManager = new ZipCodeManager(this);
            }
            #endregion

        #endregion

        #region Properties

            #region DataConnector
            public DataConnector DataConnector
            {
                get { return dataConnector; }
                set { dataConnector = value; }
            }
            #endregion

            #region AddressManager
            public AddressManager AddressManager
            {
                get { return addressManager; }
                set { addressManager = value; }
            }
            #endregion

            #region FirstNameManager
            public FirstNameManager FirstNameManager
            {
                get { return firstnameManager; }
                set { firstnameManager = value; }
            }
            #endregion

            #region LastNameManager
            public LastNameManager LastNameManager
            {
                get { return lastnameManager; }
                set { lastnameManager = value; }
            }
            #endregion

            #region MemberManager
            public MemberManager MemberManager
            {
                get { return memberManager; }
                set { memberManager = value; }
            }
            #endregion

            #region MemberAddressViewManager
            public MemberAddressViewManager MemberAddressViewManager
            {
                get { return memberaddressviewManager; }
                set { memberaddressviewManager = value; }
            }
            #endregion

            #region StateManager
            public StateManager StateManager
            {
                get { return stateManager; }
                set { stateManager = value; }
            }
            #endregion

            #region StreetNameManager
            public StreetNameManager StreetNameManager
            {
                get { return streetnameManager; }
                set { streetnameManager = value; }
            }
            #endregion

            #region ZipCodeManager
            public ZipCodeManager ZipCodeManager
            {
                get { return zipcodeManager; }
                set { zipcodeManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
