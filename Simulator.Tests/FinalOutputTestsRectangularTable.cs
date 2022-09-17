using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;
using Simulator.Core.Interfaces;
using Simulator.Core;

namespace Simulator.Tests
{
    [TestClass]
    public class FinalOutputTestsRectangularTable
    {

        StringBuilder StringBuilder = new StringBuilder();
        string FinalOutput
        {
            get
            {
                string fullString = StringBuilder.ToString();
                string[] arrayOfString = fullString.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
                string finalOutPut = arrayOfString[^1];
                return finalOutPut;
            }
        }
        IUIWriterAndReader ConsoleAdapter = new ConsoleAdapter(); 
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
            string testCommands = "1,0";
            string expectedFinalOutput = "[1,0]";
            DoBasicArrangements(testCommands);

            //act
            App.Run(ConsoleAdapter);
           
            //assert
            Assert.AreEqual<string>(expectedFinalOutput, FinalOutput);

        }

        [TestMethod]
        public void Check_If_MovingObject_MovesOneStepBackward_Vertical()
        {
            //arrange
            string testCommands = "2,0";
            string expectedFinalOutput = "[1,2]";
            DoBasicArrangements(testCommands);

            //act
            App.Run(ConsoleAdapter);

            //assert
            Assert.AreEqual<string>(expectedFinalOutput, FinalOutput);

        }


        [TestMethod]
        public void Check_If_MovingObject_MovesOneStepForward_Horizontal()
        {
            //arrange
            string testCommands = "3,1,0";
            string expectedFinalOutput = "[2,1]";
            DoBasicArrangements(testCommands);

            //act
            App.Run(ConsoleAdapter);

            //assert
            Assert.AreEqual<string>(expectedFinalOutput, FinalOutput);

        }

        [TestMethod]
        public void Check_If_MovingObject_MovesOneStepBackward_Horizontal()
        {
            //arrange
            string testCommands = "3,2,0";
            string expectedFinalOutput = "[0,1]";
            DoBasicArrangements(testCommands);

            //act
            App.Run(ConsoleAdapter);

            //assert
            Assert.AreEqual<string>(expectedFinalOutput, FinalOutput);

        }

        [TestMethod]
        public void Check_If_MovingObject_RotateClockwise90Degrees()
        {
            //arrange
            string testCommands = "3,1,0";
            string expectedFinalOutput = "[2,1]";
            DoBasicArrangements(testCommands);

            //act
            App.Run(ConsoleAdapter);

            //assert
            Assert.AreEqual<string>(expectedFinalOutput, FinalOutput);
        }


        [TestMethod]
        public void Check_If_MovingObject_RotateCounterClockwise90Degrees()
        {
            //arrange
            string testCommands = "4,1,0";
            string expectedFinalOutput = "[0,1]";
            DoBasicArrangements(testCommands);

            //act
            App.Run(ConsoleAdapter);

            //assert
            Assert.AreEqual<string>(expectedFinalOutput, FinalOutput);
        }


        [TestMethod]
        public void Check_If_MovingObject_RotateFullCircle_Clockwise()
        {
            //arrange
            string testCommands = "3,3,3,3,1,0";
            string expectedFinalOutput = "[1,0]";
            DoBasicArrangements(testCommands);

            //act
            App.Run(ConsoleAdapter);

            //assert
            Assert.AreEqual<string>(expectedFinalOutput, FinalOutput);

        }


        [TestMethod]
        public void Check_If_MovingObject_RotateFullCircle_CounterClockwise()
        {
            //arrange
            string testCommands = "4,4,4,4,1,0";
            string expectedFinalOutput = "[1,0]";
            DoBasicArrangements(testCommands);

            //act
            App.Run(ConsoleAdapter);

            //assert
            Assert.AreEqual<string>(expectedFinalOutput, FinalOutput);

        }

        [TestMethod]
        public void Check_If_MovingObject_IsOutOfTable()
        {
            //arrange
            string testCommands = "1,0";
            string widthHeightAndStartingPointForMovingObject = "1,1,0,0";
            string expectedFinalOutput = "[-1,-1]";
            DoBasicArrangements(testCommands, widthHeightAndStartingPointForMovingObject);

            //act
            App.Run(ConsoleAdapter);

            //assert
            Assert.AreEqual<string>(expectedFinalOutput, FinalOutput);
        }

        [TestMethod]
        public void Check_If_MovingObject_IsWithinTable()
        {
            //arrange
            string testCommands = "1,0";
            string widthHeightAndStartingPointForMovingObject = "2,2,1,1";
            string expectedFinalOutput = "[1,0]";
            DoBasicArrangements(testCommands, widthHeightAndStartingPointForMovingObject);

            //act
            App.Run(ConsoleAdapter);

            //assert
            Assert.AreEqual<string>(expectedFinalOutput, FinalOutput);
        }

    }
}
