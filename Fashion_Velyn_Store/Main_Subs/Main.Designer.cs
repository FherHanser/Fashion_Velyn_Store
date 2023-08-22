namespace Fashion_Velyn_Store
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panelForms = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(3, 202);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(355, 60);
            button4.TabIndex = 6;
            button4.Text = "SALIR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(2, 135);
            button3.Name = "button3";
            button3.Size = new Size(355, 60);
            button3.TabIndex = 2;
            button3.Text = "ADMINISTRACIÓN";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Plum;
            button2.Location = new Point(3, 69);
            button2.Name = "button2";
            button2.Size = new Size(355, 60);
            button2.TabIndex = 1;
            button2.Text = "PEDIDOS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(355, 60);
            button1.TabIndex = 0;
            button1.Text = "CLIENTES";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(1, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 269);
            panel2.TabIndex = 1;
            // 
            // panelForms
            // 
            panelForms.Location = new Point(365, 0);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(895, 665);
            panelForms.TabIndex = 2;
            panelForms.Paint += panelForms_Paint;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 668);
            Controls.Add(panelForms);
            Controls.Add(panel2);
            Name = "Main";
            Opacity = 0.75D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Inicio";
            Load += Main_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Panel panel2;
        private Panel panelForms;
    }
}