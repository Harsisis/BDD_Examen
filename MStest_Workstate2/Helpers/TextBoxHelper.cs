using OpenQA.Selenium;
using SpecFlowProject_BDD.BasesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MStest_Workstate1.Helpers {
    public class TextBoxHelper {
        public static void TypeInTextBox(By locator, string text) {
            ObjectRepository.Driver.FindElement(locator).SendKeys(text);
        }
        public static void ClearTextBox(By locator) {
            ObjectRepository.Driver.FindElement(locator).Clear();
        }
    }
}
