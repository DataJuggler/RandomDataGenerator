

#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using DataJuggler.Net;
using System;

#endregion


namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllMemberAddressViewsStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'MemberAddressView' objects.
    /// </summary>
    public class FetchAllMemberAddressViewsStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllMemberAddressViewsStoredProcedure' object.
        /// </summary>
        public FetchAllMemberAddressViewsStoredProcedure()
        {
            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Set Procedure Properties
            /// </summary>
            private void Init()
            {
                // Set Properties For This Proc

                // Set ProcedureName
                this.ProcedureName = "MemberAddressView_FetchAll";

                // Set tableName
                this.TableName = "MemberAddressView";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
