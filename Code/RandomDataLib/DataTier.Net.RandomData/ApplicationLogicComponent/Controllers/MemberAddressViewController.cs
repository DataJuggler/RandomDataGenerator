

#region using statements

using ApplicationLogicComponent.DataBridge;
using ApplicationLogicComponent.DataOperations;
using ApplicationLogicComponent.Logging;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.Controllers
{

    #region class MemberAddressViewController
    /// <summary>
    /// This class controls a(n) 'MemberAddressView' object.
    /// </summary>
    public class MemberAddressViewController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'MemberAddressViewController' object.
        /// </summary>
        public MemberAddressViewController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateMemberAddressViewParameter
            /// <summary>
            /// This method creates the parameter for a 'MemberAddressView' data operation.
            /// </summary>
            /// <param name='memberaddressview'>The 'MemberAddressView' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateMemberAddressViewParameter(MemberAddressView memberAddressView)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = memberAddressView;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region FetchAll(MemberAddressView tempMemberAddressView)
            /// <summary>
            /// This method fetches a collection of 'MemberAddressView' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'MemberAddressView_FetchAll'.</summary>
            /// <param name='tempMemberAddressView'>A temporary MemberAddressView for passing values.</param>
            /// <returns>A collection of 'MemberAddressView' objects.</returns>
            public List<MemberAddressView> FetchAll(MemberAddressView tempMemberAddressView)
            {
                // Initial value
                List<MemberAddressView> memberAddressViewList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.MemberAddressViewMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateMemberAddressViewParameter(tempMemberAddressView);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<MemberAddressView> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        memberAddressViewList = (List<MemberAddressView>) returnObject.ObjectValue;
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return memberAddressViewList;
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ErrorProcessor
            public ErrorHandler ErrorProcessor
            {
                get { return errorProcessor; }
                set { errorProcessor = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
