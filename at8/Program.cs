namespace at8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor da compra: ");
        float valorCompra = float.Parse(Console.ReadLine());

        float valorVenda = valorCompra * 1.12f;

        Console.WriteLine($"Valor de venda: R${Math.Round(valorVenda,2)}");
    }
}
