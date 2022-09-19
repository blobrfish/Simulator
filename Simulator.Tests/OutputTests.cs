using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;
using Simulator.Core.Interfaces;
using Simulator.Core;

namespace Simulator.Tests
{
    [TestClass]
    public class OutputTests
    {

        IUI UI = new MyUI();
        IMovingObject MovingObject= new MyMovingObject();
        ITable Table = new MyRectangularTable();
        StringBuilder StringBuilder = new StringBuilder();
        string Output
        {
            get
            {
                string fullString = StringBuilder.ToString();
                string[] arrayOfString = fullString.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
                string finalOutPut = arrayOfString[^1];
                return finalOutPut;
            }
        }
        IUI ConsoleAdapter = new MyUI(); 
        void RedirectStdOut()
        {
            
            TextWriter writer = new StringWriter(StringBuilder);
            Console.SetOut(writer);
        }

        void RedirectStdIn(string testCommands, string widthHeightAndStartingPointForMovingObject)
        {
            var testData = String.Join(Environment.NewLine, new[] { widthHeightAndStartingPointForMovingObject, testCommands });
            Console.SetIn(new System.IO.StringReader(testData));
        }

        void DoBasicArrangements(string testCommands, string widthHeightAndStartingPointForMovingObject = "3,3,1,1")
        {
            RedirectStdOut();
            RedirectStdIn(testCommands, widthHeightAndStartingPointForMovingObject);
           
        }

        [TestMethod]
        public void Check_If_MovingObject_MovesOneStepForward_Vertical()
        {
            //arrange
            string commands = "1,0";
            string expectedOutput = "[1,0]";
            DoBasicArrangements(commands);

            //act
            App.Run(UI, Table, MovingObject);
           
            //assert
            Assert.AreEqual<string>(expectedOutput, Output);

        }

        [TestMethod]
        public void Check_If_MovingObject_MovesOneStepBackward_Vertical()
        {
            //arrange
            string commands = "2,0";
            string expectedOutput = "[1,2]";
            DoBasicArrangements(commands);

            //act
            App.Run(UI, Table, MovingObject);

            //assert
            Assert.AreEqual<string>(expectedOutput, Output);

        }


        [TestMethod]
        public void Check_If_MovingObject_MovesOneStepForward_Horizontal()
        {
            //arrange
            string commands = "3,1,0";
            string expectedOutput = "[2,1]";
            DoBasicArrangements(commands);

            //act
            App.Run(UI, Table, MovingObject);

            //assert
            Assert.AreEqual<string>(expectedOutput, Output);

        }

        [TestMethod]
        public void Check_If_MovingObject_MovesOneStepBackward_Horizontal()
        {
            //arrange
            string commands = "3,2,0";
            string expectedOutput = "[0,1]";
            DoBasicArrangements(commands);

            //act
            App.Run(UI, Table, MovingObject);

            //assert
            Assert.AreEqual<string>(expectedOutput, Output);

        }

        [TestMethod]
        public void Check_If_MovingObject_RotateClockwise90Degrees()
        {
            //arrange
            string commands = "3,1,0";
            string expectedOutput = "[2,1]";
            DoBasicArrangements(commands);

            //act
            App.Run(UI, Table, MovingObject);

            //assert
            Assert.AreEqual<string>(expectedOutput, Output);
        }


        [TestMethod]
        public void Check_If_MovingObject_RotateCounterClockwise90Degrees()
        {
            //arrange
            string commands = "4,1,0";
            string expectedOutput = "[0,1]";
            DoBasicArrangements(commands);

            //act
            App.Run(UI, Table, MovingObject);

            //assert
            Assert.AreEqual<string>(expectedOutput, Output);
        }


        [TestMethod]
        public void Check_If_MovingObject_RotateFullCircle_Clockwise()
        {
            //arrange
            string commands = "3,3,3,3,1,0";
            string expectedOutput = "[1,0]";
            DoBasicArrangements(commands);

            //act
            App.Run(UI, Table, MovingObject);

            //assert
            Assert.AreEqual<string>(expectedOutput, Output);
        }

        [TestMethod]
        public void Check_If_MovingObject_RotateFullCircle_CounterClockwise()
        {
            //arrange
            string commands = "4,4,4,4,1,0";
            string expectedOutput = "[1,0]";
            DoBasicArrangements(commands);

            //act
            App.Run(UI, Table, MovingObject);

            //assert
            Assert.AreEqual<string>(expectedOutput, Output);
        }

        [TestMethod]
        public void Check_If_MovingObject_IsOutOfTable()
        {
            //arrange
            string commands = "1,0";
            string widthHeightAndStartingPointForMovingObject = "1,1,0,0";
            string expectedOutput = "[-1,-1]";
            DoBasicArrangements(commands, widthHeightAndStartingPointForMovingObject);

            //act
            App.Run(UI, Table, MovingObject);

            //assert
            Assert.AreEqual<string>(expectedOutput, Output);
        }

        [TestMethod]
        public void Check_If_MovingObject_IsWithinTable()
        {
            //arrange
            string commands = "1,0";
            string widthHeightAndStartingPointForMovingObject = "2,2,1,1";
            string expectedOutput = "[1,0]";
            DoBasicArrangements(commands, widthHeightAndStartingPointForMovingObject);

            //act
            App.Run(UI, Table, MovingObject);

            //assert
            Assert.AreEqual<string>(expectedOutput, Output);
        }

    }
}
