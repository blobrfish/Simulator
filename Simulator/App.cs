using Simulator.Abstractions;
using Simulator.Concretes;
using Simulator.Interfaces;

namespace Simulator
{
    public class App
    {
        public static IUIWriterAndReader WriterAndReader;
        public static ICommandService CommandService;
        public static Table Table;
        App()
        {
            WriterAndReader = new CustomConsole();
            Table = Table.CreateTable();
            CommandService = new CommandService();
            CommandService.Run();
        }

        public static App Run()
        {
            return new App();
        }
    }
 }



