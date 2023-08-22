using System;
using System.Data;
using System.Windows.Forms;
using Fashion_Velyn_Store.Class;

namespace Fashion_Velyn_Store.List
{
    public partial class List_Cliente : Form
    {
        private DataTable dataTable;

        public List_Cliente()
        {
            InitializeComponent();
        }

        private void List_Cliente_Load(object sender, EventArgs e)
        {
            LoadClientes();
        }

        private void LoadClientes()
        {
            using (DatabaseConnection dbConnection = new DatabaseConnection())
            {
                string query = "SELECT * FROM cliente";

                using (var command = new Microsoft.Data.Sqlite.SqliteCommand(query, dbConnection.GetConnection()))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewClientes.DataSource = dataTable;
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
            string filtro = textBoxBuscarNombre.Text.Trim();

            if (!string.IsNullOrEmpty(filtro))
            {
                DataView dv = dataTable.DefaultView;
                dv.RowFilter = $"nombres LIKE '%{filtro}%'";
                dataGridViewClientes.DataSource = dv.ToTable();
            }
            else
            {
                dataGridViewClientes.DataSource = dataTable;
            }
        }

        private void buttonBuscar_Click_1(object sender, EventArgs e)
        {
            string filtro = textBoxBuscarNombre.Text.Trim();

            if (!string.IsNullOrEmpty(filtro))
            {
                DataView dv = dataTable.DefaultView;
                dv.RowFilter = $"nombres LIKE '%{filtro}%'";
                DataTable filteredDataTable = dv.ToTable();

                if (filteredDataTable.Rows.Count > 0)
                {
                    dataGridViewClientes.DataSource = filteredDataTable;
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



        private void textBoxBuscarNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // Para evitar que se emita un sonido al presionar Enter
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadClientes();
            textBoxBuscarNombre.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridViewClientes.SelectedRows[0].Index;
                int clienteId = Convert.ToInt32(dataGridViewClientes.Rows[rowIndex].Cells["id_cliente"].Value);

                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (DatabaseConnection dbConnection = new DatabaseConnection())
                    {
                        string query = "DELETE FROM cliente WHERE id_cliente = @ClienteId";

                        using (var command = new Microsoft.Data.Sqlite.SqliteCommand(query, dbConnection.GetConnection()))
                        {
                            command.Parameters.AddWithValue("@ClienteId", clienteId);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Registro eliminado exitosamente.");
                                LoadClientes(); // Recargar los datos en el DataGridView
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el registro.");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un registro para eliminar.");
            }
        }

    }
}
