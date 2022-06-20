using CryptoMiner.ConsoleCommands.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiner.ConsoleCommands
{
    public static class CommandManager
    {
        public static List<ICommand> commandList = new List<ICommand>();

        public static void VerifyCommand(ICommand command, MinerForm console)
        {
            if (command != null)
            {
                command.Execute(console);
            }
        }

        public static void LoadDefaultCommands()
        {
            CommandManager.AddCommand(new CommandStartMiner());
            CommandManager.AddCommand(new CommandMinerStop());
            CommandManager.AddCommand(new CommandHelp());
            CommandManager.AddCommand(new CommandWallet());
            CommandManager.AddCommand(new CommandMinerStatus());


        }

        public static void AddCommand(ICommand command)
        {
            commandList.Add(command);
        }
        
        public static List<ICommand> GetCommands()
        {
            return commandList;
        }

        public static ICommand GetCommandByName(string commandName)
        {
            foreach(ICommand command in commandList)
            {
                if(command.Name == commandName)
                {
                    return (ICommand)command;
                }
            }
            return null;
        }

    }
}
