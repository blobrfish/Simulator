
using Simulator.Abstractions;
namespace Simulator.Concretes.Commands
{
    public class QuitSimulatioAndPrintResultsStdout : CommandBase
    {
        public QuitSimulatioAndPrintResultsStdout() :base(0, "Quit simulation and print results to stdout") 
        {}

        public override void Execute()
        {
            App.WriterAndReader.PrintOutPostion(this.MovingObject.FinalPosition);
        }
    }
}
