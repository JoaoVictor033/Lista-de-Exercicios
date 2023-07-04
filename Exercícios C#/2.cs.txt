using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Codifique um programa que leia três números reais quaisquer. A seguir o programa calcula e imprime a média aritmética desses três números. //
            int numero1;
            int numero2;
            int numero3;
            int soma;
            int media;
            Console.WriteLine("Digite um número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o último número: ");
            numero3 = Convert.ToInt32(Console.ReadLine());
            soma = numero1 + numero2 + numero3;
            media = soma / 3;
            Console.WriteLine("A soma dos três números é: " + soma);
            Console.WriteLine("A média destes números é: " + media);


        }
    }
}
