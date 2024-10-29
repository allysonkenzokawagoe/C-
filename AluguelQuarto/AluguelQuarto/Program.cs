using System;
using System.Globalization;

namespace AluguelQuarto {
    class Program {
        static void Main(string[] args) {

            Rent[] vet = new Rent[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Rent #{i}: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();
                vet[room] = new Rent(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Busy Rooms:");
            for (int i = 0; i < 10; i++) {
                if (vet[i] != null) {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }
        }
    }
}