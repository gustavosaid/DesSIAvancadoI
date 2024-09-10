public class Produto{
    private int id;
    private string nome = "";
    private decimal preco;

    public int Id{
        get { return id; }
        set { id = value; }
    }

    public string Nome{
        get { return nome; }
        set { nome = value; }
    }

    public decimal Preco{
        get { return preco; }
        set { preco = value; }
    }
    public Produto(int id, string nome, decimal preco){
        Id = id;
        Nome = nome;
        Preco = preco;
    }

    public override string ToString(){
        return $"O Id é {Id}, contendo o Nome: {Nome}, e seu valor de: {preco}";
    }

}