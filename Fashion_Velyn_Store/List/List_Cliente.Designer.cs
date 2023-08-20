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
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
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
            textBoxBuscarNombre.Location = new Point(252, 83);
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
            label1.Location = new Point(185, 86);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 9;
            label1.Text = "Buscar";
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(487, 82);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 29);
            buttonBuscar.TabIndex = 10;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(596, 82);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // List_Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 668);
            Controls.Add(button1);
            Controls.Add(buttonBuscar);
            Controls.Add(label1);
            Controls.Add(textBoxBuscarNombre);
            Controls.Add(dataGridViewClientes);
            Controls.Add(button4);
            Name = "List_Cliente";
            Opacity = 0.75D;
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
    }
}