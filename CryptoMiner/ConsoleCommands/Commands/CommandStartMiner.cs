using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoMiner.ConsoleCommands.Commands
{
    public class CommandStartMiner : ICommand
    {
        public string Name => "Miner.Start()";

        public string Description => "Starts the miner";

        public void Execute(MinerForm console)
        {
            console.TypeWriteInConsole("Miner starting.");
            console.miner.StartMiner();
        }
    }
}
