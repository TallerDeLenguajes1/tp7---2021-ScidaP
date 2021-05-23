using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp6Calculadora {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void button14_Click(object sender, EventArgs e) {
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e) { // Botón de igual

        }

        private void button_Click(object sender, EventArgs e) {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text; // Me parecía muy feo el código que había escrito, era obvio que había una forma de escribirlo mejor xd
        }
    }
}
