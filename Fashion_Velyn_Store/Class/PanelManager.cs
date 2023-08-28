using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Velyn_Store.Class
{
public static class PanelManager
    {

        public static void AbrirFormularios<MiForm>(Panel panelForms) where MiForm : Form, new()
        {
            Form formularioActual = panelForms.Controls.OfType<Form>().FirstOrDefault();
            //formularioActual?.Close();

            Form formulario = new MiForm();
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;

            panelForms.Controls.Clear();
            panelForms.Controls.Add(formulario);

            formulario.Show();
            formulario.BringToFront();
        }

    }
}
