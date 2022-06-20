using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiner.ConsoleCommands.Commands
{
    public interface ICommand
    { 
        string Name { get; }
        string Description { get; }

        void Execute(MinerForm console);
    }
}
