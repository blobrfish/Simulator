using Simulator.Core.Concretions;

namespace Simulator.Core.Abstractions
{
    public abstract class Command 
    {
        protected MovingObject MovingObject => Table.MovingObject;
        public int Code { get; }

        protected readonly string Name;
        public string CodeAndName => string.Format("{0}={1}", this.Code, this.Name);

        public Command(int code, string name)
        {
            this.Code = code;
            this.Name = name;
        }
        public abstract void Execute();
    }
}
