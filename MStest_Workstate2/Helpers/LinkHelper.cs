using OpenQA.Selenium;
using SpecFlowProject_BDD.BasesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MStest_Workstate1.Helpers {
    internal class LinkHelper {
        public static void ClickLink(By Locator) {
            GenericHelper.GetElement(Locator).Click();
        }
    }
}
