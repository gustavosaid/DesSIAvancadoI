namespace aula13_OTM{
    public class Categoria {
        public int CategoriaId { get; set; }

        public string Nome { get; set; }

        public List<Produto> Produtos { get; set; } = new List<Produto>();
    }
}