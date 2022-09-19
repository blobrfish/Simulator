using System;
using System.Collections.Generic;
using System.Linq;
using Simulator.Core.Interfaces;
using Simulator.Core.Abstractions;

namespace Simulator
{
    public class MyUI : IUI
    {
        public string GetCommands(IEnumerable<Command> availableCommands)
        {
            Console.WriteLine("Please enter the commands for the moving object. Add multiple commands by comma seperation. Finish off with 0.");
            for (int index = 0; index < availableCommands.Count(); index++)
            {
                Console.WriteLine("{0}", availableCommands.OrderBy(c => c.Code).ElementAt(index).CodeAndName);
            }

            string input = Console.ReadLine();
            return input;
        }

        public string GetTableDimensionsAndMovingObjectStartPostion()
        {
            Console.WriteLine("Please enter the width and length of the table followed by the starting position of the moving object in following format: width,length,x,y");
            string input = Console.ReadLine();
            return input;
        }

        public void ReportPostion(string postion)
        {
            Console.WriteLine(postion);
        }
    }
}
