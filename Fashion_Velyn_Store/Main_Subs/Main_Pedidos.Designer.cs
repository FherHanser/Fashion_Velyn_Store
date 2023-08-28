namespace Fashion_Velyn_Store.Main_Subs
{
    partial class Main_Pedidos
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
            panel1 = new Panel();
            button5 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Plum;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 120);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(766, 225);
            panel1.TabIndex = 2;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(189, 52);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(153, 112);
            button5.TabIndex = 0;
            button5.Text = "REGISTROS";
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(434, 52);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(153, 112);
            button1.TabIndex = 1;
            button1.Text = "NUEVO";
            button1.UseVisualStyleBackColor = true;
            // 
            // Main_Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 464);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Main_Pedidos";
            Opacity = 0.75D;
            Text = "Main_Pedidos";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button button1;
    }
}