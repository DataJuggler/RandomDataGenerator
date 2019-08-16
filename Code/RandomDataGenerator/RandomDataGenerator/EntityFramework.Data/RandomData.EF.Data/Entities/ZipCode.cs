

#region using statements

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#endregion


namespace RandomData.EF.Data.Entities
{

    #region class ZipCode
    public partial class ZipCode
    {

        #region Private Variables
        private string cityName;
        private int id;
        private string name;
        private int stateId;    
        #endregion

        #region Methods

        #endregion

        #region Properties

            #region CityName
            /// <summary>
            /// This property gets or sets the value for 'CityName'.
            /// </summary>
            public string CityName
            {
                get { return cityName; }
                set { cityName = value; }
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

            #region string Name
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            #endregion

            #region int StateId
            public int StateId
            {
                get
                {
                    return stateId;
                }
                set
                {
                    stateId = value;
                }
            }
            #endregion
          
        #endregion

    }
    #endregion

}
