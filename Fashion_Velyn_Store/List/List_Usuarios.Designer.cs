namespace Fashion_Velyn_Store.List
{
    partial class List_Usuarios
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
            dataGridViewUsuarios = new DataGridView();
            button1 = new Button();
            buttonBuscar = new Button();
            label1 = new Label();
            textBoxBuscarUsuario = new TextBox();
            btnEliminarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(1155, 58);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(65, 33);
            button4.TabIndex = 5;
            button4.Text = "Menú";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(311, 201);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.RowTemplate.Height = 29;
            dataGridViewUsuarios.Size = new Size(631, 347);
            dataGridViewUsuarios.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(647, 86);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(420, 85);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 29);
            buttonBuscar.TabIndex = 14;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 89);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 13;
            label1.Text = "Buscar";
            // 
            // textBoxBuscarUsuario
            // 
            textBoxBuscarUsuario.Location = new Point(185, 86);
            textBoxBuscarUsuario.Name = "textBoxBuscarUsuario";
            textBoxBuscarUsuario.PlaceholderText = "Ingresa Nombre del Usuario";
            textBoxBuscarUsuario.Size = new Size(217, 27);
            textBoxBuscarUsuario.TabIndex = 12;
            textBoxBuscarUsuario.TextChanged += textBoxBuscarUsuario_TextChanged;
            textBoxBuscarUsuario.KeyDown += TextBox_KeyDown;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.ForeColor = SystemColors.ControlText;
            btnEliminarUsuario.Location = new Point(534, 85);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(95, 30);
            btnEliminarUsuario.TabIndex = 16;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // List_Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 668);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(button1);
            Controls.Add(buttonBuscar);
            Controls.Add(label1);
            Controls.Add(textBoxBuscarUsuario);
            Controls.Add(dataGridViewUsuarios);
            Controls.Add(button4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "List_Usuarios";
            Opacity = 0.75D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registros";
            Load += List_Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private DataGridView dataGridViewUsuarios;
        private Button button1;
        private Button buttonBuscar;
        private Label label1;
        private TextBox textBoxBuscarUsuario;
        private Button btnEliminarUsuario;
    }
}