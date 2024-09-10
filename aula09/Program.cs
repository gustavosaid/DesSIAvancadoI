public class Program{
    public static void Main(string[] args){
        // Criando clientes
        Cliente cliente1 = new Cliente(1, "Gustavo");
        Cliente cliente2 = new Cliente(2,"Laura");

        // Criando produto
        Produto produto1 = new Produto(1, "Calça", 50.25M);
        Produto produto2 = new Produto(2, "Tenis", 100.50M);
        Produto produto3 = new Produto(3, "Notebook", 5000.00M);
        Produto produto4 = new Produto(4, "Carro", 700.00M);

        //Criando compra para o cliente 1
        Compra compra1 = new Compra(cliente1);
        compra1.AdcionaProduto(produto1);
        compra1.AdcionaProduto(produto2);
        compra1.AdcionaProduto(produto3);

        //Criando compra para o cliente 2
        Compra compra2 = new Compra(cliente2);
        compra2.AdcionaProduto(produto4);
        compra2.AdcionaProduto(produto1);

        //exibir compra
        Console.WriteLine(compra1);
        Console.WriteLine(compra2);
    }
}