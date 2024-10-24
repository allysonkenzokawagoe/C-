using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosFuncionario {
    internal class Funcionario {

        public string nome;
        public double salario;
        public double imposto;

        public double SalarioLiquido() {
            return salario - imposto;
        }

        public void AumentarSalario(double porcentagem) {
            salario = salario + (salario * porcentagem / 100);
        }

        public override string ToString() {
            return nome + ", $ " + SalarioLiquido();
        }

    }
}
