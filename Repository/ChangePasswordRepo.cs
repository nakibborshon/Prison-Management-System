using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using Interfaces;
using System.Data.SqlClient;

namespace Repository
{
    class ChangePasswordRepo:IChangePassword
    {
        DatabaseConnectionClass dcc;
        public ChangePasswordRepo()
        {
            dcc = new DatabaseConnectionClass();
        }

        public bool UpdateUser(Login l)
        {
            string query = "Update Login SET Password = '" + l.Password + "' WHERE Id = '" + l.Id + "'";

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
    }
}
