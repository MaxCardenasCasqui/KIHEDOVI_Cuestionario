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
        int numeroPregunta = 1;
        public FormCrearCuestionario()
        {
            InitializeComponent();
            NumUpDownTiempoMinuto.Value = 1;
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
            //Validar si el cuestionario fue rellando o no
            if (txtCodigoQuiz.Text == "")
            {
                this.Close();
            }
            else
            {
                //Mensaje de advertencia en caso el cuestionario haya sido llenado sin guardarse
                string mensaje = "¿Desea salir sin guardar los cambios?";
                string titulo = "Advertencia";
                MessageBoxButtons botones = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void btnCrearquiz_Click(object sender, EventArgs e)
        {
            String titulo = txtTituloQuiz.Text;
            String codigo = txtCodigoQuiz.Text;
            int tiempoMinuto = (int)NumUpDownTiempoMinuto.Value;
            int tiempoSegundo = (int)NumUpDownTiempoSegundo.Value;
        }

        private void btnSiguientePregunta_Click(object sender, EventArgs e)
        {
            string Pregunta, RespuestaA, RespuestaB, RespuestaC, RespuestaD;
            string RespuestaCorrecta;

            Pregunta = txtPregunta.Text;
            RespuestaA = txtRespuesta1.Text;
            RespuestaB = txtRespuesta2.Text;
            RespuestaC = txtRespuesta3.Text;
            RespuestaD = txtRespuesta4.Text;

            if (rbtnRespuesta1.Checked)
            {
                RespuestaCorrecta = RespuestaA;
            }
            else
            {
                if (rbtnRespuesta2.Checked)
                {
                    RespuestaCorrecta = RespuestaB;
                }
                else
                {
                    if (rbtnRespuesta3.Checked)
                    {
                        RespuestaCorrecta = RespuestaC;
                    }
                    else
                    {
                        RespuestaCorrecta = RespuestaD;
                    }
                }
            }
        }
    }
}
