using Microsoft.Data.Sqlite;
using System;

namespace Fashion_Velyn_Store
{
    public class UsuarioManager
    {
        private readonly DatabaseConnection dbConnection;

        public UsuarioManager(DatabaseConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public bool InsertUsuario(string nombreUsuario, string nombre, string apellido, string password)
        {
            using var connection = dbConnection.GetConnection();
            using var transaction = connection.BeginTransaction();

            try
            {
                using var command = connection.CreateCommand();
                command.Transaction = transaction;

                command.CommandText =
                    @"INSERT INTO usuarios (nombre_usuario, nombre, apellido, password)
                      VALUES (@nombreUsuario, @nombre, @apellido, @password)";

                command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@password", password);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    transaction.Commit();
                    return true;
                }
                else
                {
                    transaction.Rollback();
                    return false;
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Error al insertar el usuario: " + ex.Message);
                return false;
            }
        }
    }
}
