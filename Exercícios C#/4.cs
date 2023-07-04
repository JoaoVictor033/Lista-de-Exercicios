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
            /*
            Certa importância em dólares será dividida entre três pessoas. 
            A primeira receberá 30% da quantia total; a segunda 38% e a terceira 32%. 
            Codifique um programa que leia o valor total da importância em dólares 
            e calcule a parcela destinada a cada pessoa. 
            */
            
            double quantiaTotal;
            double parcela1;
            double parcela2;
            double parcela3;
            Console.WriteLine("Qual será a quantia? ");
            quantiaTotal = Convert.ToInt32(Console.ReadLine());
            parcela1 = 0.3 * quantiaTotal;
            Console.WriteLine("\nA 1° pessoa receberá 30% do valor que será: " + parcela1 + " dólares.");
            parcela2 = 0.38 * quantiaTotal;
            Console.WriteLine("\nA 2° pessoa receberá 38% do valor que será:" + parcela2 + " dólares.");
            parcela3 = 0.32 * quantiaTotal;
            Console.WriteLine("\nA 3° pessoa receberá 32% do valor que será:" + parcela3 + " dólares.");



        }
    }
}
