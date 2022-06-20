using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiner.ConsoleCommands.Commands
{
    public class CommandWallet : ICommand
    {
        public string Name => "Wallet.Show()";

        public string Description => "Shows your current cryptos";

        public void Execute(MinerForm console)
        {
            console.TypeWriteInConsole(console.wallet.coins.ToString());
        }
    }
}
