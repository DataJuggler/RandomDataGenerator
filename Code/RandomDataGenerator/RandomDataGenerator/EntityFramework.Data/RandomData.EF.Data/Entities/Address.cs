

#region using statements

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#endregion

namespace RandomData.EF.Data.Entities
{

    #region class Address
    public partial class Address
    {

        #region Private Variables
        private string city;
        private int id;
        private int stateId;
        private int memberId;
        private string streetAddress;
        private string unit;
        private string zipCode;
        #endregion

        #region Properties
            
            #region string City
            public string City
            {
                get
                {
                    return city;
                }
                set
                {
                    city = value;
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

            #region int MemberId
            /// <summary>
            /// This property gets or sets the value for 'MemberId'.
            /// </summary>
            public int MemberId
            {
                get { return memberId; }
                set { memberId = value; }
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

            #region string StreetAddress
            public string StreetAddress
            {
                get
                {
                    return streetAddress;
                }
                set
                {
                    streetAddress = value;
                }
            }
            #endregion

            #region string ZipCode
            public string ZipCode
            {
                get
                {
                    return zipCode;
                }
                set
                {
                    zipCode = value;
                }
            }
            #endregion

            #region Unit
            /// <summary>
            /// This property gets or sets the value for 'Unit'.
            /// </summary>
            public string Unit
            {
                get { return unit; }
                set { unit = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
