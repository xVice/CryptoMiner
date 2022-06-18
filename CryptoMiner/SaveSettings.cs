using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CryptoMiner
{
    public static class SaveSettings
    {
        public static Settings _settings;
        
        public static void Load()
        {
            if (File.Exists(@"./settings.json")) { _settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(@"./settings.json")); }   
        }

        public static void Save()
        {
            File.WriteAllText(@"./settings.json", JsonConvert.SerializeObject(_settings));
        }

        //Settings struct, so kann man ez felder hinzufügen in der zukunft glaube ich
        public struct Settings
        {
            public bool tutorialFinished;
            public double cryptoWallet;

            public Settings(bool tutorialFinished, double cryptoWallet = 0.0)
            {
                this.tutorialFinished = tutorialFinished;
                this.cryptoWallet = cryptoWallet;
            }
        }

        /*
        public void WriteSettingsFile()
        {
            if (File.Exists(@"./settings.txt")){ File.Delete(@"./settings.txt"); }
            File.AppendAllText(
            @"./settings.txt",
            "ConsoleTutorial;"+tutorial+"\n"+
            "CryptoCoins;"+cryptoWallet+"\n"
            );
        }
        */
    }
}
