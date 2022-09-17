using Simulator.Core.Abstractions;

namespace Simulator.Core.Concretions.Commands
{
    public class MoveBackwardsOneStep : Command
    {
        public MoveBackwardsOneStep() :base(2, "Move backwards one step") 
        {}
        public override void Execute()
        {
            this.MovingObject.MoveBackwardsOneStep();
        }
    }
}
