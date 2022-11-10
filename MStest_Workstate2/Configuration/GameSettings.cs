using SpecFlowProject_BDD.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject_BDD.Configuration {
    public class GameSettings {
        public string Browser { get; set; }
        public string Website { get; set; }

        public GameSettings(string browser, string website) {
            Browser = browser;
            Website = website;
        }
    }
}
