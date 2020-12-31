using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class DataProvider
    {
        // Enter connection string at here to run!
       
        private const string _connection = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";

        private static DataProvider _instance;

        public static DataProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataProvider();
                }
                return _instance;
            }
        }

        /*private DataProvider()
        {
        }*/

        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            try
            {
                int data = 0;
                using (SqlConnection connec = new SqlConnection(_connection))
                {
                    connec.Open();
                    using (SqlCommand command = new SqlCommand(query, connec))
                    {
                        if (parameter != null)
                        {
                            string[] ListPara = query.Split(' ');
                            int i = 0;
                            foreach (string item in ListPara)
                            {
                                if (item.Contains('@'))
                                {
                                    command.Parameters.AddWithValue(item, parameter[i]);
                                    i++;
                                }
                            }
                        }
                        data = command.ExecuteNonQuery();
                    }
                    connec.Close();
                }
                return data;
            }
            catch
            {
                throw;
            }
        }

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            try
            {
                DataTable data = new DataTable();
                using (SqlConnection connec = new SqlConnection(_connection))
                {
                    connec.Open();
                    SqlCommand command = new SqlCommand(query, connec);

                    if (parameter != null)
                    {
                        string[] ListPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in ListPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(data);
                    }
                    connec.Close();
                }
                return data;
            }
            catch
            {
                throw;
            }
        }

        public object ExcuteScalar(string query, object[] parameter = null)
        {
            try
            {
                object data = 0;
                using (SqlConnection connec = new SqlConnection(_connection))
                {
                    connec.Open();
                    using (SqlCommand command = new SqlCommand(query, connec))
                    {
                        if (parameter != null)
                        {
                            string[] ListPara = query.Split(' ');
                            int i = 0;
                            foreach (string item in ListPara)
                            {
                                if (item.Contains('@'))
                                {
                                    command.Parameters.AddWithValue(item, parameter[i]);
                                    i++;
                                }
                            }
                        }
                        data = command.ExecuteScalar();
                    }
                    connec.Close();
                }
                return data;
            }
            catch
            {
                throw;
            }
        }
    }
}

    

