using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Interfaces
{
    public interface ICellRepo
    {
        bool InsertCell(Cell c);
        bool DeleteCell(Cell c);
        bool UpdateCell(Cell c);
        Cell GetCell(string cellNo);
        List<Cell> GetAllCells();
    }
}
