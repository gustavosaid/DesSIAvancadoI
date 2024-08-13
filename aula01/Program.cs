using System;

public class Program {
    public static void Main(string[]args){
        //Cadastras os dados de pessoa

        Console.WriteLine("Cadastro de Pessoa");
        Console.Write("Nome: ");
        string nomePessoa = Console.ReadLine();

        Console.Write("Idade: ");
        int idadePessoa = int.Parse(Console.ReadLine());

        Pessoa obj1 = new Pessoa(nomePessoa, idadePessoa);

        Console.WriteLine(obj1);
    }
}