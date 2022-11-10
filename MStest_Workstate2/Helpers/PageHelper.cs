using SpecFlowProject_BDD.BasesClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MStest_Workstate1.Helpers {
    public class PageHelper {
        public static string GetPageTitle() {
            return ObjectRepository.Driver.Title;
        }

        public static string GetPageUrl() {
            return ObjectRepository.Driver.Url;
        }
    }
}
