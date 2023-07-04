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
            /*Codifique um programa para realizar a conversão de uma temperatura em graus Celsius para graus Fahrenheit. O programa recebe com entrada a temperatura em Celsius e exibe o resultado da conversão para o usuário. */
        double celsius;
        double resulT;
        Console.WriteLine("Qual a temperatura em Celsius: ");
        celsius = Convert.ToInt32(Console.ReadLine());
        resulT = (celsius * 9 / 5) + 32;
        Console.WriteLine("Convertendo para Fahrenheit: " + resulT);


        }
    }
}
