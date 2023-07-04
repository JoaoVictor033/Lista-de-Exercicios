using System;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        Codifique um programa que faça a leitura de um número inteiro pelo teclado.
        A seguir, o programa determina se o número é par ou impar, imprimindo uma mensagem para o usuário.
        */
        int numero1;
        Console.WriteLine("Digite um número: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        if(numero1 % 2 == 0){
            Console.WriteLine("O número que você digitou é PAR!");
        }else if(numero1 % 2 != 0){
            Console.WriteLine("O número que você digitou é ÍMPAR!");
        }



    }
}


