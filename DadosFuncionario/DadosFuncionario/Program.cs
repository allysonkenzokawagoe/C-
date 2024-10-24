using DadosFuncionario;
using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Funcionario func = new Funcionario();

            Console.WriteLine("Digite os dados do funcionário:");
            Console.Write("Nome: ");
            func.nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.Write($"Funcionário: {func}");
            Console.WriteLine(); Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);
            Console.WriteLine();

            Console.Write($"Dados atualizados: {func}");

        }
    }
}