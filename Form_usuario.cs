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
    public partial class Form_usuario : Form
    {
        private List<ClaseAsignaciones> listaAsignaciones;
        private Asignaciones formularioAsignaciones;
        public Form_usuario(List<ClaseAsignaciones> asignaciones, Asignaciones formAsignaciones)
        {
            InitializeComponent();
            listaAsignaciones = asignaciones;
            formularioAsignaciones = formAsignaciones;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OI24L37;Initial Catalog=Asignaciones;Integrated Security=True");



        private void logIn_button_Click(object sender, EventArgs e)
        {
            String username, password;

            username = usuario_text.Text;
            password = contrasena_text.Text;

            try
            {
                String querry = "SELECT * FROM logIn_usuario where username= '" + usuario_text.Text + "' AND password= '" + contrasena_text.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    username = usuario_text.Text;
                    password = contrasena_text.Text;

                    //Metodo para agregar la otra pantalla

                    Canva_Estudiante canvaEstudiante = new Canva_Estudiante(listaAsignaciones, formularioAsignaciones);
                    canvaEstudiante.Show();
                    this.Hide();

                }
                else
                {

                    MessageBox.Show("ERROR DE CREDENCIALES", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usuario_text.Clear();
                    contrasena_text.Clear();

                    usuario_text.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }


        private void Form_usuario_Load(object sender, EventArgs e)
        {
            
                Form_Principal principal = new Form_Principal();
                principal.Show();
                this.Hide();
            
        }
    }
}
