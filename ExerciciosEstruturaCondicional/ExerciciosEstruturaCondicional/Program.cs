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
            Console.WriteLine("4) Exercício 4 - Horas jogadas");
            Console.WriteLine("5) Exercício 5 - Lanches");
            Console.WriteLine("6) Exercício 6 - Intervalo dos numeros");
            Console.WriteLine("7) Exercício 7 - Plano Cartesiano");
            Console.WriteLine("8) Exercício 8 - Calculo de imposto");
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
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    Exercicio7();
                    break;
                case ConsoleKey.D8:
                case ConsoleKey.NumPad8:
                    Exercicio8();
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
            double total;

            if (codigo == 1)
            {
                preco = 4.00;
                Console.WriteLine("Total: R$" + (preco * quantidade).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 2)
            {
                preco = 4.50;
                Console.WriteLine("Total: R$" + (preco * quantidade).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 3)
            {
                preco = 5.00;
                Console.WriteLine("Total: R$" + (preco * quantidade).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 4)
            {
                preco = 2.00;
                Console.WriteLine("Total: R$" + (preco * quantidade).ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                preco = 1.50;
                Console.WriteLine("Total: R$" + (preco * quantidade).ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public static void Exercicio6()
        {
            Console.Clear();
            Console.WriteLine("Insira um numero para saber se o mesmo está dentro de algum intervalo: ");
            double numeroInserido = double.Parse(Console.ReadLine());

            if (numeroInserido >= 0 && numeroInserido < 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if(numeroInserido >= 25 && numeroInserido < 75)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if(numeroInserido >= 75 && numeroInserido <= 100)
            {
                Console.WriteLine("Intervalo [75,100]");
            }
            else 
            {
                Console.WriteLine("Fora de intervalo");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public static void Exercicio7()
        {
            Console.Clear();
            Console.WriteLine("Informe o valor de X e Y na mesma linha: ");
            string[] vetor = Console.ReadLine().Split(" ");
            double x = double.Parse(vetor[0]);
            double y = double.Parse(vetor[1]);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else 
            {
                Console.WriteLine("Origem");
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public static void Exercicio8()
        {
            Console.Clear();
            Console.WriteLine("Informe sua renda para calcular o imposto de renda: ");
            double renda = double.Parse(Console.ReadLine());
            double imposto8 = 0.08;
            double imposto18 = 0.18;
            double imposto28 = 0.28;

            double rendaTaxada;

            if(renda > 2000 && renda <= 3000)
            {
                rendaTaxada = renda - 2000;
                Console.WriteLine("R$ " + (imposto8 * rendaTaxada).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(renda > 3000 && renda <= 4500)
            {
                rendaTaxada = renda - 3000;
                Console.WriteLine("R$ " + (((imposto8 * 1000)  + (imposto18 * rendaTaxada)).ToString("F2", CultureInfo.InvariantCulture)));
            }
            else if(renda > 4500)
            {
                rendaTaxada = renda - 4500;
                Console.WriteLine("R$ " + ((imposto8 * 1000) + (imposto18 * 1500) + (imposto28 * rendaTaxada)).ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Isento");
            }
            
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}