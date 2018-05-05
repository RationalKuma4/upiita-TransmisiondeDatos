using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            busca_puertos();
            cmbvelocidad.Items.Add("1200");
            cmbvelocidad.Items.Add("2400");
            cmbvelocidad.Items.Add("4800");
            cmbvelocidad.Items.Add("9600");
            cmbvelocidad.Items.Add("19200");

            cmbvelocidad.Text = "19200";

            cmbparidad.Items.Add(Parity.Even.ToString());
            cmbparidad.Items.Add(Parity.Mark.ToString());
            cmbparidad.Items.Add(Parity.Odd.ToString());
            cmbparidad.Items.Add(Parity.Space.ToString());
            cmbparidad.Items.Add(Parity.None.ToString());

            cmbparidad.Text = "None";
        }
        private void busca_puertos()
        {
            String[] ports = SerialPort.GetPortNames();
            cmbpuerto.Items.Clear();
            foreach (String port in ports)
            {
                cmbpuerto.Items.Add(port);
            }

            cmbpuerto.Text = "Seleccione el puerto";
        }

        private void configura_puerto(String npuerto, int vel, Parity paridad, int nBits, StopBits bits_parada)
        {
            serialPort1.PortName = npuerto;
            serialPort1.BaudRate = vel;
            serialPort1.Parity = paridad;
            serialPort1.DataBits= nBits;
            serialPort1.StopBits = bits_parada;
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
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
            configura_puerto(cmbpuerto.Text, Convert.ToInt32(cmbvelocidad.Text), paridad, nBits, bits_parada);
        }

    
    }
}
