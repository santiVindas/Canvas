namespace GestionAsignaciones
{
    partial class Canva_Estudiante
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
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(87, 35, 100);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button1);
            panelMenu.Location = new Point(3, 9);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(101, 487);
            panelMenu.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(9, 130);
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
            label1.Location = new Point(247, 9);
            label1.Name = "label1";
            label1.Size = new Size(436, 20);
            label1.TabIndex = 3;
            label1.Text = "BIENVENDOS ESTUDIANTE A LA PAGINA PRINCIPAL DE CANVAS";
            label1.Click += label1_Click;
            // 
            // Canva_Estudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(871, 503);
            Controls.Add(panelMenu);
            Controls.Add(label1);
            Name = "Canva_Estudiante";
            Text = "Canva_Estudiante";
            Load += Canva_Estudiante_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Button button3;
        private Button button1;
        private Label label1;
    }
}