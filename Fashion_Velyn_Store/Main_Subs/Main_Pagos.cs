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
    public partial class Main_Pagos : Form
    {
        public Main_Pagos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pago_Form pago_Form = new Pago_Form();
            pago_Form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List_Pagos registros = new List_Pagos();
            registros.ShowDialog();
        }
    }
}
