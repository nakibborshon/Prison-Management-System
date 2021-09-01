using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Prisoner
    {
        string prisonerId;

        public string PrisonerId
        {
            get { return prisonerId; }
            set { prisonerId = value; }
        }
        string prisonerName;

        public string PrisonerName
        {
            get { return prisonerName; }
            set { prisonerName = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        string crime;

        public string Crime
        {
            get { return crime; }
            set { crime = value; }
        }
        string punishment;

        public string Punishment
        {
            get { return punishment; }
            set { punishment = value; }
        }
        string cellNo;

        public string CellNo
        {
            get { return cellNo; }
            set { cellNo = value; }
        }
    }
}
