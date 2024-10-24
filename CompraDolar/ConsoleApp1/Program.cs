using ConsoleApp1;
using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dólar? ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"Valor a ser pago em reais: {ConversorDeMoeda.QtdReais(cot,qtd).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}