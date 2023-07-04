using System;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        Codifique um programa que faça a leitura de um número inteiro pelo teclado. 
        Se o número for positivo, ou nulo (0), o programa calcula a raiz quadrada do número. 
        Caso contrário, o programa calcula o quadrado desse número.
        */
        int numero = 0;
        double raizQuadrada = 0;
        int quadrado = 0;
        Console.WriteLine ("Digite um número inteiro: ");
        numero = Convert.ToInt32(Console.ReadLine());
        if(numero >=0){
            raizQuadrada = Math.Sqrt(numero);
            Console.WriteLine("A raiz quadrada do número " + numero + " é " + raizQuadrada);
        } else {
            quadrado = numero * numero;
            Console.WriteLine("O quadrado do número " + numero + " é " + quadrado);
        }

    }
}


