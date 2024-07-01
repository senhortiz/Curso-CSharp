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
            Console.WriteLine("4) Exercício 4");
            Console.WriteLine("5) Exercício 5");
            Console.WriteLine("6) Exercício 6");
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
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Exercicio4();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Exercicio5();
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    Exercicio6();
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

        public static void Exercicio4()
        {
            Console.Clear();
            Console.WriteLine("Digite um numero: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
            int workedHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe quanto recebe por hora: ");
            double earnPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salary = workedHours * earnPerHour;
            Console.WriteLine($"Number = {number}");
            Console.WriteLine($"Salary = U${salary.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public static void Exercicio5()
        {
            Console.Clear();
            Console.WriteLine("Informe o código do produto 1: ");
            int codigo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de peças do produto 1: ");
            int quantidadePecas1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor unitário do produto 1: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o código do produto 2: ");
            int codigo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de peças do produto 2: ");
            int quantidadePecas2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor unitário do produto 2: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalCompra = (quantidadePecas1 * valor1) + (quantidadePecas2 * valor2);
            Console.WriteLine($"Valor a pagar: R$ {totalCompra.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();

        }public static void Exercicio6()
        {
            Console.Clear();
            Console.WriteLine("Insira tres valores com ponto flutuante na mesma linha: ");
            string[] vetor = Console.ReadLine().Split(" ");
            double a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            double triangulo = (a * c) / 2;
            double circulo = 3.14159 * c * c;
            double trapezio = ((a + b) * c) / 2;
            double quadrado = b * b;
            double retangulo = a * b;
            Console.WriteLine($"Triangulo: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Circulo: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapezio: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retangulo: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}
