using Microsoft.Extensions.Configuration;
using SpecFlowProject_BDD.CustomException;
using SpecFlowProject_BDD.Interfaces;
using SpecFlowProject_BDD.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject_BDD.Configuration {
    public class ConfigReader: IConfig {
        private GameSettings settings;

        public ConfigReader() {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            settings = config.GetRequiredSection(nameof(GameSettings)).Get<GameSettings>();
        }

        public BrowserType GetBrowser() {
            string browser = settings.Browser;

            try {
                return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
            } catch (ArgumentException) {
                throw new NoSuitableDriverFoundException("Aucun driver n'a été trouvé  : " + settings.Browser);
            }
        }

        public string GetPlayerOne() {
            return settings.PlayerOne;
        }

        public string GetPlayerTwo() {
            return settings.PlayerTwo;
        }

        public string GetWebsite() {
            return settings.Website;
        }
    }
}
