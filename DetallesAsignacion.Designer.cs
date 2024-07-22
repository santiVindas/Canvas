namespace GestionAsignaciones
{
    partial class DetallesAsignacion
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
            panelMenu = new Panel();
            button3 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            label6 = new Label();
            label7 = new Label();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(87, 35, 100);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button1);
            panelMenu.Location = new Point(12, 12);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(101, 560);
            panelMenu.TabIndex = 14;
            // 
            // button3
            // 
            button3.Location = new Point(9, 141);
            button3.Name = "button3";
            button3.Size = new Size(71, 28);
            button3.TabIndex = 2;
            button3.Text = "Cursos";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(9, 21);
            button1.Name = "button1";
            button1.Size = new Size(80, 77);
            button1.TabIndex = 1;
            button1.Text = "Perfil";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 46);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 15;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 116);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 16;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 46);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 17;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(551, 46);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 18;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(747, 46);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 19;
            label5.Text = "label5";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 191);
            textBox1.MaxLength = 999999;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(644, 371);
            textBox1.TabIndex = 21;
            // 
            // button4
            // 
            button4.Location = new Point(781, 365);
            button4.Name = "button4";
            button4.Size = new Size(110, 37);
            button4.TabIndex = 22;
            button4.Text = "Enviar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(897, 365);
            button5.Name = "button5";
            button5.Size = new Size(110, 37);
            button5.TabIndex = 23;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(458, 9);
            label6.Name = "label6";
            label6.Size = new Size(199, 26);
            label6.TabIndex = 24;
            label6.Text = "REALIZAR TAREA";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(907, 46);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 25;
            label7.Text = "label7";
            // 
            // DetallesAsignacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 574);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelMenu);
            Name = "DetallesAsignacion";
            Text = "EntregarTarea";
            Load += DetallesAsignacion_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Button button3;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Button button4;
        private Button button5;
        private Label label6;
        private Label label7;
    }
}