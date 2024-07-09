using System;
using System.Globalization;

namespace ExercicioEstruturaFor
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
            Console.WriteLine("1) Exercício 1 - Numeros impares");
            Console.WriteLine("2) Exercício 2 - In or Out");
            Console.WriteLine("3) Exercício 3 - Média por peso");
            Console.WriteLine("4) Exercício 4 - Divisão de dois numeros");
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
            Console.Write("Informe um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= x; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public static void Exercicio2()
        {
            Console.Clear();
            Console.Write("Informe a quantidade de numeros inteiros deseja ler: ");
            int N = int.Parse(Console.ReadLine());
            int In = 0;
            int Out = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Valor #{0}: " , i);
                int X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20) 
                {
                    In++;
                }
                else
                {
                    Out++;
                }
            }

            Console.WriteLine(In + " in");
            Console.WriteLine(Out + " out");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public static void Exercicio3()
        {
            Console.Clear();
            Console.WriteLine("Informe a quantidade de testes a realizar: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Informe o valor na mesma linha: ");
                string[] vetor = Console.ReadLine().Split(" ");

                double a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public static void Exercicio4()
        {
            Console.Clear();
            Console.WriteLine("Informe a quantidade de divisões a realizar: ");
            int n = int.Parse(Console.ReadLine());
            double soma = 0;

            for (int i = 1; i <= n;i++)
            {
                Console.WriteLine("Informe os numeros a dividir: ");
                string[] vetor = Console.ReadLine().Split(" ");
                int n1 = int.Parse(vetor[0]);
                int n2 = int.Parse(vetor[1]);

                if (n1 == 0)
                {
                    Console.WriteLine("0.0");
                }
                else if (n2 == 0) 
                {
                    Console.WriteLine("Divisão Impossivel");
                }
                else 
                {
                    soma = n1 / n2;
                    Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}