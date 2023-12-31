﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fashion_Velyn_Store.Class;
using Fashion_Velyn_Store.Main_Subs;
using Microsoft.Data.Sqlite;
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

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            AuthenticationManager authManager = new AuthenticationManager(dbConnection);

            string nombreUsuario = TxtBoxUser.Text;
            string password = TxtBoxPass.Text;

            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(password))
            {
                ErrorLabelManager.MostrarError("Ingrese el nombre de usuario y la contraseña", labelError);
            }
            else
            {
                labelError.Visible = false;

                if (authManager.AuthenticateUser(nombreUsuario, password, out var nombreCompleto))
                {
                    this.Hide();
                    Main_Bienvenido bienvenido = new Main_Bienvenido();
                    bienvenido.NombreCompleto = nombreCompleto; // Asigna el nombre completo al formulario de bienvenida
                    bienvenido.ShowDialog();
                    Main inicio = new Main();
                    inicio.NombreCompletoM = nombreCompleto;
                    inicio.Show();
                }


                else
                {
                    MessageBox.Show("Credenciales inválidas");
                    TxtBoxUser.Text = string.Empty;
                    TxtBoxPass.Text = string.Empty;
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
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}