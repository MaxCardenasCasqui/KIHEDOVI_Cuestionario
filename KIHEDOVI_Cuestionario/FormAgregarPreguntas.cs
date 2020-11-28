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
    public partial class FormAgregarPreguntas : Form
    {
        int NumeroPregunta = 1;
        public FormAgregarPreguntas()
        {
            InitializeComponent();
            txtPregunta.Focus();
        }

        private void btnSiguientePreguntas_Click(object sender, EventArgs e)
        {
            String Pregunta, RespuestaA, RespuestaB, RespuestaC, RespuestaD;

            Pregunta = txtPregunta.Text;
            if(Pregunta == "")
            {
                MessageBox.Show("Ingrese una pregunta.", "Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                RespuestaA = txtRespuestaA.Text;
                RespuestaB = txtRespuestaB.Text;
                RespuestaC = txtRespuestaC.Text;
                RespuestaD = txtRespuestaD.Text;

                NumeroPregunta++;
                lblPregunta.Text = "Pregunta " + NumeroPregunta + ":";
                FormCrearCuestionario fCuestionario = new FormCrearCuestionario();
                fCuestionario.lbCantidadPreguntas.Text = " " + NumeroPregunta.ToString();

                txtPregunta.Text = "";
                txtRespuestaA.Text = "";
                txtRespuestaB.Text = "";
                txtRespuestaC.Text = "";
                txtRespuestaD.Text = "";
                txtPregunta.Focus();

                btnAgregarPreguntas.Text = "Agregar " + "("+ (NumeroPregunta-1).ToString() + ")"+ " Preguntas";
            }
        }

        public void btnAgregarPreguntas_Click(object sender, EventArgs e)
        {
            
        }
    }
}
