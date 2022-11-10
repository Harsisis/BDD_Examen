using SpecFlowProject_BDD.Configuration;
using SpecFlowProject_BDD.Interfaces;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;

namespace SpecFlowProject_BDD.Tests.NavigatorTests {
    [TestClass]
    public class NavigatorTests {

        [TestMethod]
        public void OpenChromeAndGoToHomePage() {
            IWebDriver driver = new ChromeDriver();
            IConfig config = new ConfigReader();
            driver.Navigate().GoToUrl(config.GetWebsite());
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        [Ignore] // firefox is not installed on my computer
        public void OpenFirefoxAndGoToHomePage() {
            IWebDriver driver = new FirefoxDriver();
            IConfig config = new ConfigReader();
            driver.Navigate().GoToUrl(config.GetWebsite());
            driver.Close();
            driver.Quit();
        }
    }
}
