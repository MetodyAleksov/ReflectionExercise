using System.Net.Http.Headers;

namespace CommandPattern.Core.Contracts
{
    public interface ICommandFactory
    {
        ICommand CreateCommand(string commandType);
    }
}