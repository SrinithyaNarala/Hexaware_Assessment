using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace CourierManagementSystem.ConnectionUtil
{
    public static class DBConnection
    {
        private static string connectionString;

        static DBConnection()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            IConfiguration config = builder.Build();
            connectionString = config.GetConnectionString("DefaultConnection");
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
