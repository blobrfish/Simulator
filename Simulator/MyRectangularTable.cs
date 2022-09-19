using System;
using System.Collections.Generic;
using Simulator.Core;
using Simulator.Core.Interfaces;
using Simulator.Core.Enums;

namespace Simulator
{

    public class MyRectangularTable : ITable
    {
        int Width;
        int Height;
        int MaxX;
        int MaxY;
        readonly int MinXY =0;
        TableOrigoPostion origoPosition = TableOrigoPostion.TopLeft;
        public TableOrigoPostion OrigoPosition => this.origoPosition;

        public bool IsMovingObjectWithinTable(Position currentPosition)
        {
            int x = currentPosition.X;
            int y = currentPosition.Y;
            return (this.MinXY <= x && x <= this.MaxX) && (this.MinXY <= y && y <= this.MaxY); 
        }

        public void SetDimensionsAndMovingObjectStartPostion(IMovingObject movingObject)
        {
            string input = App.UI.GetTableDimensionsAndMovingObjectStartPostion();
            IList<string> inputSeperated = input.Split(',');
            this.Width = Int32.Parse(inputSeperated[0]);
            MaxX = this.Width - 1;
            this.Height = Int32.Parse(inputSeperated[1]);
            MaxY = this.Height - 1;
            int movingObjectStartPositionX = Int32.Parse(inputSeperated[2]);
            int movingObjectStartPositionY = Int32.Parse(inputSeperated[3]);
            movingObject.SetStartingPosition(new Position(movingObjectStartPositionX, movingObjectStartPositionY));
        }

    }

}



