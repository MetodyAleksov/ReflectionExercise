using System;
using System.Linq;
using System.Reflection;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Models
{
    public class CommandFactory : ICommandFactory
    {
        public ICommand CreateCommand(string commandType)
        {
            Type type = Assembly.GetEntryAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name.StartsWith(commandType));

            ICommand instance = (ICommand)Activator.CreateInstance(type);

            return instance;
        }
    }
}