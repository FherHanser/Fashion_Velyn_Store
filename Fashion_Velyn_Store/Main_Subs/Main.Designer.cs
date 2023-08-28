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
            button5 = new Button();
            panelForms = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlDarkDark;
            button4.Location = new Point(3, 218);
            button4.Name = "button4";
            button4.Size = new Size(311, 45);
            button4.TabIndex = 6;
            button4.Text = "CERRAR SESIÓN";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(2, 158);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(311, 45);
            button3.TabIndex = 2;
            button3.Text = "USUARIOS";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Plum;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(3, 54);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(311, 45);
            button2.TabIndex = 1;
            button2.Text = "PEDIDOS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(3, 2);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(311, 45);
            button1.TabIndex = 0;
            button1.Text = "CLIENTES";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(1, 133);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 270);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.MediumOrchid;
            button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(2, 106);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(311, 45);
            button5.TabIndex = 7;
            button5.Text = "INFORMES";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panelForms
            // 
            panelForms.Location = new Point(319, 0);
            panelForms.Margin = new Padding(3, 2, 3, 2);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(783, 499);
            panelForms.TabIndex = 2;
            panelForms.Paint += panelForms_Paint;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 501);
            Controls.Add(panelForms);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
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
        private Button button5;
    }
}