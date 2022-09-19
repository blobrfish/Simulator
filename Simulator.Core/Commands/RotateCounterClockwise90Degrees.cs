using Simulator.Core.Abstractions;
using Simulator.Core.Interfaces;

namespace Simulator.Core.Concretions.Commands
{
    public class RotateCounterClockwise90Degrees : Command
    {
        public RotateCounterClockwise90Degrees(IMovingObject movingObject) : base(movingObject,4, "Rotate counter clockwise 90 degrees")
        { }
        public override void Execute()
        {
            this.MovingObject.RotateCounterClockwise90Degrees();
        }
    }
}
