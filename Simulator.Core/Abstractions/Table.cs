using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Simulator.Core.Concretions;
using Simulator.Core.Enums;
namespace Simulator.Core.Abstractions
{
    public abstract class Table
    {
        public static MovingObject MovingObject { get; private set; }
        public static TableOrigoPostion OrigoPosition { get; private set; }
        static IEnumerable<Type> AvailableTableTypes => Assembly.GetAssembly(typeof(Table)).GetTypes().Where(t => !t.IsAbstract && t.IsSubclassOf(typeof(Table)));

        protected abstract Position RequestInput();
        protected Table()
        {
            var movingObjectStartPosition =  this.RequestInput();
            MovingObject = new MovingObject(this, movingObjectStartPosition);
        }

        public abstract bool IsMovingObjectWithinTable(Position position);
       
        public static Table CreateTable()
        {
            var availableTableTypes = AvailableTableTypes;
            int matrixTypeIndex = default(int);
            
            if (availableTableTypes.Count() > 1)
            {
                string input = App.WriterAndReader.AskForTableType(availableTableTypes);
                matrixTypeIndex = Int32.Parse(input);
            }
            return (Table)Activator.CreateInstance(availableTableTypes.ElementAt(matrixTypeIndex));
        }
    }

}



