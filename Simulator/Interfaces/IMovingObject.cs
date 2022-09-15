
namespace Simulator.Interfaces
{
    public interface IMovingObject
    {
        void MoveForwardOneStep();
        void MoveBackwardsOneStep();
        void RotateClockwise90Degrees();
        void RotateCounterClockwise90Degrees();
    }
}
