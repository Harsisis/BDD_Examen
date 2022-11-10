using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MStest_Workstate1.Helpers {
    public class ButtonHelper {
        public static void ClickButton(By Locator) {
            GenericHelper.GetElement(Locator).Click();
        }
    }
}
