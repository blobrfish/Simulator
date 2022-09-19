using System;
using System.Collections.Generic;
using Simulator.Core.Abstractions;

namespace Simulator.Core.Interfaces
{
    public interface IUI
    {
        string GetTableDimensionsAndMovingObjectStartPostion();
        string GetCommands(IEnumerable<Command> availableCommands);
        void ReportPostion(string position);

    }
}
