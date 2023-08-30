namespace Fashion_Velyn_Store
{
    partial class Cliente_Form
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
            labelMensaje = new Label();
            labelError = new Label();
            btnLimpiar = new Button();
            button4 = new Button();
            btnAgregar = new Button();
            textBoxTipoCliente = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxReferencia = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxTel2 = new TextBox();
            textBoxTel1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBoxApellidos = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Thistle;
            groupBox1.Controls.Add(labelMensaje);
            groupBox1.Controls.Add(labelError);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(textBoxTipoCliente);
            groupBox1.Controls.Add(textBoxCorreo);
            groupBox1.Controls.Add(textBoxReferencia);
            groupBox1.Controls.Add(textBoxDireccion);
            groupBox1.Controls.Add(textBoxTel2);
            groupBox1.Controls.Add(textBoxTel1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxApellidos);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(260, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(590, 460);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Nuevo Cliente";
            // 
            // labelMensaje
            // 
            labelMensaje.AutoSize = true;
            labelMensaje.ForeColor = Color.IndianRed;
            labelMensaje.Location = new Point(130, 177);
            labelMensaje.Name = "labelMensaje";
            labelMensaje.Size = new Size(59, 16);
            labelMensaje.TabIndex = 24;
            labelMensaje.Text = "Mensaje";
            labelMensaje.Visible = false;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.ForeColor = Color.IndianRed;
            labelError.Location = new Point(130, 374);
            labelError.Name = "labelError";
            labelError.Size = new Size(59, 16);
            labelError.TabIndex = 23;
            labelError.Text = "Mensaje";
            labelError.Visible = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(235, 403);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(139, 36);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(515, 15);
            button4.Name = "button4";
            button4.Size = new Size(65, 30);
            button4.TabIndex = 4;
            button4.Text = "Menú";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(405, 403);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 36);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // textBoxTipoCliente
            // 
            textBoxTipoCliente.Location = new Point(175, 330);
            textBoxTipoCliente.Name = "textBoxTipoCliente";
            textBoxTipoCliente.PlaceholderText = "Defina: Mayorista ó Minorista";
            textBoxTipoCliente.Size = new Size(239, 22);
            textBoxTipoCliente.TabIndex = 20;
            textBoxTipoCliente.KeyDown += TextBox_KeyDown;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(175, 284);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.PlaceholderText = "Ingrese Correo Electrónico";
            textBoxCorreo.Size = new Size(239, 22);
            textBoxCorreo.TabIndex = 19;
            textBoxCorreo.KeyDown += TextBox_KeyDown;
            // 
            // textBoxReferencia
            // 
            textBoxReferencia.Location = new Point(130, 238);
            textBoxReferencia.Name = "textBoxReferencia";
            textBoxReferencia.PlaceholderText = "Ingrese la Referencia Domiciliar";
            textBoxReferencia.Size = new Size(284, 22);
            textBoxReferencia.TabIndex = 18;
            textBoxReferencia.KeyDown += TextBox_KeyDown;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(130, 197);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.PlaceholderText = "Ingrese la Dirección de Residencia";
            textBoxDireccion.Size = new Size(284, 22);
            textBoxDireccion.TabIndex = 17;
            textBoxDireccion.KeyDown += TextBox_KeyDown;
            // 
            // textBoxTel2
            // 
            textBoxTel2.Location = new Point(312, 151);
            textBoxTel2.Name = "textBoxTel2";
            textBoxTel2.PlaceholderText = "# Domiciliar";
            textBoxTel2.Size = new Size(102, 22);
            textBoxTel2.TabIndex = 16;
            textBoxTel2.TextChanged += textBoxTel2_TextChanged;
            textBoxTel2.KeyDown += TextBox_KeyDown;
            // 
            // textBoxTel1
            // 
            textBoxTel1.Location = new Point(130, 151);
            textBoxTel1.Name = "textBoxTel1";
            textBoxTel1.PlaceholderText = "# Celular";
            textBoxTel1.Size = new Size(98, 22);
            textBoxTel1.TabIndex = 15;
            textBoxTel1.TextChanged += textBoxTel1_TextChanged;
            textBoxTel1.KeyDown += TextBox_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 333);
            label8.Name = "label8";
            label8.Size = new Size(98, 16);
            label8.TabIndex = 14;
            label8.Text = "Tipo de Cliente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 287);
            label7.Name = "label7";
            label7.Size = new Size(118, 16);
            label7.TabIndex = 13;
            label7.Text = "Correo Electrónico";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 241);
            label6.Name = "label6";
            label6.Size = new Size(73, 16);
            label6.TabIndex = 12;
            label6.Text = "Referencia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 201);
            label5.Name = "label5";
            label5.Size = new Size(64, 16);
            label5.TabIndex = 11;
            label5.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 155);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 10;
            label4.Text = "Teléfono 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 155);
            label3.Name = "label3";
            label3.Size = new Size(71, 16);
            label3.TabIndex = 9;
            label3.Text = "Teléfono 1";
            // 
            // textBoxApellidos
            // 
            textBoxApellidos.Location = new Point(130, 106);
            textBoxApellidos.Name = "textBoxApellidos";
            textBoxApellidos.PlaceholderText = "Ingrese Apellidos";
            textBoxApellidos.Size = new Size(284, 22);
            textBoxApellidos.TabIndex = 8;
            textBoxApellidos.KeyDown += TextBox_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 109);
            label2.Name = "label2";
            label2.Size = new Size(64, 16);
            label2.TabIndex = 7;
            label2.Text = "Apellidos";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(130, 61);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Ingrese Nombres";
            textBoxName.Size = new Size(284, 22);
            textBoxName.TabIndex = 6;
            textBoxName.TextChanged += textBoxName_TextChanged;
            textBoxName.KeyDown += TextBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 64);
            label1.Name = "label1";
            label1.Size = new Size(63, 16);
            label1.TabIndex = 5;
            label1.Text = "Nombres";
            // 
            // Cliente_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 501);
            ControlBox = false;
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Cliente_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Cliente";
            Load += Cliente_Form_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button button4;
        private TextBox textBoxName;
        private Label label2;
        private TextBox textBoxApellidos;
        private TextBox textBoxTipoCliente;
        private TextBox textBoxCorreo;
        private TextBox textBoxReferencia;
        private TextBox textBoxDireccion;
        private TextBox textBoxTel2;
        private TextBox textBoxTel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Label labelError;
        private Label labelMensaje;
    }
}