using System;
using System.Collections.Generic;
using Simulator.Core.Abstractions;
using System.ComponentModel;

namespace Simulator.Core.Concretions.Tables
{
    [DisplayName("Rectangular")]
    public class RectangularTable : Table
    {
        int Width;
        int Height;
        int MaxX;
        int MaxY;
        readonly int MinXY =0;
     
        public RectangularTable()
        {}

        public override bool IsMovingObjectWithinTable(Position currentPosition)
        {
            int x = currentPosition.X;
            int y = currentPosition.Y;
            return (this.MinXY <= x && x <= this.MaxX) && (this.MinXY <= y && y <= this.MaxY); 
        }

        protected override Position RequestInput()
        {
            string input = App.WriterAndReader.AskForTableDimensionsAndMovingObjectStartPostion();
            IList<string> inputSeperated = input.Trim().Split(',');
            this.Width = Int32.Parse(inputSeperated[0]);
            MaxX = this.Width - 1;
            this.Height = Int32.Parse(inputSeperated[1]);
            MaxY = this.Height - 1;
            int movingObjectStartPositionX = Int32.Parse(inputSeperated[2]);
            int movingObjectStartPositionY = Int32.Parse(inputSeperated[3]);
            return new Position(movingObjectStartPositionX, movingObjectStartPositionY);
        }
     
    }


  

  




    }



