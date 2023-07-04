using System;

public class Program
{
    public static void Main(string[] args)
    {
        /*  Sabendo que o latão é obtido fundindo-se sete partes de cobre com três partes de zinco, 
        escreva um programa que solicite quantos quilos de latão um usuário quer produzir. 
        A seguir o programa informa ao usuário as quantidades de cobre e zinco necessárias.
        */
        
        double quilosLatão = 0;
        double quilosCobre = 0;
        double quilosZinco = 0;

        Console.WriteLine("Digite a quantidade de quilos de latão a ser produzido:");
        quilosLatão = Convert.ToDouble(Console.ReadLine());

        quilosCobre = (7.0 / 10.0) * quilosLatão;
        quilosZinco = (3.0 / 10.0) * quilosLatão;

        Console.WriteLine("Para produzir {0} quilos de latão, serão necessários {1} quilos de cobre e {2} quilos de zinco.", quilosLatão, quilosCobre, quilosZinco);
    }
}


