using Simulator.Core.Abstractions;

namespace Simulator.Core.Concretions.Commands
{
    public class RotateClockwise90Degrees : Command
    {
        public RotateClockwise90Degrees() :base(3, "Rotate clockwise 90 degrees") 
        {}
   
        public override void Execute()
        {
            this.MovingObject.RotateClockwise90Degrees();
        }
    }
}
