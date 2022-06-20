using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoMiner.ConsoleCommands.Commands;

namespace CryptoMiner.ConsoleCommands.Commands
{
    public class CommandMinerStop : ICommand
    {
        public string Name => "Miner.Stop()";

        public string Description => "Stops the miner";

        public void Execute(MinerForm console)
        {
            console.TypeWriteInConsole("Miner stopping.");
            console.miner.StopMiner();
        }
    }
}
