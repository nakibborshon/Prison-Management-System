using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Interfaces;
using System.Data.SqlClient;

namespace Repository
{
    public class CellRepo:ICellRepo
    {
        DatabaseConnectionClass dcc;
        public CellRepo()
        {
            dcc = new DatabaseConnectionClass();
        }


        public bool InsertCell(Cell c)
        {
            string query = "INSERT into Cells VALUES ('" + c.CellNo + "', " + c.CellCapacity + ", " + c.NumberOfPrisoners + ", '" + c.GuardId + "', '" + c.GuardName + "')";
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

        public bool DeleteCell(Cell c)
        {
            string query = "DELETE from Cells WHERE CellNo = '" + c.CellNo + "'";
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

        public bool UpdateCell(Cell c)
        {
            string query = "UPDATE Cells SET CellCapacity = " + c.CellCapacity + ", NumberOfPrisoners= " + c.NumberOfPrisoners + ", GuardId = '" + c.GuardId + "', GuardName= '" + c.GuardName + "' WHERE CellNo = '" + c.CellNo + "'";
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

        public Cell GetCell(string cellNo)
        {
            Cell c = null;
            string query = "SELECT * from Cells WHERE CellNo = '" + cellNo + "'";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                c = new Cell();
                c.CellNo = sdr["CellNo"].ToString();
                c.CellCapacity = Convert.ToInt32(sdr["CellCapacity"].ToString());
                c.NumberOfPrisoners = Convert.ToInt32(sdr["NumberOfPrisoners"].ToString());
                c.GuardId = sdr["GuardId"].ToString();
                c.GuardName = sdr["GuardName"].ToString();
            }

            dcc.CloseConnection();
            return c; 
        }

        public List<Cell> GetAllCells()
        {
            Cell c = null;
            List<Cell> listOfCell = new List<Cell>();

            string query = "SELECT * from Cells";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                c = new Cell();
                c.CellNo = sdr["CellNo"].ToString();
                c.CellCapacity = Convert.ToInt32(sdr["CellCapacity"].ToString());
                c.NumberOfPrisoners = Convert.ToInt32(sdr["NumberOfPrisoners"].ToString());
                c.GuardId = sdr["GuardId"].ToString();
                c.GuardName = sdr["GuardName"].ToString();

                listOfCell.Add(c);
            }

            dcc.CloseConnection();

            return listOfCell;
        }
    }
}
