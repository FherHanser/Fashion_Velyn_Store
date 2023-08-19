using Microsoft.Data.Sqlite;
using System;

namespace Fashion_Velyn_Store
{
    public class DatabaseConnection : IDisposable
    {
        private readonly string connectionString = "Data Source=FV_store.db";
        private readonly SqliteConnection connection;

        public DatabaseConnection()
        {
            connection = new SqliteConnection(connectionString);
            connection.Open();
        }

        public SqliteConnection GetConnection()
        {
            return connection;
        }

        public void Dispose()
        {
            connection?.Dispose();
        }
    }
}
