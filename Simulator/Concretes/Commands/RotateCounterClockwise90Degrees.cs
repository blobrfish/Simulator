using Simulator.Abstractions;
namespace Simulator.Concretes.Commands
{
    public class RotateCounterClockwise90Degrees : CommandBase
    {
        public RotateCounterClockwise90Degrees() : base(4, "Rotate counter clockwise 90 degrees")
        { }
        public override void Execute()
        {
            this.MovingObject.RotateCounterClockwise90Degrees();
        }
    }
}
