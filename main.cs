/*Exercício 1: Faça um programa em C# que recebe 3 números e imprime na tela o maior dos 3 números.*/

using System;
namespace Exercicio_01
{
    class Program
    {

        public static void Main(string[] args)
        {

            Console.Write("Insira o primeiro número: ");
            int number_1 = int.Parse(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            int number_2 = int.Parse(Console.ReadLine());

            Console.Write("Insira o terceiro número: ");
            int number_3 = int.Parse(Console.ReadLine());

            int maior = number_1;

            if (number_2 > maior)
            {
                maior = number_2;
            }

            if (number_3 > maior)
            {
                maior = number_3;
            }

            Console.WriteLine($"O maior número é: {maior}");
        }
    }
}