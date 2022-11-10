using Microsoft.VisualStudio.TestTools.UnitTesting;
using MStest_Workstate1.Helpers;
using OpenQA.Selenium;
using SpecFlowProject_BDD.BasesClasses;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace MStest_Workstate1.Tests.WebElementsTests {
    [TestClass]
    public class TextBoxTests {

        [TestInitialize]
        public void GoToHome() {
            NavigationHelper.NavigateToHomePage();
        }

        [TestMethod]
        public void TextBoxTest() {
            ObjectRepository.Driver.FindElement(By.Id("p1")).SendKeys("Martin");
        }
        [TestMethod]
        public void TextBoxFromHelperTest() {
            TextBoxHelper.TypeInTextBox(By.Id("p1"), "Martin");

        }
        [TestMethod]
        public void ClearTextBoxTest() {
            ObjectRepository.Driver.FindElement(By.Id("p1")).Clear();
        }
        [TestMethod]
        public void ClearTextBoxFromHelperTest() {
            TextBoxHelper.ClearTextBox(By.Id("p1"));
        }
    }
}
