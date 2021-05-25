using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6Calculadora {
    class Calculadora {
        public float numero1, numero2;

        public float Suma(float n1, float n2) {
            return n1 + n2;
        }

        public float Resta(float n1, float n2) {
            return n1 - n2;
        }
        public float Mult(float n1, float n2) {
            return n1 * n2;
        }
        public float Div(float n1, float n2) {
            return n1 / n2;
        }
    }
}
