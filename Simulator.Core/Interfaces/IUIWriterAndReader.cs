using System;
using System.Collections.Generic;
using Simulator.Core.Abstractions;

namespace Simulator.Core.Interfaces
{
    public interface IUIWriterAndReader
    {
        string AskForTableType(IEnumerable<Type> availableTableTypes);
        string AskForTableDimensionsAndMovingObjectStartPostion();
        string AskForCommands(IEnumerable<Command> availableCommands);
        void PrintOutPostion(string position);

    }
}
