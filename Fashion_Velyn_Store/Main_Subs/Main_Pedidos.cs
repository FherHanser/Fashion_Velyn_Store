using Fashion_Velyn_Store.Forms;
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

namespace Fashion_Velyn_Store.Main_Subs
{
    public partial class Main_Pedidos : Form
    {
        public Main_Pedidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedido_Form pedido_Form = new Pedido_Form();
            pedido_Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List_Pedidos registrosPedidos = new List_Pedidos();
            registrosPedidos.Show();
        }
    }
}
