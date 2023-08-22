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
            AbrirFormularios<Main_Clientes>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Main_Usuarios>();
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

        public void AbrirFormularios<MiForm>() where MiForm : Form, new()
        {
            Form formularioActual = panelForms.Controls.OfType<Form>().FirstOrDefault();
            formularioActual?.Close(); // Cierra el formulario actual si existe
            Form formulario = new MiForm();
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            panelForms.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            panelForms.Controls.Add(formulario);
            formulario.Show();
            formulario.BringToFront();
        }


    }
}