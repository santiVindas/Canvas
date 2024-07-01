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
    public partial class ModulosCurso : Form
    {
        private Asignaciones form1; // Referencia al formulario Form1
        private List<ClaseAsignaciones> listaAsignaciones; // Lista de asignaciones recibida de Form1

        public ModulosCurso(Asignaciones form1, List<ClaseAsignaciones> listaAsignaciones)
        {
            InitializeComponent();
            this.form1 = form1;
            this.listaAsignaciones = listaAsignaciones;
            this.form1 = form1;
        }

        // Método para mostrar las asignaciones de la semana correspondiente
        private void MostrarAsignacionesSemana(int numeroSemana)
        {
            // Limpiar cualquier contenido anterior en el panel
            panel2.Controls.Clear();

            // Filtrar las asignaciones por la semana especificada
            var asignacionesSemana = listaAsignaciones.Where(a => a.Semana == numeroSemana).ToList();

            // Mostrar las asignaciones en el panel
            foreach (var asignacion in asignacionesSemana)
            {
                // Crear un control para mostrar la asignación
                Panel panelAsignacion = new Panel();
                panelAsignacion.BorderStyle = BorderStyle.FixedSingle;
                panelAsignacion.Size = new System.Drawing.Size(500, 300);
                panelAsignacion.Margin = new Padding(9);

                // Crear etiquetas para mostrar los detalles de la asignación
                Label lblTitulo = new Label();
                lblTitulo.Text = $"Título: {asignacion.Titulo}";
                lblTitulo.AutoSize = true;
                lblTitulo.Location = new System.Drawing.Point(10, 10);

                Label lblDescripcion = new Label();
                lblDescripcion.Text = $"Descripción: {asignacion.Descripcion}";
                lblDescripcion.AutoSize = true;
                lblDescripcion.Location = new System.Drawing.Point(10, 30);

                Label lblFecha = new Label();
                lblFecha.Text = $"Fecha: {asignacion.Fecha.ToShortDateString()}";
                lblFecha.AutoSize = true;
                lblFecha.Location = new System.Drawing.Point(10, 50);

                Label lblTipo = new Label();
                lblTipo.Text = $"Tipo: {asignacion.Tipo}";
                lblTipo.AutoSize = true;
                lblTipo.Location = new System.Drawing.Point(10, 70);

                // Agregar las etiquetas al panel de asignación
                panelAsignacion.Controls.Add(lblTitulo);
                panelAsignacion.Controls.Add(lblDescripcion);
                panelAsignacion.Controls.Add(lblFecha);
                panelAsignacion.Controls.Add(lblTipo);

                // Agregar el panel de asignación al panel principal
                panel2.Controls.Add(panelAsignacion);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarAsignacionesSemana(1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MostrarAsignacionesSemana(2);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            MostrarAsignacionesSemana(3);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            MostrarAsignacionesSemana(4);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            MostrarAsignacionesSemana(5);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            MostrarAsignacionesSemana(6);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MostrarAsignacionesSemana(7);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MostrarAsignacionesSemana(8);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            MostrarAsignacionesSemana(9);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario de módulos
            this.Hide();

            // Mostrar el formulario de asignaciones
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Canva_Main cm = new Canva_Main();
            cm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
