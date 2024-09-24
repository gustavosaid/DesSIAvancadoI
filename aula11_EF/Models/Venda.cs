namespace aula11_EF.Models
{
    public class Venda
    {

        public int Id { get; set; }
        public Cliente Cliente { get; set; }

        List<Livro> Livros { get; set; }

        //Construtor sem parametro necessario para o Entity Framework
        public Venda(){
            Cliente = new Cliente("",0);
            Livros = new List<Livro>();
        }

        public Venda(Cliente cliente){
            Cliente = cliente;
            Livros = new List<Livro>();
        }
        public void AdcionarLivro(Livro livro){
            Livros.Add(livro);
        }

        public decimal CalcularTotal(){
            return Livros.Sum(l => l.Preco);
        }

        public override string ToString(){
            string livrosStr.string.Join(", ", Livros.Select(l => l.Nome));
            return $"Venda para {Cliente.Nome}, Livro: [{livrosStr}], Total: {CalcularTotal():C}";
        }

        public void ListarLivrosMaisCaros(decimal precoMinimo){
            var livrosCaros = Livros.Where(l => l.Preco > precoMinimo).OrderBy(l => l.Nome).ToString();

            if(livrosCaros.Count > 0 ){
                Console.WriteLine($"Livros com o preço maior que {precoMinimo:C}:");
                livrosCaros.ForEach(l => Console.WriteLine(l));
            }else {
                Console.WriteLine($"Nenhum livro com o preço maior que {precoMinimo:C}");
            }
        }

        public void LivrosOrdenados(){
            var livrosOrdenados = Livros.OrderBy(l => l.Nome).ToList();
            livrosOrdenados.ForEach(l => Console.WriteLine(l));
        }
        
    }
}