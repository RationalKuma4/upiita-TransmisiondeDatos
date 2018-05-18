using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransmisionChat
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                MessageBox.Show("Inserta un nombre de usuario", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                Hide();
                Form1 form1 = new Form1(textBox1.Text);
                form1.Closed += (s, args) => Close();
                form1.Show();
            }
        }
    }
}
