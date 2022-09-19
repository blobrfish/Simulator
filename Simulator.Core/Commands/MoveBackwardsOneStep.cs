using Simulator.Core.Interfaces;
using Simulator.Core.Abstractions;

namespace Simulator.Core.Concretions.Commands
{
    public class MoveBackwardsOneStep : Command
    {
        public MoveBackwardsOneStep(IMovingObject movingObject) :base(movingObject, 2, "Move backwards one step") 
        {}
        public override void Execute()
        {
            this.MovingObject.MoveBackwardsOneStep();
        }
    }
}
