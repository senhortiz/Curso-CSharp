using System;
using System.Globalization;

namespace ExerciciosEstruturaWhile
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
            Console.WriteLine("1) Exercício 1 - Senha");
            Console.WriteLine("2) Exercício 2 - Sistema Cartesiano");
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
            Console.WriteLine("Informe a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha inválida !!!");
                Console.WriteLine("Informe a senha novamente: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido !!!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public static void Exercicio2()
        {
            Console.Clear();
            Console.WriteLine("Informe o valor de X e Y na mesma linha: ");
            string[] vetor = Console.ReadLine().Split(" ");
            int x = int.Parse(vetor[0]);
            int y = int.Parse(vetor[1]);

            while(x != 0 && y != 0)
            {
                if (x > 1 && y > 1)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x > 1 && y < 1)
                {
                    Console.WriteLine("Quarto");
                }
                else if (x < 1 && y < 1)
                {
                    Console.WriteLine("Terceiro");
                }
                else 
                {
                    Console.WriteLine("Segundo");
                }

                Console.WriteLine("Informe o valor de X e Y na mesma linha novamente: ");
                vetor = Console.ReadLine().Split(" ");
                x = int.Parse(vetor[0]);
                y = int.Parse(vetor[1]);
            };
            Console.WriteLine(" ");
            Console.ReadKey();

        }

        public static void Exercicio3() 
        {
            Console.Clear();
            Console.WriteLine("Informe a qual produto tem preferencia: ");
            Console.WriteLine("1 - Alcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - Fim");
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int produtoSelecionado = int.Parse(Console.ReadLine());
            Console.Clear();

            while (produtoSelecionado > 0 && produtoSelecionado < 4)
            {
                if(produtoSelecionado == 1)
                {
                    alcool ++;
                    Console.WriteLine("Informe a qual produto tem preferencia: ");
                    Console.WriteLine("1 - Alcool");
                    Console.WriteLine("2 - Gasolina");
                    Console.WriteLine("3 - Diesel");
                    Console.WriteLine("4 - Fim");
                    produtoSelecionado = int.Parse(Console.ReadLine());
                    Console.Clear() ;
                }
                else if(produtoSelecionado == 2)
                {
                    gasolina ++;
                    Console.WriteLine("Informe a qual produto tem preferencia: ");
                    Console.WriteLine("1 - Alcool");
                    Console.WriteLine("2 - Gasolina");
                    Console.WriteLine("3 - Diesel");
                    Console.WriteLine("4 - Fim");
                    produtoSelecionado = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                else if (produtoSelecionado == 3)
                {
                    diesel ++;
                    Console.WriteLine("Informe a qual produto tem preferencia: ");
                    Console.WriteLine("1 - Alcool");
                    Console.WriteLine("2 - Gasolina");
                    Console.WriteLine("3 - Diesel");
                    Console.WriteLine("4 - Fim");
                    produtoSelecionado = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Informe corretamente a qual produto tem preferencia: ");
                    Console.WriteLine("1 - Alcool");
                    Console.WriteLine("2 - Gasolina");
                    Console.WriteLine("3 - Diesel");
                    Console.WriteLine("4 - Fim");
                    produtoSelecionado = int.Parse(Console.ReadLine());
                    Console.Clear();
                }             
            }
            Console.WriteLine("Muito Obrigado !!!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
            Console.ReadKey();
        }
    }
}