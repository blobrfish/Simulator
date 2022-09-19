using Simulator.Core.Interfaces;
using Simulator.Core.Enums;
using Simulator.Core;

namespace Simulator
{
    public class MyMovingObject  : IMovingObject
    {
        Position Position;
        MovingObjectDirection Direction = MovingObjectDirection.North;
        TableOrigoPostion TableOrigoPostion => Table.OrigoPosition; 
        readonly string OutOfAvailableCellsMessage = "[-1,-1]";
  
        ITable Table => App.Table;
        public string FinalPosition => string.Format(IsWithinTable ? this.Position.ToString() : OutOfAvailableCellsMessage);

        protected bool IsWithinTable => this.Table.IsMovingObjectWithinTable(this.Position);
       
        public void MoveForwardOneStep()
        {
            if(Direction  == MovingObjectDirection.North)
            {
                this.Position.DecreaseY();
            }
            else if (Direction == MovingObjectDirection.South)
            {
                this.Position.IncreaseY();
            }
            else if (Direction == MovingObjectDirection.West)
            {
                this.Position.DecreaseX();
            }
            else if (Direction == MovingObjectDirection.East)
            {
                this.Position.IncreaseX();
            }
        }

        public void RotateClockwise90Degrees()
        {
            if (Direction == MovingObjectDirection.North)
            {
                this.Direction = MovingObjectDirection.East;
            }
            else if (Direction == MovingObjectDirection.South)
            {
                this.Direction = MovingObjectDirection.West;
            }
            else if (Direction == MovingObjectDirection.West)
            {
                this.Direction = MovingObjectDirection.North;
            }
            else if (Direction == MovingObjectDirection.East)
            {
                this.Direction = MovingObjectDirection.South;
            }
        }

        public void RotateCounterClockwise90Degrees()
        {
            if (Direction == MovingObjectDirection.North)
            {
                this.Direction = MovingObjectDirection.West;
            }
            else if (Direction == MovingObjectDirection.South)
            {
                this.Direction = MovingObjectDirection.East;
            }
            else if (Direction == MovingObjectDirection.West)
            {
                this.Direction = MovingObjectDirection.South;
            }
            else if (Direction == MovingObjectDirection.East)
            {
                this.Direction = MovingObjectDirection.North;
            }
        }

        public void MoveBackwardsOneStep()
        {
            if (Direction == MovingObjectDirection.North)
            {
                this.Position.IncreaseY();
            }
            else if (Direction == MovingObjectDirection.South)
            {
                this.Position.DecreaseY();
            }
            else if (Direction == MovingObjectDirection.West)
            {
                this.Position.IncreaseX();
            }
            else if (Direction == MovingObjectDirection.East)
            {
                this.Position.DecreaseX();
            }
        }

        public void SetStartingPosition(Position position)
        {
            this.Position = position;
        }
    }
}



