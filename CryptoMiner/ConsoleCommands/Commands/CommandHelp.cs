using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoMiner.ConsoleCommands.Commands;

namespace CryptoMiner.ConsoleCommands.Commands
{
    public class CommandHelp : ICommand
    {
        public string Name => "Console.Help()";

        public string Description => "Shows this list!";

        public void Execute(MinerForm console)
        {
            StringBuilder sb = new StringBuilder();
            foreach(ICommand command in CommandManager.GetCommands())
            {
                sb.Append(command.Name + "|" + command.Description + Environment.NewLine);
            }
            console.TypeWriteInConsole("Help list: " + Environment.NewLine + sb.ToString());
        }
    }
}
