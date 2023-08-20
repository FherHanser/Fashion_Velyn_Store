using System;
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
            Main_Usuarios inicio = new Main_Usuarios();
            this.Hide();
            inicio.Show();
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

        private void textBoxBuscarUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click_1(object sender, EventArgs e)
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

    }
}

