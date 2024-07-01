using System;
using System.Globalization;

namespace ExercicioEntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double precoProduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string[] vetor = Console.ReadLine().Split(' ');
            string ultimoNome = vetor[0];
            int idade = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            Console.WriteLine("Resultado: ");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade.ToString());
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}