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
    public partial class Asistencia : Form
    {
        private string connectionString = "Data Source=LAPTOP-SANTIV\\SQLDEVELOPER;Initial Catalog=Asignaciones;Integrated Security=True;";

        public Asistencia()
        {
            InitializeComponent();
            CargarEstudiantes();
        }

        public void CargarEstudiantes()
        {
            string query = "SELECT Id, Nombre FROM Estudiantes";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    checkedListBox1.Items.Clear();
                    panel1.Controls.Clear(); // Limpiar los ComboBox previos

                    int yPosition = 10; // Posición vertical inicial para el primer ComboBox
                    int comboBoxHeight = 20; // Altura de cada ComboBox
                    int verticalSpacing = 10; // Espacio entre ComboBoxes

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string nombreEstudiante = row["Nombre"].ToString();
                        int estudianteId = (int)row["Id"];

                        checkedListBox1.Items.Add(nombreEstudiante);

                        ComboBox comboBox = new ComboBox
                        {
                            Name = "comboBox_" + estudianteId,
                            Items = { "Presente", "Ausente", "Vacío" },
                            SelectedIndex = 2, // Valor por defecto
                            Tag = estudianteId, // Etiqueta para facilitar la asociación
                            Width = 120, // Ajusta el ancho según sea necesario
                            Height = comboBoxHeight,
                            Left = 10, // Ajusta la posición horizontal según sea necesario
                            Top = yPosition // Posición vertical
                        };

                        panel1.Controls.Add(comboBox);

                        // Actualizar la posición vertical para el siguiente ComboBox
                        yPosition += comboBoxHeight + verticalSpacing;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar estudiantes: " + ex.Message);
                }
            }
        }

        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    foreach (Control control in panel1.Controls)
                    {
                        if (control is ComboBox comboBox)
                        {
                            string estado = comboBox.SelectedItem.ToString();
                            int estudianteId = (int)comboBox.Tag;

                            // Obtener el nombre del estudiante basado en el ID
                            string queryEstudianteNombre = "SELECT Nombre FROM Estudiantes WHERE Id = @Id";
                            SqlCommand commandNombre = new SqlCommand(queryEstudianteNombre, connection, transaction);
                            commandNombre.Parameters.AddWithValue("@Id", estudianteId);
                            string nombreEstudiante = (string)commandNombre.ExecuteScalar();

                            // Insertar el estado de asistencia en la base de datos
                            string queryInsertAsistencia = "INSERT INTO Asistencia (EstudianteId, Nombre, Fecha, Estado) VALUES (@EstudianteId, @Nombre, @Fecha, @Estado)";
                            SqlCommand commandInsert = new SqlCommand(queryInsertAsistencia, connection, transaction);
                            commandInsert.Parameters.AddWithValue("@EstudianteId", estudianteId);
                            commandInsert.Parameters.AddWithValue("@Nombre", nombreEstudiante);
                            commandInsert.Parameters.AddWithValue("@Fecha", DateTime.Now); // O usa la fecha actual
                            commandInsert.Parameters.AddWithValue("@Estado", estado);
                            commandInsert.ExecuteNonQuery();

                            // Verificar si el estudiante ha acumulado 3 ausencias
                            string queryAusencias = "SELECT COUNT(*) FROM Asistencia WHERE EstudianteId = @EstudianteId AND Estado = 'Ausente'";
                            SqlCommand commandAusencias = new SqlCommand(queryAusencias, connection, transaction);
                            commandAusencias.Parameters.AddWithValue("@EstudianteId", estudianteId);
                            int ausencias = (int)commandAusencias.ExecuteScalar();

                            if (ausencias >= 3)
                            {
                                MessageBox.Show($"El estudiante {nombreEstudiante} está reprobado por asistencia.");
                            }
                        }
                    }

                    // Confirmar la transacción
                    transaction.Commit();
                    MessageBox.Show("Asistencia guardada exitosamente.");
                }
                catch (Exception ex)
                {
                    // Revertir la transacción en caso de error
                    transaction.Rollback();
                    MessageBox.Show("Error al guardar la asistencia: " + ex.Message);
                }
            }
        }
    }
}
