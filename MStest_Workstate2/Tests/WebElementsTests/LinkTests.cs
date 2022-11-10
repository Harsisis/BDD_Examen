using Microsoft.VisualStudio.TestTools.UnitTesting;
using MStest_Workstate1.Helpers;
using OpenQA.Selenium;
using SpecFlowProject_BDD.BasesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MStest_Workstate1.Tests.WebElementsTests
{
    [TestClass]
    public class LinkTests
    {
        [TestInitialize]
        public void GoToHome() {
            NavigationHelper.NavigateToHomePage();
        }

        [TestMethod]
        public void ClickLinkTest()
        {
            ObjectRepository.Driver.FindElement(By.LinkText("Contact")).Click();
        }

        [TestMethod]
        public void ClickLinkFromHelperTest()
        {
            LinkHelper.ClickLink(By.LinkText("Contact"));
        }
    }
}
