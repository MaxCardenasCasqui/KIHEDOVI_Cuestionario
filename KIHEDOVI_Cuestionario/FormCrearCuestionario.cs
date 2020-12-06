using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIHEDOVI_Cuestionario
{
    public partial class FormCrearCuestionario : Form
    {
        public FormCrearCuestionario()
        {
            InitializeComponent();
        }

        private void btnEditarPreguntas_Click(object sender, EventArgs e)
        {
            panelCalificaciones.Hide();
            panelInicio.Hide();
            panelEditarPreguntas.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelCalificaciones.Hide();
            panelEditarPreguntas.Hide();
            panelInicio.Show();
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            panelInicio.Hide();
            panelEditarPreguntas.Hide();
            panelCalificaciones.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
