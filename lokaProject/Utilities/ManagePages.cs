using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NopCommerce.Utilities
{
	class ManagePages : CommonOps
	{
		public static void init()
		{
			PageFactory.InitElements(driver, topMenu);
			PageFactory.InitElements(driver, items);
			PageFactory.InitElements(driver, sortDisplay);
		}
	}
}
