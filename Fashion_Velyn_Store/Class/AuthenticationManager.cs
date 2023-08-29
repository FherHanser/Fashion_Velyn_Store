using Microsoft.Data.Sqlite;
using System;
using System.Text;

namespace Fashion_Velyn_Store.Class
{
    public class AuthenticationManager
    {
        private DatabaseConnection dbConnection;

        public AuthenticationManager(DatabaseConnection connection)
        {
            dbConnection = connection;
        }

        public bool AuthenticateUser(string nombreUsuario, string password)
        {
            using (var connection = dbConnection.GetConnection())
            {
                try
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT password FROM usuarios WHERE nombre_usuario = @nombreUsuario";
                        command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                        connection.Open();

                        var hashedPasswordFromDB = (string)command.ExecuteScalar();

                        if (hashedPasswordFromDB != null)
                        {
                            string hashedPasswordInput = HashPassword(password);
                            return hashedPasswordInput == hashedPasswordFromDB;
                        }
                        else
                        {
                            return false; // El usuario no existe en la base de datos
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error de autenticación: " + ex.Message);
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

