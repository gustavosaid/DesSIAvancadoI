public class Program {
    public static void Main(string [] args){
        // Conversão implicita
        int numInt = 45;
        double numDouble = numInt;
        Console.WriteLine("Conversão implicita de int para double");
        Console.WriteLine($"Int: {numInt}, Double: {numDouble}");

        //Conversao usando o Convert
        double valorDouble = 7.45;
        int valorConvertidoInt = Convert.ToInt32(valorDouble);
        string textoValor = "123";
        int textoConvertidoInt = Convert.ToInt32(textoValor);
        Console.WriteLine($"Double: {valorDouble}, Inteiro: {valorConvertidoInt}, String: {textoValor}. Inteiro: {textoConvertidoInt}");

        //Conversão explicita usando o (casting)
        double x = 9.75;
        int a = (int)x;
        Console.WriteLine($"Double: {x}, Inteiro: {a}");

        //Conversão usando o Parse
        string textDecimal = "12.75";
        double decimalString = double.Parse(textDecimal);
        Console.WriteLine($"Sring: {textDecimal}, Double: {decimalString}");

        char caractere = 'A';
        int codigoAscii = (int)caractere;
        Console.WriteLine($"Char: {caractere}, Ascii: {codigoAscii}");

    }
}