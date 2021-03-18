using System.Linq;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Models
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private readonly ICommandFactory factory;
        public CommandInterpreter()
        {
            factory = new CommandFactory();
        }
        public string Read(string args)
        {
            string[] parts = args.Split();

            string commandType = parts[0];
            string[] commandParts = parts.Skip(1).ToArray();

            //reflection command creation;

            ICommand command = this.factory.CreateCommand(commandType);

            return command.Execute(commandParts);
        }
    }
}