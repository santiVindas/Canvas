using Cursos;
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
    public partial class Canva_Main : Form
    {

        private string connectionString = "Data Source=EWM0803-PC0803;Initial Catalog=Asignaciones;Integrated Security=True;";
        private List<ClaseAsignaciones> listaAsignaciones;
        private Asignaciones formularioAsignaciones;

        public Canva_Main(List<ClaseAsignaciones> asignaciones, Asignaciones formAsignaciones)
        {
            InitializeComponent();
            CargarDatos();
            this.Load += new EventHandler(Canva_Main_Load);
            listaAsignaciones = asignaciones;
            formularioAsignaciones = formAsignaciones;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                CreacionCursos principal = new CreacionCursos(formularioAsignaciones, listaAsignaciones);
                principal.Show();
                this.Hide();
            }
        }


        public void CargarDatos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Cursos", con);
                    SqlDataReader reader = command.ExecuteReader();

                    // Asigna la información de los cursos a los botones
                    int i = 0;
                    while (reader.Read() && i < Controls.Count)
                    {
                        Control control = Controls[i];
                        if (control is System.Windows.Forms.Button button)  // Usar el namespace completo aquí
                        {
                            button.Text = reader["nombre_del_curso"].ToString();
                            button.Tag = reader["codigo"].ToString(); // Almacenar el código del curso en el Tag del botón

                        }
                        i++;
                    }

                    // Deshabilitar los botones que no tienen un curso asignado
                    for (int j = i; j < Controls.Count; j++)
                    {
                        Control control = Controls[j];
                        if (control is System.Windows.Forms.Button button)  // Usar el namespace completo aquí también
                        {
                            button.Text = "Disponible";
                            button.Tag = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los cursos: " + ex.Message);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            if (button != null && button.Tag != null)
            {
                Asignaciones asig = new Asignaciones(listaAsignaciones);
                asig.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No hay curso asignado a este botón.");
            }
        }

        private void Canva_Main_Load(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Control control in Controls)
            {
                if (control is System.Windows.Forms.Button button)
                {
                    button.Click += button2_Click_1;
                }
            }
        }

        private void Canva_Main_Load_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}

