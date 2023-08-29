using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Velyn_Store.Class
{
    internal class ErrorLabelManager
    {
        public static void MostrarError(string mensaje, Label labelError)
        {
            labelError.Text = mensaje;
            labelError.Visible = true;
        }


        public static void ValidarNumericInput(TextBox textBox, int maxLength)
        {
            string input = textBox.Text;
            string numericInput = new string(input.Where(char.IsDigit).ToArray());

            if (numericInput.Length > maxLength)
            {
                numericInput = numericInput.Substring(0, maxLength);
            }

            textBox.Text = numericInput;
            textBox.SelectionStart = textBox.Text.Length;
        }



    }
}

