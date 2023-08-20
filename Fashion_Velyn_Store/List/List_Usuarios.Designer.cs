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
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(1155, 58);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(65, 33);
            button4.TabIndex = 5;
            button4.Text = "Inicio";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // List_Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 668);
            Controls.Add(button4);
            Name = "List_Usuarios";
            Opacity = 0.75D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registros";
            Load += List_Usuarios_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
    }
}