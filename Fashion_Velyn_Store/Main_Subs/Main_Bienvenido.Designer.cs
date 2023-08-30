namespace Fashion_Velyn_Store.Main_Subs
{
    partial class Main_Bienvenido
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            labelUserName = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 35;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 35;
            timer2.Tick += timer2_Tick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(progressBar1);
            panel2.Controls.Add(labelUserName);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.SlateBlue;
            panel2.Location = new Point(153, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 252);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(150, 203);
            label2.Name = "label2";
            label2.Size = new Size(70, 16);
            label2.TabIndex = 3;
            label2.Text = "Iniciando...";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(217, 201);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(217, 17);
            progressBar1.TabIndex = 2;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserName.Location = new Point(180, 69);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(96, 29);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(17, 27);
            label1.Name = "label1";
            label1.Size = new Size(175, 29);
            label1.TabIndex = 0;
            label1.Text = "BIENVENID@";
            // 
            // Main_Bienvenido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(612, 325);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Bienvenido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main_Bienvenido";
            Load += Main_Bienvenido_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Panel panel2;
        private Label label1;
        private Label labelUserName;
        private ProgressBar progressBar1;
        private Label label2;
    }
}