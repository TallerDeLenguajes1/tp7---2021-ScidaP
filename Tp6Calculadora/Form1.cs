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
        Calculadora miCalculadora = new Calculadora();
        string operador;
        float res;
        int numeroValido = 0;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void button14_Click(object sender, EventArgs e) { // CLEAR
            textBox1.Text = "";
            label4.Text = "";
            miCalculadora.numero1 = default(float);
            miCalculadora.numero2 = default(float);
            operador = "";
            numeroValido = 0;
        }

        private void button15_Click(object sender, EventArgs e) { // Botón de igual
            miCalculadora.numero2 = float.Parse(textBox1.Text);
            label4.Text += miCalculadora.numero2;
            switch (operador) {
                case "+":
                    res = miCalculadora.Suma(miCalculadora.numero1, miCalculadora.numero2);
                    break;
                case "-":
                    res = miCalculadora.Resta(miCalculadora.numero1, miCalculadora.numero2);
                    break;
                case "*":
                    res = miCalculadora.Mult(miCalculadora.numero1, miCalculadora.numero2);
                    break;
                case "/":
                    if (miCalculadora.numero2 != 0) {
                        res = miCalculadora.Div(miCalculadora.numero1, miCalculadora.numero2);
                    }
                    break;
            }
            if (operador == "/" && miCalculadora.numero2 == 0) {
                textBox1.Text = "Error";
            } else {
                textBox1.Text = res.ToString();
            }
        }

        private void button_Click(object sender, EventArgs e) {
            Button boton = (Button)sender;
            switch (boton.Text) {
                case "+":
                    operador = "+"; // El operador va afuera del if, para que al tocar dos operadores seguidos, se reemplace en la operación.
                    if (textBox1.Text != "") { //Evito que el programa crashee al querer hacer una operacion de un valor vacío.
                        miCalculadora.numero1 = float.Parse(textBox1.Text);
                        textBox1.Clear();
                    }
                    numeroValido = 1;
                    break;
                case "-":
                    operador = "-";
                    if (textBox1.Text != "") {
                        miCalculadora.numero1 = float.Parse(textBox1.Text);
                        textBox1.Clear();
                    }
                    numeroValido = 1;
                    break;
                case "/":
                    operador = "/";
                    if (textBox1.Text != "") {
                        miCalculadora.numero1 = float.Parse(textBox1.Text);
                        textBox1.Clear();
                    }
                    numeroValido = 1;
                    break;
                case "*":
                    operador = "*";
                    if (textBox1.Text != "") {
                        miCalculadora.numero1 = float.Parse(textBox1.Text);
                        textBox1.Clear();
                    }
                    numeroValido = 1;
                    break;
                default:
                    textBox1.Text += boton.Text;
                    break;
            }
            if (numeroValido == 1) {
                label4.Text = miCalculadora.numero1.ToString();
            }
            label4.Text += operador;
        }
    }
}
