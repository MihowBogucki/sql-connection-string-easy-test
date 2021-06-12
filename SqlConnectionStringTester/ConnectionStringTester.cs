namespace SqlConnectionStringTester
{
    using System;
    using System.Text.Json;
    using Microsoft.Data.SqlClient;
    using Microsoft.Extensions.Logging;

    public static class ConnectionStringTester
    {
        public static void Test(string connectionString)
        {
            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();

                Console.WriteLine("Connection is working");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Connection failed, {e}");
            }
        }
    }
}