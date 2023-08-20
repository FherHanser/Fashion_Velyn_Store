using System;
using System.Windows.Forms;
using SQLitePCL;

namespace Fashion_Velyn_Store
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Main_Clientes menuClientes = new();
            this.Hide();
            menuClientes.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main_Usuarios menuUsuarios = new();
            this.Hide();
            menuUsuarios.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main menu = new();
            this.Hide();
            menu.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }

    }
}