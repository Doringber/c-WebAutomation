using Microsoft.VisualStudio.TestTools.UnitTesting;
using NopCommerce.Utilities;

using System;

namespace NopCommerce.Extensions
{
	class Verifications : CommonOps
	{
		public static void VerifyEquals(int expected, int actual)
		{
			try
			{
				Assert.AreEqual(expected, actual);
				//test.Log(LogStatus.Pass, "Verify Equals Pased");
			}
			catch (Exception e)
			{
				//test.Log(LogStatus.Fail, "Verify Equals Failed: " + e + test.AddScreenCapture(ScreenShot()));
			}
		}
	}
}
