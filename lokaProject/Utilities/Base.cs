using OpenQA.Selenium;
using System;
using NopCommerce.PageObjects;
using AventStack.ExtentReports;

namespace NopCommerce.Utilities
{
	class Base
	{
		public static IWebDriver driver;
		public static ExtentReports extent;
		public static ExtentTest test;
		public static String TimeStamp = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd_HH-mm-ss");

		public static TopMenu topMenu = new TopMenu();
		public static Items items = new Items();
		public static SortDisplay sortDisplay = new SortDisplay();
	}
}
