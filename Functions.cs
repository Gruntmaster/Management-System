using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    public class Functions
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private DataTable dataTable;
        private SqlDataAdapter sqlDataAdapter;
        private string ConnectionString;
        public Functions()
        {
            ConnectionString = @"Data Source=localhost\SqlExpress;Initial Catalog=ManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            sqlConnection = new SqlConnection(ConnectionString);
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

        }

        // retrieves data from the database based on the provided query
        public DataTable GetData(string query) // This function retrieves data from the database based on the provided query
        {
           dataTable = new DataTable();
           sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
           sqlDataAdapter.Fill(dataTable);
           return dataTable;
        }

        // modifies data in the database based on the provided query
        public int SetData(string query)
        {
            int affectedRows = 0;
            if(sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            sqlCommand.CommandText = query;
            affectedRows = sqlCommand.ExecuteNonQuery();
            return affectedRows;
        }
    }
}
