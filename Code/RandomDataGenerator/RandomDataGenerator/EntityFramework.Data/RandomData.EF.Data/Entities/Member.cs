

#region using statements

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#endregion

namespace RandomData.EF.Data.Entities
{

    #region class Member
    public partial class Member
    {

        #region Private Variables
        private bool active;
        private string firstName;
        private int id;
        private string lastName;
        private Address address;
        #endregion

        #region Properties

            #region Address
            /// <summary>
            /// This property gets or sets the value for 'Address'.
            /// </summary>
            [NotMapped]
            public Address Address
            {
                get { return address; }
                set { address = value; }
            }
            #endregion
            
            #region bool Active
            public bool Active
            {
                get
                {
                    return active;
                }
                set
                {
                    active = value;
                }
            }
            #endregion

            #region string FirstName
            public string FirstName
            {
                get
                {
                    return firstName;
                }
                set
                {
                    firstName = value;
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

            #region string LastName
            public string LastName
            {
                get
                {
                    return lastName;
                }
                set
                {
                    lastName = value;
                }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
