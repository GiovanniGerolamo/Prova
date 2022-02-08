using System;
using Exercicio_2.src.entities;
using System.Collections.Generic;

namespace Exercicio_2;
class Program
{   
    //static List<Pessoa>pessoas;
    public static void Main(string[] args)
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        pessoas.Add(new Pessoa("João", 15));
        pessoas.Add(new Pessoa("Leandro", 21));
        pessoas.Add(new Pessoa("Paulo", 17));
        pessoas.Add(new Pessoa("Jessica", 18));

        int c = 4;
        int u = 0;

        foreach(Pessoa p in pessoas)
        {
            Console.WriteLine($"Nome: {p.Name} Idade: {p.Age}");
            if(p.Age < 18)
            {
                p.Excluido = true;
                c = c-1;
                u++;

            }
        }
        Console.WriteLine($"Antes da exclusão a lista possuía 4 pessoas. Após a exclusão a lista possui {c} pessoas. Total de {u} exclusões.");

        

        

    }
}