using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class ConversorDeMoeda {

        public static double QtdReais(double cotacao, double qtd) {

            return (cotacao * qtd) + (cotacao * qtd * 0.06);

        }

    }
}
