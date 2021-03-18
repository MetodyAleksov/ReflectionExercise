using System;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Models
{
    public class Engine : IEngine
    {
        private ICommandInterpreter interpreter;
        public Engine(ICommandInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }
        public void Run()
        {
            while (true)
            {
                string line = Console.ReadLine();

                string result = interpreter.Read(line);

                if (result == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}