namespace Fashion_Velyn_Store
{
    partial class Usuario_Form
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
            groupBox1 = new GroupBox();
            textBoxPass = new TextBox();
            label3 = new Label();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            textBoxUsuario = new TextBox();
            label7 = new Label();
            textBoxApellidos = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxPass);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(textBoxUsuario);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBoxApellidos);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(287, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 314);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Nuevo Usuario";
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(172, 191);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(190, 23);
            textBoxPass.TabIndex = 24;
            textBoxPass.TextChanged += textBoxPass_TextChanged;
            textBoxPass.KeyDown += TextBox_KeyDown; 
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 194);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 23;
            label3.Text = "Contraseña";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(241, 256);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(122, 34);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(389, 256);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 34);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(172, 142);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(190, 23);
            textBoxUsuario.TabIndex = 19;
            textBoxUsuario.TextChanged += textBoxUsuario_TextChanged;
            textBoxUsuario.KeyDown += TextBox_KeyDown;

            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 146);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 13;
            label7.Text = "Nombre De Usuario";
            // 
            // textBoxApellidos
            // 
            textBoxApellidos.Location = new Point(114, 99);
            textBoxApellidos.Name = "textBoxApellidos";
            textBoxApellidos.Size = new Size(249, 23);
            textBoxApellidos.TabIndex = 8;
            textBoxApellidos.TextChanged += textBoxApellidos_TextChanged;
            textBoxApellidos.KeyDown += TextBox_KeyDown; 
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 103);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 7;
            label2.Text = "Apellidos";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(114, 57);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(249, 23);
            textBoxName.TabIndex = 6;
            textBoxName.TextChanged += textBoxName_TextChanged;
            textBoxName.KeyDown += TextBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 61);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombres";
            // 
            // Usuario_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 501);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Usuario_Form";
            Opacity = 0.75D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Usuario";
            Load += Usuario_Form_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLimpiar;
        private Button btnAgregar;
        private TextBox textBoxUsuario;
        private Label label7;
        private TextBox textBoxApellidos;
        private Label label2;
        private TextBox textBoxName;
        private Label label1;
        private TextBox textBoxPass;
        private Label label3;
    }
}