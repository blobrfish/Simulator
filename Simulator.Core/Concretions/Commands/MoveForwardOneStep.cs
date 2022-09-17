using Simulator.Core.Abstractions;

namespace Simulator.Core.Concretions.Commands
{
    public class MoveForwardOneStep : Command
    {
        public MoveForwardOneStep() :base(1, "Move forward one step") 
        {}
        public override void Execute()
        {
            this.MovingObject.MoveForwardOneStep();
        }
    }
}
