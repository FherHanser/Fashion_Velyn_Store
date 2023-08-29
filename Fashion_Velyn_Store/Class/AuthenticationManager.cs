using System;
using System.Collections.Generic;
using Fashion_Velyn_Store.Cache;

namespace Fashion_Velyn_Store.Class
{
    public class AuthenticationManager
    {
        private DatabaseConnection dbConnection;
        private Dictionary<string, User> userCache; // Caché de usuarios autenticados

        public AuthenticationManager(DatabaseConnection connection)
        {
            dbConnection = connection;
            userCache = new Dictionary<string, User>();
        }

        public bool AuthenticateUser(string nombreUsuario, string password, out string nombreCompleto)
        {
            nombreCompleto = null;

            // Verificar si el usuario está en caché
            if (userCache.TryGetValue(nombreUsuario, out var cachedUser))
            {
                if (cachedUser.Password == password)
                {
                    nombreCompleto = $"{cachedUser.Nombre} {cachedUser.Apellido}";
                    return true;
                }
                return false;
            }

            using (var connection = dbConnection.GetConnection())
            {
                try
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT password, nombre, apellido FROM usuarios WHERE nombre_usuario = @nombreUsuario";
                        command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashedPasswordFromDB = reader.GetString(0);
                                string nombreFromDB = reader.GetString(1);
                                string apellidoFromDB = reader.GetString(2);

                                PasswordHasher hasher = new PasswordHasher();
                                string hashedPasswordInput = hasher.HashPassword(password);

                                if (hashedPasswordInput == hashedPasswordFromDB)
                                {
                                    // Agregar a la caché
                                    userCache[nombreUsuario] = new User
                                    {
                                        Nombre_Usuario = nombreUsuario,
                                        Nombre = nombreFromDB,
                                        Apellido = apellidoFromDB,
                                        Password = hashedPasswordFromDB
                                    };

                                    nombreCompleto = $"{nombreFromDB} {apellidoFromDB}";

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

        public bool GetCurrentUser(string nombreUsuario, out User currentUser)
        {
            currentUser = null;
            // Implementa la lógica para obtener el usuario actual de la caché
            // Retorna true si se encuentra el usuario en la caché, de lo contrario, false
            return userCache.TryGetValue(nombreUsuario, out currentUser);
        }

    }
}
