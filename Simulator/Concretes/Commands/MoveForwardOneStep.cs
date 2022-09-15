
using Simulator.Abstractions;
namespace Simulator.Concretes.Commands
{
    public class MoveForwardOneStep : CommandBase
    {
        public MoveForwardOneStep() :base(1, "Move forward one step") 
        {}
        public override void Execute()
        {
            this.MovingObject.MoveForwardOneStep();
        }
    }
}
