using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionAsignaciones
{

    public partial class Assigments_Estudiante : Form
    {
        private string connectionString = "Data Source=EWM0803-PC0803;Initial Catalog=Asignaciones;Integrated Security=True;";

        private List<ClaseAsignaciones> listaAsignaciones;
        private Asignaciones formularioAsignaciones;


        public Assigments_Estudiante(List<ClaseAsignaciones> asignaciones, Asignaciones form1)
        {
            InitializeComponent();
            listaAsignaciones = asignaciones;
            formularioAsignaciones = form1;
            ActualizarListBox();
            CargarAsignaciones();

        }

        private void CargarAsignaciones()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Asignaciones", con);
                    SqlDataReader reader = command.ExecuteReader();

                    // Limpiar la lista y el listbox
                    listaAsignaciones.Clear();
                    ListaTarea.Items.Clear();

                    // Llenar la lista y el listbox con las asignaciones
                    while (reader.Read())
                    {
                        ClaseAsignaciones asignacion = new ClaseAsignaciones
                        {
                            Titulo = reader["Titulo"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
                            Semana = Convert.ToInt32(reader["Semana"]),
                            Tipo = reader["Tipo"].ToString()
                        };
                        listaAsignaciones.Add(asignacion);
                        ListaTarea.Items.Add(asignacion.Titulo);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las asignaciones: " + ex.Message);
                }
            }
        }

        public void ActualizarListBox()
        {
            ListaTarea.Items.Clear();
            foreach (var asignacion in listaAsignaciones)
            {
                ListaTarea.Items.Add(asignacion.Titulo);
            }
        }

        private void ListaTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ListaTarea.SelectedIndex;
            if (selectedIndex != -1 && selectedIndex < listaAsignaciones.Count)
            {
                var selectedAssignment = listaAsignaciones[selectedIndex];
                DetallesAsignacion detalleForm = new DetallesAsignacion(formularioAsignaciones, selectedAssignment);
                detalleForm.Show();
            }
            else
            {
                MessageBox.Show("Índice seleccionado no válido.");
            }
        }

        private void Assignments_Estudiante_Load(object sender, EventArgs e)
        {
            CargarAsignaciones(); // Cargar asignaciones al cargar el formulario
            ListaTarea.SelectedIndexChanged += ListaTarea_SelectedIndexChanged;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Asegúrate de tener una instancia válida de Asignaciones
            if (formularioAsignaciones != null)
            {
                // Abrir el formulario ModulosCurso y pasar las asignaciones
                ModulosCurso modulosForm = new ModulosCurso(formularioAsignaciones, listaAsignaciones);
                modulosForm.Show();

                // Opcional: Ocultar el formulario actual si no quieres que siga visible
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se puede abrir ModulosCurso. El formulario de asignaciones no está disponible.");
            }
        }

        private void Assigments_Estudiante_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            VisualizarPeople ver = new VisualizarPeople();
            ver.Show();
            this.Hide();
        }
    }
}
