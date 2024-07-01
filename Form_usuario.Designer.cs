namespace GestionAsignaciones
{
    partial class Form_usuario
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
            label3 = new Label();
            label4 = new Label();
            usuario_text = new TextBox();
            contrasena_text = new TextBox();
            logIn_button = new Button();
            atrasUsuario_text = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(376, 130);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 0;
            label3.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(364, 265);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 2;
            label4.Text = "Contraseña";
            // 
            // usuario_text
            // 
            usuario_text.Location = new Point(248, 187);
            usuario_text.Name = "usuario_text";
            usuario_text.Size = new Size(328, 27);
            usuario_text.TabIndex = 3;
            // 
            // contrasena_text
            // 
            contrasena_text.Location = new Point(248, 322);
            contrasena_text.Name = "contrasena_text";
            contrasena_text.Size = new Size(328, 27);
            contrasena_text.TabIndex = 4;
            // 
            // logIn_button
            // 
            logIn_button.BackgroundImageLayout = ImageLayout.None;
            logIn_button.FlatStyle = FlatStyle.System;
            logIn_button.Location = new Point(442, 409);
            logIn_button.Name = "logIn_button";
            logIn_button.Size = new Size(91, 28);
            logIn_button.TabIndex = 5;
            logIn_button.Text = "Ingresar\r\n";
            logIn_button.UseVisualStyleBackColor = true;
            logIn_button.Click += logIn_button_Click;
            // 
            // atrasUsuario_text
            // 
            atrasUsuario_text.FlatStyle = FlatStyle.System;
            atrasUsuario_text.Location = new Point(287, 409);
            atrasUsuario_text.Name = "atrasUsuario_text";
            atrasUsuario_text.Size = new Size(91, 28);
            atrasUsuario_text.TabIndex = 6;
            atrasUsuario_text.Text = "Regresar";
            atrasUsuario_text.UseVisualStyleBackColor = true;
            atrasUsuario_text.Click += atrasUsuario_text_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(355, 70);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 7;
            label1.Text = "Estudiante";
            // 
            // Form_usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            BackgroundImage = Properties.Resources.ulacit_logo;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(851, 494);
            Controls.Add(label1);
            Controls.Add(atrasUsuario_text);
            Controls.Add(logIn_button);
            Controls.Add(contrasena_text);
            Controls.Add(usuario_text);
            Controls.Add(label4);
            Controls.Add(label3);
            DoubleBuffered = true;
            ForeColor = Color.White;
            Name = "Form_usuario";
            Text = "Form_usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label4;
        private TextBox usuario_text;
        private TextBox contrasena_text;
        private Button logIn_button;
        private Button atrasUsuario_text;
        private Label label1;
    }
}