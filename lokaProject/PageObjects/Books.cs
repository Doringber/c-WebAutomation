using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace NopCommerce.PageObjects
{
	class Books
	{
		[FindsBy(How = How.ClassName, Using = "item-box")]
		public IList<IWebElement> lst_items;
	}
}
