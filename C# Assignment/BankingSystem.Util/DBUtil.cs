﻿using System.Data.SqlClient;

namespace BankingSystem.Utils
{
    public static class DBUtil
    {
        private static readonly string connectionString = "Data Source=DESKTOP-JA7DIJC;Initial Catalog=HMBank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"; 

        public static SqlConnection GetDBConn()
        {
            var conn = new SqlConnection(connectionString);
            conn.Open(); // Open the connection
            return conn;
        }
    }
}


