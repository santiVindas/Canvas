namespace GestionAsignaciones
{
    partial class Asistencia
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
            checkedListBox1 = new CheckedListBox();
            button_Confirmar = new Button();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 46);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(551, 554);
            checkedListBox1.TabIndex = 0;
            // 
            // button_Confirmar
            // 
            button_Confirmar.Location = new Point(614, 559);
            button_Confirmar.Name = "button_Confirmar";
            button_Confirmar.Size = new Size(130, 45);
            button_Confirmar.TabIndex = 1;
            button_Confirmar.Text = "Confirmar";
            button_Confirmar.UseVisualStyleBackColor = true;
            button_Confirmar.Click += button_Confirmar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Presente", "Ausente", "Vacio" });
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 28);
            comboBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(comboBox4);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(569, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 507);
            panel1.TabIndex = 3;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Presente", "Ausente", "Vacio" });
            comboBox4.Location = new Point(3, 92);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(213, 28);
            comboBox4.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Presente", "Ausente", "Vacio" });
            comboBox3.Location = new Point(3, 148);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(213, 28);
            comboBox3.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Presente", "Ausente", "Vacio" });
            comboBox2.Location = new Point(3, 46);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(213, 28);
            comboBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(191, 9);
            label4.Name = "label4";
            label4.Size = new Size(163, 26);
            label4.TabIndex = 26;
            label4.Text = "ESTUDIANTES";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Asistencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 616);
            Controls.Add(label4);
            Controls.Add(checkedListBox1);
            Controls.Add(panel1);
            Controls.Add(button_Confirmar);
            Name = "Asistencia";
            Text = "Asistencia";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button button_Confirmar;
        private ComboBox comboBox1;
        private Panel panel1;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label4;
    }
}