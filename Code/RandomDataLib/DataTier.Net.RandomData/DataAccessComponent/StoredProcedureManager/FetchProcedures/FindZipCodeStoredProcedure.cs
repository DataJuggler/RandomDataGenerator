

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

    #region class FindZipCodeStoredProcedure
    /// <summary>
    /// This class is used to Find a 'ZipCode' object.
    /// </summary>
    public class FindZipCodeStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindZipCodeStoredProcedure' object.
        /// </summary>
        public FindZipCodeStoredProcedure()
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
                this.ProcedureName = "ZipCode_Find";

                // Set tableName
                this.TableName = "ZipCode";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
