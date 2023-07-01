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
// Codifique um programa que leia um número inteiro qualquer e imprima o seu sucessor e seu antecessor. //
int numero;
int sucessor;
int antecessor;
Console.WriteLine("Digite um número qualquer: ");
numero = Convert.ToInt32(Console.ReadLine());
sucessor = numero + 1;
antecessor = numero - 1;
Console.WriteLine("O sucessor do " + numero + " é " + sucessor);
Console.WriteLine("O antecessor do " + numero + " é " + antecessor);
}
}
}
