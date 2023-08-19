using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Fashion_Velyn_Store
{
    public partial class Cliente_Form : Form
    {
        public Cliente_Form()
        {
            InitializeComponent();
        }

        private void Cliente_Form_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main inicio = new Main();
            this.Hide();
            inicio.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            DatabaseConnection mySQLiteConnection = new DatabaseConnection();
            Cliente nuevoCliente = new Cliente
            {
                Nombres = textBoxName.Text,
                Apellidos = textBoxApellidos.Text,
                Telefono1 = textBoxTel1.Text,
                Telefono2 = textBoxTel2.Text,
                Direccion = textBoxDireccion.Text,
                Referencia = textBoxReferencia.Text,
                Correo = textBoxCorreo.Text,
                Clase = textBoxTipoCliente.Text
            };

            // Mostrar MessageBox con la información a cometer
            string message = $"Información del Nuevo Cliente:\n" +
                             $"Nombres: {nuevoCliente.Nombres}\n" +
                             $"Apellidos: {nuevoCliente.Apellidos}\n" +
                             $"Teléfono 1: {nuevoCliente.Telefono1}\n" +
                             $"Teléfono 2: {nuevoCliente.Telefono2}\n" +
                             $"Dirección: {nuevoCliente.Direccion}\n" +
                             $"Referencia: {nuevoCliente.Referencia}\n" +
                             $"Correo: {nuevoCliente.Correo}\n" +
                             $"Clase: {nuevoCliente.Clase}";

            DialogResult result = MessageBox.Show(message, "Nuevo Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {

                DatabaseConnection dbConnection = new DatabaseConnection();
                ClienteManager clienteManager = new ClienteManager(dbConnection);

                bool insertExitoso = clienteManager.InsertCliente(nuevoCliente);


                if (insertExitoso)
                {
                    MessageBox.Show("Insert de cliente exitoso");
                }
                else
                {
                    MessageBox.Show("Error en el insert de cliente");
                }
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxApellidos.Text = "";
            textBoxTel1.Text = "";
            textBoxTel2.Text = "";
            textBoxDireccion.Text = "";
            textBoxReferencia.Text = "";
            textBoxCorreo.Text = "";
            textBoxTipoCliente.Text = "";
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
