class Program{
    public static void Main (string[] args){
        Pessoa objPessoa = new Pessoa("Gustavo");
        Console.WriteLine("Antes do método (Classe)" + objPessoa.ToString());
        AlteraNomeClasse (objPessoa);
        Console.WriteLine("Depois do método (Classe):" +objPessoa.ToString());

        PessoaStruct objPessoaStruct = new PessoaStruct("Adriana");
        Console.WriteLine("Antes do método (Struct)" +objPessoaStruct);
        AlteraNomeStruct(objPessoaStruct);
        Console.WriteLine("Depois do método (Struct):" +objPessoaStruct.ToString());
    }

    public static void AlteraNomeClasse(Pessoa objAux){
        objAux.Nome = "Laura";
    }

    public static void AlteraNomeStruct(PessoaStruct objAuxStruct){
        objAuxStruct.NomeStruct = "Rogerio";
    }
}