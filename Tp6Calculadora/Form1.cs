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
        float num1, num2, res;
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
            num1 = default(float);
            num2 = default(float);
            operador = "";
            numeroValido = 0;
        }

        private void button15_Click(object sender, EventArgs e) { // Botón de igual
            num2 = int.Parse(textBox1.Text);
            label4.Text += num2;
            switch (operador) {
                case "+":
                    res = miCalculadora.Suma(num1, num2);
                    break;
                case "-":
                    res = miCalculadora.Resta(num1, num2);
                    break;
                case "*":
                    res = miCalculadora.Mult(num1, num2);
                    break;
                case "/":
                    res = miCalculadora.Div(num1, num2);
                    break;
            }
            textBox1.Text = res.ToString();
        }

        private void button_Click(object sender, EventArgs e) {
            Button boton = (Button)sender;
            switch (boton.Text) {
                case "+":
                    operador = "+"; // El operador va afuera del if, para que al tocar dos operadores seguidos, se reemplace en la operación.
                    if (textBox1.Text != "") { //Evito que el programa crashee al querer hacer una operacion de un valor vacío.
                        num1 = int.Parse(textBox1.Text);
                        textBox1.Clear();
                    }
                    numeroValido = 1;
                    break;
                case "-":
                    operador = "-";
                    if (textBox1.Text != "") {
                        num1 = int.Parse(textBox1.Text);
                        textBox1.Clear();
                    }
                    numeroValido = 1;
                    break;
                case "/":
                    operador = "/";
                    if (textBox1.Text != "") {
                        num1 = int.Parse(textBox1.Text);
                        textBox1.Clear();
                    }
                    numeroValido = 1;
                    break;
                case "*":
                    operador = "*";
                    if (textBox1.Text != "") {
                        num1 = int.Parse(textBox1.Text);
                        textBox1.Clear();
                    }
                    numeroValido = 1;
                    break;
                default:
                    textBox1.Text += boton.Text;
                    break;
            }
            if (numeroValido == 1) {
                label4.Text = num1.ToString();
            }
            label4.Text += operador;
        }
    }
}
