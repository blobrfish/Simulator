using Simulator.Core.Interfaces;

namespace Simulator.Core.Abstractions
{
    public abstract class Command 
    {
        protected IMovingObject MovingObject;
        public int Code { get; }

        protected readonly string Name;
        public string CodeAndName => string.Format("{0}={1}", this.Code, this.Name);

        public Command(IMovingObject movingObject, int code, string name)
        {
            this.MovingObject = movingObject;
            this.Code = code;
            this.Name = name;
        }
        public abstract void Execute();
    }
}
