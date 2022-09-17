using Simulator.Core.Abstractions;

namespace Simulator.Core.Concretions.Commands
{
    public class RotateCounterClockwise90Degrees : Command
    {
        public RotateCounterClockwise90Degrees() : base(4, "Rotate counter clockwise 90 degrees")
        { }
        public override void Execute()
        {
            this.MovingObject.RotateCounterClockwise90Degrees();
        }
    }
}
