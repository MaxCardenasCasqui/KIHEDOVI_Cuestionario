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

        /// <summary>Handles the Click event of the btnEditarPreguntas control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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

        private void btnCrearquiz_Click(object sender, EventArgs e)
        {
            String titulo = txtTituloQuiz.Text;
            
        }
    }
}
