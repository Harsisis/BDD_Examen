using SpecFlowProject_BDD.CustomException;
using SpecFlowProject_BDD.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject_BDD.Interfaces {
    public interface IConfig {
        public BrowserType GetBrowser();
        public string GetWebsite();
    }
}
