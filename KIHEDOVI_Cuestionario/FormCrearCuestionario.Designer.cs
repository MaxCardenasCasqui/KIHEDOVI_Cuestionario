namespace KIHEDOVI_Cuestionario
{
    partial class FormCrearCuestionario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbTituloCuestionario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCantidadPreguntas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarPreguntas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.upMinutoTGeneral = new System.Windows.Forms.NumericUpDown();
            this.upHoraTGeneral = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbPreguntaCorrecta = new System.Windows.Forms.CheckBox();
            this.chbLeaderBoard = new System.Windows.Forms.CheckBox();
            this.chbPreguntasAleatorias = new System.Windows.Forms.CheckBox();
            this.btnCrearCuestionario = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upMinutoTGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upHoraTGeneral)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título: ";
            // 
            // tbTituloCuestionario
            // 
            this.tbTituloCuestionario.Location = new System.Drawing.Point(71, 22);
            this.tbTituloCuestionario.Name = "tbTituloCuestionario";
            this.tbTituloCuestionario.Size = new System.Drawing.Size(492, 20);
            this.tbTituloCuestionario.TabIndex = 1;
            this.tbTituloCuestionario.TextChanged += new System.EventHandler(this.tbTituloCuestionario_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbCantidadPreguntas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAgregarPreguntas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.upMinutoTGeneral);
            this.groupBox1.Controls.Add(this.upHoraTGeneral);
            this.groupBox1.Location = new System.Drawing.Point(27, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preguntas";
            // 
            // lbCantidadPreguntas
            // 
            this.lbCantidadPreguntas.AutoSize = true;
            this.lbCantidadPreguntas.Location = new System.Drawing.Point(125, 81);
            this.lbCantidadPreguntas.Name = "lbCantidadPreguntas";
            this.lbCantidadPreguntas.Size = new System.Drawing.Size(13, 13);
            this.lbCantidadPreguntas.TabIndex = 13;
            this.lbCantidadPreguntas.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Preguntas Agregadas:";
            // 
            // btnAgregarPreguntas
            // 
            this.btnAgregarPreguntas.Location = new System.Drawing.Point(197, 98);
            this.btnAgregarPreguntas.Name = "btnAgregarPreguntas";
            this.btnAgregarPreguntas.Size = new System.Drawing.Size(112, 23);
            this.btnAgregarPreguntas.TabIndex = 11;
            this.btnAgregarPreguntas.Text = "Editar Preguntas";
            this.btnAgregarPreguntas.UseVisualStyleBackColor = true;
            this.btnAgregarPreguntas.Click += new System.EventHandler(this.btnAgregarPreguntas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "h";
            // 
            // upMinutoTGeneral
            // 
            this.upMinutoTGeneral.Location = new System.Drawing.Point(190, 31);
            this.upMinutoTGeneral.Name = "upMinutoTGeneral";
            this.upMinutoTGeneral.Size = new System.Drawing.Size(34, 20);
            this.upMinutoTGeneral.TabIndex = 4;
            // 
            // upHoraTGeneral
            // 
            this.upHoraTGeneral.Location = new System.Drawing.Point(131, 31);
            this.upHoraTGeneral.Name = "upHoraTGeneral";
            this.upHoraTGeneral.Size = new System.Drawing.Size(34, 20);
            this.upHoraTGeneral.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbPreguntaCorrecta);
            this.groupBox2.Controls.Add(this.chbLeaderBoard);
            this.groupBox2.Controls.Add(this.chbPreguntasAleatorias);
            this.groupBox2.Location = new System.Drawing.Point(27, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 80);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras";
            // 
            // chbPreguntaCorrecta
            // 
            this.chbPreguntaCorrecta.AutoSize = true;
            this.chbPreguntaCorrecta.Location = new System.Drawing.Point(356, 30);
            this.chbPreguntaCorrecta.Name = "chbPreguntaCorrecta";
            this.chbPreguntaCorrecta.Size = new System.Drawing.Size(150, 17);
            this.chbPreguntaCorrecta.TabIndex = 2;
            this.chbPreguntaCorrecta.Text = "Mostrar Pregunta Correcta";
            this.chbPreguntaCorrecta.UseVisualStyleBackColor = true;
            // 
            // chbLeaderBoard
            // 
            this.chbLeaderBoard.AutoSize = true;
            this.chbLeaderBoard.Location = new System.Drawing.Point(197, 30);
            this.chbLeaderBoard.Name = "chbLeaderBoard";
            this.chbLeaderBoard.Size = new System.Drawing.Size(120, 17);
            this.chbLeaderBoard.TabIndex = 1;
            this.chbLeaderBoard.Text = "Añadir LeaderBoard";
            this.chbLeaderBoard.UseVisualStyleBackColor = true;
            // 
            // chbPreguntasAleatorias
            // 
            this.chbPreguntasAleatorias.AutoSize = true;
            this.chbPreguntasAleatorias.Location = new System.Drawing.Point(17, 30);
            this.chbPreguntasAleatorias.Name = "chbPreguntasAleatorias";
            this.chbPreguntasAleatorias.Size = new System.Drawing.Size(123, 17);
            this.chbPreguntasAleatorias.TabIndex = 0;
            this.chbPreguntasAleatorias.Text = "Preguntas Aleatorias";
            this.chbPreguntasAleatorias.UseVisualStyleBackColor = true;
            this.chbPreguntasAleatorias.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // btnCrearCuestionario
            // 
            this.btnCrearCuestionario.Location = new System.Drawing.Point(451, 323);
            this.btnCrearCuestionario.Name = "btnCrearCuestionario";
            this.btnCrearCuestionario.Size = new System.Drawing.Size(112, 23);
            this.btnCrearCuestionario.TabIndex = 4;
            this.btnCrearCuestionario.Text = "Crear Cuestionario";
            this.btnCrearCuestionario.UseVisualStyleBackColor = true;
            this.btnCrearCuestionario.Click += new System.EventHandler(this.btnCrearCuestionario_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(296, 323);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Duracion del examen:  ";
            // 
            // FormCrearCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 362);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrearCuestionario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbTituloCuestionario);
            this.Controls.Add(this.label1);
            this.Name = "FormCrearCuestionario";
            this.Text = "Crear Cuestionario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upMinutoTGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upHoraTGeneral)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTituloCuestionario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown upMinutoTGeneral;
        private System.Windows.Forms.NumericUpDown upHoraTGeneral;
        private System.Windows.Forms.Button btnAgregarPreguntas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbPreguntaCorrecta;
        private System.Windows.Forms.CheckBox chbLeaderBoard;
        private System.Windows.Forms.CheckBox chbPreguntasAleatorias;
        private System.Windows.Forms.Button btnCrearCuestionario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbCantidadPreguntas;
    }
}

