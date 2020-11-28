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
            upHoraTGeneral.Value = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbTituloCuestionario.Focus();
        }

        private void btnAgregarPreguntas_Click(object sender, EventArgs e)
        {
            Form abrirFormulario = new FormAgregarPreguntas();
            abrirFormulario.ShowDialog();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearCuestionario_Click(object sender, EventArgs e)
        {
            String TituloTest, codigo = "SDS45QWE";
            decimal TiempoHora,TiempoMinuto;

            TituloTest = tbTituloCuestionario.Text;
            if (TituloTest == "" && lbCantidadPreguntas.Text == "0")
            {
                MessageBox.Show("Debe ingresar un título.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TiempoHora = upHoraTGeneral.Value;
                TiempoMinuto = upMinutoTGeneral.Value;
                MessageBox.Show("Cuestionario creado.\nEl código es: "+codigo,"", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbTituloCuestionario_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
