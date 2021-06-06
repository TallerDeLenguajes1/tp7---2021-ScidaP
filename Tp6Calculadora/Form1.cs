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
        float res, resAux;
        bool valorIgual = false;
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
            valorIgual = false;
        }

        private void button15_Click(object sender, EventArgs e) { // Botón de igual
            if (miCalculadora.numero2 != default(float)) {
                resAux = calcular(miCalculadora.numero2);
            }
            miCalculadora.numero2 = float.Parse(textBox1.Text);
            res = calcular(miCalculadora.numero2);
            if (resAux.ToString() != textBox1.Text) {
                label4.Text += miCalculadora.numero2;
            } else {
                textBox1.Text = resAux.ToString();
                valorIgual = true;
            }
            if (operador == "/" && miCalculadora.numero2 == 0) {
                textBox1.Text = "Error";
            } else if (valorIgual == false) {
                textBox1.Text = res.ToString();
            }
            miCalculadora.numero2 = default(float);
        }

        private void button_Click(object sender, EventArgs e) {
            agregarNumeros(sender);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
            label4.Text = e.KeyChar.ToString();
        }

        private void agregarNumeros(object sender) {
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            textBox1.Text = e.KeyChar.ToString();
            agregarNumeros(sender);
        }

        private float calcular(float numero2) {
            switch (operador) {
                case "+":
                    res = miCalculadora.Suma(miCalculadora.numero1, numero2);
                    break;
                case "-":
                    res = miCalculadora.Resta(miCalculadora.numero1, numero2);
                    break;
                case "*":
                    res = miCalculadora.Mult(miCalculadora.numero1, numero2);
                    break;
                case "/":
                    if (miCalculadora.numero2 != 0) {
                        res = miCalculadora.Div(miCalculadora.numero1, numero2);
                    }
                    break;
            }
            return res;
        }
    }
}
