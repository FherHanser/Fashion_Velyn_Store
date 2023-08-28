namespace Fashion_Velyn_Store
{
    partial class Login_Form
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
            TxtBoxUser = new TextBox();
            TxtBoxPass = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            labelError = new Label();
            button4 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // TxtBoxUser
            // 
            TxtBoxUser.BackColor = SystemColors.InactiveBorder;
            TxtBoxUser.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBoxUser.Location = new Point(147, 44);
            TxtBoxUser.Margin = new Padding(3, 2, 3, 2);
            TxtBoxUser.Name = "TxtBoxUser";
            TxtBoxUser.PlaceholderText = "Usuario en el sistema";
            TxtBoxUser.Size = new Size(133, 21);
            TxtBoxUser.TabIndex = 0;
            TxtBoxUser.TextChanged += TxtBoxUser_TextChanged;
            TxtBoxUser.KeyDown += TextBox_KeyDown;
            // 
            // TxtBoxPass
            // 
            TxtBoxPass.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBoxPass.Location = new Point(147, 82);
            TxtBoxPass.Margin = new Padding(3, 2, 3, 2);
            TxtBoxPass.Name = "TxtBoxPass";
            TxtBoxPass.PlaceholderText = "Contraseña";
            TxtBoxPass.Size = new Size(133, 21);
            TxtBoxPass.TabIndex = 1;
            TxtBoxPass.TextChanged += TxtBoxPass_TextChanged;
            TxtBoxPass.KeyDown += TextBox_KeyDown;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(195, 132);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(84, 28);
            button1.TabIndex = 2;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelError);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TxtBoxUser);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(TxtBoxPass);
            panel1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(10, 47);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 213);
            panel1.TabIndex = 3;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelError.ForeColor = Color.IndianRed;
            labelError.Location = new Point(74, 179);
            labelError.Name = "labelError";
            labelError.Size = new Size(62, 15);
            labelError.TabIndex = 8;
            labelError.Text = "Mensaje";
            labelError.Visible = false;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(106, 132);
            button4.Name = "button4";
            button4.Size = new Size(84, 28);
            button4.TabIndex = 7;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(64, 82);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 46);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(10, 296);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(331, 20);
            panel2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(238, 4);
            label4.Name = "label4";
            label4.Size = new Size(87, 13);
            label4.TabIndex = 11;
            label4.Text = "SMART MEDIA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(153, 4);
            label3.Name = "label3";
            label3.Size = new Size(87, 13);
            label3.TabIndex = 10;
            label3.Text = "Desarrollado por";
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 325);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Login_Form";
            Opacity = 0.75D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            TransparencyKey = Color.FromArgb(255, 128, 255);
            Load += Login_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TxtBoxUser;
        private TextBox TxtBoxPass;
        private Button button1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button4;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label labelError;
    }
}