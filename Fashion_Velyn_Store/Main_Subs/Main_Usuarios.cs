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
    public partial class Main_Usuarios : Form
    {
        public Main_Usuarios()
        {
            InitializeComponent();
        }

        private void Main_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main menu = new();
            this.Hide();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario_Form usurioForm = new Usuario_Form();
            this.Hide();
            usurioForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List_Usuarios main = new List_Usuarios();
            this.Hide();
            main.Show();
        }
    }
}