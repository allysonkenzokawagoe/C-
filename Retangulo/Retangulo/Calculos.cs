using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo {
    internal class Calculos {

        public double altura;
        public double largura;

        public double Area() {
            return altura * largura;
        }

        public double Perimetro() {
            return (largura * 2) + (altura * 2);
        }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }

    }
}
