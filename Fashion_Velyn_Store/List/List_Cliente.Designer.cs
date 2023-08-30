namespace Fashion_Velyn_Store.List
{
    partial class List_Cliente
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
            dataGridViewClientes = new DataGridView();
            textBoxBuscarNombre = new TextBox();
            label1 = new Label();
            buttonBuscar = new Button();
            button1 = new Button();
            btnEliminar = new Button();
            button2 = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(975, 45);
            button4.Name = "button4";
            button4.Size = new Size(65, 30);
            button4.TabIndex = 6;
            button4.Text = "Menú";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.BackgroundColor = Color.Thistle;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(101, 146);
            dataGridViewClientes.Margin = new Padding(3, 2, 3, 2);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersWidth = 51;
            dataGridViewClientes.RowTemplate.Height = 29;
            dataGridViewClientes.Size = new Size(882, 260);
            dataGridViewClientes.TabIndex = 7;
            // 
            // textBoxBuscarNombre
            // 
            textBoxBuscarNombre.Location = new Point(101, 116);
            textBoxBuscarNombre.Margin = new Padding(3, 2, 3, 2);
            textBoxBuscarNombre.Name = "textBoxBuscarNombre";
            textBoxBuscarNombre.PlaceholderText = "Ingresa Nombre del Cliente";
            textBoxBuscarNombre.Size = new Size(217, 22);
            textBoxBuscarNombre.TabIndex = 8;
            textBoxBuscarNombre.KeyDown += TextBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 119);
            label1.Name = "label1";
            label1.Size = new Size(49, 16);
            label1.TabIndex = 9;
            label1.Text = "Buscar";
            // 
            // buttonBuscar
            // 
            buttonBuscar.ForeColor = SystemColors.ControlText;
            buttonBuscar.Location = new Point(339, 112);
            buttonBuscar.Margin = new Padding(3, 2, 3, 2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(95, 30);
            buttonBuscar.TabIndex = 10;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click_1;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(437, 112);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(95, 30);
            button1.TabIndex = 11;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = SystemColors.ControlText;
            btnEliminar.Location = new Point(811, 112);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 30);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(571, 112);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(95, 30);
            button2.TabIndex = 13;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = SystemColors.ControlText;
            btnGuardar.Location = new Point(669, 112);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 30);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // List_Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 501);
            ControlBox = false;
            Controls.Add(btnEliminar);
            Controls.Add(button2);
            Controls.Add(btnGuardar);
            Controls.Add(buttonBuscar);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBoxBuscarNombre);
            Controls.Add(dataGridViewClientes);
            Controls.Add(button4);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "List_Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registros";
            Load += List_Cliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button button4;
        private DataGridView dataGridViewClientes;
        private TextBox textBoxBuscarNombre;
        private Label label1;
        private Button buttonBuscar;
        private Button button1;
        private Button btnEliminar;
        private Button button2;
        private Button btnGuardar;
    }
}