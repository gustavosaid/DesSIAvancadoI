using aula10_EF.Models;

class Program{
    public static void Main(string[] args){
        using (var context = new PessoaContext()){

            //Criar o banco de dados se ele não existir
            context.DataBase.EnsureCreated();

            //Adcionar uma nova pessoa ao banco
            var pessoa = new Pessoa{
                Nome = "Gustavo",
                Idade = 20
            };

            context.Pessoas.Add(pessoa);
            context.SaveChanges();

            //Listar as pessoas cadastradas
            var listaPessoas = context.Pessoas.ToString();
            foreach(var p in listaPessoas){
                Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}");
            }
        }
    }
}