using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiner.ConsoleCommands.Commands
{
    internal class CommandMinerStatus : ICommand
    {
        public string Name => "Miner.Status()";

        public string Description => "Shows some info about the miner";

        public void Execute(MinerForm console)
        {
            console.TypeWriteInConsole("Current hashes: " + console.miner.hashes.ToString() + " HashRate:" + console.hashRate);
        }
    }
}
