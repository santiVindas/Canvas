namespace GestionAsignaciones
{
    partial class Assigments_Estudiante
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
            button3 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button4 = new Button();
            button2 = new Button();
            panelMenu = new Panel();
            ListaTarea = new ListBox();
            panel1.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(11, 176);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(89, 35);
            button3.TabIndex = 2;
            button3.Text = "Cursos";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(11, 26);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(100, 96);
            button1.TabIndex = 1;
            button1.Text = "Perfil";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(149, 15);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 739);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 9;
            label1.Text = "2C024";
            // 
            // button10
            // 
            button10.Location = new Point(26, 548);
            button10.Margin = new Padding(4, 4, 4, 4);
            button10.Name = "button10";
            button10.Size = new Size(259, 59);
            button10.TabIndex = 8;
            button10.Text = "Integrantes";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(26, 451);
            button9.Margin = new Padding(4, 4, 4, 4);
            button9.Name = "button9";
            button9.Size = new Size(259, 59);
            button9.TabIndex = 7;
            button9.Text = "Ver Grupos";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(26, 362);
            button8.Margin = new Padding(4, 4, 4, 4);
            button8.Name = "button8";
            button8.Size = new Size(259, 59);
            button8.TabIndex = 6;
            button8.Text = "Crear Grupos";
            button8.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(26, 268);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(259, 59);
            button4.TabIndex = 2;
            button4.Text = "Assignments";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(26, 174);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(259, 59);
            button2.TabIndex = 1;
            button2.Text = "Modulos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(87, 35, 100);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button1);
            panelMenu.Location = new Point(15, 15);
            panelMenu.Margin = new Padding(4, 4, 4, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(126, 739);
            panelMenu.TabIndex = 13;
            // 
            // ListaTarea
            // 
            ListaTarea.FormattingEnabled = true;
            ListaTarea.ItemHeight = 25;
            ListaTarea.Location = new Point(501, 19);
            ListaTarea.Margin = new Padding(4, 4, 4, 4);
            ListaTarea.Name = "ListaTarea";
            ListaTarea.Size = new Size(864, 554);
            ListaTarea.TabIndex = 15;
            ListaTarea.SelectedIndexChanged += ListaTarea_SelectedIndexChanged;
            // 
            // Assigments_Estudiante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 769);
            Controls.Add(ListaTarea);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Assigments_Estudiante";
            Text = "Assigments_Estudiante";
            Load += Assigments_Estudiante_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button4;
        private Button button2;
        private Panel panelMenu;
        private ListBox ListaTarea;
    }
}