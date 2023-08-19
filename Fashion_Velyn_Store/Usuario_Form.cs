using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fashion_Velyn_Store
{
    public partial class Usuario_Form : Form
    {
        public Usuario_Form()
        {
            InitializeComponent();
        }

        private void Usuario_Form_Load(object sender, EventArgs e)
        {

        }

        private void BtnInsertarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxApellidos.Text = "";
            textBoxUsuario.Text = "";
            textBoxPass.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBoxUsuario.Text;
            string nombre = textBoxName.Text;
            string apellido = textBoxApellidos.Text;
            string password = textBoxPass.Text;

            DatabaseConnection dbConnection = new DatabaseConnection();
            UsuarioManager usuarioManager = new UsuarioManager(dbConnection);

            bool insertExitoso = usuarioManager.InsertUsuario(nombreUsuario, nombre, apellido, password);

            if (insertExitoso)
            {
                MessageBox.Show("Usuario insertado exitosamente.");

            }
            else
            {
                MessageBox.Show("Error al insertar usuario.");

            }
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // Para evitar que se emita un sonido al presionar Enter
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




