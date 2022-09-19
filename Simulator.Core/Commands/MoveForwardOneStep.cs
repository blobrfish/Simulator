using Simulator.Core.Interfaces;
using Simulator.Core.Abstractions;


namespace Simulator.Core.Concretions.Commands
{
    public class MoveForwardOneStep : Command
    {
        public MoveForwardOneStep(IMovingObject movingObject) :base(movingObject,1, "Move forward one step") 
        {}
        public override void Execute()
        {
            this.MovingObject.MoveForwardOneStep();
        }
    }
}
