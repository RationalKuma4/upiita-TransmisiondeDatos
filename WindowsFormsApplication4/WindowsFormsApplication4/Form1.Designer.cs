namespace WindowsFormsApplication4
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
            this.cmbpuerto = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnparada2 = new System.Windows.Forms.RadioButton();
            this.rbtnparada1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnbits2 = new System.Windows.Forms.RadioButton();
            this.rbtnbits1 = new System.Windows.Forms.RadioButton();
            this.cmbparidad = new System.Windows.Forms.ComboBox();
            this.cmbvelocidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtrecibido = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtenviar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.groupBox1.Controls.Add(this.cmbpuerto);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbparidad);
            this.groupBox1.Controls.Add(this.cmbvelocidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurar puerto serial";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(542, 68);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(104, 26);
            this.btnConfigurar.TabIndex = 9;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // cmbpuerto
            // 
            this.cmbpuerto.FormattingEnabled = true;
            this.cmbpuerto.Location = new System.Drawing.Point(151, 19);
            this.cmbpuerto.Name = "cmbpuerto";
            this.cmbpuerto.Size = new System.Drawing.Size(168, 21);
            this.cmbpuerto.TabIndex = 8;
            this.cmbpuerto.Text = "Seleccione el puerto";
            this.cmbpuerto.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnparada2);
            this.groupBox3.Controls.Add(this.rbtnparada1);
            this.groupBox3.Location = new System.Drawing.Point(377, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 46);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bits de parada";
            // 
            // rbtnparada2
            // 
            this.rbtnparada2.AutoSize = true;
            this.rbtnparada2.Location = new System.Drawing.Point(65, 19);
            this.rbtnparada2.Name = "rbtnparada2";
            this.rbtnparada2.Size = new System.Drawing.Size(31, 17);
            this.rbtnparada2.TabIndex = 1;
            this.rbtnparada2.Text = "2";
            this.rbtnparada2.UseVisualStyleBackColor = true;
            // 
            // rbtnparada1
            // 
            this.rbtnparada1.AutoSize = true;
            this.rbtnparada1.Checked = true;
            this.rbtnparada1.Location = new System.Drawing.Point(6, 19);
            this.rbtnparada1.Name = "rbtnparada1";
            this.rbtnparada1.Size = new System.Drawing.Size(31, 17);
            this.rbtnparada1.TabIndex = 0;
            this.rbtnparada1.TabStop = true;
            this.rbtnparada1.Text = "1";
            this.rbtnparada1.UseVisualStyleBackColor = true;
            this.rbtnparada1.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnbits2);
            this.groupBox2.Controls.Add(this.rbtnbits1);
            this.groupBox2.Location = new System.Drawing.Point(377, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 46);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Número de bits";
            // 
            // rbtnbits2
            // 
            this.rbtnbits2.AutoSize = true;
            this.rbtnbits2.Location = new System.Drawing.Point(65, 19);
            this.rbtnbits2.Name = "rbtnbits2";
            this.rbtnbits2.Size = new System.Drawing.Size(31, 17);
            this.rbtnbits2.TabIndex = 1;
            this.rbtnbits2.Text = "8";
            this.rbtnbits2.UseVisualStyleBackColor = true;
            this.rbtnbits2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtnbits1
            // 
            this.rbtnbits1.AutoSize = true;
            this.rbtnbits1.Checked = true;
            this.rbtnbits1.Location = new System.Drawing.Point(6, 19);
            this.rbtnbits1.Name = "rbtnbits1";
            this.rbtnbits1.Size = new System.Drawing.Size(31, 17);
            this.rbtnbits1.TabIndex = 0;
            this.rbtnbits1.TabStop = true;
            this.rbtnbits1.Text = "7";
            this.rbtnbits1.UseVisualStyleBackColor = true;
            this.rbtnbits1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cmbparidad
            // 
            this.cmbparidad.FormattingEnabled = true;
            this.cmbparidad.Location = new System.Drawing.Point(151, 109);
            this.cmbparidad.Name = "cmbparidad";
            this.cmbparidad.Size = new System.Drawing.Size(168, 21);
            this.cmbparidad.TabIndex = 5;
            this.cmbparidad.Text = "None";
            this.cmbparidad.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cmbvelocidad
            // 
            this.cmbvelocidad.FormattingEnabled = true;
            this.cmbvelocidad.Location = new System.Drawing.Point(151, 68);
            this.cmbvelocidad.Name = "cmbvelocidad";
            this.cmbvelocidad.Size = new System.Drawing.Size(168, 21);
            this.cmbvelocidad.TabIndex = 4;
            this.cmbvelocidad.Text = "19200";
            this.cmbvelocidad.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paridad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Velocidad (Baudios)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puerto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cadena recibida";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(542, 161);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(104, 26);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.txtrecibido);
            this.groupBox4.Controls.Add(this.btnCerrar);
            this.groupBox4.Controls.Add(this.btnAbrir);
            this.groupBox4.Controls.Add(this.txtenviar);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnEnviar);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(676, 254);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configurar puerto serial";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(542, 210);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 26);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtrecibido
            // 
            this.txtrecibido.Location = new System.Drawing.Point(29, 53);
            this.txtrecibido.Multiline = true;
            this.txtrecibido.Name = "txtrecibido";
            this.txtrecibido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtrecibido.Size = new System.Drawing.Size(617, 93);
            this.txtrecibido.TabIndex = 14;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(215, 210);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(104, 26);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(65, 210);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(104, 26);
            this.btnAbrir.TabIndex = 12;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            // 
            // txtenviar
            // 
            this.txtenviar.Location = new System.Drawing.Point(131, 167);
            this.txtenviar.Name = "txtenviar";
            this.txtenviar.Size = new System.Drawing.Size(370, 20);
            this.txtenviar.TabIndex = 11;
            this.txtenviar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cadena a enviar";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 472);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnbits1;
        private System.Windows.Forms.ComboBox cmbparidad;
        private System.Windows.Forms.ComboBox cmbvelocidad;
        private System.Windows.Forms.RadioButton rbtnbits2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnparada2;
        private System.Windows.Forms.RadioButton rbtnparada1;
        protected System.Windows.Forms.ComboBox cmbpuerto;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtenviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtrecibido;
        private System.Windows.Forms.Button btnSalir;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

