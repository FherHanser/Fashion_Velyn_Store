using Fashion_Velyn_Store.Class;
using Fashion_Velyn_Store.Main_Subs;

namespace Fashion_Velyn_Store
{
    public partial class Main : Form
    {
        public string NombreCompletoM { get; set; }
        public Main()
        {
            InitializeComponent();
            this.Load += Main_Load;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            labelUserNameM.Text = NombreCompletoM;
            PanelManager.AbrirFormularios<Main_Clientes>(panelForms);
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
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PanelManager.AbrirFormularios<Main_Informes>(panelForms);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PanelManager.AbrirFormularios<Main_Pagos>(panelForms);
        }
    }
}