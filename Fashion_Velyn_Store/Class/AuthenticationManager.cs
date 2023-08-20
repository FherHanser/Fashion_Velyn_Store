using Microsoft.Data.Sqlite;
using System;

namespace Fashion_Velyn_Store.Class
{
    public class AuthenticationManager
    {
        private readonly DatabaseConnection dbConnection;

        public AuthenticationManager(DatabaseConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public string GetNameByCredentials(string nombreUsuario, string password)
        {
            using var connection = dbConnection.GetConnection();

            using var command = connection.CreateCommand();
            command.CommandText =
            @"SELECT nombre || ' ' || apellido
              FROM usuarios
              WHERE nombre_usuario = @nombreUsuario AND password = @password";
            command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            command.Parameters.AddWithValue("@password", password);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return reader.GetString(0);
            }

            return null;
        }
    }
}
