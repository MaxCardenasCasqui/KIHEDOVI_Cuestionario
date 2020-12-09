using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KIHEDOVI_Cuestionario
{
    public partial class FormInicio : Form
    {
        //DBConnection conexion = new DBConnection();
        FormCrearCuestionario crearCuestionario = new FormCrearCuestionario();
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
            crearCuestionario.Show();
        }

        private void btnAceptarCodigoNombre_Click(object sender, EventArgs e)
        {
            FormResponderCuestionario responderCuestionario = new FormResponderCuestionario();

            if (txtCodigoQuiz.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un código y su nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                /*string query = "SELECT IDQuiz FROM tblQuizGeneralData WHERE IDQuiz = '"+txtCodigoQuiz.Text+"'";
                SqlCommand comando = new SqlCommand(query, conexion.conectarDB);
                SqlDataReader lectorDatos = comando.ExecuteReader();
                
                string codigo = lectorDatos["IDQuiz"].ToString();*/

                string nombre = txtNombre.Text;
                string codigo = crearCuestionario.txtCodigoQuiz.Text;

                if(txtCodigoQuiz.Text == codigo)
                {
                    responderCuestionario.Show();
                }
                else
                {
                    MessageBox.Show("Código inválido.\nVuelva a ingresar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            //conexion.abrir();
        }
    }
}
