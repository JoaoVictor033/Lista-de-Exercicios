using System;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        Codifique um programa que leia um número inteiro qualquer e determine se esse número é igual a 5, ou se é igual a 200, ou se é igual a 400, ou se está no intervalo aberto entre 500 e 1000 (aberto nos dois extremos).
        O programa também verifica se o número não atende a nenhum dos critérios anteriores. 
        */
        
       int numero = 0;
       Console.WriteLine("Digite um número: ");
       numero = Convert.ToInt32(Console.ReadLine());
       if(numero == 5){
           Console.WriteLine("Este número é igual a 5 ");
       }else if(numero == 200){
           Console.WriteLine("Este número é igual a 200 ");
       }else if(numero == 400){
           Console.WriteLine("Este número é igual a 400 ");
       }else if(numero > 500 && numero < 1000){
           Console.WriteLine("Este número está entre 500 e 1000 ");
       }else{
           Console.WriteLine("Este número não atende a nenhum dos critérios!");
       }


    }
}


