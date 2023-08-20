using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fashion_Velyn_Store.List
{
    public partial class List_Usuarios : Form
    {
        public List_Usuarios()
        {
            InitializeComponent();
        }

        private void List_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main_Usuarios inicio = new Main_Usuarios();
            this.Hide();
            inicio.Show();
        }
    }
}
