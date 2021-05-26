namespace SqlConnectionStringTester
{
    using System;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello Sql Connection String Tester!");
            
            #region Connection String Examples for Azure SQL Database connections

            // Source: https://www.connectionstrings.com/azure-sql-database/
            var Standard = "Server=tcp:myserver.database.windows.net,1433;Authentication=Active Directory Password;Database=myDataBase;UID=myUser@myDomain;PWD=myPassword;";
            var WithMARSEnabled = "Server=tcp:myserver.database.windows.net,1433;Authentication=Active Directory Password;Database=myDataBase;UID=myUser@myDomain;PWD=myPassword;";
            var IntegratedWindowsAuthenticationWithAnAzureADIdentity = "Server=tcp:myserver.database.windows.net,1433;Authentication=Active Directory Password;Database=myDataBase;UID=myUser@myDomain;PWD=myPassword;";
            
            #endregion


            const string server = "SERVER_ADDRESS";
            const string database = "DATABASE";
            const string userId = "USER_ID";
            const string password = "PASSWORD";
            
            // For testing connection strings a short timeout is preferred.
            const string connectionTimeout = "30";
            
            var azureActiveDirectoryConnectionString = $"Server={server};Initial Catalog={database};Persist Security Info=False;User ID={userId};Password={password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout={connectionTimeout};Authentication=ActiveDirectoryPassword";

            ConnectionStringTester.Test(azureActiveDirectoryConnectionString);
        }
    }
}