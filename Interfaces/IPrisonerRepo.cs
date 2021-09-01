using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
   public interface IPrisonerRepo
    {
        bool InsertPrisoner(Prisoner p);
        bool DeletePrisoner(Prisoner p);
        bool UpdatePrisoner(Prisoner p);
        Prisoner GetPrisoner(string prisonerId);
        List<Prisoner> GetAllPrisoners();
    }
}
