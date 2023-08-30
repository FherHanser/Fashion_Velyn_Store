using Fashion_Velyn_Store.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fashion_Velyn_Store.Class;
using Fashion_Velyn_Store.Main_Subs;

namespace Fashion_Velyn_Store.Main_Subs
{
    public partial class Main_Bienvenido : Form
    {
        private AuthenticationManager authManager;

        public string NombreCompleto { get; set; }
        public Main_Bienvenido()
        {
            InitializeComponent();
            this.authManager = authManager;

            this.Load += Main_Bienvenido_Load;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }

        }

        private void Main_Bienvenido_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
            labelUserName.Text = NombreCompleto;
        }

    }
}
