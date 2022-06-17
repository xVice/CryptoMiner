using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiner
{
    public class SaveSettings
    {
        public string tutorial { get; set; }
        public double cryptoWallet { get; set; }
        public void WriteSettingsFile()
        {
            if (File.Exists(@"./settings.txt")){ File.Delete(@"./settings.txt"); }
            File.AppendAllText(
            @"./settings.txt",
            "ConsoleTutorial;"+tutorial+"\n"+
            "CryptoCoins;"+cryptoWallet+"\n"
            );
        }
    }
}
