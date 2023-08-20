using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace Fashion_Velyn_Store.Class
{
    public class ClienteManager
    {
        private readonly DatabaseConnection dbConnection;

        public ClienteManager(DatabaseConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public bool InsertCliente(Cliente cliente)
        {
            using var connection = dbConnection.GetConnection();
            using var transaction = connection.BeginTransaction();

            try
            {
                using var command = connection.CreateCommand();
                command.Transaction = transaction;

                command.CommandText =
                    @"INSERT INTO cliente (nombres, apellidos, telefono1, telefono2, direccion, referencia, correo, clase)
                      VALUES (@nombres, @apellidos, @telefono1, @telefono2, @direccion, @referencia, @correo, @clase)";

                command.Parameters.AddWithValue("@nombres", cliente.Nombres);
                command.Parameters.AddWithValue("@apellidos", cliente.Apellidos);
                command.Parameters.AddWithValue("@telefono1", cliente.Telefono1);
                command.Parameters.AddWithValue("@telefono2", cliente.Telefono2);
                command.Parameters.AddWithValue("@direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@referencia", cliente.Referencia);
                command.Parameters.AddWithValue("@correo", cliente.Correo);
                command.Parameters.AddWithValue("@clase", cliente.Clase);

                string valuesToInsert = $"Nombres: {cliente.Nombres}\nApellidos: {cliente.Apellidos}\nTeléfono 1: {cliente.Telefono1}\nTeléfono 2: {cliente.Telefono2}\nDirección: {cliente.Direccion}\nReferencia: {cliente.Referencia}\nCorreo: {cliente.Correo}\nClase: {cliente.Clase}";

                DialogResult result = MessageBox.Show("Información para Nuevo Cliente:\n\n" + valuesToInsert + "\n\n¿Desea continuar?", "Confirmar inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Insert exitoso");
                        transaction.Commit();
                        return true;
                    }
                    else
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
                else
                {
                    transaction.Rollback();
                    return false;
                }
            }
            catch (Exception)
            {
                transaction.Rollback();
                return false;
            }
        }
    }
}
