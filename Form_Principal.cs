using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAsignaciones
{
    public partial class Form_Principal : Form
    {
        private List<ClaseAsignaciones> listaAsignaciones; // Asegúrate de inicializar esta lista en algún lugar de tu código
        private Asignaciones formularioAsignaciones; // Asegúrate de tener una referencia a tu formulario Asignaciones
        public Form_Principal()
        {
            InitializeComponent();
            listaAsignaciones = new List<ClaseAsignaciones>();
            formularioAsignaciones = new Asignaciones(listaAsignaciones);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_usuario formUsuario = new Form_usuario(listaAsignaciones, formularioAsignaciones);
            formUsuario.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Profesor profesor = new Form_Profesor(listaAsignaciones, formularioAsignaciones);
            profesor.Show();
            this.Hide();
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
