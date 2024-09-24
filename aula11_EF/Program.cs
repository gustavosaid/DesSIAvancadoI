using System.Linq;
using aula11_EF.Models;

public class Program{
    public static void Main(){
        using (var db = new AppDbContext()){
            db.DataBase.EnsyreCreated(); // Se o banco nao existir sera criado

            Cliente cliente1 = new Cliente("Gustavo",20);
            Cliente cliente2 = new Cliente ("Laura", 22);
            db.Cliente.Add(cliente1);
            db.Cliente.Add(cliente2);
            db.SaveChanges();

            Livro livro1 = new Livro("C# para iniciantes", 45.00M);
            Livro livro2 = new Livro ("Java: para programar", 80.00M);
            db.Livro.Add(livro1,livro2);
            db.SaveChanges();

            Venda venda1 = new Venda(cliente1);
            venda1.AdcionarLivro(livro1);
            venda1.AdcionarLivro(livro2);
            db.Venda.Add(venda1);

            Console.WriteLine(venda1);
        }
    }
}