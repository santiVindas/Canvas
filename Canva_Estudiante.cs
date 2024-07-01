using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAsignaciones
{
    public partial class Canva_Estudiante : Form
    {
        public Canva_Estudiante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Canva_Estudiante_Load(object sender, EventArgs e)
        {
            Form_Principal fm = new Form_Principal();
            fm.Show();
            this.Hide();
        }
    }
}
