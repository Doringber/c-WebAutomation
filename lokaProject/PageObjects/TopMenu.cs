using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace NopCommerce.PageObjects
{
	class TopMenu
	{
		[FindsBy(How = How.CssSelector, Using = "a[href='/books']")]
		public IWebElement lnk_book;
	}
}
