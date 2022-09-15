using System.Collections.Generic;

namespace Simulator.Structs
{
    public struct Position
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void IncreaseX()
        {
            this.X++;
        }

        public void IncreaseY()
        {
            this.Y++; 
        }

        public void DecreaseX()
        {
            this.X--; 
        }

        public void DecreaseY()
        {
            this.Y--; ;
        }

        public override string ToString()
        {
            return string.Format("[{0},{1}]", this.X, this.Y);
        }
    }
}



