using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowProject_BDD.Configuration;
using System;

namespace SpecFlowProject_BDD.Tests.ConfigTests {
    [TestClass]
    public class SettingsTests {

        private GameSettings settings;

        [TestInitialize]
        public void Init() {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            settings = config.GetRequiredSection(nameof(GameSettings)).Get<GameSettings>();
        }

        [TestMethod]
        public void GetBrowserFromConfig() {
            Console.WriteLine($"Browser = {settings.Browser}");
        }

        [TestMethod]
        public void GetPlayerOneFromConfig() {
            Console.WriteLine($"PlayerOne = {settings.PlayerOne}");
        }

        [TestMethod]
        public void GetPlayerTwoFromConfig() {
            Console.WriteLine($"PlayerTwo = {settings.PlayerTwo}");
        }

        [TestMethod]
        public void GetWebsiteFromConfig() {
            Console.WriteLine($"Website = {settings.Website}");
        }
    }
}
