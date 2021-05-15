//using NopCommerce.Utilities;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;
//using System;
//using System.Collections.Generic;
//using System.Threading;

//namespace NopCommerce.Extensions
//{
//	class UIActions : CommonOps
//	{

//		static SelectElement drop;

//		public static void Click(IWebElement elem)
//		{
//			try
//			{
//				// Excpilict Wait
//				elem.Click();
//				test.Log(LogStatus.Pass, "Clicked Successfully");
//			}
//			catch (Exception e)
//			{
//				test.Log(LogStatus.Fail, "Clicked Failed: " + e + test.AddScreenCapture(ScreenShot()));
//			}
//		}

//		public static void UpdateDropDown(IWebElement elem, String value)
//		{
//			try
//			{
//				// Excpilict Wait
//				drop = new SelectElement(elem);
//				drop.SelectByText(value);
//				test.Log(LogStatus.Pass, "DropDown Update Successfully");
//			}
//			catch (Exception e)
//			{
//				test.Log(LogStatus.Fail, "DropDown Failed: " + e + test.AddScreenCapture(ScreenShot()));
//			}
//		}

//		public static void UpdateDropDown(IWebElement elem, int index)
//		{
//			try
//			{
//				// Excpilict Wait
//				drop = new SelectElement(driver.FindElement(By.Id("products-pagesize")));// Need to be Replaces with PageObjcts - element
//				//drop = new SelectElement(elem);
//				drop.SelectByIndex(index);
//				test.Log(LogStatus.Pass, "DropDown Update Successfully");

//			}
//			catch (Exception e)
//			{
//				test.Log(LogStatus.Fail, "DropDown Failed: " + e + test.AddScreenCapture(ScreenShot()));
//			}
//		}

//		public static int GetListCount(IList<IWebElement> elems)
//		{
//			return elems.Count;
//		}
		

//	}
//}
