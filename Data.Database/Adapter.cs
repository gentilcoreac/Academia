using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    {

			//private SqlConnection sqlConnection = new SqlConnection("ConnectionString;");

			//Clave por defecto a utlizar para la cadena de conexion
			const string consKeyDefaultCnnString = "ConnStringLocal";
			#region Propiedades
			private SqlConnection _SqlConn;
			public SqlConnection SqlConn
			{
				get { return _SqlConn; }
				set { _SqlConn = value; }
			}
			#endregion
		
			#region Metodos
			protected void OpenConnection()
			{
				string temp = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
				SqlConn = new SqlConnection(temp);
				SqlConn.Open();
			}    

			protected void CloseConnection()
			{
				SqlConn.Close();
				SqlConn = null;
			}

			protected SqlDataReader ExecuteReader(String commandText)
			{
				throw new Exception("Metodo no implementado");
			}
			#endregion
		}
	}