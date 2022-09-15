using Simulator.Abstractions;
using Simulator.Enums;
using Simulator.Interfaces;
using Simulator.Structs;
namespace Simulator.Models.Concrete
{
    public class MovingObject :IMovingObject
    {
        Position Position;
        MovingObjectDirection Direction = MovingObjectDirection.North;
        TableOrigoPostion TableOrigoPostion => Table.OrigoPosition; //MatrixOrigoPostion.TopLeft;
        readonly string OutOfAvailableCellsMessage = "[-1,-1]";
  
        Table Table;
        public string FinalPosition => string.Format(IsWithinTable ? this.Position.ToString() : OutOfAvailableCellsMessage);

        protected bool IsWithinTable => this.Table.IsMovingObjectWithinTable(this.Position);
       

        public MovingObject(Table table, Position startPosition)
        {
            this.Table = table;
            this.Position = startPosition;
        }


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
    }


  

  




    }



