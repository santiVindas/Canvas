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
namespace GestionAsignaciones
{
    public partial class Canva_Estudiante : Form
    {
        private string connectionString = "Data Source=EWM0803-PC0803;Initial Catalog=Asignaciones;Integrated Security=True;";
        private List<ClaseAsignaciones> listaAsignaciones;
        private Asignaciones formularioAsignaciones;
        private List<Button> courseButtons;

        public Canva_Estudiante(List<ClaseAsignaciones> asignaciones, Asignaciones formAsignaciones)
        {
            InitializeComponent();
            listaAsignaciones = asignaciones;
            formularioAsignaciones = formAsignaciones;
            panel1.Visible = false;

          
            courseButtons = new List<Button> { button4, button5, button6, button7, button8, button9, button10, button11 };
        }

        private void Canva_Estudiante_Load(object sender, EventArgs e)
        {
            Form_Principal fm = new Form_Principal();
            fm.Show();
            this.Hide();

          
            LoadCourseNames();
        }

        private void LoadCourseNames()
        {
            List<string> courseNames = GetCourseNamesFromDatabase();

            for (int i = 0; i < courseButtons.Count && i < courseNames.Count; i++)
            {
                courseButtons[i].Text = courseNames[i];
            }
        }

        private List<string> GetCourseNamesFromDatabase()
        {
            List<string> courseNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT nombre_del_curso FROM Cursos";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        courseNames.Add(reader["nombre_del_curso"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los nombres de los cursos: " + ex.Message);
                }
            }

            return courseNames;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Assigments_Estudiante assigmentsEstudiante = new Assigments_Estudiante(listaAsignaciones, formularioAsignaciones);
            assigmentsEstudiante.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Assigments_Estudiante assigmentsEstudiante = new Assigments_Estudiante(listaAsignaciones, formularioAsignaciones);
            assigmentsEstudiante.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Assigments_Estudiante assigmentsEstudiante = new Assigments_Estudiante(listaAsignaciones, formularioAsignaciones);
            assigmentsEstudiante.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Assigments_Estudiante assigmentsEstudiante = new Assigments_Estudiante(listaAsignaciones, formularioAsignaciones);
            assigmentsEstudiante.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }
    }
}
