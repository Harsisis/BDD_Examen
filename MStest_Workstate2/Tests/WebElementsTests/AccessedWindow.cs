using Microsoft.VisualStudio.TestTools.UnitTesting;
using MStest_Workstate1.Helpers;
using SpecFlowProject_BDD.BasesClasses;

namespace MStest_Workstate1.Tests.WebElementsTests {
    [TestClass]
    public class AccessedWindow {

        [TestMethod]
        public void CheckIfCurrentPageIsHome() {
            NavigationHelper.NavigateToHomePage();
            string url = ObjectRepository.Driver.Url;
            Assert.IsTrue(url.Contains("jeuSerpent"));
        }
    }
}
