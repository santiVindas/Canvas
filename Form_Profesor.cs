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
    public partial class Form_Profesor : Form
    {
        private List<ClaseAsignaciones> listaAsignaciones;
        private Asignaciones formularioAsignaciones;
        public Form_Profesor(List<ClaseAsignaciones> asignaciones, Asignaciones formAsignaciones)
        {
            InitializeComponent();
            listaAsignaciones = asignaciones;
            formularioAsignaciones = formAsignaciones;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OI24L37;Initial Catalog=Asignaciones;Integrated Security=True");


        private void logInProfesor_button_Click(object sender, EventArgs e)
        {
            String username_Profesor, password_Profesor;

            username_Profesor = usuarioProf_text.Text;
            password_Profesor = contrasenaProf_text.Text;

            try
            {
                String querry = "SELECT * FROM logIn_profesor where username_Profesor= '" + usuarioProf_text.Text + "' AND password_Profesor= '" + contrasenaProf_text.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username_Profesor = usuarioProf_text.Text;
                    password_Profesor = contrasenaProf_text.Text;

                    //Metodo para agregar la otra pantalla

                    Canva_Main canvaMain = new Canva_Main(listaAsignaciones, formularioAsignaciones);
                    canvaMain.Show();
                    this.Hide();

                }
                else
                {

                    MessageBox.Show("ERROR DE CREDENCIALES", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usuarioProf_text.Clear();
                    contrasenaProf_text.Clear();

                    usuarioProf_text.Focus();

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



        private void Form_Profesor_Load(object sender, EventArgs e)
        {
            
                Form_Principal principal = new Form_Principal();
                principal.Show();
                this.Hide();
           
        }
    }
}
