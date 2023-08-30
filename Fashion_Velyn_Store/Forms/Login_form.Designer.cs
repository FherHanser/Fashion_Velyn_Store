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
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TxtBoxUser
            // 
            TxtBoxUser.BackColor = SystemColors.Window;
            TxtBoxUser.BorderStyle = BorderStyle.None;
            TxtBoxUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBoxUser.Location = new Point(147, 50);
            TxtBoxUser.Margin = new Padding(3, 2, 3, 2);
            TxtBoxUser.Name = "TxtBoxUser";
            TxtBoxUser.PlaceholderText = "Usuario en el sistema";
            TxtBoxUser.Size = new Size(151, 15);
            TxtBoxUser.TabIndex = 0;
            TxtBoxUser.KeyDown += TextBox_KeyDown;
            // 
            // TxtBoxPass
            // 
            TxtBoxPass.BorderStyle = BorderStyle.None;
            TxtBoxPass.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBoxPass.Location = new Point(146, 88);
            TxtBoxPass.Margin = new Padding(3, 2, 3, 2);
            TxtBoxPass.Name = "TxtBoxPass";
            TxtBoxPass.PlaceholderText = "Contraseña";
            TxtBoxPass.Size = new Size(151, 15);
            TxtBoxPass.TabIndex = 1;
            TxtBoxPass.TextChanged += TxtBoxPass_TextChanged;
            TxtBoxPass.KeyDown += TextBox_KeyDown;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(203, 134);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(95, 30);
            button1.TabIndex = 2;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelError);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(TxtBoxUser);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(TxtBoxPass);
            panel1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(10, 73);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 227);
            panel1.TabIndex = 3;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelError.ForeColor = Color.IndianRed;
            labelError.Location = new Point(42, 182);
            labelError.Name = "labelError";
            labelError.Size = new Size(62, 15);
            labelError.TabIndex = 8;
            labelError.Text = "Mensaje";
            labelError.Visible = false;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(102, 134);
            button4.Name = "button4";
            button4.Size = new Size(95, 30);
            button4.TabIndex = 7;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 50);
            label1.Name = "label1";
            label1.Size = new Size(54, 16);
            label1.TabIndex = 9;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 87);
            label2.Name = "label2";
            label2.Size = new Size(67, 16);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 380);
            ControlBox = false;
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Login_Form";
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
        private Button button4;
        private Label labelError;
        private Label label2;
        private Label label1;
    }
}