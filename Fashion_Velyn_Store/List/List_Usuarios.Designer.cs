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
            button4.Location = new Point(1011, 44);
            button4.Name = "button4";
            button4.Size = new Size(57, 25);
            button4.TabIndex = 5;
            button4.Text = "Menú";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(272, 151);
            dataGridViewUsuarios.Margin = new Padding(3, 2, 3, 2);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.RowTemplate.Height = 29;
            dataGridViewUsuarios.Size = new Size(552, 260);
            dataGridViewUsuarios.TabIndex = 6;
            dataGridViewUsuarios.CellContentClick += dataGridViewUsuarios_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(567, 64);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(83, 22);
            button1.TabIndex = 15;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(368, 64);
            buttonBuscar.Margin = new Padding(3, 2, 3, 2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(83, 22);
            buttonBuscar.TabIndex = 14;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 67);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 13;
            label1.Text = "Buscar";
            // 
            // textBoxBuscarUsuario
            // 
            textBoxBuscarUsuario.Location = new Point(162, 64);
            textBoxBuscarUsuario.Margin = new Padding(3, 2, 3, 2);
            textBoxBuscarUsuario.Name = "textBoxBuscarUsuario";
            textBoxBuscarUsuario.PlaceholderText = "Ingresa Nombre del Usuario";
            textBoxBuscarUsuario.Size = new Size(190, 23);
            textBoxBuscarUsuario.TabIndex = 12;
            textBoxBuscarUsuario.TextChanged += textBoxBuscarUsuario_TextChanged;
            textBoxBuscarUsuario.KeyDown += TextBox_KeyDown;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.ForeColor = SystemColors.ControlText;
            btnEliminarUsuario.Location = new Point(467, 64);
            btnEliminarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(83, 22);
            btnEliminarUsuario.TabIndex = 16;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // List_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 501);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(button1);
            Controls.Add(buttonBuscar);
            Controls.Add(label1);
            Controls.Add(textBoxBuscarUsuario);
            Controls.Add(dataGridViewUsuarios);
            Controls.Add(button4);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "List_Usuarios";
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