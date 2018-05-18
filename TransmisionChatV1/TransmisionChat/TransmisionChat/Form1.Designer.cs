namespace TransmisionChat
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnParada2 = new System.Windows.Forms.RadioButton();
            this.rbtnParada1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnBits2 = new System.Windows.Forms.RadioButton();
            this.rbtnBits1 = new System.Windows.Forms.RadioButton();
            this.cmbParidad = new System.Windows.Forms.ComboBox();
            this.cmbVelocidad = new System.Windows.Forms.ComboBox();
            this.cmbPuerto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.tbxEnviar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxRecibido = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfigurar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbParidad);
            this.groupBox1.Controls.Add(this.cmbVelocidad);
            this.groupBox1.Controls.Add(this.cmbPuerto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurar puerto serial";
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(405, 85);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(75, 23);
            this.btnConfigurar.TabIndex = 8;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnParada2);
            this.groupBox3.Controls.Add(this.rbtnParada1);
            this.groupBox3.Location = new System.Drawing.Point(390, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(90, 50);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bist de parada";
            // 
            // rbtnParada2
            // 
            this.rbtnParada2.AutoSize = true;
            this.rbtnParada2.Location = new System.Drawing.Point(44, 24);
            this.rbtnParada2.Name = "rbtnParada2";
            this.rbtnParada2.Size = new System.Drawing.Size(31, 17);
            this.rbtnParada2.TabIndex = 1;
            this.rbtnParada2.Text = "2";
            this.rbtnParada2.UseVisualStyleBackColor = true;
            // 
            // rbtnParada1
            // 
            this.rbtnParada1.AutoSize = true;
            this.rbtnParada1.Checked = true;
            this.rbtnParada1.Location = new System.Drawing.Point(7, 24);
            this.rbtnParada1.Name = "rbtnParada1";
            this.rbtnParada1.Size = new System.Drawing.Size(31, 17);
            this.rbtnParada1.TabIndex = 0;
            this.rbtnParada1.TabStop = true;
            this.rbtnParada1.Text = "1";
            this.rbtnParada1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnBits2);
            this.groupBox2.Controls.Add(this.rbtnBits1);
            this.groupBox2.Location = new System.Drawing.Point(285, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(94, 50);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Numero de bits";
            // 
            // rbtnBits2
            // 
            this.rbtnBits2.AutoSize = true;
            this.rbtnBits2.Location = new System.Drawing.Point(44, 24);
            this.rbtnBits2.Name = "rbtnBits2";
            this.rbtnBits2.Size = new System.Drawing.Size(31, 17);
            this.rbtnBits2.TabIndex = 1;
            this.rbtnBits2.Text = "8";
            this.rbtnBits2.UseVisualStyleBackColor = true;
            // 
            // rbtnBits1
            // 
            this.rbtnBits1.AutoSize = true;
            this.rbtnBits1.Checked = true;
            this.rbtnBits1.Location = new System.Drawing.Point(7, 24);
            this.rbtnBits1.Name = "rbtnBits1";
            this.rbtnBits1.Size = new System.Drawing.Size(31, 17);
            this.rbtnBits1.TabIndex = 0;
            this.rbtnBits1.TabStop = true;
            this.rbtnBits1.Text = "7";
            this.rbtnBits1.UseVisualStyleBackColor = true;
            // 
            // cmbParidad
            // 
            this.cmbParidad.FormattingEnabled = true;
            this.cmbParidad.Location = new System.Drawing.Point(112, 76);
            this.cmbParidad.Name = "cmbParidad";
            this.cmbParidad.Size = new System.Drawing.Size(121, 21);
            this.cmbParidad.TabIndex = 5;
            // 
            // cmbVelocidad
            // 
            this.cmbVelocidad.FormattingEnabled = true;
            this.cmbVelocidad.Location = new System.Drawing.Point(112, 48);
            this.cmbVelocidad.Name = "cmbVelocidad";
            this.cmbVelocidad.Size = new System.Drawing.Size(121, 21);
            this.cmbVelocidad.TabIndex = 4;
            // 
            // cmbPuerto
            // 
            this.cmbPuerto.FormattingEnabled = true;
            this.cmbPuerto.Location = new System.Drawing.Point(112, 20);
            this.cmbPuerto.Name = "cmbPuerto";
            this.cmbPuerto.Size = new System.Drawing.Size(121, 21);
            this.cmbPuerto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paridad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Velocidad (Baudios)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puerto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnEnviar);
            this.groupBox4.Controls.Add(this.btnCerrar);
            this.groupBox4.Controls.Add(this.btnAbrir);
            this.groupBox4.Controls.Add(this.tbxEnviar);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbxRecibido);
            this.groupBox4.Location = new System.Drawing.Point(13, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(492, 175);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transmision de datos";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(411, 146);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(411, 117);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(92, 146);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(10, 146);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // tbxEnviar
            // 
            this.tbxEnviar.Location = new System.Drawing.Point(92, 119);
            this.tbxEnviar.Name = "tbxEnviar";
            this.tbxEnviar.Size = new System.Drawing.Size(313, 20);
            this.tbxEnviar.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cadena a enviar";
            // 
            // tbxRecibido
            // 
            this.tbxRecibido.Location = new System.Drawing.Point(7, 20);
            this.tbxRecibido.Multiline = true;
            this.tbxRecibido.Name = "tbxRecibido";
            this.tbxRecibido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxRecibido.Size = new System.Drawing.Size(473, 92);
            this.tbxRecibido.TabIndex = 0;
            this.tbxRecibido.TextChanged += new System.EventHandler(this.tbxRecibido_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 321);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnParada2;
        private System.Windows.Forms.RadioButton rbtnParada1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnBits2;
        private System.Windows.Forms.RadioButton rbtnBits1;
        private System.Windows.Forms.ComboBox cmbParidad;
        private System.Windows.Forms.ComboBox cmbVelocidad;
        private System.Windows.Forms.ComboBox cmbPuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbxRecibido;
        private System.Windows.Forms.TextBox tbxEnviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnSalir;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

