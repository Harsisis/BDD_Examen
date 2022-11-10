using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SpecFlowProject_BDD.Configuration;
using SpecFlowProject_BDD.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;

namespace SpecFlowProject_BDD.BasesClasses {
    [TestClass]
    public class BaseClass {
        public static IWebDriver GetChromeWebDriver() {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }

        public static IWebDriver GetFirefoxWebDriver() {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        [AssemblyInitialize]
        public static void InitWebDriver(TestContext tc) {
            ObjectRepository.Config = new ConfigReader();

            switch (ObjectRepository.Config.GetBrowser()) {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeWebDriver();
                    break;
                case BrowserType.Firefox:
                    ObjectRepository.Driver = GetFirefoxWebDriver();
                    break;

            }

            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
        }

        [AssemblyCleanup]
        public static void TearDownWebDriver() {
            if (ObjectRepository.Driver != null) {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }
    }
}
