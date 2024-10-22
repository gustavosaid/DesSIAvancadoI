﻿using Microsoft.EntityFrameworkCore;
using System.Linq;

class Program{
    public static void Main(string[] args){

        using(var context = new AppDbContext){
            context.Database.EnsureCreated();

            var novaPessoa = new Pessoa{
                Nome = "Gustavo Ribeiro",
                Idade = 20,
            };
            context.Pessoas.Add(novaPessoa);
            context.SaveChanges();

            var pessoas = context.Pessoas.ToList();
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Nome:{pessoa.Nome}, Idade:{pessoa.Idade}");
            }
        }
    }
}
