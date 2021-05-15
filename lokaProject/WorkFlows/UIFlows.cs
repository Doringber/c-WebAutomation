
using NopCommerce.Utilities;
using OpenQA.Selenium;
using System;
using NopCommerce.Extensions;

namespace NopCommerce.WorkFlows
{
	class UIFlows : CommonOps
	{
		public static void displayItems(IWebElement elem, int number)
		{
			UIActions.Click(elem);
			UIActions.UpdateDropDown(elem, number);
		}
	}
}
