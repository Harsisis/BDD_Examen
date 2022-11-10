using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SpecFlowProject_BDD.Configuration;
using SpecFlowProject_BDD.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using MStest_Workstate1.Helpers;
using SpecFlowProject_BDD.BasesClasses;

namespace MStest_Workstate1.PageNavigationTests {
    [TestClass]
    public class PageNavigationTests {

        [TestMethod]
        public void OpenPageFromDriver() {
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
        }

        [TestMethod]
        public void OpenPageFromObjectRepository() {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }

        [TestMethod]
        public void OpenPageFromObjectRepositoryAndGetTitle() {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Console.WriteLine(ObjectRepository.Driver.Title);
        }

        [TestMethod]
        public void OpenPageFromObjectRepositoryAndGetTitleFromPageHelper() {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Console.WriteLine(PageHelper.GetPageTitle());
        }
    }
}
