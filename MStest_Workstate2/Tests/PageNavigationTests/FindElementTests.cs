using Microsoft.VisualStudio.TestTools.UnitTesting;
using MStest_Workstate1.Helpers;
using OpenQA.Selenium;
using SpecFlowProject_BDD.BasesClasses;
using System;
using System.Collections.ObjectModel;

namespace MStest_Workstate1.Tests.PageNavigationTests {
    [TestClass]
    public class FindElementTests {
        [TestMethod]
        public void GetElementTests() {
            try {
                ObjectRepository.Driver.FindElement(By.LinkText("Contact"));
            } catch (NoSuchElementException ex) {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void GetElementsTests() {
            try {
                ReadOnlyCollection<IWebElement> elements = ObjectRepository.Driver.FindElements(By.TagName("input"));
                Console.WriteLine(elements.Count);
            } catch (NoSuchElementException ex) {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void GetElementFromGenericHelper() {
            Assert.IsNotNull(GenericHelper.GetElement(By.LinkText("Contact")));
        }

        [TestMethod]
        public void IsElementPresentOnce() {
            Assert.IsTrue(ObjectRepository.Driver.FindElements(By.LinkText("Contact")).Count == 1);
        }

        [TestMethod]
        public void IsElementPresentOnceFromGenericHelper() {
            Assert.IsTrue(GenericHelper.IsElementPresentOnce(By.LinkText("Contact")));
        }
    }
}
