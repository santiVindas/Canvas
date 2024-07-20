namespace GestionAsignaciones
{
    partial class Asignaciones
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
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            textBoxTitulo = new TextBox();
            textBoxTipo = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            textBoxDesc = new TextBox();
            label3 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            label4 = new Label();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(87, 35, 100);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button1);
            panelMenu.Location = new Point(3, 12);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(101, 931);
            panelMenu.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(9, 141);
            button3.Name = "button3";
            button3.Size = new Size(71, 28);
            button3.TabIndex = 2;
            button3.Text = "Cursos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            // button2
            // 
            button2.Location = new Point(21, 139);
            button2.Name = "button2";
            button2.Size = new Size(207, 47);
            button2.TabIndex = 1;
            button2.Text = "Modulos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(21, 214);
            button4.Name = "button4";
            button4.Size = new Size(207, 47);
            button4.TabIndex = 2;
            button4.Text = "Assignments";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(10, 61);
            button5.Name = "button5";
            button5.Size = new Size(572, 45);
            button5.TabIndex = 3;
            button5.Text = "Create assignment";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Location = new Point(220, 239);
            button6.Name = "button6";
            button6.Size = new Size(111, 31);
            button6.TabIndex = 4;
            button6.Text = "Submit";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.Location = new Point(21, 290);
            button8.Name = "button8";
            button8.Size = new Size(207, 47);
            button8.TabIndex = 6;
            button8.Text = "People";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(21, 361);
            button9.Name = "button9";
            button9.Size = new Size(207, 47);
            button9.TabIndex = 7;
            button9.Text = "Ver Grupos";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(21, 438);
            button10.Name = "button10";
            button10.Size = new Size(207, 47);
            button10.TabIndex = 8;
            button10.Text = "Integrantes";
            button10.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 53);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 9;
            label1.Text = "2C024";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(110, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 952);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(374, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(594, 409);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxTitulo);
            panel3.Controls.Add(textBoxTipo);
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textBoxDesc);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button6);
            panel3.Location = new Point(10, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(581, 278);
            panel3.TabIndex = 20;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(102, 10);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(315, 27);
            textBoxTitulo.TabIndex = 0;
            // 
            // textBoxTipo
            // 
            textBoxTipo.FormattingEnabled = true;
            textBoxTipo.Items.AddRange(new object[] { "Individual", "Grupal" });
            textBoxTipo.Location = new Point(436, 179);
            textBoxTipo.Name = "textBoxTipo";
            textBoxTipo.Size = new Size(115, 28);
            textBoxTipo.TabIndex = 22;
            textBoxTipo.KeyPress += textBoxTipo_KeyPress;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(83, 180);
            numericUpDown1.Maximum = new decimal(new int[] { 14, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(45, 27);
            numericUpDown1.TabIndex = 20;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.KeyPress += numericUpDown1_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(152, 182);
            label7.Name = "label7";
            label7.Size = new Size(278, 20);
            label7.TabIndex = 17;
            label7.Text = "Tipo de asignacion (Grupal o Individual):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 182);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 16;
            label6.Text = "Semana";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(117, 118);
            dateTimePicker1.MaxDate = new DateTime(2024, 8, 23, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2024, 7, 17, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 123);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 14;
            label5.Text = "Fecha Entrega";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(102, 61);
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(470, 27);
            textBoxDesc.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 64);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 11;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 10);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 10;
            label2.Text = "Titulo";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(384, 479);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(575, 444);
            listBox1.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(561, 443);
            label4.Name = "label4";
            label4.Size = new Size(240, 26);
            label4.TabIndex = 25;
            label4.Text = "TAREA ESTUDIANTES";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Asignaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 955);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "Asignaciones";
            Text = "Asignaciones";
            Load += Asignaciones_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox textBoxDesc;
        private TextBox textBoxTitulo;
        private Label label3;
        private Label label2;
        private Label label7;
        private Panel panel3;
        private NumericUpDown numericUpDown1;
        private ComboBox textBoxTipo;
        private TextBox txtBoxTipo;
        private ListBox listBox1;
        private Label label4;
    }
}