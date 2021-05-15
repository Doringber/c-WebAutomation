
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NopCommerce.Extensions;
using NopCommerce.Utilities;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;

namespace NopCommerce.TestCases
{
	[TestClass]
	class Tests : CommonOps
	{
		[TestMethod]
		public void test01_VerifyBooks()
		{
			WorkFlows.UIFlows.displayItems(topMenu.lnk_book, 2);
			Verifications.VerifyEquals(2, UIActions.GetListCount(items.lst_items));
		}
	}
}
