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
            Console.WriteLine("3) Exercício 3 - Preferencia de combustivel");
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
    }
}