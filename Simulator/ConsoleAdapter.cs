using System;
using System.Collections.Generic;
using System.Linq;
using Simulator.Core.Interfaces;
using Simulator.Core.Abstractions;
using System.ComponentModel;

namespace Simulator
{
    public class ConsoleAdapter : IUIWriterAndReader
    {
        public string AskForCommands(IEnumerable<Command> availableCommands)
        {
            Console.WriteLine("Please enter the commands for the moving object. Add multiple commands by comma seperation. Finish off with 0.");
            for (int index = 0; index < availableCommands.Count(); index++)
            {
                Console.WriteLine("{0}", availableCommands.OrderBy(c => c.Code).ElementAt(index).CodeAndName);
            }

            string input = Console.ReadLine();
            return input;
        }

        public string AskForTableDimensionsAndMovingObjectStartPostion()
        {
            Console.WriteLine("Please enter the width and length of the table followed by the starting position of the moving object in following format: width,length,x,y");
            string input = Console.ReadLine();
            return input;
        }

        public string AskForTableType(IEnumerable<Type> availableTableTypes)
        {
            Console.WriteLine("Please select the table type. ");
            for (int index = 0; index < availableTableTypes.Count(); index++)
            {
                var type = availableTableTypes.ElementAt(index);
                var displayName = type.GetCustomAttributes(typeof(DisplayNameAttribute), true).FirstOrDefault() as DisplayNameAttribute;
                Console.WriteLine("{0} {1} ", index, displayName.DisplayName);
            }
            string input = Console.ReadLine();
            return input;
        }

        public void PrintOutPostion(string postion)
        {
            Console.WriteLine(postion);
        }
    }
}
