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
            button4.Location = new Point(1115, 60);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(65, 33);
            button4.TabIndex = 6;
            button4.Text = "Menú";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.BackgroundColor = Color.DarkSlateBlue;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(116, 148);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersWidth = 51;
            dataGridViewClientes.RowTemplate.Height = 29;
            dataGridViewClientes.Size = new Size(1020, 420);
            dataGridViewClientes.TabIndex = 7;
            // 
            // textBoxBuscarNombre
            // 
            textBoxBuscarNombre.Location = new Point(252, 82);
            textBoxBuscarNombre.Name = "textBoxBuscarNombre";
            textBoxBuscarNombre.PlaceholderText = "Ingresa Nombre del Cliente";
            textBoxBuscarNombre.Size = new Size(217, 27);
            textBoxBuscarNombre.TabIndex = 8;
            textBoxBuscarNombre.TextChanged += textBoxBuscarNombre_TextChanged;
            textBoxBuscarNombre.KeyDown += TextBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 87);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 9;
            label1.Text = "Buscar";
            // 
            // buttonBuscar
            // 
            buttonBuscar.ForeColor = SystemColors.ControlText;
            buttonBuscar.Location = new Point(1, 11);
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
            button1.Location = new Point(99, 11);
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
            btnEliminar.Location = new Point(3, 10);
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
            button2.Location = new Point(1, 11);
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
            btnGuardar.Location = new Point(99, 11);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 30);
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
            panel1.Location = new Point(491, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 50);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Plum;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnGuardar);
            panel2.Location = new Point(724, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 50);
            panel2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(btnEliminar);
            panel3.Location = new Point(952, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(100, 50);
            panel3.TabIndex = 17;
            // 
            // List_Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 668);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(textBoxBuscarNombre);
            Controls.Add(dataGridViewClientes);
            Controls.Add(button4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "List_Cliente";
            Opacity = 0.75D;
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