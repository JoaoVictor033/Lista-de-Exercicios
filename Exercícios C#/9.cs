using System;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        Codifique um programa que faça a leitura de um número inteiro pelo teclado. 
        O programa deve exibir uma mensagem de texto identificando o número 
        como “POSITIVO”,“NEGATIVO” ou “NULO” no caso do valor 0.
        */
    
        int numero1;
        Console.WriteLine("Digite um número: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        if(numero1 > 0){
            Console.WriteLine("O número que digitou é POSITIVO!");
        }else if(numero1 < 0){
            Console.WriteLine("O número que digitou é NEGATIVO!");
        }else if(numero1 == 0){
            Console.WriteLine("O número que digitou é NULO!");
        }

    }
}


