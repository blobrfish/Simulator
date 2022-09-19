using Simulator.Core.Abstractions;
using Simulator.Core.Interfaces;

namespace Simulator.Core.Concretions.Commands
{
    public class QuitSimulatioAndPrintResultsStdout : Command
    {
        public QuitSimulatioAndPrintResultsStdout(IMovingObject movingObject) :base(movingObject, 0, "Quit simulation and print results to stdout") 
        {}

        public override void Execute()
        {
            App.UI.ReportPostion(this.MovingObject.FinalPosition);
        }
    }
}
