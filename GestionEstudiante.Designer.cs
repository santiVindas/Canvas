namespace GestionAsignaciones
{
    partial class GestionEstudiante
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
            dataGridView1 = new DataGridView();
            DELETE = new Button();
            MODIFY = new Button();
            ADD = new Button();
            label1 = new Label();
            cancelar_button2 = new Button();
            aceptar_button1 = new Button();
            eliminar_button3 = new Button();
            panel1 = new Panel();
            cedula_textBox = new TextBox();
            primer_Apellido_textBox = new TextBox();
            segundo_Apellido_textBox = new TextBox();
            correo_textBox = new TextBox();
            grupo_textBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            nombre_textBox = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(825, 656);
            dataGridView1.TabIndex = 11;
            // 
            // DELETE
            // 
            DELETE.Location = new Point(1155, 30);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(78, 39);
            DELETE.TabIndex = 10;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = true;
            DELETE.Click += DELETE_Click;
            // 
            // MODIFY
            // 
            MODIFY.Location = new Point(1073, 30);
            MODIFY.Name = "MODIFY";
            MODIFY.Size = new Size(79, 39);
            MODIFY.TabIndex = 9;
            MODIFY.Text = "MODIFY";
            MODIFY.UseVisualStyleBackColor = true;
            MODIFY.Click += MODIFY_Click_1;
            // 
            // ADD
            // 
            ADD.Location = new Point(989, 30);
            ADD.Name = "ADD";
            ADD.Size = new Size(81, 39);
            ADD.TabIndex = 8;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            ADD.Click += ADD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(862, 39);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 6;
            label1.Text = "Estudiante";
            // 
            // cancelar_button2
            // 
            cancelar_button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelar_button2.Location = new Point(280, 495);
            cancelar_button2.Name = "cancelar_button2";
            cancelar_button2.Size = new Size(101, 54);
            cancelar_button2.TabIndex = 4;
            cancelar_button2.Text = "Cancelar";
            cancelar_button2.UseVisualStyleBackColor = true;
            cancelar_button2.Click += cancelar_button2_Click;
            // 
            // aceptar_button1
            // 
            aceptar_button1.Location = new Point(88, 495);
            aceptar_button1.Name = "aceptar_button1";
            aceptar_button1.Size = new Size(110, 54);
            aceptar_button1.TabIndex = 3;
            aceptar_button1.Text = "Aceptar";
            aceptar_button1.UseVisualStyleBackColor = true;
            aceptar_button1.Click += aceptar_button1_Click;
            // 
            // eliminar_button3
            // 
            eliminar_button3.Location = new Point(150, 3);
            eliminar_button3.Name = "eliminar_button3";
            eliminar_button3.Size = new Size(186, 68);
            eliminar_button3.TabIndex = 7;
            eliminar_button3.Text = "Eliminar";
            eliminar_button3.UseVisualStyleBackColor = true;
            eliminar_button3.Click += eliminar_button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cedula_textBox);
            panel1.Controls.Add(primer_Apellido_textBox);
            panel1.Controls.Add(segundo_Apellido_textBox);
            panel1.Controls.Add(correo_textBox);
            panel1.Controls.Add(grupo_textBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cancelar_button2);
            panel1.Controls.Add(aceptar_button1);
            panel1.Controls.Add(nombre_textBox);
            panel1.Location = new Point(843, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 569);
            panel1.TabIndex = 12;
            // 
            // cedula_textBox
            // 
            cedula_textBox.Location = new Point(172, 307);
            cedula_textBox.Name = "cedula_textBox";
            cedula_textBox.Size = new Size(220, 27);
            cedula_textBox.TabIndex = 16;
            // 
            // primer_Apellido_textBox
            // 
            primer_Apellido_textBox.Location = new Point(172, 93);
            primer_Apellido_textBox.Name = "primer_Apellido_textBox";
            primer_Apellido_textBox.Size = new Size(220, 27);
            primer_Apellido_textBox.TabIndex = 15;
            // 
            // segundo_Apellido_textBox
            // 
            segundo_Apellido_textBox.Location = new Point(172, 146);
            segundo_Apellido_textBox.Name = "segundo_Apellido_textBox";
            segundo_Apellido_textBox.Size = new Size(220, 27);
            segundo_Apellido_textBox.TabIndex = 14;
            // 
            // correo_textBox
            // 
            correo_textBox.Location = new Point(172, 202);
            correo_textBox.Name = "correo_textBox";
            correo_textBox.Size = new Size(220, 27);
            correo_textBox.TabIndex = 13;
            // 
            // grupo_textBox
            // 
            grupo_textBox.Location = new Point(172, 252);
            grupo_textBox.Name = "grupo_textBox";
            grupo_textBox.Size = new Size(220, 27);
            grupo_textBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 252);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 11;
            label7.Text = "Grupo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 307);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 10;
            label6.Text = "Cedula";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 202);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 9;
            label5.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 146);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 8;
            label4.Text = "segundo_Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 93);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 7;
            label3.Text = "primer_Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 38);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // nombre_textBox
            // 
            nombre_textBox.Location = new Point(172, 38);
            nombre_textBox.Name = "nombre_textBox";
            nombre_textBox.Size = new Size(220, 27);
            nombre_textBox.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(eliminar_button3);
            panel2.Location = new Point(843, 650);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 92);
            panel2.TabIndex = 13;
            // 
            // GestionEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 746);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(DELETE);
            Controls.Add(MODIFY);
            Controls.Add(ADD);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "GestionEstudiante";
            Text = "GestionEstudiante";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button DELETE;
        private Button MODIFY;
        private Button ADD;
        private Label label1;
        private Button cancelar_button2;
        private Button aceptar_button1;
        private Button eliminar_button3;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox nombre_textBox;
        private TextBox cedula_textBox;
        private TextBox primer_Apellido_textBox;
        private TextBox segundo_Apellido_textBox;
        private TextBox correo_textBox;
        private TextBox grupo_textBox;
        private Label label7;
        private Label label6;
        private Panel panel2;
    }
}