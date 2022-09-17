using Simulator.Core.Abstractions;

namespace Simulator.Core.Concretions.Commands
{
    public class QuitSimulatioAndPrintResultsStdout : Command
    {
        public QuitSimulatioAndPrintResultsStdout() :base(0, "Quit simulation and print results to stdout") 
        {}

        public override void Execute()
        {
            App.WriterAndReader.PrintOutPostion(this.MovingObject.FinalPosition);
        }
    }
}
