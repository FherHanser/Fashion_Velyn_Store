using System;
using System.Windows.Forms;
using Fashion_Velyn_Store.Main_Subs;
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
            AbrirFormularios<Main_Pedidos>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Main_Clientes menuClientes = new();
            //this.Hide();
            //menuClientes.Show();

            AbrirFormularios<Main_Clientes>();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Main_Usuarios menuUsuarios = new();
            //this.Hide();
            //menuUsuarios.Show();
            AbrirFormularios<Main_Usuarios>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main menu = new();
            this.Hide();
            menu.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirma salir de Fashion Velyn Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cierra la aplicación
            }
        }

        private void panelForms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormularios<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelForms.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                panelForms.Controls.Add(formulario);
                panelForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();


            }


        }







    }
}