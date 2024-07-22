using System;
using System.Collections;
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
    public partial class VisualizarPeople : Form
    {
        private string connectionString = "Data Source=EWM0803-PC0803;Initial Catalog=Asignaciones;Integrated Security=True;";
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public VisualizarPeople()
        {
            InitializeComponent();
            InitializeDataGridView(); // Asegúrate de que el DataGridView esté configurado correctamente
            LoadData();
        }

        private void InitializeDataGridView()
        {
            // Configuración básica del DataGridView
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT e.Nombre, e.Primer_Apellido, e.Segundo_Apellido 
                        FROM Estudiantes e
                        INNER JOIN cursos c ON e.curso_id = c.curso_id";

                    dataAdapter = new SqlDataAdapter(query, connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Debugging: verificar el número de filas en dataTable
                    MessageBox.Show($"Número de filas: {dataTable.Rows.Count}");

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
    }
}