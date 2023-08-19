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
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TxtBoxUser
            // 
            TxtBoxUser.Location = new Point(168, 53);
            TxtBoxUser.Name = "TxtBoxUser";
            TxtBoxUser.PlaceholderText = "Usuario en el sistema";
            TxtBoxUser.Size = new Size(151, 27);
            TxtBoxUser.TabIndex = 0;
            TxtBoxUser.TextChanged += TxtBoxUser_TextChanged;
            TxtBoxUser.KeyDown += txtUser_KeyDown;
            // 
            // TxtBoxPass
            // 
            TxtBoxPass.Location = new Point(168, 109);
            TxtBoxPass.Name = "TxtBoxPass";
            TxtBoxPass.PlaceholderText = "Contraseña";
            TxtBoxPass.Size = new Size(151, 27);
            TxtBoxPass.TabIndex = 1;
            TxtBoxPass.UseSystemPasswordChar = true;
            TxtBoxPass.TextChanged += TxtBoxPass_TextChanged;
            TxtBoxPass.KeyDown += txtPass_KeyDown;
            // 
            // button1
            // 
            button1.Location = new Point(223, 176);
            button1.Name = "button1";
            button1.Size = new Size(96, 37);
            button1.TabIndex = 2;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TxtBoxUser);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(TxtBoxPass);
            panel1.Location = new Point(11, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 284);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 109);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 61);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 433);
            Controls.Add(panel1);
            Name = "Login_Form";
            Opacity = 0.75D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            TransparencyKey = Color.FromArgb(255, 128, 255);
            Load += Login_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TxtBoxUser;
        private TextBox TxtBoxPass;
        private Button button1;
        private Panel panel1;
        private Label label2;
        private Label label1;
    }
}