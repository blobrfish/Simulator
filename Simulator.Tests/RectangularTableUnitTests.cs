using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace Simulator.Tests
{
    [TestClass]
    public class RectangularTableUnitTests
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
        public void Check_If_MovingObject_Moves_One_Step_Forward()
        {
            //arrange
            string testCommands = "1,0";
            string expectedFinalOutput = "[1,0]";
            DoBasicArrangements(testCommands);

            //act
            App.Run();
           
            //assert
            Assert.AreEqual<string>(expectedFinalOutput, FinalOutput);

        }

        [TestMethod]
        public void Check_If_MovingObject_Moves_One_Step_Backward()
        {
            //arrange
            string testCommands = "2,0";
            string expectedFinalOutput = "[1,2]";
            DoBasicArrangements(testCommands);

            //act
            App.Run();

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
            App.Run();

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
            App.Run();

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
            App.Run();

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
            App.Run();

            //assert
            Assert.AreEqual<string>(expectedFinalOutput, FinalOutput);
        }

    }
}
