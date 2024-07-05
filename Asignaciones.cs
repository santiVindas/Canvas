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
        private List<ClaseAsignaciones> listaAsignaciones = new List<ClaseAsignaciones>();

        public Asignaciones()
        {
            InitializeComponent();

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

            // Mostrar un mensaje de éxito u otro tipo de feedback al usuario
            MessageBox.Show("Asignación guardada correctamente.");

            // Limpiar los campos después de guardar
            LimpiarCampos();
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


        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSemana_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTitulo_TextChanged(object sender, EventArgs e)
        {

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxTitulo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Canva_Main cm = new Canva_Main();
            cm.Show();
            this.Hide();
        }

        private void textBoxTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


    }
}
