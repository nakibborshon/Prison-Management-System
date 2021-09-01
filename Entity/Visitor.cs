using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
   public class Visitor
    {
        string visitorName;

        public string VisitorName
        {
            get { return visitorName; }
            set { visitorName = value; }
        }
        string visitedPrisonerId;

        public string VisitedPrisonerId
        {
            get { return visitedPrisonerId; }
            set { visitedPrisonerId = value; }
        }
        string counterNo;

        public string CounterNo
        {
            get { return counterNo; }
            set { counterNo = value; }
        }
        double visitedDuration;

        public double VisitedDuration
        {
            get { return visitedDuration; }
            set { visitedDuration = value; }
        }
    }
}
