using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMemberCreator
{
    
	#region SetupGraphCallBack(string message, int maxValue, int currentValue);
	/// <summary>
    /// This delegate is used to send a message back to the MemberCreatorControl on the progress
    /// </summary>
    /// <param name="message"></param>
    /// <param name="maxValue"></param>
    /// <param name="currentValue"></param>
	public delegate void SetupGraphCallBack(string message, int maxValue, int currentValue);
    #endregion

}
