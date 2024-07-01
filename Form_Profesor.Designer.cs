namespace GestionAsignaciones
{
    partial class Form_Profesor
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
            atrasProfesor_text = new Button();
            logInProfesor_button = new Button();
            contrasenaProf_text = new TextBox();
            usuarioProf_text = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(379, 67);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 14;
            label1.Text = "Profesor";
            // 
            // atrasProfesor_text
            // 
            atrasProfesor_text.FlatStyle = FlatStyle.System;
            atrasProfesor_text.Location = new Point(311, 406);
            atrasProfesor_text.Name = "atrasProfesor_text";
            atrasProfesor_text.Size = new Size(91, 28);
            atrasProfesor_text.TabIndex = 13;
            atrasProfesor_text.Text = "Regresar";
            atrasProfesor_text.UseVisualStyleBackColor = true;
            atrasProfesor_text.Click += atrasProfesor_text_Click;
            // 
            // logInProfesor_button
            // 
            logInProfesor_button.BackgroundImageLayout = ImageLayout.None;
            logInProfesor_button.FlatStyle = FlatStyle.System;
            logInProfesor_button.Location = new Point(466, 406);
            logInProfesor_button.Name = "logInProfesor_button";
            logInProfesor_button.Size = new Size(91, 28);
            logInProfesor_button.TabIndex = 12;
            logInProfesor_button.Text = "Ingresar\r\n";
            logInProfesor_button.UseVisualStyleBackColor = true;
            logInProfesor_button.Click += logInProfesor_button_Click;
            // 
            // contrasenaProf_text
            // 
            contrasenaProf_text.Location = new Point(272, 319);
            contrasenaProf_text.Name = "contrasenaProf_text";
            contrasenaProf_text.Size = new Size(328, 27);
            contrasenaProf_text.TabIndex = 11;
            // 
            // usuarioProf_text
            // 
            usuarioProf_text.Location = new Point(272, 184);
            usuarioProf_text.Name = "usuarioProf_text";
            usuarioProf_text.Size = new Size(328, 27);
            usuarioProf_text.TabIndex = 10;
            usuarioProf_text.TextChanged += usuarioProf_text_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(388, 262);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 9;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(400, 127);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 8;
            label2.Text = "Correo";
            // 
            // Form_Profesor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(873, 500);
            Controls.Add(label1);
            Controls.Add(atrasProfesor_text);
            Controls.Add(logInProfesor_button);
            Controls.Add(contrasenaProf_text);
            Controls.Add(usuarioProf_text);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form_Profesor";
            Text = "Form_Profesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button atrasProfesor_text;
        private Button logInProfesor_button;
        private TextBox contrasenaProf_text;
        private TextBox usuarioProf_text;
        private Label label3;
        private Label label2;
    }
}