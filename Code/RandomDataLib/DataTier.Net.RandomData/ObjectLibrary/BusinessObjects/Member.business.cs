

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Member
    [Serializable]
    public partial class Member
    {

        #region Private Variables
        private Address address;
        #endregion

        #region Constructor
        public Member()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public Member Clone()
            {
                // Create New Object
                Member newMember = (Member) this.MemberwiseClone();

                // Return Cloned Object
                return newMember;
            }
            #endregion

            #region ToString()
            /// <summary>
            /// This method returns a summary of this Member
            /// </summary>
            public override string ToString()
            {
                // initial value
                string toString = FirstName + " " + LastName;

                // if the value for HasAddress is true
                if (HasAddress)
                {
                    // set the return value
                    toString = toString + ", " + Address.ToString();
                }

                // return value
               return toString;
            }
            #endregion

        #endregion

        #region Properties

            #region Address
            /// <summary>
            /// This property gets or sets the value for 'Address'.
            /// </summary>
            public Address Address
            {
                get { return address; }
                set {address = value; }
            }
            #endregion
            
            #region HasAddress
            /// <summary>
            /// This property returns true if this object has an 'Address'.
            /// </summary>
            public bool HasAddress
            {
                get
                {
                    // initial value
                    bool hasAddress = (this.Address != null);
                    
                    // return value
                    return hasAddress;
                }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
