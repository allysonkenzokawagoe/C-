using AlunoNotas;
using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Aluno n = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            n.nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            n.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"NOTA FINAL: {n.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();

            if(n.NotaFinal() >= 60) {
                Console.Write("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
                double aprovacao = 60 - n.NotaFinal();
                Console.WriteLine($"FALTARAM {aprovacao.ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }
    }
}