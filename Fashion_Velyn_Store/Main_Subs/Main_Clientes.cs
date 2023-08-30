using Fashion_Velyn_Store.List;
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
    public partial class Main_Clientes : Form
    {
        public Main_Clientes()
        {
            InitializeComponent();
        }

        private void Main_Clientes_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main inicio = new Main();
            this.Hide();
            inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente_Form nuevoCliente = new Cliente_Form();
            nuevoCliente.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List_Cliente registrosClientes = new List_Cliente();
            registrosClientes.Show();
        }
    }
}