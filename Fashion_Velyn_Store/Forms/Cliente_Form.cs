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
using Fashion_Velyn_Store.Class;

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
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxApellidos.Text) ||
                string.IsNullOrWhiteSpace(textBoxTel1.Text) ||
                string.IsNullOrWhiteSpace(textBoxDireccion.Text) ||
                string.IsNullOrWhiteSpace(textBoxReferencia.Text) ||
                string.IsNullOrWhiteSpace(textBoxTipoCliente.Text))
            {
                errorMessage = "Todos los campos deben ir llenos, excepto correo y teléfono 2.";
                ErrorLabelManager.MostrarError(errorMessage, labelError);
                return;
            }
            else
            {
                labelError.Visible = false; 
            }

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

            DatabaseConnection dbConnection = new DatabaseConnection();
            ClienteManager clienteManager = new ClienteManager(dbConnection);

            bool insertExitoso = clienteManager.InsertCliente(nuevoCliente);

            if (insertExitoso)
            {
                MessageBox.Show("Nuevo Cliente Registrado");
                LimpiarCasillas();
            }
            else
            {
                MessageBox.Show("No se Registró un Nuevo Cliente");
                LimpiarCasillas();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            LimpiarCasillas();
            labelError.Visible = false; // Hacer invisible el labelError al limpiar los campos
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
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

        private void LimpiarCasillas()
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

        private void textBoxTel1_TextChanged(object sender, EventArgs e)
        {
            ErrorLabelManager.ValidarNumericInput(textBoxTel1, 8);

        }

        private void textBoxTel2_TextChanged(object sender, EventArgs e)
        {
            ErrorLabelManager.ValidarNumericInput(textBoxTel2, 8);
        }
    }
}
