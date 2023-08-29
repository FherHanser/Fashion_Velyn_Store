using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fashion_Velyn_Store.Class;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Timer = System.Windows.Forms.Timer;

namespace Fashion_Velyn_Store
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }

        public bool AuthenticateUser(string nombreUsuario, string password)
        {
            using (var connection = dbConnection.GetConnection())
            {
                try
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = @"SELECT password FROM usuarios WHERE nombre_usuario = @nombreUsuario";
                        command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                        connection.Open();

                        var hashedPasswordFromDB = (string)command.ExecuteScalar();

                        if (hashedPasswordFromDB != null)
                        {
                            PasswordHasher hasher = new PasswordHasher();
                            string hashedPasswordInput = hasher.HashPassword(password);
                            return hashedPasswordInput == hashedPasswordFromDB;
                        }
                        else
                        {
                            return false; // El usuario no existe en la base de datos
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error de autenticación: " + ex.Message);
                    return false;
                }
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

        private void TxtBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxPass_TextChanged(object sender, EventArgs e)
        {
            // Mostrar el carácter durante un corto período y luego ocultarlo
            TxtBoxPass.UseSystemPasswordChar = false;

            Timer timer = new Timer();
            timer.Interval = 500; // Intervalo en milisegundos (1 segundo en este caso)
            timer.Tick += (s, ev) =>
            {
                TxtBoxPass.UseSystemPasswordChar = true;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
