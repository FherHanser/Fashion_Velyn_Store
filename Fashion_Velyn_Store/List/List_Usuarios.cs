﻿using System;
using System.Data;
using System.Windows.Forms;
using Fashion_Velyn_Store.Class;

namespace Fashion_Velyn_Store.List
{
    public partial class List_Usuarios : Form
    {
        private DataTable dataTable;

        public List_Usuarios()
        {
            InitializeComponent();
        }

        private void List_Usuarios_Load(object sender, EventArgs e)
        {
            LoadUsuarios();
        }

        private void LoadUsuarios()
        {
            using (DatabaseConnection dbConnection = new DatabaseConnection())
            {
                string query = "SELECT * FROM usuarios";

                using (var command = new Microsoft.Data.Sqlite.SqliteCommand(query, dbConnection.GetConnection()))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewUsuarios.DataSource = dataTable;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string filtro = textBoxBuscarUsuario.Text.Trim();

            if (!string.IsNullOrEmpty(filtro))
            {
                DataView dv = dataTable.DefaultView;
                dv.RowFilter = $"nombre LIKE '%{filtro}%' OR apellido LIKE '%{filtro}%'";
                dataGridViewUsuarios.DataSource = dv.ToTable();
            }
            else
            {
                dataGridViewUsuarios.DataSource = dataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxBuscarUsuario.Text = "";
            LoadUsuarios(); // Vuelve a cargar todos los usuarios en el DataGridView
        }


        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // Para evitar que se emita un sonido al presionar Enter
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void buttonBuscar_Click_1(object sender, EventArgs e)

        {
            string filtro = textBoxBuscarUsuario.Text.Trim();

            if (!string.IsNullOrEmpty(filtro))
            {
                DataView dv = dataTable.DefaultView;
                dv.RowFilter = $"nombre_usuario LIKE '%{filtro}%'";
                DataTable filteredDataTable = dv.ToTable();

                if (filteredDataTable.Rows.Count > 0)
                {
                    dataGridViewUsuarios.DataSource = filteredDataTable;
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados para el nombre buscado.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre a buscar.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridViewUsuarios.SelectedRows[0].Index;
                int usuarioId = Convert.ToInt32(dataGridViewUsuarios.Rows[rowIndex].Cells["id_usuario"].Value);

                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (DatabaseConnection dbConnection = new DatabaseConnection())
                    {
                        string query = "DELETE FROM usuarios WHERE id_usuario = @UsuarioId";

                        using (var command = new Microsoft.Data.Sqlite.SqliteCommand(query, dbConnection.GetConnection()))
                        {
                            command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Usuario eliminado exitosamente.");
                                LoadUsuarios(); // Recargar los datos en el DataGridView
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el usuario.");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

