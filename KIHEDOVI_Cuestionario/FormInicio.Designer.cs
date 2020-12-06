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
            this.btnAceptarCodigoNombre = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombrePrograma = new System.Windows.Forms.Label();
            this.btnCrearQuiz = new System.Windows.Forms.Button();
            this.btnTengoCodigo = new System.Windows.Forms.Button();
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 454);
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
            this.panelSubMenuTengoCodigo.Location = new System.Drawing.Point(524, 158);
            this.panelSubMenuTengoCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSubMenuTengoCodigo.Name = "panelSubMenuTengoCodigo";
            this.panelSubMenuTengoCodigo.Size = new System.Drawing.Size(281, 217);
            this.panelSubMenuTengoCodigo.TabIndex = 1;
            this.panelSubMenuTengoCodigo.Visible = false;
            // 
            // btnAceptarCodigoNombre
            // 
            this.btnAceptarCodigoNombre.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAceptarCodigoNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarCodigoNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarCodigoNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceptarCodigoNombre.Location = new System.Drawing.Point(177, 167);
            this.btnAceptarCodigoNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptarCodigoNombre.Name = "btnAceptarCodigoNombre";
            this.btnAceptarCodigoNombre.Size = new System.Drawing.Size(100, 43);
            this.btnAceptarCodigoNombre.TabIndex = 4;
            this.btnAceptarCodigoNombre.Text = "ACEPTAR";
            this.btnAceptarCodigoNombre.UseVisualStyleBackColor = false;
            this.btnAceptarCodigoNombre.Click += new System.EventHandler(this.btnAceptarCodigoNombre_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(5, 90);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "NOMBRE";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(0, 116);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 43);
            this.textBox1.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCodigo.Location = new System.Drawing.Point(0, 34);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(280, 43);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigo.Location = new System.Drawing.Point(5, 9);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(77, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // lblNombrePrograma
            // 
            this.lblNombrePrograma.AutoSize = true;
            this.lblNombrePrograma.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblNombrePrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNombrePrograma.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblNombrePrograma.Location = new System.Drawing.Point(17, 16);
            this.lblNombrePrograma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePrograma.Name = "lblNombrePrograma";
            this.lblNombrePrograma.Size = new System.Drawing.Size(176, 31);
            this.lblNombrePrograma.TabIndex = 2;
            this.lblNombrePrograma.Text = "Penguin Quiz";
            // 
            // btnCrearQuiz
            // 
            this.btnCrearQuiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCrearQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCrearQuiz.Location = new System.Drawing.Point(524, 16);
            this.btnCrearQuiz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearQuiz.Name = "btnCrearQuiz";
            this.btnCrearQuiz.Size = new System.Drawing.Size(281, 62);
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
            this.btnTengoCodigo.Location = new System.Drawing.Point(524, 96);
            this.btnTengoCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTengoCodigo.Name = "btnTengoCodigo";
            this.btnTengoCodigo.Size = new System.Drawing.Size(281, 62);
            this.btnTengoCodigo.TabIndex = 4;
            this.btnTengoCodigo.Text = "TENGO UN CÓDIGO";
            this.btnTengoCodigo.UseVisualStyleBackColor = false;
            this.btnTengoCodigo.Click += new System.EventHandler(this.btnTengoCodigo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalir.Location = new System.Drawing.Point(524, 390);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(281, 43);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 454);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTengoCodigo);
            this.Controls.Add(this.btnCrearQuiz);
            this.Controls.Add(this.lblNombrePrograma);
            this.Controls.Add(this.panelSubMenuTengoCodigo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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