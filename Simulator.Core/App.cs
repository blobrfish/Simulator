using Simulator.Core.Abstractions;
using Simulator.Core.Concretions;
using Simulator.Core.Interfaces;

namespace Simulator.Core
{
    public class App
    {
        public static IUIWriterAndReader WriterAndReader;
        public static CommandService CommandService;
        public static Table Table;
        App(IUIWriterAndReader writerAndReader)
        {
            WriterAndReader = writerAndReader;
            Table = Table.CreateTable();
            CommandService = new CommandService();
            CommandService.Run();
        }

        public static App Run(IUIWriterAndReader writerAndReader)
        {
            return new App(writerAndReader);
        }
    }
 }



