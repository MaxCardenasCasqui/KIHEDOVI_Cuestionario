namespace KIHEDOVI_Cuestionario
{
    partial class FormInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSubMenuTengoCodigo = new System.Windows.Forms.Panel();
            this.lblNombrePrograma = new System.Windows.Forms.Label();
            this.btnCrearQuiz = new System.Windows.Forms.Button();
            this.btnTengoCodigo = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptarCodigoNombre = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSubMenuTengoCodigo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 369);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelSubMenuTengoCodigo
            // 
            this.panelSubMenuTengoCodigo.BackColor = System.Drawing.Color.Transparent;
            this.panelSubMenuTengoCodigo.Controls.Add(this.btnAceptarCodigoNombre);
            this.panelSubMenuTengoCodigo.Controls.Add(this.lblNombre);
            this.panelSubMenuTengoCodigo.Controls.Add(this.textBox1);
            this.panelSubMenuTengoCodigo.Controls.Add(this.txtCodigo);
            this.panelSubMenuTengoCodigo.Controls.Add(this.lblCodigo);
            this.panelSubMenuTengoCodigo.Location = new System.Drawing.Point(393, 128);
            this.panelSubMenuTengoCodigo.Name = "panelSubMenuTengoCodigo";
            this.panelSubMenuTengoCodigo.Size = new System.Drawing.Size(211, 176);
            this.panelSubMenuTengoCodigo.TabIndex = 1;
            this.panelSubMenuTengoCodigo.Visible = false;
            // 
            // lblNombrePrograma
            // 
            this.lblNombrePrograma.AutoSize = true;
            this.lblNombrePrograma.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblNombrePrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNombrePrograma.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblNombrePrograma.Location = new System.Drawing.Point(13, 13);
            this.lblNombrePrograma.Name = "lblNombrePrograma";
            this.lblNombrePrograma.Size = new System.Drawing.Size(143, 26);
            this.lblNombrePrograma.TabIndex = 2;
            this.lblNombrePrograma.Text = "Penguin Quiz";
            // 
            // btnCrearQuiz
            // 
            this.btnCrearQuiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCrearQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCrearQuiz.Location = new System.Drawing.Point(393, 13);
            this.btnCrearQuiz.Name = "btnCrearQuiz";
            this.btnCrearQuiz.Size = new System.Drawing.Size(211, 50);
            this.btnCrearQuiz.TabIndex = 3;
            this.btnCrearQuiz.Text = "CREAR QUIZ";
            this.btnCrearQuiz.UseVisualStyleBackColor = false;
            this.btnCrearQuiz.Click += new System.EventHandler(this.btnCrearQuiz_Click);
            // 
            // btnTengoCodigo
            // 
            this.btnTengoCodigo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTengoCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTengoCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTengoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTengoCodigo.Location = new System.Drawing.Point(393, 78);
            this.btnTengoCodigo.Name = "btnTengoCodigo";
            this.btnTengoCodigo.Size = new System.Drawing.Size(211, 50);
            this.btnTengoCodigo.TabIndex = 4;
            this.btnTengoCodigo.Text = "TENGO UN CÓDIGO";
            this.btnTengoCodigo.UseVisualStyleBackColor = false;
            this.btnTengoCodigo.Click += new System.EventHandler(this.btnTengoCodigo_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigo.Location = new System.Drawing.Point(4, 7);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCodigo.Location = new System.Drawing.Point(0, 28);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(211, 36);
            this.txtCodigo.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(0, 94);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 36);
            this.textBox1.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(4, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 17);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "NOMBRE";
            // 
            // btnAceptarCodigoNombre
            // 
            this.btnAceptarCodigoNombre.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAceptarCodigoNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarCodigoNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarCodigoNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceptarCodigoNombre.Location = new System.Drawing.Point(133, 136);
            this.btnAceptarCodigoNombre.Name = "btnAceptarCodigoNombre";
            this.btnAceptarCodigoNombre.Size = new System.Drawing.Size(75, 35);
            this.btnAceptarCodigoNombre.TabIndex = 4;
            this.btnAceptarCodigoNombre.Text = "ACEPTAR";
            this.btnAceptarCodigoNombre.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalir.Location = new System.Drawing.Point(393, 317);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(211, 35);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(616, 369);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTengoCodigo);
            this.Controls.Add(this.btnCrearQuiz);
            this.Controls.Add(this.lblNombrePrograma);
            this.Controls.Add(this.panelSubMenuTengoCodigo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formInicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSubMenuTengoCodigo.ResumeLayout(false);
            this.panelSubMenuTengoCodigo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSubMenuTengoCodigo;
        private System.Windows.Forms.Label lblNombrePrograma;
        private System.Windows.Forms.Button btnCrearQuiz;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnTengoCodigo;
        private System.Windows.Forms.Button btnAceptarCodigoNombre;
        private System.Windows.Forms.Button btnSalir;
    }
}