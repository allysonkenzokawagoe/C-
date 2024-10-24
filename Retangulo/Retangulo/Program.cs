using Retangulo;
using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
 
            Calculos ret = new Calculos();

            Console.WriteLine("Digite os valores da altura e da largura de um retângulo: ");
            Console.Write("Altura: ");
            ret.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Largura: ");
            ret.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write($"Area = {ret.Area()}");
            Console.WriteLine();
            Console.Write($"Perímetro = {ret.Perimetro()}");
            Console.WriteLine();
            Console.Write($"Diagonal = {ret.Diagonal()}");


        }
    }
}
