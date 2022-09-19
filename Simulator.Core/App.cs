using Simulator.Core.Abstractions;
using Simulator.Core.Interfaces;

namespace Simulator.Core
{
    public class App
    {
        public static IUI UI;
        public static ITable Table;
        public static IMovingObject MovingObject;
        public static CommandService CommandService;
     
        App(IUI uI, ITable table, IMovingObject movingObject)
        {
            UI = uI;
            Table = table;
            MovingObject = movingObject;
            
            if(Table != null && MovingObject != null)
            {
                table.SetDimensionsAndMovingObjectStartPostion(movingObject);
            }

            CommandService = new CommandService(movingObject);
            CommandService.ListenToCommands();
            CommandService.RunCommands();
        }

        public static App Run(IUI uI, ITable table, IMovingObject movingObject)
        {
            return new App(uI, table, movingObject);
        }
    }
 }



