using System;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        Codifique um programa que leia dois números inteiros e calcule a soma desses dois números.
        O programa somente imprimirá o resultado da soma quando a soma for maior que 10. 
        Se a soma for menor ou igual a 10, o programa imprime uma mensagem de aviso ao usuário. 
        */
        
        int numero1;
        int numero2;
        int soma;
        Console.WriteLine("Digite um número: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        soma = numero1 + numero2;
        if(soma > 10){
            Console.WriteLine("A soma de " + numero1 + " + " + numero2 + " = " + soma);
        }else if(soma <=10){
            Console.WriteLine("A soma dos dois números foi menor que ou igual a 10. Digite os dois números novamente.");
        }


    }
}


