using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Interfaces
{
    public interface IVisitorRepo
    {
        bool InsertVisitor(Visitor v);
        bool DeleteVisitor(Visitor v);
        bool UpdateVisitor(Visitor v);
        Visitor GetVisitor(string visitorName);
        List<Visitor> GetAllVisitors();
    }
}
