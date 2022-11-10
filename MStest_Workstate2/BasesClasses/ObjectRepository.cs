using OpenQA.Selenium;
using SpecFlowProject_BDD.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject_BDD.BasesClasses {
    public class ObjectRepository {
        public ObjectRepository() {
        }
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }

    }
}
