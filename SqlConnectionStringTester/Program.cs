/*
Copyright 2021 Karol Bajkowski
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

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