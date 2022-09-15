
namespace Simulator.Interfaces
{
    public interface ICommand
    {
        public int Code { get; }
        public string CodeAndName { get; }
        void Execute();
    }
}
