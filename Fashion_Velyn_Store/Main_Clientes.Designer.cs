namespace Fashion_Velyn_Store
{
    partial class Main_Clientes
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(150, 142);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(788, 225);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(719, 196);
            button4.Name = "button4";
            button4.Size = new Size(57, 25);
            button4.TabIndex = 3;
            button4.Text = "Inicio";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(572, 52);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(153, 112);
            button3.TabIndex = 2;
            button3.Text = "DAR DE BAJA";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(320, 52);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(153, 112);
            button2.TabIndex = 1;
            button2.Text = "ACTUALIZAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(64, 52);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(153, 112);
            button1.TabIndex = 0;
            button1.Text = "NUEVO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Main_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 501);
            Controls.Add(panel1);
            Name = "Main_Clientes";
            Opacity = 0.75D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += Main_Clientes_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}