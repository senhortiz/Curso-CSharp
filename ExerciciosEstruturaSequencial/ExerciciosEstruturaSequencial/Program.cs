using System;
using System.Globalization;

namespace ExerciciosEstruturaSequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha um exercício:");
            Console.WriteLine("1) Exercício 1");
            Console.WriteLine("2) Exercício 2");
            Console.WriteLine("3) Exercício 3");
            Console.WriteLine("ESC) Sair");
            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Exercicio1();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Exercicio2();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Exercicio3();
                    break;
                case ConsoleKey.Escape:
                    return false;
                default:
                    Console.WriteLine("\nOpção inválida. Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
            return true;
        }

        public static void Exercicio1()
        {
            Console.Clear();
            Console.WriteLine("Digite um número inteiro:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"SOMA = {n1 + n2}");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public static void Exercicio2()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor que deseja calcular o raio: ");
            double pi = 3.14159;
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = pi * (n1 * n1);
            Console.WriteLine($"A= {area.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey ();
        }

        public static void Exercicio3()
        {
            Console.Clear();
            Console.WriteLine("Digite o Valor do Produto A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor do Produto B");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor do Produto C");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor do Produto D");
            int d = int.Parse(Console.ReadLine());
            int diferenca = (a * b) - (c * d);
            Console.WriteLine($"Diferença = {diferenca}");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}
