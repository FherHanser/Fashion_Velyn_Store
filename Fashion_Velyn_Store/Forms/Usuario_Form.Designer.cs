﻿namespace Fashion_Velyn_Store
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
            button4 = new Button();
            textBoxPass2 = new TextBox();
            label4 = new Label();
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
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(textBoxPass2);
            groupBox1.Controls.Add(label4);
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
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(260, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(590, 385);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Nuevo Usuario";
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
            // textBoxPass2
            // 
            textBoxPass2.Location = new Point(197, 252);
            textBoxPass2.Name = "textBoxPass2";
            textBoxPass2.PlaceholderText = "Confirme Contraseña";
            textBoxPass2.Size = new Size(173, 22);
            textBoxPass2.TabIndex = 11;
            textBoxPass2.UseSystemPasswordChar = true;
            textBoxPass2.TextChanged += textBoxPass2_TextChanged;
            textBoxPass2.KeyDown += TextBox_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 255);
            label4.Name = "label4";
            label4.Size = new Size(132, 16);
            label4.TabIndex = 25;
            label4.Text = "Confirme Contraseña";
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(197, 209);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PlaceholderText = "Escriba Contraseña";
            textBoxPass.Size = new Size(173, 22);
            textBoxPass.TabIndex = 10;
            textBoxPass.UseSystemPasswordChar = true;
            textBoxPass.TextChanged += textBoxPass_TextChanged;
            textBoxPass.KeyDown += TextBox_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 215);
            label3.Name = "label3";
            label3.Size = new Size(76, 16);
            label3.TabIndex = 23;
            label3.Text = "Contraseña";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(153, 316);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(95, 30);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(275, 316);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(95, 30);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(197, 163);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Defina UserName";
            textBoxUsuario.Size = new Size(173, 22);
            textBoxUsuario.TabIndex = 9;
            textBoxUsuario.KeyDown += TextBox_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 169);
            label7.Name = "label7";
            label7.Size = new Size(127, 16);
            label7.TabIndex = 13;
            label7.Text = "Nombre De Usuario";
            // 
            // textBoxApellidos
            // 
            textBoxApellidos.Location = new Point(130, 106);
            textBoxApellidos.Name = "textBoxApellidos";
            textBoxApellidos.PlaceholderText = "Ingrese Apellidos";
            textBoxApellidos.Size = new Size(240, 22);
            textBoxApellidos.TabIndex = 8;
            textBoxApellidos.KeyDown += TextBox_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 110);
            label2.Name = "label2";
            label2.Size = new Size(64, 16);
            label2.TabIndex = 7;
            label2.Text = "Apellidos";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(130, 61);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Ingrese Nombre";
            textBoxName.Size = new Size(240, 22);
            textBoxName.TabIndex = 6;
            textBoxName.KeyDown += TextBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 65);
            label1.Name = "label1";
            label1.Size = new Size(63, 16);
            label1.TabIndex = 5;
            label1.Text = "Nombres";
            // 
            // Usuario_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 501);
            ControlBox = false;
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Usuario_Form";
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
        private TextBox textBoxPass2;
        private Label label4;
        private Button button4;
    }
}