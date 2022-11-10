using Microsoft.VisualStudio.TestTools.UnitTesting;
using MStest_Workstate1.Helpers;
using OpenQA.Selenium;
using SpecFlowProject_BDD.BasesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MStest_Workstate1.Tests.WebElementsTests {
    [TestClass]
    public class ButtonTests {
        [TestInitialize]
        public void GoToHome() {
            NavigationHelper.NavigateToHomePage();
            TextBoxHelper.TypeInTextBox(By.Id("p1"), "Martin");
            TextBoxHelper.TypeInTextBox(By.Id("p2"), "Matin");
        }

        [TestMethod]
        public void ClickOnButtonTest() {
            GenericHelper.GetElement(By.Id("submitPlayers")).Click();
        }
        [TestMethod]
        public void ClickOnButtonFromHelperTest() {
            ButtonHelper.ClickButton(By.Id("submitPlayers"));
        }
    }
}
