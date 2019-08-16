
#region using statements

using System;

#endregion

namespace ObjectLibrary.BusinessObjects
{

    #region class State
    [Serializable]
    public partial class State
    {

        #region Private Variables
        private bool findByName;
        #endregion

        #region Constructor
        public State()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public State Clone()
            {
                // Create New Object
                State newState = (State) this.MemberwiseClone();

                // Return Cloned Object
                return newState;
            }
            #endregion

        #endregion

        #region Properties

            #region FindByName
            /// <summary>
            /// This property gets or sets the value for 'FindByName'.
            /// </summary>
            public bool FindByName
            {
                get { return findByName; }
                set { findByName = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
