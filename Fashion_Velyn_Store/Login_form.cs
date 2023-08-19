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
            {
                DatabaseConnection dbConnection = new DatabaseConnection();
                AuthenticationManager authManager = new AuthenticationManager(dbConnection);

                string nombreCompleto = authManager.GetNameByCredentials(TxtBoxUser.Text, TxtBoxPass.Text);


                if (nombreCompleto != null)
                {
                    Main consulta = new Main();
                    this.Hide();
                    consulta.Show();
                }
                else
                {
                    MessageBox.Show("Credenciales inválidas");
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

        }
    }
}
