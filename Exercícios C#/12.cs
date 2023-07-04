using System;

public class Program
{
    public static void Main(string[] args)
    {
        /*
         Codifique um programa que solicite ao usuário três valores, a saber: A, B e C.
         O programa deve imprimir os valores em ordem decrescente (do maior para o menor). 
        */
        int numero1 = 0;
        int numero2 = 0;
        int numero3 = 0;
        int menor = 0;
        int meio = 0;
        int maior = 0;
        
        Console.WriteLine("Digite o 1° número:");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o 2° número:");
        numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o 3° número:");
        numero3 = Convert.ToInt32(Console.ReadLine());
        
        if(numero1 <= numero2 && numero1 <= numero3){
            menor = numero1;            
        } else if (numero2 <= numero1 && numero2 <= numero3) {
            menor = numero2;
        } else {
            menor = numero3;
        }
        if (numero1 >= numero2 && numero1 >= numero3){
            maior = numero1;
        } else if (numero2 >= numero1 && numero2 >= numero3) {
            maior = numero2;
        } else {
            maior = numero3;
        }
        meio = numero1 + numero2 + numero3 - menor - maior;
        Console.WriteLine("Os valores em ordem decrescente é: " + maior + " - " + meio + " - " + menor);

    }
}


