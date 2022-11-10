
using MStest_Workstate1.Helpers;
using OpenQA.Selenium;
using SpecFlowProject_BDD.BasesClasses;
using SpecFlowProject_BDD.Configuration;
using SpecFlowProject_BDD.Settings;

namespace SpecFlowProject.StepDefinitions {
    [Binding]
    public class startGameAndQuit {
        private string playerNameOne, playerNameTwo;

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

        [Given(@"the first player is (.*)")]
        public void GivenTheFisrtPlayerName(string playerName) {
            playerNameOne = playerName;
        }
        [Given(@"the second player is (.*)")]
        public void GivenTheSecondPlayerName(string playerName) {
            playerNameTwo = playerName;
        }

        [When(@"the player name are string")]
        public void WhenPlayerNamesAreString() {
            Assert.IsTrue(playerNameOne is string && playerNameTwo is string);
        }
        [When(@"the textboxes are filled")]
        public void WhenTextboxesAreFilled() {
            NavigationHelper.NavigateToHomePage();
            TextBoxHelper.TypeInTextBox(By.Id("p1"), playerNameOne);
            TextBoxHelper.TypeInTextBox(By.Id("p2"), playerNameTwo);
        }

        [Then(@"click on play button")]
        public void ThenClickOnPlayButton() {
            ButtonHelper.ClickButton(By.Id("submitPlayers"));
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
