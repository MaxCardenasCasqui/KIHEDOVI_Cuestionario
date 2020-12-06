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

        private void btnCrearQuiz_Click(object sender, EventArgs e)
        {
            FormCrearCuestionario crearCuestionario = new FormCrearCuestionario();
            crearCuestionario.Show();
        }
    }
}
