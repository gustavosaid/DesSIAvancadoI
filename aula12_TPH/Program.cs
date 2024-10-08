using System.Linq;

namespace aula12_TPH{
    public class Program{
        public static void Main(string[] args){
            using (var context = new AppDbContext()){
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                // Adiciona dados de exemplo
                context.Pessoas.Add(new Aluno {Nome = "João", Matricula = "A001"});
                context.Pessoas.Add(new Professor {Nome = "Maria", Disciplina = "IOT"});
                context.SaveChanges();

                // Consulta e exibe os dados do banco
                var pessoas = context.Pessoas.ToList();
                foreach(var pessoa in pessoas){
                    Console.WriteLine($"Id: {pessoa.Id}, Nome: {pessoa.Nome}");
                }
            }
        }
    }
}