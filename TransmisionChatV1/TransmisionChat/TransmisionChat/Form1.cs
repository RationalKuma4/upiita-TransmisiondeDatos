using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace TransmisionChat
{
    public partial class Form1 : Form
    {
        private readonly string _usuario;
        private delegate void SetTextCallback(String text);
        private readonly StringBuilder _textoChat;

        public Form1(string usuario)
        {
            _usuario = usuario;
            _textoChat = new StringBuilder();
            InitializeComponent();
            Thread hilo = new Thread(new ThreadStart(LeerPuerto));
            hilo.IsBackground = true;
            hilo.Start();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            if (cmbPuerto.Text.Equals("Seleccione el puerto"))
            {
                MessageBox.Show("Seleccione un puerto");
                return;
            }

            var puerto = cmbPuerto.Text;
            var velocidad = int.Parse(cmbVelocidad.Text);
            var paridad = (Parity)Enum.Parse(typeof(Parity), cmbParidad.Text);
            var numeroBits = rbtnBits1.Checked ? 7 : 8;
            var bistParada = (StopBits)Enum.Parse(typeof(StopBits), rbtnParada1.Checked ? "1" : "2");
            ConfigurarPuerto(puerto, velocidad, paridad, numeroBits, bistParada);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (serialPort1 != null)
            {
                if (!serialPort1.IsOpen)
                    serialPort1.Open();
                MessageBox.Show("Puerto abierto");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (serialPort1 != null)
            {
                serialPort1.Close();
                MessageBox.Show("Puerto cerrardo");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var mensaje = _usuario + ": " + tbxEnviar.Text + "\r\n";

            if (serialPort1 != null && serialPort1.IsOpen)
                serialPort1.WriteLine(mensaje);

            _textoChat.Append(mensaje);
            tbxRecibido.Text = _textoChat.ToString();
            tbxEnviar.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BuscarPuertos();

            cmbVelocidad.Items.Add("1200");
            cmbVelocidad.Items.Add("2400");
            cmbVelocidad.Items.Add("4800");
            cmbVelocidad.Items.Add("9600");
            cmbVelocidad.Items.Add("19200");
            cmbVelocidad.Text = "19200";

            cmbParidad.Items.Add(Parity.Even.ToString());
            cmbParidad.Items.Add(Parity.Mark.ToString());
            cmbParidad.Items.Add(Parity.Odd.ToString());
            cmbParidad.Items.Add(Parity.Space.ToString());
            cmbParidad.Items.Add(Parity.None.ToString());
            cmbParidad.Text = "None";
        }

        private void BuscarPuertos()
        {
            var ports = SerialPort.GetPortNames();
            cmbParidad.Items.Clear();

            foreach (var port in ports)
                cmbPuerto.Items.Add(port);

            cmbPuerto.Text = "Seleccione el puerto";
        }

        private void ConfigurarPuerto(string nPuerto, int vel, Parity period, int nBits,
            StopBits bistParada)
        {
            serialPort1.PortName = nPuerto;
            serialPort1.BaudRate = vel;
            serialPort1.Parity = period;
            serialPort1.DataBits = nBits;
            serialPort1.StopBits = bistParada;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LeerPuerto()
        {
            var mensaje = "";
            bool continuar = true;
            while (continuar)
            {
                if (serialPort1 != null && serialPort1.IsOpen)
                {
                    try
                    {
                        mensaje = serialPort1.ReadLine();
                        SetText(mensaje);
                    }
                    catch (TimeoutException) { }
                    catch (IOException) { }
                }
            }
        }

        private void SetText(string text)
        {
            if (tbxRecibido.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new Object[] { text });
            }
            else
            {
                _textoChat.Append(text);
                tbxRecibido.Text = _textoChat.ToString();
            }
        }

        private void tbxRecibido_TextChanged(object sender, EventArgs e)
        {
            tbxRecibido.SelectionStart = tbxRecibido.Text.Length;
            tbxRecibido.ScrollToCaret();
        }
    }
}
