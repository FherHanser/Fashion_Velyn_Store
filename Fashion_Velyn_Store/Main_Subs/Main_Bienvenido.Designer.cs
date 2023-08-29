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
            progressBar1 = new ProgressBar();
            labelUserName = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 30;
            timer2.Tick += timer2_Tick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.GhostWhite;
            panel2.Controls.Add(progressBar1);
            panel2.Controls.Add(labelUserName);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.SlateBlue;
            panel2.Location = new Point(153, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 272);
            panel2.TabIndex = 1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(217, 223);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(217, 17);
            progressBar1.TabIndex = 2;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserName.Location = new Point(120, 56);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(86, 25);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(175, 29);
            label1.TabIndex = 0;
            label1.Text = "BIENVENID@";
            label1.Click += label1_Click;
            // 
            // Main_Bienvenido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
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
    }
}