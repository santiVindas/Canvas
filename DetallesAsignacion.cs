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
    public partial class DetallesAsignacion : Form
    {

        private Asignaciones formularioAsignaciones;
        private ClaseAsignaciones asignacion;
        private string connectionString = "Data Source=LAPTOP-SANTIV\\SQLDEVELOPER;Initial Catalog=Asignaciones;Integrated Security=True;";



        // Define un evento para manejar el envío del texto
        public event EventHandler<string> EnviarTexto;


        public DetallesAsignacion(Asignaciones formularioAsignaciones, ClaseAsignaciones asignacion)
        {
            InitializeComponent();
            this.formularioAsignaciones = formularioAsignaciones;
            this.asignacion = asignacion;
            CargarDetalles();

        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string texto = textBox1.Text;

            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Está vacío y no hay nada para enviar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Asignaciones SET Respuesta = @Respuesta WHERE Titulo = @Titulo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Respuesta", texto);
                        command.Parameters.AddWithValue("@Titulo", asignacion.Titulo);

                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Enviado.");
                                formularioAsignaciones.RecibirRespuesta(asignacion.Titulo, texto);
                            }
                            else
                            {
                                MessageBox.Show("No se encontró la asignación para actualizar.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al enviar la respuesta: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }

            this.Close();
        }

        private void CargarDetalles()
        {
            // Asumiendo que tienes labels con estos nombres en el formulario
            label1.Text = $"Título: {asignacion.Titulo}";
            label2.Text = $"Descripción: {asignacion.Descripcion}";
            label3.Text = $"Fecha: {asignacion.Fecha.ToShortDateString()}";
            label4.Text = $"Semana: {asignacion.Semana}";
            label5.Text = $"Tipo: {asignacion.Tipo}";
            label7.Text = $"Nota: {asignacion.Nota}";
        }

        private void DetallesAsignacion_Load(object sender, EventArgs e)
        {

        }
    }
}
