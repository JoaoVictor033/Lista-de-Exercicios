using System;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        Codifique um programa que faça a entrada de um número qualquer pelo teclado. 
        A seguir o programa imprime uma mensagem textual somente se ele for maior que 20.
        */
       int numero;
        Console.WriteLine ("Digite um número qualquer: ");
        numero = Convert.ToInt32(Console.ReadLine());
        if(numero > 20){
            Console.WriteLine("O seu número é maior que 20.");
        }

    }
}


