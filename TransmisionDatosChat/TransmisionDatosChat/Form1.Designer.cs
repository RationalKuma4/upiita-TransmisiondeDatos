namespace TransmisionDatosChat
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbBparDos = new System.Windows.Forms.RadioButton();
            this.rbBparUno = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNbitsOcho = new System.Windows.Forms.RadioButton();
            this.rbNbitsSiete = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tbxMensaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMensajes = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cmbPuerto = new System.Windows.Forms.ComboBox();
            this.cmbVelocidad = new System.Windows.Forms.ComboBox();
            this.cmbParidad = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbParidad);
            this.groupBox1.Controls.Add(this.cmbVelocidad);
            this.groupBox1.Controls.Add(this.cmbPuerto);
            this.groupBox1.Controls.Add(this.btnConfigurar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion puerto serial";
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(253, 86);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(75, 23);
            this.btnConfigurar.TabIndex = 8;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbBparDos);
            this.groupBox3.Controls.Add(this.rbBparUno);
            this.groupBox3.Location = new System.Drawing.Point(360, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(95, 59);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bits de parada";
            // 
            // rbBparDos
            // 
            this.rbBparDos.AutoSize = true;
            this.rbBparDos.Location = new System.Drawing.Point(49, 24);
            this.rbBparDos.Name = "rbBparDos";
            this.rbBparDos.Size = new System.Drawing.Size(31, 17);
            this.rbBparDos.TabIndex = 1;
            this.rbBparDos.TabStop = true;
            this.rbBparDos.Text = "2";
            this.rbBparDos.UseVisualStyleBackColor = true;
            // 
            // rbBparUno
            // 
            this.rbBparUno.AutoSize = true;
            this.rbBparUno.Location = new System.Drawing.Point(11, 24);
            this.rbBparUno.Name = "rbBparUno";
            this.rbBparUno.Size = new System.Drawing.Size(31, 17);
            this.rbBparUno.TabIndex = 0;
            this.rbBparUno.TabStop = true;
            this.rbBparUno.Text = "1";
            this.rbBparUno.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNbitsOcho);
            this.groupBox2.Controls.Add(this.rbNbitsSiete);
            this.groupBox2.Location = new System.Drawing.Point(253, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(101, 60);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Numero de bits";
            // 
            // rbNbitsOcho
            // 
            this.rbNbitsOcho.AutoSize = true;
            this.rbNbitsOcho.Location = new System.Drawing.Point(54, 25);
            this.rbNbitsOcho.Name = "rbNbitsOcho";
            this.rbNbitsOcho.Size = new System.Drawing.Size(31, 17);
            this.rbNbitsOcho.TabIndex = 1;
            this.rbNbitsOcho.TabStop = true;
            this.rbNbitsOcho.Text = "8";
            this.rbNbitsOcho.UseVisualStyleBackColor = true;
            // 
            // rbNbitsSiete
            // 
            this.rbNbitsSiete.AutoSize = true;
            this.rbNbitsSiete.Location = new System.Drawing.Point(17, 25);
            this.rbNbitsSiete.Name = "rbNbitsSiete";
            this.rbNbitsSiete.Size = new System.Drawing.Size(31, 17);
            this.rbNbitsSiete.TabIndex = 0;
            this.rbNbitsSiete.TabStop = true;
            this.rbNbitsSiete.Text = "7";
            this.rbNbitsSiete.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paridad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Velocidad (Baudios)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puerto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEnviar);
            this.groupBox4.Controls.Add(this.btnAbrir);
            this.groupBox4.Controls.Add(this.btnCerrar);
            this.groupBox4.Controls.Add(this.tbxMensaje);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbxMensajes);
            this.groupBox4.Location = new System.Drawing.Point(12, 137);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(465, 216);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transmision de datos";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(380, 181);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(7, 181);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 4;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(96, 181);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tbxMensaje
            // 
            this.tbxMensaje.Location = new System.Drawing.Point(96, 153);
            this.tbxMensaje.Name = "tbxMensaje";
            this.tbxMensaje.Size = new System.Drawing.Size(359, 20);
            this.tbxMensaje.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cadena a enviar";
            // 
            // tbxMensajes
            // 
            this.tbxMensajes.Location = new System.Drawing.Point(7, 20);
            this.tbxMensajes.Multiline = true;
            this.tbxMensajes.Name = "tbxMensajes";
            this.tbxMensajes.Size = new System.Drawing.Size(448, 127);
            this.tbxMensajes.TabIndex = 0;
            // 
            // cmbPuerto
            // 
            this.cmbPuerto.FormattingEnabled = true;
            this.cmbPuerto.Location = new System.Drawing.Point(112, 20);
            this.cmbPuerto.Name = "cmbPuerto";
            this.cmbPuerto.Size = new System.Drawing.Size(121, 21);
            this.cmbPuerto.TabIndex = 9;
            // 
            // cmbVelocidad
            // 
            this.cmbVelocidad.FormattingEnabled = true;
            this.cmbVelocidad.Location = new System.Drawing.Point(112, 48);
            this.cmbVelocidad.Name = "cmbVelocidad";
            this.cmbVelocidad.Size = new System.Drawing.Size(121, 21);
            this.cmbVelocidad.TabIndex = 10;
            // 
            // cmbParidad
            // 
            this.cmbParidad.FormattingEnabled = true;
            this.cmbParidad.Location = new System.Drawing.Point(112, 75);
            this.cmbParidad.Name = "cmbParidad";
            this.cmbParidad.Size = new System.Drawing.Size(121, 21);
            this.cmbParidad.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 363);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNbitsOcho;
        private System.Windows.Forms.RadioButton rbNbitsSiete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbBparDos;
        private System.Windows.Forms.RadioButton rbBparUno;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbxMensajes;
        private System.Windows.Forms.TextBox tbxMensaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnCerrar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cmbParidad;
        private System.Windows.Forms.ComboBox cmbVelocidad;
        private System.Windows.Forms.ComboBox cmbPuerto;
    }
}

