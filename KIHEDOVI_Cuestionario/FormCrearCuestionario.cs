using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KIHEDOVI_Cuestionario
{
    public partial class FormCrearCuestionario : Form
    {
        Stopwatch oSW = new Stopwatch();
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
            panelResponderPregunta.Hide();
            panelInicio.Hide();
            panelEditarPreguntas.Show();
        }

        /// <summary>Handles the Click event of the btnInicio control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelResponderPregunta.Hide();
            panelEditarPreguntas.Hide();
            panelInicio.Show();

            
        }

        /// <summary>Handles the Click event of the btnCalificaciones control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            panelInicio.Hide();
            panelEditarPreguntas.Hide();
            panelResponderPregunta.Show();

            ///Nombre del titulo y la pregunta
            lblTitulo.Text = txtTituloQuiz.Text;
            lblResponderPregunta.Text = txtCodigoQuiz.Text;

            ///Nombre en los botones de respuestas
            button1.Text = txtRespuesta1.Text;
            button2.Text = txtRespuesta2.Text;
            button3.Text = txtRespuesta3.Text;
            button4.Text = txtRespuesta4.Text;

        }

        /// <summary>Handles the Click event of the btnSalir control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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

        /// <summary>Handles the Click event of the btnCrearquiz control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        public void btnCrearquiz_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloQuiz.Text;
            string codigo = txtCodigoQuiz.Text;
            int tiempoMinuto = (int)NumUpDownTiempoMinuto.Value;
            int tiempoSegundo = (int)NumUpDownTiempoSegundo.Value;
        }

        /// <summary>Handles the Click event of the btnSiguientePregunta control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnSiguientePregunta_Click(object sender, EventArgs e)
        {
            string Pregunta, RespuestaA, RespuestaB, RespuestaC, RespuestaD;
            string RespuestaCorrecta;

            ///Guardando la pregunta y respuestas en variables
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

        private void panelResponderPregunta_Paint(object sender, PaintEventArgs e)
        {
            oSW.Start();
            timer1.Enabled = true;
        }

        /// <summary>Handles the Tick event of the timer1 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)oSW.ElapsedMilliseconds);
            txtminu.Text = ts.Minutes.ToString();
            txtsegun.Text = ts.Seconds.ToString();

            ///Detener el cronometro
            if (txtminu.Text == "1")
            {
                if(txtsegun.Text == "0")
                {
                    MessageBox.Show("Se acabo su tiempo");
                    oSW.Stop();
                }
            }
        }

        /// <summary>Handles the Click event of the button1 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnRespuesta1.Checked)
            {
                MessageBox.Show("Respuesta correcta");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
            }
        }

        /// <summary>Handles the Click event of the button2 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (rbtnRespuesta2.Checked)
            {
                MessageBox.Show("Respuesta correcta");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
            }
        }

        /// <summary>Handles the Click event of the button3 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (rbtnRespuesta3.Checked)
            {
                MessageBox.Show("Respuesta correcta");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
            }
        }

        /// <summary>Handles the Click event of the button4 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (rbtnRespuesta4.Checked)
            {
                MessageBox.Show("Respuesta correcta");
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
            }
        }

        private void txtTituloQuiz_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
