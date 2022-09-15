using Simulator.Abstractions;
namespace Simulator.Concretes.Commands
{
    public class MoveBackwardsOneStep : CommandBase
    {
        public MoveBackwardsOneStep() :base(2, "Move backwards one step") 
        {}
        public override void Execute()
        {
            this.MovingObject.MoveBackwardsOneStep();
        }
    }
}
