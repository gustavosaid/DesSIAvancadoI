// nome e idade 
namespace aula11_EF.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public Cliente(int id, string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString(){
        return $"Id:{Id}, Nome: {Nome}, Idade: {Idade} ";
        }
    }
}