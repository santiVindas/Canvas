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
        private string connectionString = "Server=LAPTOP-LAPTOP-SANTIV\\SQLDEVELOPER;Database=Asignaciones;Trusted_Connection=True;";


        public Asignaciones(List<ClaseAsignaciones> asignaciones)
        {
            InitializeComponent();
            listaAsignaciones = asignaciones;
            CargarAsignacionesDesdeBD();


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

                string query = "INSERT INTO Asignaciones (Titulo, Descripcion, Fecha, Semana, Tipo) VALUES (@Titulo, @Descripcion, @Fecha, @Semana, @Tipo)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Titulo", textBoxTitulo.Text);
                    command.Parameters.AddWithValue("@Descripcion", textBoxDesc.Text);
                    command.Parameters.AddWithValue("@Fecha", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@Semana", (int)numericUpDown1.Value);
                    command.Parameters.AddWithValue("@Tipo", textBoxTipo.SelectedItem.ToString());

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
                Tipo = textBoxTipo.SelectedItem?.ToString()
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

        }

        private void CargarAsignacionesDesdeBD()
        {
            listaAsignaciones = new List<ClaseAsignaciones>();
            string connectionString = "Server=LAPTOP-SANTIV\\SQLDEVELOPER;Database=Asignaciones;Trusted_Connection=True;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Titulo, Descripcion, Fecha, Semana, Tipo, Respuesta FROM Asignaciones";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ClaseAsignaciones asignacion = new ClaseAsignaciones
                        {
                            Titulo = reader["Titulo"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
                            Semana = Convert.ToInt32(reader["Semana"]),
                            Tipo = reader["Tipo"].ToString(),
                            Respuesta = reader["Respuesta"]?.ToString()  // Agrega esta línea si tienes una propiedad Respuesta en tu clase
                        };
                        listaAsignaciones.Add(asignacion);
                    }
                }
            }

            ActualizarListBox();
        }

        public void RecibirRespuesta(string tituloAsignacion, string respuesta)
        {
            var asignacion = listaAsignaciones.FirstOrDefault(a => a.Titulo == tituloAsignacion);
            if (asignacion != null)
            {
                asignacion.Respuesta = respuesta; // Usa la propiedad Respuesta si existe
                ActualizarListBox();
            }
        }

        private void ActualizarListBox()
        {
            listBox1.Items.Clear();
            foreach (var asignacion in listaAsignaciones)
            {
                string itemText = asignacion.Titulo;
                if (!string.IsNullOrEmpty(asignacion.Respuesta))
                {
                    itemText += " (Entregado)";
                }
                listBox1.Items.Add(itemText);
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
            Canva_Estudiante canvaEstudiante = new Canva_Estudiante(listaAsignaciones, this);
            canvaEstudiante.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GestionEstudiante canvaMain = new GestionEstudiante(listaAsignaciones, this);
            canvaMain.Show();
            this.Hide();
        }
    }
}
