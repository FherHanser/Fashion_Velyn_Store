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
                            PasswordHasher hasher = new PasswordHasher();
                            string hashedPasswordInput = hasher.HashPassword(password);
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

    }
}


