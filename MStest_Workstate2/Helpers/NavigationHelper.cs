using SpecFlowProject_BDD.BasesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MStest_Workstate1.Helpers {
    public class NavigationHelper {
        public static void NavigateToUrl(string url) {
            ObjectRepository.Driver.Navigate().GoToUrl(url);
        }

        public static void NavigateToHomePage() {
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
        }
    }
}
