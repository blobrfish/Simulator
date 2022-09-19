using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulator.Core.Enums;
namespace Simulator.Core.Interfaces
{
    public interface ITable
    {
        bool IsMovingObjectWithinTable(Position position);
        void SetDimensionsAndMovingObjectStartPostion(IMovingObject movingObject);
        
        TableOrigoPostion OrigoPosition { get; }



    }
}
