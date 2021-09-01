using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repository
{
   public class VisitorRepo:IVisitorRepo
    {
       DatabaseConnectionClass dcc;
       public VisitorRepo()
       {
           dcc = new DatabaseConnectionClass();
       }

       public bool InsertVisitor(Visitor v)
       {
           string query = "INSERT into Visitors VALUES ('" + v.VisitorName + "', '" + v.VisitedPrisonerId + "', '" + v.CounterNo + "', " + v.VisitedDuration + ")";
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

       public bool DeleteVisitor(Visitor v)
       {
           string query = "DELETE from Visitors WHERE VisitorName = '" + v.VisitorName + "'";
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
               dcc.CloseConnection();
           }
       }

       public bool UpdateVisitor(Visitor v)
       {
           string query = "UPDATE Visitors SET VisitedPrisonerId = '" + v.VisitedPrisonerId + "', CounterNo= '" + v.CounterNo + "', VisitedDuration = " + v.VisitedDuration + " WHERE VisitorName = '" + v.VisitorName + "'";
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
               dcc.CloseConnection();
           }
       }

       public Visitor GetVisitor(string visitorName)
       {
           Visitor v = null;
           string query = "SELECT * from Visitors WHERE VisitorName = '" + visitorName + "'";

           dcc.ConnectWithDB();
           SqlDataReader sdr = dcc.GetData(query);

           while (sdr.Read())
           {
               v = new Visitor();
               v.VisitorName = sdr["VisitorName"].ToString();
               v.VisitedPrisonerId = sdr["VisitedPrisonerId"].ToString();
               v.CounterNo = sdr["CounterNo"].ToString();
               v.VisitedDuration = Convert.ToDouble(sdr["VisitedDuration"].ToString());

           }

           dcc.CloseConnection();
           return v;
       }

       public List<Visitor> GetAllVisitors()
       {
           Visitor v = null;
           List<Visitor> listOfVisitor = new List<Visitor>();

           string query = "SELECT * from Visitors";

           dcc.ConnectWithDB();
           SqlDataReader sdr = dcc.GetData(query);

           while (sdr.Read())
           {
               v = new Visitor();
               v.VisitorName = sdr["VisitorName"].ToString();
               v.VisitedPrisonerId = sdr["VisitedPrisonerId"].ToString();
               v.CounterNo = sdr["CounterNo"].ToString();
               v.VisitedDuration = Convert.ToDouble(sdr["VisitedDuration"].ToString());

               listOfVisitor.Add(v);
           }

           dcc.CloseConnection();

           return listOfVisitor;
       }


       Visitor IVisitorRepo.GetVisitor(string visitorName)
       {
           Visitor v = null;
           string query = "SELECT * from Visitors WHERE VisitorName = '" + visitorName + "'";

           dcc.ConnectWithDB();
           SqlDataReader sdr = dcc.GetData(query);

           while (sdr.Read())
           {
               v = new Visitor();
               v.VisitorName = sdr["VisitorName"].ToString();
               v.VisitedPrisonerId = sdr["VisitedPrisonerId"].ToString();
               v.CounterNo = sdr["CounterNo"].ToString();
               v.VisitedDuration = Convert.ToDouble(sdr["CounterNo"].ToString());

           }

           dcc.CloseConnection();
           return v;
       }

    }
}
