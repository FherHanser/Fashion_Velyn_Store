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

        public bool AuthenticateUser(string nombreUsuario, string password, out string nombreCompleto)
        {
            nombreCompleto = null; // Inicializar el nombre completo

            using (var connection = dbConnection.GetConnection())
            {
                try
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT password, nombre_completo FROM usuarios WHERE nombre_usuario = @nombreUsuario";
                        command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashedPasswordFromDB = reader.GetString(0);
                                string nombreCompletoFromDB = reader.GetString(1);

                                PasswordHasher hasher = new PasswordHasher();
                                string hashedPasswordInput = hasher.HashPassword(password);

                                if (hashedPasswordInput == hashedPasswordFromDB)
                                {
                                    nombreCompleto = nombreCompletoFromDB;
                                    return true; // Autenticación exitosa
                                }
                            }
                        }
                    }

                    return false; // Credenciales inválidas
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

