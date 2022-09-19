using Simulator.Core.Abstractions;
using Simulator.Core.Interfaces;

namespace Simulator.Core.Concretions.Commands
{
    public class RotateClockwise90Degrees : Command
    {
        public RotateClockwise90Degrees(IMovingObject movingObject) :base(movingObject, 3, "Rotate clockwise 90 degrees") 
        {}
   
        public override void Execute()
        {
            this.MovingObject.RotateClockwise90Degrees();
        }
    }
}
