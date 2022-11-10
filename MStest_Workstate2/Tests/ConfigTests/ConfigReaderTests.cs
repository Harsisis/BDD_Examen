using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowProject_BDD.Configuration;
using SpecFlowProject_BDD.Interfaces;
using System;

namespace SpecFlowProject_BDD.Tests.ConfigTests {
    [TestClass]
    public class ConfigReaderTests {
        [TestMethod]
        public void GetSettingsKeysFromConfigReader() {
            IConfig config = new ConfigReader();
            Console.WriteLine("Browser : " + config.GetBrowser());
            Console.WriteLine("player  1 : " + config.GetPlayerOne());
            Console.WriteLine("player 2 : " + config.GetPlayerTwo());
            Console.WriteLine("Website : " + config.GetWebsite());
        }
    }
}
