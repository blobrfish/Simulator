using Simulator.Core;

namespace Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            App.Run(new MyUI(), new MyRectangularTable(), new MyMovingObject());
        }
    }
}



