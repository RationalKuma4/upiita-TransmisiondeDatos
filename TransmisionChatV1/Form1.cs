using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;


namespace Chat
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm


    {
        public Form1()
        {
            InitializeComponent();
            Thread hilo = new Thread(new ThreadStart(LeerPuerto));
            hilo.IsBackground = true;
            hilo.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            busca_puertos();
            cmbparidad.Items.Add(Parity.Even.ToString());
            cmbparidad.Items.Add(Parity.Mark.ToString());
            cmbparidad.Items.Add(Parity.Odd.ToString());
            cmbparidad.Items.Add(Parity.Space.ToString());
            cmbparidad.Items.Add(Parity.None.ToString());
            cmbparidad.Text = "None";
        }
        private void busca_puertos() {
            String[] ports = SerialPort.GetPortNames();
            cmbpuerto.Items.Clear();
            foreach (String port in ports)
            {
                cmbpuerto.Items.Add(port);
            }

        }
        private void configurar_puerto(String npuerto, int vel, Parity paridad, int nBits, StopBits bits_paraidad) {
            serialPort1.PortName = npuerto;
            serialPort1.BaudRate = vel;
            serialPort1.Parity = paridad;
            serialPort1.DataBits = nBits;
            serialPort1.StopBits = bits_paraidad;
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void cmbvelocidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LeerPuerto()
        {
            String mensaje;
            bool continuar = true;
            while (continuar)
            {
                if (serialPort1 != null && (serialPort1.IsOpen == true))
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

        private delegate void SetTextCallback(String text);
private void SetText(String text) {
            if (textrecibido.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new Object[] { text });
            }
            else
                this.textrecibido.Text += text + "\r\n";
}
        private void btnconfigurar_Click(object sender, EventArgs e)
        {
            Parity paridad;
            StopBits bits_parada;
            int nBits;
            if (cmbparidad.Text == "Even")
                paridad = Parity.Even;
            else if (cmbparidad.Text == "Mark")
                paridad = Parity.Mark;
            else if (cmbparidad.Text == "Odd")
                paridad = Parity.Odd;
            else if (cmbparidad.Text == "Space")
                paridad = Parity.Space;
            else 
                paridad = Parity.None;
            if (rbtnparada1.Checked)
                bits_parada = StopBits.One;
            else
                bits_parada = StopBits.Two;
            if (rbtnbits1.Checked)
                nBits = 7;
            else
                nBits = 8;
            configurar_puerto(cmbpuerto.Text, Convert.ToInt32(cmbvelocidad.Text), paridad, nBits, bits_parada);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (serialPort1 != null)
            {
                if(serialPort1.IsOpen != true)
                    serialPort1.Open();

                MessageBox.Show("Puerto abierto");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (serialPort1 != null)
            {
                serialPort1.Close();
                MessageBox.Show("Puerto cerrar");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(serialPort1 != null  && serialPort1.IsOpen == true)
            {
                serialPort1.WriteLine(textenviar.Text);
            }
        }
    }
}
