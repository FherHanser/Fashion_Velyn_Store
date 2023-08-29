using System;
using System.Windows.Forms;
using Fashion_Velyn_Store.Class;
using Fashion_Velyn_Store.Main_Subs;
using SQLitePCL;

namespace Fashion_Velyn_Store
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();

            this.Load += Main_Load; // Asociar el evento Load al manejador Main_Load
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelManager.AbrirFormularios<Main_Pedidos>(panelForms);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelManager.AbrirFormularios<Main_Clientes>(panelForms);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelManager.AbrirFormularios<Main_Usuarios>(panelForms);
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

        private void button5_Click(object sender, EventArgs e)
        {
            PanelManager.AbrirFormularios<Main_Informes>(panelForms);
        }

    }
}