using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Cell
    {
        string cellNo;

        public string CellNo
        {
            get { return cellNo; }
            set { cellNo = value; }
        }
        int cellCapacity;

        public int CellCapacity
        {
            get { return cellCapacity; }
            set { cellCapacity = value; }
        }
        int numberOfPrisoners;

        public int NumberOfPrisoners
        {
            get { return numberOfPrisoners; }
            set { numberOfPrisoners = value; }
        }
        string guardId;

        public string GuardId
        {
            get { return guardId; }
            set { guardId = value; }
        }
        string guardName;

        public string GuardName
        {
            get { return guardName; }
            set { guardName = value; }
        }
    }
}
