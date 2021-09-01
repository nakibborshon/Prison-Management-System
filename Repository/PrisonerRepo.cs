using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repository
{
    public class PrisonerRepo : IPrisonerRepo
    {
        DatabaseConnectionClass dcc;
        public PrisonerRepo()
        {
            dcc = new DatabaseConnectionClass();
        }

        public bool InsertPrisoner(Prisoner p)
        {
            string query = "INSERT into Prisoners VALUES ('" + p.PrisonerId + "', '" + p.PrisonerName + "', '" + p.Address + "', '" + p.Crime + "', '" + p.Punishment + "','"+p.CellNo+"')";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                dcc.CloseConnection();
                return false;
            }
        }

        public bool DeletePrisoner(Prisoner p)
        {
            string query = "DELETE from Prisoners WHERE PrisonerId = '" + p.PrisonerId + "'";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }

        public bool UpdatePrisoner(Prisoner p)
        {
            string query = "UPDATE Prisoners SET PrisonerName = '" + p.PrisonerName + "', Address = '" + p.Address + "', Crime = '" + p.Crime + "', Punishment= '" + p.Punishment + "''"+p.CellNo+"' WHERE PrisonerId = '" + p.PrisonerId + "'";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }

        public Prisoner GetPrisoner(string prisonerId)
        {
            Prisoner p = null;
            string query = "SELECT * from Prisoners WHERE PrisonerId = '" + prisonerId + "'";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                p = new Prisoner();
                p.PrisonerId = sdr["PrisonerId"].ToString();
                p.PrisonerName = sdr["PrisonerName"].ToString();
                p.Address = sdr["Address"].ToString();
                p.Crime = sdr["Crime"].ToString();
                p.Punishment = sdr["Punishment"].ToString();
                p.CellNo = sdr["CellNo"].ToString();
            }

            dcc.CloseConnection();
            return p; 
        }

        public List<Prisoner> GetAllPrisoners()
        {
            Prisoner p = null;
            List<Prisoner> listOfPrisoner = new List<Prisoner>();

            string query = "SELECT * from Prisoners";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                p = new Prisoner();
                p.PrisonerId = sdr["PrisonerId"].ToString();
                p.PrisonerName = sdr["PrisonerName"].ToString();
                p.Address = sdr["Address"].ToString();
                p.Crime = sdr["Crime"].ToString();
                p.Punishment = sdr["Punishment"].ToString();
                p.CellNo = sdr["CellNo"].ToString();

                listOfPrisoner.Add(p);
            }

            dcc.CloseConnection();

            return listOfPrisoner;
        }

        public Prisoner GetPriosner(string prisonerId)
        {
            Prisoner p = null;
            string query = "SELECT * from Prisoners WHERE PrisonerId = '" + prisonerId + "'";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                p = new Prisoner();
                p.PrisonerId = sdr["PrisonerId"].ToString();
                p.PrisonerName = sdr["PrisonerName"].ToString();
                p.Address = sdr["Address"].ToString();
                p.Crime = sdr["Crime"].ToString();
                p.Punishment = sdr["Punishment"].ToString();
                p.CellNo = sdr["CellNo"].ToString();
            }

            dcc.CloseConnection();
            return p; 
        }
    }
}
