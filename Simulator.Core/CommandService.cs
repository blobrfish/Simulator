using System;
using System.Collections.Generic;
using System.Linq;
using Simulator.Core.Abstractions;
using Simulator.Core.Interfaces;
namespace Simulator.Core
{
    public class CommandService 
    {
        IList<Command> AvailableCommands = new List<Command>();
        IList<int> CommandCodesToExecute = new List<int>();
        IEnumerable<Type> AvailableCommandTypes => AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(Command).IsAssignableFrom(p) && !p.IsAbstract);

        public CommandService(IMovingObject movingObject)
        {
            this.InitializeAvailableCommands(movingObject);
       
        }

        public void ListenToCommands()
        {
            string input = App.UI.GetCommands(this.AvailableCommands);
            IEnumerable<string> seperatedInputs = input.Trim().Split(',');
            foreach (var seperatedInput in seperatedInputs)
            {
                this.CommandCodesToExecute.Add(Int32.Parse(seperatedInput));
            }
        }
        void InitializeAvailableCommands(IMovingObject movingObject)
        {
            foreach (var availableCommandType in AvailableCommandTypes)
            {
                AvailableCommands.Add((Command)Activator.CreateInstance(availableCommandType,movingObject));
            }
        }


        public void RunCommands()
        {
            foreach(var code in CommandCodesToExecute)
            {
                AvailableCommands.First(command => command.Code == code).Execute();
            }
        }
    }
}
