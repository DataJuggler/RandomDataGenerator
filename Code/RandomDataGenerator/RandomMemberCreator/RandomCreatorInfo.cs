
#region using statements

using RandomMemberCreator.Enumerations;

#endregion

namespace RandomMemberCreator
{

    #region class RandomCreatorInfo
    /// <summary>
    /// This class is used to capture all the properties from the MemberCreatorControl
    /// and pass it to the MemberCreator.
    /// </summary>
    public class RandomCreatorInfo
    {
        
        #region Private Variables
        private int minAddressNumber;
        private int maxAddressNumber;
        private int streetNamesCount;
        private int zipCodesCount;
        private int membersToCreate;
        private DataTechnologyEnum dataTechnology;
        private int percentInApartments;
        private int percentUnitNumeric;
        private int firstNamesCount;
        private int lastNamesCount;
        #endregion

        #region Methods

            #region IsValid()
            /// <summary>
            /// method returns the Valid
            /// </summary>
            public bool IsValid()
            {
                // initial value
                bool isValid = ((FirstNamesCount > 0) && (LastNamesCount > 0) && (StreetNamesCount > 0) && (ZipCodesCount > 0) && (MinAddressNumber > 0) && (MaxAddressNumber > 0) && (DataTechnology != DataTechnologyEnum.Unknown) && (MembersToCreate > 0));
                
                // return value
                return isValid;
            }
            #endregion
            
        #endregion

        #region Properties

        #region DataTechnology
        /// <summary>
        /// This property gets or sets the value for 'DataTechnology'.
        /// </summary>
        public DataTechnologyEnum DataTechnology
            {
                get { return dataTechnology; }
                set { dataTechnology = value; }
            }
            #endregion
            
            #region FirstNamesCount
            /// <summary>
            /// This property gets or sets the value for 'FirstNamesCount'.
            /// </summary>
            public int FirstNamesCount
            {
                get { return firstNamesCount; }
                set { firstNamesCount = value; }
            }
            #endregion
            
            #region LastNamesCount
            /// <summary>
            /// This property gets or sets the value for 'LastNamesCount'.
            /// </summary>
            public int LastNamesCount
            {
                get { return lastNamesCount; }
                set { lastNamesCount = value; }
            }
            #endregion
            
            #region MaxAddressNumber
            /// <summary>
            /// This property gets or sets the value for 'MaxAddressNumber'.
            /// </summary>
            public int MaxAddressNumber
            {
                get { return maxAddressNumber; }
                set { maxAddressNumber = value; }
            }
            #endregion
            
            #region MembersToCreate
            /// <summary>
            /// This property gets or sets the value for 'MembersToCreate'.
            /// </summary>
            public int MembersToCreate
            {
                get { return membersToCreate; }
                set { membersToCreate = value; }
            }
            #endregion
            
            #region MinAddressNumber
            /// <summary>
            /// This property gets or sets the value for 'MinAddressNumber'.
            /// </summary>
            public int MinAddressNumber
            {
                get { return minAddressNumber; }
                set { minAddressNumber = value; }
            }
            #endregion
            
            #region PercentInApartments
            /// <summary>
            /// This property gets or sets the value for 'PercentInApartments'.
            /// </summary>
            public int PercentInApartments
            {
                get { return percentInApartments; }
                set { percentInApartments = value; }
            }
            #endregion
            
            #region PercentUnitNumeric
            /// <summary>
            /// This property gets or sets the value for 'PercentUnitNumeric'.
            /// </summary>
            public int PercentUnitNumeric
            {
                get { return percentUnitNumeric; }
                set { percentUnitNumeric = value; }
            }
            #endregion
            
            #region StreetNameCount
            /// <summary>
            /// This property gets or sets the value for 'StreetNamesCount'.
            /// </summary>
            public int StreetNamesCount
            {
                get { return streetNamesCount; }
                set { streetNamesCount = value; }
            }
            #endregion
            
            #region ZipCodesCount
            /// <summary>
            /// This property gets or sets the value for 'ZipCodesCount'.
            /// </summary>
            public int ZipCodesCount
            {
                get { return zipCodesCount; }
                set { zipCodesCount = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
