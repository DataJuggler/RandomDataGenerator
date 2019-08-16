

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

    #region class FetchAllZipCodeViewsStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'ZipCodeView' objects.
    /// </summary>
    public class FetchAllZipCodeViewsStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllZipCodeViewsStoredProcedure' object.
        /// </summary>
        public FetchAllZipCodeViewsStoredProcedure()
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
                this.ProcedureName = "ZipCodeView_FetchAll";

                // Set tableName
                this.TableName = "ZipCodeView";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
