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
            Main_Clientes inicio = new Main_Clientes();
            this.Hide();
            inicio.Show();
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
                dataGridViewClientes.DataSource = dv.ToTable();
            }
            else
            {
                dataGridViewClientes.DataSource = dataTable;
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
    }
}
