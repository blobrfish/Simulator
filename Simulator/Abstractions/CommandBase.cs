using Simulator.Interfaces;
using Simulator.Models.Concrete;

namespace Simulator.Abstractions
{
    public abstract class CommandBase : ICommand
    {
        protected MovingObject MovingObject => Table.MovingObject;
        public int Code { get; }

        protected readonly string Name;
        public string CodeAndName => string.Format("{0}={1}", this.Code, this.Name);

        public CommandBase(int code, string name)
        {
            this.Code = code;
            this.Name = name;
        }
        public abstract void Execute();
    }
}
