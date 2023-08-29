using Microsoft.Data.Sqlite;
using System;
using System.Text;

namespace Fashion_Velyn_Store.Class
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
            using (var connection = dbConnection.GetConnection())
            {
                try
                {
                    using (var command = connection.CreateCommand())
                    {
                        // Generar el hash de la contraseña
                        string hashedPassword = HashPassword(password);

                        command.CommandText =
                            @"INSERT INTO usuarios (nombre_usuario, nombre, apellido, password)
                      VALUES (@nombreUsuario, @nombre, @apellido, @password)";

                        command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellido", apellido);
                        command.Parameters.AddWithValue("@password", hashedPassword);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Error al insertar el usuario.");
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar el usuario: " + ex.Message);
                    return false;
                }
            }
        }

        private string HashPassword(string password)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }


    }
}