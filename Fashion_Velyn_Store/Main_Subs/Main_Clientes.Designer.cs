﻿namespace Fashion_Velyn_Store
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
            button5 = new Button();
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
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(170, 190);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(900, 300);
            panel1.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(30, 70);
            button5.Name = "button5";
            button5.Size = new Size(175, 150);
            button5.TabIndex = 0;
            button5.Text = "REGISTROS";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(822, 261);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(65, 33);
            button4.TabIndex = 4;
            button4.Text = "Inicio";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(698, 68);
            button3.Name = "button3";
            button3.Size = new Size(175, 150);
            button3.TabIndex = 3;
            button3.Text = "DAR DE BAJA";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(471, 68);
            button2.Name = "button2";
            button2.Size = new Size(175, 150);
            button2.TabIndex = 2;
            button2.Text = "ACTUALIZAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(248, 70);
            button1.Name = "button1";
            button1.Size = new Size(175, 150);
            button1.TabIndex = 1;
            button1.Text = "NUEVO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Main_Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 668);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button5;
    }
}