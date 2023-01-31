using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace UI.Model
{
    public class DBConnection
    {
        private SqlConnection _connection;

        private static string _connectionString;

        public static string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public DBConnection(string connectionString)
        {
            _connectionString = connectionString;
            _connection = new SqlConnection(_connectionString);
        }

        public bool OpenConnection()
        {
            bool isConnected;

            try
            {
                _connection.Open();
                isConnected = true;
            }
            catch (SqlException ex)
            {
                // Handle the exception;
                isConnected = false;
            }
            
            return isConnected;
        }

        public void CloseConnection()
        {
            _connection.Close();
        }

        public bool IsOpen()
        {
            return (_connection.State == System.Data.ConnectionState.Open);
        }

        public DataTable GetDataTable(string storedProc, out string ex, List<string> paramList = null)
        {
            DataTable dtTemp = new DataTable();
            ex = "";

            try
            {
                using (SqlCommand command = new SqlCommand(storedProc, _connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (paramList != null)
                        foreach (var s in paramList)
                        {
                            string[] sParam = s.Split('-');
                            command.Parameters.AddWithValue(sParam[0], sParam[1]);
                        }

                    //command.ExecuteNonQuery();

                    using (SqlDataAdapter adapater = new SqlDataAdapter(command))
                    {
                        adapater.Fill(dtTemp);
                    }

                }
            }
            catch (SqlException e)
            {
                ex = e.Message;
            }

            return dtTemp;
        }

        public T GetData<T>(string storedProc, out string ex, string[] parameters = null)
        {
            ex = "";
            T result = default(T);

            try
            {
                using (SqlCommand command = new SqlCommand(storedProc, _connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    foreach (var s in parameters)
                    {
                        string[] sParam = s.Split('-');
                        command.Parameters.AddWithValue(sParam[0], sParam[1]);
                    }

                    //command.ExecuteNonQuery();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = (T)reader[0];
                        }
                    }

                }
            }
            catch (SqlException e)
            {
                ex = e.Message;
            }

            return result;
        }

        public bool UpdateData(string sSQL, out string ex, List<string> paramList = null)
        {
            ex = "";
            bool bSuccess = false;

            try
            {
                using (SqlCommand command = new SqlCommand(sSQL, _connection))
                {
                    if (paramList != null)
                        foreach (var s in paramList)
                        {
                            string[] sParam = s.Split('-');
                            command.Parameters.AddWithValue(sParam[0], sParam[1]);
                        }

                    command.ExecuteNonQuery();
                    bSuccess = true;
                }
            }
            catch (SqlException e)
            {
                ex = e.Message;
                bSuccess = false;
            }

            return bSuccess;
        }

    }
}
