using System;
using System.Collections.Generic;
using System.Linq;
using Simulator.Core.Abstractions;
namespace Simulator.Core.Concretions
{
    public class CommandService 
    {
        IList<Command> AvailableCommands = new List<Command>();
        IList<int> CommandCodesToExecute = new List<int>();
        IEnumerable<Type> AvailableCommandTypes => AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(Command).IsAssignableFrom(p) && !p.IsAbstract);

        public CommandService()
        {
            this.InitializeAvailableCommands();
            this.RequestCommands();
        }

        public void InitializeAvailableCommands()
        {
            foreach (var availableCommandType in AvailableCommandTypes)
            {
                AvailableCommands.Add((Command)Activator.CreateInstance(availableCommandType));
            }
        }


        public void Run()
        {
            foreach(var code in CommandCodesToExecute)
            {
                AvailableCommands.First(command => command.Code == code).Execute();
            }
        }

        void RequestCommands()
        {
            string input = App.WriterAndReader.AskForCommands(this.AvailableCommands);
            IEnumerable<string> seperatedInputs = input.Trim().Split(',');
            foreach (var seperatedInput in seperatedInputs)
            {
                this.CommandCodesToExecute.Add(Int32.Parse(seperatedInput));
            }
        }

        
    }
}
