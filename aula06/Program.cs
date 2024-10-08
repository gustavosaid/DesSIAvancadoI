using System;
public class Program{

    public delegate void ExibirNumero(int num);
    public static void imprimeNumero(int numero){
        Console.WriteLine("O numero é: " +numero);
    }

    public static void ExibirQuadrado(int numero){
        Console.WriteLine("O quadrado do numero " + numero + " é: " +numero*numero);
    }




    public static void MediaNota(int nota){
        if(nota < 60){
            Console.WriteLine("Reprovado, sua nota é: "+ nota);
        }else{
            Console.WriteLine("Aprovado sua nota é: "+ nota);
        }
    }

    public static void Main (){
        ExibirNumero meuDelegate = imprimeNumero;
        meuDelegate(10);

        meuDelegate += ExibirQuadrado;
        meuDelegate(2);

        meuDelegate += delegate (int num){
            Console.WriteLine("O dobro do número " + num + " é " +(num*2));
        };

        meuDelegate(3);

        Pessoa objPessoa = new Pessoa("Gustavo", 59);
        meuDelegate += MediaNota;

        meuDelegate(objPessoa.Nota);
    }
    
    
}
