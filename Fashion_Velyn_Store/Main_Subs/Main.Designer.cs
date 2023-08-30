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
            btnCerrar = new Button();
            btnUsuarios = new Button();
            btnPedidos = new Button();
            btnClientes = new Button();
            panel2 = new Panel();
            button1 = new Button();
            btnInformes = new Button();
            labelUserNameM = new Label();
            panelForms = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = SystemColors.ControlDarkDark;
            btnCerrar.Location = new Point(3, 269);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(311, 45);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "CERRAR SESIÓN";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += button4_Click_1;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = SystemColors.ActiveCaption;
            btnUsuarios.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuarios.ForeColor = SystemColors.ButtonFace;
            btnUsuarios.Location = new Point(4, 207);
            btnUsuarios.Margin = new Padding(3, 2, 3, 2);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(311, 45);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "USUARIOS";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += button3_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.Plum;
            btnPedidos.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPedidos.ForeColor = SystemColors.ButtonFace;
            btnPedidos.Location = new Point(3, 54);
            btnPedidos.Margin = new Padding(3, 2, 3, 2);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(311, 45);
            btnPedidos.TabIndex = 1;
            btnPedidos.Text = "PEDIDOS";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += button2_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Thistle;
            btnClientes.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClientes.ForeColor = SystemColors.ButtonFace;
            btnClientes.Location = new Point(3, 2);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(311, 45);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "CLIENTES";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnInformes);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(btnClientes);
            panel2.Controls.Add(btnUsuarios);
            panel2.Controls.Add(btnPedidos);
            panel2.Location = new Point(1, 107);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 322);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(3, 105);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(311, 45);
            button1.TabIndex = 5;
            button1.Text = "PAGOS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btnInformes
            // 
            btnInformes.BackColor = Color.MediumOrchid;
            btnInformes.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInformes.ForeColor = SystemColors.ButtonFace;
            btnInformes.Location = new Point(4, 156);
            btnInformes.Margin = new Padding(3, 2, 3, 2);
            btnInformes.Name = "btnInformes";
            btnInformes.Size = new Size(311, 45);
            btnInformes.TabIndex = 2;
            btnInformes.Text = "INFORMES";
            btnInformes.UseVisualStyleBackColor = false;
            btnInformes.Click += button5_Click;
            // 
            // labelUserNameM
            // 
            labelUserNameM.AutoSize = true;
            labelUserNameM.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserNameM.ForeColor = Color.MediumOrchid;
            labelUserNameM.Location = new Point(99, 59);
            labelUserNameM.Name = "labelUserNameM";
            labelUserNameM.Size = new Size(50, 15);
            labelUserNameM.TabIndex = 3;
            labelUserNameM.Text = "Usuario";
            // 
            // panelForms
            // 
            panelForms.Location = new Point(319, 0);
            panelForms.Margin = new Padding(3, 2, 3, 2);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(783, 499);
            panelForms.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.MediumOrchid;
            label1.Location = new Point(5, 59);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 4;
            label1.Text = "¡Manos a la obra!";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 501);
            Controls.Add(label1);
            Controls.Add(labelUserNameM);
            Controls.Add(panelForms);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Inicio";
            Load += Main_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPedidos;
        private Button btnClientes;
        private Button btnUsuarios;
        private Button btnCerrar;
        private Panel panel2;
        private Panel panelForms;
        private Button btnInformes;
        private Label labelUserNameM;
        private Label label1;
        private Button button1;
    }
}