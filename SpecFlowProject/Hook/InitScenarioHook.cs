using MStest_Workstate1.Helpers;
using SpecFlowProject_BDD.BasesClasses;
using SpecFlowProject_BDD.Configuration;
using SpecFlowProject_BDD.Settings;

namespace SpecFlowProject.Hook {
    [Binding]
    public class InitScenarioHook {
        [BeforeScenario]
        public static void InitScenario() {
            ObjectRepository.Config = new ConfigReader();

            switch (ObjectRepository.Config.GetBrowser()) {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = BaseClass.GetChromeWebDriver();
                    break;

                case BrowserType.Firefox:
                    ObjectRepository.Driver = BaseClass.GetFirefoxWebDriver();
                    break;
            }

            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }

        [AfterScenario]
        public static void TearDown() {
            if (ObjectRepository.Driver != null) {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }
    }
}
