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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTengoCodigo_Click(object sender, EventArgs e)
        {
            panelSubMenuTengoCodigo.Show();
        }

        /// <summary>Handles the Click event of the btnCrearQuiz control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnCrearQuiz_Click(object sender, EventArgs e)
        {
            FormCrearCuestionario crearCuestionario = new FormCrearCuestionario();
            crearCuestionario.Show();
        }

        private void btnAceptarCodigoNombre_Click(object sender, EventArgs e)
        {
            FormResponderCuestionario responderCuestionario = new FormResponderCuestionario();
            responderCuestionario.Show();

            
        }
    }
}
