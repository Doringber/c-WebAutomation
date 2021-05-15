using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Xml;
using OpenQA.Selenium;
using System.IO;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NopCommerce.Utilities
{
	class CommonOps : Base
	{
		public static string getData(string sNodeName)
		{
			using (XmlReader reader = XmlReader.Create(@"../lokaProject/Configuration.xml"))
			{
				while (reader.Read())
				{
					if (reader.IsStartElement())
					{
						if (reader.Name.ToString().Equals(sNodeName))
							return reader.ReadString();
					}
				}
			}
			return "NULL";
		}

		public static void initBrowser(String browserType)
		{
			switch (browserType)
			{
				case "chrome":
				{
					driver = new ChromeDriver();
					break;
				}
				case "firefox":
				{
					driver = new FirefoxDriver();
					break;
				}
				default:
				{
					Console.WriteLine("NOt Supported ?");
					break;
				}
			}
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl(getData("URL"));
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Convert.ToDouble(getData("TimeOut")));
		}

		public static void initReport()
		{
			Directory.CreateDirectory(getData("ReportFilePath") + TimeStamp);
			extent = new ExtentReports();
			//getData("ReportFilePath") + TimeStamp + getData("ReportFileName")
		}

		public static String ScreenShot()
		{
			String location = getData("ReportFilePath") + TimeStamp + "\\screen.png";
			((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(location, ScreenshotImageFormat.Png);
			return location;
		}


		[ClassInitialize]
		public void startSession()
		{
			initBrowser(getData("BrowserType"));			
			ManagePages.init();
			initReport();
		}

		[TestInitialize]
		public void BeforeTest()
		{
			test = extent.StartTest(TestContext.CurrentContext.Test.Name.Split('_')[0], TestContext.CurrentContext.Test.Name.Split('_')[1]);
		}

		[TestCleanup]
		public void AfterTest()
		{
			extent.EndTest(test);
		}

		[ClassCleanup]
		public void closeSession()
		{
			extent.Flush();
			extent.Close();
			driver.Quit();
		}
	}
}
