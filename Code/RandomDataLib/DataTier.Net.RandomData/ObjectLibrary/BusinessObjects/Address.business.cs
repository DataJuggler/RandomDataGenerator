

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Address
    [Serializable]
    public partial class Address
    {

        #region Private Variables
        #endregion

        #region Constructor
        public Address()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public Address Clone()
            {
                // Create New Object
                Address newAddress = (Address) this.MemberwiseClone();

                // Return Cloned Object
                return newAddress;
            }
        #endregion

            #region GetStateCode()
            /// <summary>
            /// This method returns the State Code
            /// </summary>
            public string GetStateCode()
            {
                // initial value
                string stateCode = "";
                
                // Determine the action by the StateId 
                switch (StateId)
                {
                    case 1:

                        // set the return value
                        stateCode = "AK";

                        // required
                        break;

                    case 2:

                        // set the return value
                        stateCode = "AL";

                        // required
                        break;

                     case 3:

                        // set the return value
                        stateCode = "AZ";

                        // required
                        break;

                     case 4:

                        // set the return value
                        stateCode = "AR";

                        // required
                        break;

                     case 5:

                        // set the return value
                        stateCode = "CA";

                        // required
                        break;

                    case 6:

                        // set the return value
                        stateCode = "CO";

                        // required
                        break;

                     case 7:

                        // set the return value
                        stateCode = "CT";

                        // required
                        break;

                     case 8:

                        // set the return value
                        stateCode = "DE";

                        // required
                        break;

                     case 9:

                        // set the return value
                        stateCode = "DC";

                        // required
                        break;

                      case 10:

                        // set the return value
                        stateCode = "FL";

                        // required
                        break;

                     case 11:

                        // set the return value
                        stateCode = "GA";

                        // required
                        break;

                    case 12:

                        // set the return value
                        stateCode = "HI";

                        // required
                        break;

                     case 13:

                        // set the return value
                        stateCode = "ID";

                        // required
                        break;

                     case 14:

                        // set the return value
                        stateCode = "IL";

                        // required
                        break;

                     case 15:

                        // set the return value
                        stateCode = "IN";

                        // required
                        break;

                    case 16:

                        // set the return value
                        stateCode = "IA";

                        // required
                        break;

                     case 17:

                        // set the return value
                        stateCode = "KS";

                        // required
                        break;

                     case 18:

                        // set the return value
                        stateCode = "KY";

                        // required
                        break;

                     case 19:

                        // set the return value
                        stateCode = "LA";

                        // required
                        break;

                    case 20:

                        // set the return value
                        stateCode = "ME";

                        // required
                        break;

                     case 21:

                        // set the return value
                        stateCode = "MD";

                        // required
                        break;

                    case 22:

                        // set the return value
                        stateCode = "MA";

                        // required
                        break;

                     case 23:

                        // set the return value
                        stateCode = "MI";

                        // required
                        break;

                     case 24:

                        // set the return value
                        stateCode = "MN";

                        // required
                        break;

                     case 25:

                        // set the return value
                        stateCode = "MS";

                        // required
                        break;

                    case 26:

                        // set the return value
                        stateCode = "MO";

                        // required
                        break;

                     case 27:

                        // set the return value
                        stateCode = "MT";

                        // required
                        break;

                     case 28:

                        // set the return value
                        stateCode = "NE";

                        // required
                        break;

                     case 29:

                        // set the return value
                        stateCode = "NV";

                        // required
                        break;

                      case 30:

                        // set the return value
                        stateCode = "NH";

                        // required
                        break;

                     case 31:

                        // set the return value
                        stateCode = "NJ";

                        // required
                        break;

                    case 32:

                        // set the return value
                        stateCode = "NM";

                        // required
                        break;

                     case 33:

                        // set the return value
                        stateCode = "NY";

                        // required
                        break;

                     case 34:

                        // set the return value
                        stateCode = "NC";

                        // required
                        break;

                     case 35:

                        // set the return value
                        stateCode = "ND";

                        // required
                        break;

                    case 36:

                        // set the return value
                        stateCode = "OH";

                        // required
                        break;

                     case 37:

                        // set the return value
                        stateCode = "OK";

                        // required
                        break;

                     case 38:

                        // set the return value
                        stateCode = "OR";

                        // required
                        break;

                     case 39:

                        // set the return value
                        stateCode = "PA";

                        // required
                        break;

                      case 40:

                        // set the return value
                        stateCode = "RI";

                        // required
                        break;

                     case 41:

                        // set the return value
                        stateCode = "SC";

                        // required
                        break;

                    case 42:

                        // set the return value
                        stateCode = "SD";

                        // required
                        break;

                     case 43:

                        // set the return value
                        stateCode = "TN";

                        // required
                        break;

                     case 44:

                        // set the return value
                        stateCode = "TX";

                        // required
                        break;

                     case 45:

                        // set the return value
                        stateCode = "UT";

                        // required
                        break;

                    case 46:

                        // set the return value
                        stateCode = "VT";

                        // required
                        break;

                     case 47:

                        // set the return value
                        stateCode = "VA";

                        // required
                        break;

                     case 48:

                        // set the return value
                        stateCode = "WA";

                        // required
                        break;

                     case 49:

                        // set the return value
                        stateCode = "WV";

                        // required
                        break;

                    case 50:

                        // set the return value
                        stateCode = "WI";

                        // required
                        break;

                    case 51:

                        // set the return value
                        stateCode = "WY";

                        // required
                        break;
                }

                // return value
                return stateCode;
            }
            #endregion
            
            #region ToString()
            /// <summary>
            /// This method is used to return the full address when ToString is called
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                // initial value
                string address = "";

                // if the Unit exists
                if (!String.IsNullOrEmpty(Unit))
                {
                    // set the return value including the unit
                    address = this.StreetAddress + " " + Unit + ", " + City + ", " + GetStateCode() + " " + ZipCode;
                }
                else
                {
                    // set the return value
                    address = this.StreetAddress + ", " + City + ", " + GetStateCode() + " " + ZipCode;
                }

                // return value
                return address;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
