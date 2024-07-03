using System;
using System.Globalization;

namespace ExerciciosEstruturaCondicional
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
            Console.WriteLine("1) Exercício 1 - Positivo ou Negativo");
            Console.WriteLine("2) Exercício 2 - Par ou Impar");
            Console.WriteLine("3) Exercício 3 - Multiplos");
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
            Console.WriteLine("Informe um numero: ");
            int n1 = int.Parse(Console.ReadLine());
            if (n1 < 0)
            {
                Console.WriteLine("Negativo!");
            }
            else
            {
                Console.WriteLine("Positivo");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public static void Exercicio2()
        {
            Console.Clear();
            Console.WriteLine("Informe um número");
            int n1 = int.Parse(Console.ReadLine());
            if (n1 % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public static void Exercicio3()
        {
            Console.Clear();
            Console.WriteLine("Informe dois numeros na mesma linha: ");
            string[] vetor = Console.ReadLine().Split(" ");
            int n1 = int.Parse(vetor[0]);
            int n2 = int.Parse(vetor[1]);

            if (n1 % n2 == 0 || n2 % n1 == 0)
            {
                Console.WriteLine("São Multiplos!");
            }
            else
            {
                Console.WriteLine("Não São Multiplos!");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public static void Exercicio4()
        {
            Console.Clear();
            Console.WriteLine("Informe a hora inicial e final do jogo na mesma linha: ");
            string[] vetor = Console.ReadLine().Split(" ");
            int horaInicial = int.Parse(vetor[0]);
            int horaFinal = int.Parse(vetor[1]);
            int duracao;

            if (horaInicial > horaFinal)
            {
                duracao = (24 - horaInicial) + horaFinal;
            }
            else if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24;
            }

            Console.WriteLine($"O jogo durou {duracao} hora(s)");

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public static void Exercicio5()
        {
            Console.Clear();
            Console.WriteLine("Informe o código do produto seguido da quantidade: ");
            string[] vetor = Console.ReadLine().Split(" ");
            int codigo = int.Parse(vetor[0]);
            int quantidade = int.Parse(vetor[1]);

            double preco;

            if (codigo == 1)
            {
                Console.WriteLine($"Total: {preco * quantidade}");
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}