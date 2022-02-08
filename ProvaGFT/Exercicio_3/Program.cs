using System;

namespace Exercicio_3;
class Program
{
    public static void Main(string[] args)
    {
        double[] numero = new double[5];
        string[] n = new string[5];
        for (var i = 0; i < 5; i++)
        {
            n[i] = Console.ReadLine(); 
            numero[i] = Double.Parse(n[i]);
        }
        Double maior = numero[0];
        Double menor = numero[0];
        Double media = 0;
        Double soma = 0;
        for (var i = 0; i < 5; i++)
        {
            if(numero[i]>maior)
            {
                maior = numero[i];

            }
            if(numero[i]<menor)
            {
                menor = numero[i];
            }
            soma = soma + numero[i];
            

        }
        
        media = soma/5;
        Console.WriteLine($"Maior: {maior}  Menor: {menor}  Media: {media}");

    }
}