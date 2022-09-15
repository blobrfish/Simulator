using System;
using System.Collections.Generic;

namespace Simulator.Interfaces
{
    public interface IUIWriterAndReader
    {
        string AskForTableType(IEnumerable<Type> availableTableTypes);
        string AskForTableDimensionsAndMovingObjectStartPostion();
        string AskForCommands(IEnumerable<ICommand> availableCommands);
        void PrintOutPostion(string position);

    }
}
