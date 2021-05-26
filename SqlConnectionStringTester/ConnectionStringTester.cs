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
            var loggerFactory = LoggerFactory.Create(
                builder =>
                {
                    builder.AddConsole();
                });

            loggerFactory.AddFile("Logs/{Date}.log");
            
            var logger = loggerFactory.CreateLogger("Program");

            void Print(object o)
            {
                if (o is string s)
                {
                    logger.LogInformation(s);
                }
                else
                {
                    logger.LogInformation($"{JsonSerializer.Serialize(o)}");
                }
            }

            try
            {

                using var conn = new SqlConnection(connectionString);
                conn.Open();

                Print($"Connection is working");
            }
            catch (Exception e)
            {
                Print($"Connection failed, {e}");
            }
        }
    }
}