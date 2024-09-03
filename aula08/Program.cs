using System;
using System.Collections.Generic;
using System.Linq;


//O método Where é um método de extensão da LINQ(Linguage Integrated Query)
public class Program{
    public static void Main(string[] args){
        List<int> numeros = new List<int>{1,2,3,4,5,6,7,8,9,10};

        //Usando uma expressao lambda para filtrar os números pares.
        List<int> numPares = numeros.Where(n => n % 2 == 0).ToList();

        Console.WriteLine("Numeros Pares: ");
        numPares.ForEach(n => Console.WriteLine(n));


        // Segundo exemplo
        List<string> frutas = new List<string>{"Maça", "Banana","Mamão", "Abacaxi", "Manga", "Morango"};

        // Ordenando a lista de frutas por ordem alfabética.
        List<string> frutasOrdenadas = frutas.OrderBy(f => f).ToList();

        List<string> frutasComM = frutasOrdenadas.Where(f => f.StartsWith("M")).ToList();

        Console.WriteLine("Frutas Ordenadas que começam com 'M'.");
        frutasComM.ForEach(f => Console.WriteLine(f));

        //Terceira Prática
        List<Pessoa> pessoas = new List<Pessoa>{
            new Pessoa("Gustavo",20),
            new Pessoa("Laura",22),
            new Pessoa("Adriana",50),
            new Pessoa("Rogério",45),
            new Pessoa("João",25),
        };

        List<Pessoa> pessoasFiltradas = pessoas.Where(p => p.Idade > 25).OrderBy(p => p.Nome).ToList();

        Console.WriteLine("Pessoas com idade superior a 25, ordenadas por nome: ");
        pessoasFiltradas.ForEach(p => Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}"));
    }
}