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
    public partial class GestionEstudiante : Form
    {
        private string connectionString = "Data Source=LAPTOP-SANTIV\\SQLDEVELOPER;Initial Catalog=Asignaciones;Integrated Security=True;";
        private bool isModifyMode = false;
        private bool isDeleteMode = false;
        private string CorreoEstudiantesSeleccionado = "";
        private List<ClaseAsignaciones> listaAsignaciones;
        private Asignaciones formularioAsignaciones;

        public GestionEstudiante(List<ClaseAsignaciones> asignaciones, Asignaciones formAsignaciones)
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            CargarEstudiantes();
            dataGridView1.CellClick += DataGridView1_CellClick;
            listaAsignaciones = asignaciones;
            formularioAsignaciones = formAsignaciones;
        }
        private void ADD_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            isModifyMode = false;
            isDeleteMode = false;
            LimpiarControles();
            QuitarColumnaCheckbox();
        }


        private void MODIFY_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            isModifyMode = true;
            panel2.Visible = false;
            isDeleteMode = false;

            // Mostrar la columna de CheckBox si no existe
            if (!dataGridView1.Columns.Contains("checkBoxColumn"))
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Seleccionar";
                checkBoxColumn.Name = "checkBoxColumn";
                dataGridView1.Columns.Insert(0, checkBoxColumn);  // Inserta al principio
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            // Ocultar el control de correo si hay una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                CorreoEstudiantesSeleccionado = row.Cells["Correo"].Value.ToString();
                correo_textBox.Visible = false;
                label2.Visible = false;
            }
            else
            {
                MessageBox.Show("Seleccione un Estudiante de la lista para modificar.");
            }
        }
        private void DELETE_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            isDeleteMode = true;

            if (!dataGridView1.Columns.Contains("checkBoxColumn"))
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Seleccionar";
                checkBoxColumn.Name = "checkBoxColumn";
                dataGridView1.Columns.Insert(0, checkBoxColumn);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            MessageBox.Show("Seleccione los Estudiantess que desea eliminar marcando los checkboxes en la primera columna.", "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            eliminar_button3.Visible = true;
            panel2.Visible = true;
        }

        private void aceptar_button1_Click(object sender, EventArgs e)
        {
            string Nombre = nombre_textBox.Text;
            string primer_Apellido = primer_Apellido_textBox.Text;
            string segundo_Apellido = segundo_Apellido_textBox.Text;
            string Correo = correo_textBox.Text;
            int NumGrupo = int.Parse(grupo_textBox.Text);
            int Cedula = int.Parse(cedula_textBox.Text);


            if (string.IsNullOrEmpty(Correo) || string.IsNullOrEmpty(Nombre) || NumGrupo == 0 || Cedula == 0 || string.IsNullOrEmpty(primer_Apellido) || string.IsNullOrEmpty(segundo_Apellido))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CorreoEstudianteEnUso(Correo))
            {
                MessageBox.Show("Correo ya en uso");
                return;
            }

            GuardarEstudiantesEnBaseDeDatos(Correo, Nombre, NumGrupo, Cedula, primer_Apellido, segundo_Apellido);

            LimpiarControles();
            panel1.Visible = false;
            isModifyMode = false;

            /*Abrir Canva_Main y cargar los datos*/
            Canva_Main canvaMain = new Canva_Main(listaAsignaciones, formularioAsignaciones);
            canvaMain.Show();
            canvaMain.CargarDatos();
        }

        private void cancelar_button2_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            panel1.Visible = false;
            isModifyMode = false;
        }

        private void eliminar_button3_Click(object sender, EventArgs e)
        {
            if (isDeleteMode)
            {
                EliminarEstudiantesSeleccionados();
                isDeleteMode = false;
                QuitarColumnaCheckbox();
                panel2.Visible = false;
                eliminar_button3.Visible = false;
            }
        }

        private void QuitarColumnaCheckbox()
        {
            if (dataGridView1.Columns.Contains("checkBoxColumn"))
            {
                dataGridView1.Columns.Remove("checkBoxColumn");
            }
        }

        private bool CorreoEstudianteEnUso(string Correo)
        {
            string query = isModifyMode ?
                "SELECT COUNT(*) FROM Estudiantes WHERE Correo = @Correo AND Correo <> @CorreoEstudiantesSeleccionado" :
                "SELECT COUNT(*) FROM Estudiantes WHERE Correo = @Correo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Correo", Correo);

                if (isModifyMode)
                {
                    command.Parameters.AddWithValue("@CorreoEstudiantesSeleccionado", CorreoEstudiantesSeleccionado);
                }

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar el correo del Estudiantes: " + ex.Message);
                    return false;
                }
            }
        }
        private int ContarEstudiantesEnBaseDeDatos()
        {
            string query = "SELECT COUNT(*) FROM Estudiantes";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al contar los Estudiantes en la base de datos: " + ex.Message);
                    return 0;
                }
            }
        }

        private void LimpiarControles()
        {
            nombre_textBox.Text = "";
            primer_Apellido_textBox.Text = "";
            segundo_Apellido_textBox.Text = "";
            correo_textBox.Text = "";
            grupo_textBox.Text = "";
            cedula_textBox.Text = "";

        }
        private void GuardarEstudiantesEnBaseDeDatos(string Correo, string Nombre, int NumGrupo, int Cedula, string primer_Apellido, string segundo_Apellido)
        {
            if (string.IsNullOrEmpty(Correo) || string.IsNullOrEmpty(Nombre) || NumGrupo == 0 || Cedula == 0 || string.IsNullOrEmpty(primer_Apellido) || string.IsNullOrEmpty(segundo_Apellido))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CorreoEstudianteEnUso(Correo))
            {
                MessageBox.Show("El correo electrónico ya está en uso.");
                return;
            }

            string query = isModifyMode ?
                "UPDATE Estudiantes SET Correo = @Correo, Nombre = @Nombre, NumGrupo = @NumGrupo, primer_Apellido = @primerApellido, segundo_Apellido = @segundoApellido, Cedula = @cedula WHERE Correo = @Correo" :
                "INSERT INTO Estudiantes (Correo, Nombre, NumGrupo, primer_Apellido, segundo_Apellido, Cedula) VALUES (@Correo, @Nombre, @NumGrupo, @primerApellido, @segundoApellido, @cedula)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Correo", Correo);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@NumGrupo", NumGrupo);
                command.Parameters.AddWithValue("@primerApellido", primer_Apellido);
                command.Parameters.AddWithValue("@segundoApellido", segundo_Apellido);
                command.Parameters.AddWithValue("@cedula", Cedula);

                try
                {
                    connection.Open();
                    int recordsAffected = command.ExecuteNonQuery();

                    string mensaje = isModifyMode ? "El estudiante se ha modificado correctamente." : "El estudiante se ha creado correctamente.";
                    MessageBox.Show(mensaje, "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarEstudiantes();  // Actualiza la lista de estudiantes después de guardar cambios
                    LimpiarControles();   // Limpia los controles después de guardar

                    // No olvides cerrar el formulario actual y mostrar el formulario principal o de gestión principal si es necesario
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al {(isModifyMode ? "modificar" : "guardar")} el estudiante en la base de datos: " + ex.Message);
                }
            }
        }



        private void CargarEstudiantes()
        {
            string query = "SELECT Correo AS Correo,Cedula AS Cedula, Nombre AS Nombre, NumGrupo AS NumGrupo, primer_Apellido AS primerApellido, segundo_Apellido AS segundoApellido FROM Estudiantes";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar Estudiantes: ");
                }
            }
        }


        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isModifyMode && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                CorreoEstudiantesSeleccionado = row.Cells["Correo"].Value.ToString();

                string query = "SELECT Correo, Nombre, NumGrupo, primer_Apellido, segundo_Apellido, Cedula FROM Estudiantes WHERE Correo = @Correo";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Correo", CorreoEstudiantesSeleccionado);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            nombre_textBox.Text = reader["Nombre"].ToString();
                            primer_Apellido_textBox.Text = reader["primer_Apellido"].ToString();
                            segundo_Apellido_textBox.Text = reader["segundo_Apellido"].ToString();
                            correo_textBox.Text = reader["Correo"].ToString();
                            grupo_textBox.Text = reader["NumGrupo"].ToString();
                            cedula_textBox.Text = reader["Cedula"].ToString();

                            panel1.Visible = true;
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar datos del estudiante: " + ex.Message);
                    }
                }
            }
        }
        private void EliminarEstudiantesSeleccionados()
        {
            List<string> EstudiantesAEliminar = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["checkBoxColumn"] is DataGridViewCheckBoxCell chkCell && Convert.ToBoolean(chkCell.Value))
                {
                    string CorreoEstudiante = row.Cells["Correo"].Value.ToString();
                    EstudiantesAEliminar.Add(CorreoEstudiante);
                }
            }

            foreach (string CorreoEstudiante in EstudiantesAEliminar)
            {
                EliminarEstudianteEnBaseDeDatos(CorreoEstudiante);
            }

            CargarEstudiantes();
        }

        private void EliminarEstudianteEnBaseDeDatos(string CorreoEstudiante)
        {
            string query = "DELETE FROM Estudiantes WHERE Correo = @Correo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Correo", CorreoEstudiante);

                try
                {
                    connection.Open();
                    int recordsAffected = command.ExecuteNonQuery();
                    MessageBox.Show($"Estudiante con correo{CorreoEstudiante} eliminado ");
                }
                catch (Exception)
                {
                    MessageBox.Show($"Error al eliminar Estudiante con correo{CorreoEstudiante} ");
                }
            }
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dataGridView1[e.ColumnIndex, e.RowIndex];
                bool isChecked = (bool)checkBoxCell.Value;

                string CorreoEstudiante = dataGridView1.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                string Nombre = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                DialogResult result = MessageBox.Show($"¿Estás seguro que deseas eliminar el estudiante '{Nombre}'?", "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    EliminarEstudiante(CorreoEstudiante);
                    CargarEstudiantes();
                }
                else
                {
                    checkBoxCell.Value = !isChecked;
                }
            }
        }

        private void EliminarEstudiante(string CorreoEstudiante)
        {
            string query = "DELETE FROM Estudiantes WHERE Correo = @Correo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Correo", CorreoEstudiante);

                try
                {
                    connection.Open();
                    int recordsAffected = command.ExecuteNonQuery();
                    MessageBox.Show($"Estudiante eliminado");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar estudiante ");
                }
            }
        }

    }
}
