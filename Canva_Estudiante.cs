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
        private string connectionString = "Data Source=LAPTOP-SANTIV\\SQLDEVELOPER;Initial Catalog=Asignaciones;Integrated Security=True;";

        private List<ClaseAsignaciones> listaAsignaciones;
        private Asignaciones formularioAsignaciones;
        public Canva_Estudiante(List<ClaseAsignaciones> asignaciones, Asignaciones formAsignaciones)
        {
            InitializeComponent();
            listaAsignaciones = asignaciones;
            formularioAsignaciones = formAsignaciones;
        }


        private void Canva_Estudiante_Load(object sender, EventArgs e)
        {
            Form_Principal fm = new Form_Principal();
            fm.Show();
            this.Hide();

        }


        private void button3_Click(object sender, EventArgs e)
        {

            Assigments_Estudiante assigmentsEstudiante = new Assigments_Estudiante(listaAsignaciones, formularioAsignaciones);
            assigmentsEstudiante.Show();
            this.Hide();
        }
    }
}
