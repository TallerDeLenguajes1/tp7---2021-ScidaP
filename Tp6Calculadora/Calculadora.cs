using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6Calculadora {
    class Calculadora {
        public int numero1, numero2;

        public int Suma(int n1, int n2) {
            return n1 + n2;
        }

        public int Resta(int n1, int n2) {
            return n1 - n2;
        }
        public int Mult(int n1, int n2) {
            return n1 * n2;
        }
        public int Div(int n1, int n2) {
            if (n2 != 0) {
                return n1 / n2;
            } else {
                return 0;
            }
        }
    }
}
