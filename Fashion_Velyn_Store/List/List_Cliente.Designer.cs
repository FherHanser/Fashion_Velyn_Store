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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(976, 45);
            button4.Name = "button4";
            button4.Size = new Size(57, 25);
            button4.TabIndex = 6;
            button4.Text = "Menú";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.BackgroundColor = Color.Thistle;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(102, 111);
            dataGridViewClientes.Margin = new Padding(3, 2, 3, 2);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersWidth = 51;
            dataGridViewClientes.RowTemplate.Height = 29;
            dataGridViewClientes.Size = new Size(892, 315);
            dataGridViewClientes.TabIndex = 7;
            // 
            // textBoxBuscarNombre
            // 
            textBoxBuscarNombre.Location = new Point(220, 62);
            textBoxBuscarNombre.Margin = new Padding(3, 2, 3, 2);
            textBoxBuscarNombre.Name = "textBoxBuscarNombre";
            textBoxBuscarNombre.PlaceholderText = "Ingresa Nombre del Cliente";
            textBoxBuscarNombre.Size = new Size(190, 23);
            textBoxBuscarNombre.TabIndex = 8;
            textBoxBuscarNombre.KeyDown += TextBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 65);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 9;
            label1.Text = "Buscar";
            // 
            // buttonBuscar
            // 
            buttonBuscar.ForeColor = SystemColors.ControlText;
            buttonBuscar.Location = new Point(1, 8);
            buttonBuscar.Margin = new Padding(3, 2, 3, 2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(83, 22);
            buttonBuscar.TabIndex = 10;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click_1;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(87, 8);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(83, 22);
            button1.TabIndex = 11;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = SystemColors.ControlText;
            btnEliminar.Location = new Point(3, 8);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(83, 22);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(1, 8);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(83, 22);
            button2.TabIndex = 13;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = SystemColors.ControlText;
            btnGuardar.Location = new Point(87, 8);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(83, 22);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(buttonBuscar);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(430, 53);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 38);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Plum;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnGuardar);
            panel2.Location = new Point(634, 53);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 38);
            panel2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(btnEliminar);
            panel3.Location = new Point(833, 53);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(88, 38);
            panel3.TabIndex = 17;
            // 
            // List_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 501);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(textBoxBuscarNombre);
            Controls.Add(dataGridViewClientes);
            Controls.Add(button4);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "List_Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registros";
            Load += List_Cliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}