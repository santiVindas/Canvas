using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.AccessControl;

namespace GestionAsignaciones
{
    public partial class Asignaciones : Form
    {

        // Lista para almacenar las asignaciones
        private List<ClaseAsignaciones> listaAsignaciones;
        private List<ClaseAsignaciones> asignacionesPendientes = new List<ClaseAsignaciones>();
        private string connectionString = "Server=LAPTOP-SANTIV\\SQLDEVELOPER;Database=Asignaciones;Trusted_Connection=True;";
        private Asistencia formAsistencia;


        public Asignaciones(List<ClaseAsignaciones> asignaciones)
        {
            InitializeComponent();
            listaAsignaciones = asignaciones;
            ActualizarListBox(); // Actualizar al inicio


        }
        private void button6_Click(object sender, EventArgs e)
        {
            // Validar que los campos Título y Descripción no estén vacíos
            if (string.IsNullOrWhiteSpace(textBoxTitulo.Text) || string.IsNullOrWhiteSpace(textBoxDesc.Text))
            {
                MessageBox.Show("Llenar Título y Descripción");
                return; // Salir del método sin guardar la asignación
            }

            // Validar si se ha seleccionado un tipo de asignación
            if (textBoxTipo.SelectedItem == null)
            {
                MessageBox.Show("Seleccionar tipo de asignacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin guardar
            }


            // Cadena de conexión directa
            string connectionString = "Server=LAPTOP-SANTIV\\SQLDEVELOPER;Database=Asignaciones;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Asignaciones (Titulo, Descripcion, Fecha, Semana, Tipo, Nota) VALUES (@Titulo, @Descripcion, @Fecha, @Semana, @Tipo, @Nota)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Titulo", textBoxTitulo.Text);
                    command.Parameters.AddWithValue("@Descripcion", textBoxDesc.Text);
                    command.Parameters.AddWithValue("@Fecha", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@Semana", (int)numericUpDown1.Value);
                    command.Parameters.AddWithValue("@Tipo", textBoxTipo.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Nota", numericUpDown2.Value);


                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Asignación guardada exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar la asignación: " + ex.Message);
                    }
                }
            }

            // Guardar la asignación en la lista
            ClaseAsignaciones nuevaAsignacion = new ClaseAsignaciones
            {
                Titulo = textBoxTitulo.Text,
                Descripcion = textBoxDesc.Text,
                Fecha = dateTimePicker1.Value,
                Semana = (int)numericUpDown1.Value,
                Tipo = textBoxTipo.SelectedItem?.ToString(),
                Nota = numericUpDown2.Value
            };

            listaAsignaciones.Add(nuevaAsignacion);

            //// Actualizar el listBox en Assignments_Estudiante
            //if (Application.OpenForms["Assignments_Estudiante"] is Assigments_Estudiante formAssignments_Estudiante)
            //{
            //    formAssignments_Estudiante.ActualizarListBox(); // Llamar al método sin argumentos
            //    formAssignments_Estudiante.Show();  // Mostrar el formulario si está oculto
            //}
            //else
            //{
            //    // Si el formulario no está abierto, crear una nueva instancia y mostrarlo
            //    Assigments_Estudiante formAssignmentsEstudiante = new Assigments_Estudiante(listaAsignaciones, this);
            //    formAssignmentsEstudiante.Show();
            //}

            // Limpiar los campos después de guardar
            LimpiarCampos();
            ActualizarListBox();
        }

        private void CargarAsignacionesDesdeBD()
        {
            // Encuentra la asignación en la lista de pendientes por título
            var asignacion = asignacionesPendientes.FirstOrDefault(a => a.Titulo == tituloAsignacion);
            if (asignacion != null)
            {
                // Actualiza la descripción con la respuesta del estudiante
                asignacion.Descripcion += $"\nRespuesta del estudiante: {respuesta}";

                // Añadir la asignación a la lista de asignaciones visibles
                listaAsignaciones.Add(asignacion);
                asignacionesPendientes.Remove(asignacion);

                // Actualizar el ListBox
                ActualizarListBox();
            }
        }

        private void ActualizarListBox()
        {
            listBox1.Items.Clear();
            foreach (var asignacion in listaAsignaciones)
            {
                listBox1.Items.Add(asignacion.Titulo);
            }
        }

        private void LimpiarCampos()
        {
            textBoxTitulo.Text = "";
            textBoxDesc.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            numericUpDown1.Value = 1;
            textBoxTipo.SelectedIndex = -1;
        }

        private void Asignaciones_Load(object sender, EventArgs e)
        {
            // Ocultar panel3 al inicio
            panel3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Mostrar panel3 cuando se haga clic en el botón "Agregar Asignación"
            panel3.Visible = true;
        }

        // Manejador del evento KeyPress para numericUpDown1
        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Ocultar Form1 en lugar de cerrarlo
            this.Hide();

            // Mostrar ModulosForm y pasar una referencia a Form1 y la lista de asignaciones
            ModulosCurso modulosForm = new ModulosCurso(this, listaAsignaciones);
            modulosForm.ShowDialog();

            // Mostrar nuevamente Form1 cuando se cierre ModulosForm
            this.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Canva_Main cm = new Canva_Main(listaAsignaciones, this);
            cm.Show();
            this.Hide();
        }

        private void textBoxTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void buttonAbrirCanvaEstudiante_Click(object sender, EventArgs e)
        {
            string nombreEstudiante = "NombreDelEstudiante";
            Canva_Estudiante canvaEstudiante = new Canva_Estudiante(listaAsignaciones, this, nombreEstudiante);
            canvaEstudiante.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GestionEstudiante canvaMain = new GestionEstudiante(listaAsignaciones, this, formAsistencia);
            canvaMain.Show();
            this.Hide();
>>>>>>>>> Temporary merge branch 2
        }
    }
}
