using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Core.Interfaces
{
    public interface IMovingObject
    {
        void SetStartingPosition(Position position);
        void MoveForwardOneStep();
        void RotateClockwise90Degrees();
        void RotateCounterClockwise90Degrees();
        void MoveBackwardsOneStep();
        string FinalPosition { get; }
    }
}
