namespace Cursos
{
    partial class CreacionCursos
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
            label1 = new Label();
            ADD = new Button();
            MODIFY = new Button();
            DELETE = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(721, 24);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "CURSOS";
            label1.Click += label1_Click;
            // 
            // ADD
            // 
            ADD.Location = new Point(910, 24);
            ADD.Name = "ADD";
            ADD.Size = new Size(81, 39);
            ADD.TabIndex = 1;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            ADD.Click += button1_Click;
            // 
            // MODIFY
            // 
            MODIFY.Location = new Point(994, 24);
            MODIFY.Name = "MODIFY";
            MODIFY.Size = new Size(79, 39);
            MODIFY.TabIndex = 2;
            MODIFY.Text = "MODIFY";
            MODIFY.UseVisualStyleBackColor = true;
            MODIFY.Click += button2_Click;
            // 
            // DELETE
            // 
            DELETE.Location = new Point(1076, 24);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(78, 39);
            DELETE.TabIndex = 3;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = true;
            DELETE.Click += DELETE_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(675, 656);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += DataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(741, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 569);
            panel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 383);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 9;
            label5.Text = "Limite de estudiantes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 323);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 8;
            label4.Text = "Grupo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 255);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 7;
            label3.Text = "Nombre del curso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 184);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 6;
            label2.Text = "Codigo del curso:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(193, 377);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(107, 27);
            numericUpDown1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(280, 495);
            button2.Name = "button2";
            button2.Size = new Size(101, 54);
            button2.TabIndex = 4;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCancelar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(88, 495);
            button1.Name = "button1";
            button1.Size = new Size(110, 54);
            button1.TabIndex = 3;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGuardar_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(193, 317);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(193, 249);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 27);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Location = new Point(741, 644);
            panel2.Name = "panel2";
            panel2.Size = new Size(458, 92);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(124, 3);
            button3.Name = "button3";
            button3.Size = new Size(186, 68);
            button3.TabIndex = 0;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CreacionCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 780);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(DELETE);
            Controls.Add(MODIFY);
            Controls.Add(ADD);
            Controls.Add(label1);
            Name = "CreacionCursos";
            Text = "Form1";
            Load += CreacionCursos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button MODIFY;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
    }
}