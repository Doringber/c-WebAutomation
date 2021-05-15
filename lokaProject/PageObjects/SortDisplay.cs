using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace NopCommerce.PageObjects
{
	class SortDisplay
	{
		[FindsBy(How = How.Id, Using = "products-pagesize")]
		public IWebElement drp_display;
	}
}
