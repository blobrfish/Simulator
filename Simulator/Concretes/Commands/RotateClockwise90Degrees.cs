
using Simulator.Abstractions;
namespace Simulator.Concretes.Commands
{
    public class RotateClockwise90Degrees : CommandBase
    {
        public RotateClockwise90Degrees() :base(3, "Rotate clockwise 90 degrees") 
        {}
   
        public override void Execute()
        {
            this.MovingObject.RotateClockwise90Degrees();
        }
    }
}
