﻿namespace Fashion_Velyn_Store
{
    partial class Main_Usuarios
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
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 160);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(876, 300);
            panel1.TabIndex = 2;
            // 
            // button5
            // 
            button5.Location = new Point(216, 70);
            button5.Name = "button5";
            button5.Size = new Size(175, 150);
            button5.TabIndex = 0;
            button5.Text = "REGISTROS";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(496, 70);
            button1.Name = "button1";
            button1.Size = new Size(175, 150);
            button1.TabIndex = 1;
            button1.Text = "NUEVO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Main_Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 618);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Main_Usuarios";
            Opacity = 0.75D;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            Load += Main_Usuarios_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button5;
    }
}