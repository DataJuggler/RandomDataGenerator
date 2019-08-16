

#region using statements

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#endregion

namespace RandomData.EF.Data.Entities
{

    #region class Setting
    public partial class Setting
    {

        #region Private Variables
        private int defaultCount;
        private int id;
        private bool setupComplete;
        #endregion

        #region Methods

        #endregion

        #region Properties

            #region int DefaultCount
            public int DefaultCount
            {
                get
                {
                    return defaultCount;
                }
                set
                {
                    defaultCount = value;
                }
            }
            #endregion

            #region int Id
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id
            {
                get
                {
                    return id;
                }
                set
                {
                    id = value;
                }
            }
            #endregion

            #region bool SetupComplete
            public bool SetupComplete
            {
                get
                {
                    return setupComplete;
                }
                set
                {
                    setupComplete = value;
                }
            }
            #endregion

            #region bool IsNew
            [NotMapped]
            public bool IsNew
            {
                get
                {
                    // Initial Value
                    bool isNew = (this.Id < 1);

                    // return value
                    return isNew;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
