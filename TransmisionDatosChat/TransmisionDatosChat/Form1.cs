using System;
using System.Windows.Forms;

namespace TransmisionDatosChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {

            int numeroBits = rbNbitsSiete.Checked ? 7 : 8;
            int bitsParada = rbBparUno.Checked ? 1 : 2;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }
    }
}
