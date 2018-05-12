using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Data.Database
{
    public class Adapter
    {
        //string ServerName = "DESKTOP-VDVRD36\SQLEXPRESSACG";
        //string DataBaseName = "Academia";
        //private string UserName = "";
        //private string Secret = "";
        /*private SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-VDVRD36\\SQLEXPRESSACG" +
                                                                "Initial Catalog=Academia" +
                                                                 "Integrated Security=true;");
*/
        protected void OpenConnection()
        {
           // sqlConnection.Open();
        }

        protected void CloseConnection()
        {
         //   sqlConnection.Close();
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
