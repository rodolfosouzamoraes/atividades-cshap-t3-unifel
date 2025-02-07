namespace at35._1;

class Program
{
    static void Main(string[] args)
    {
        int[] codigos = new int[5];
        float totalPrecoProdutos = 0;

        for(int i = 0; i < codigos.Length ; i++){
            Console.WriteLine("Informe o código do produto: ");
            codigos[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o preço do produto: ");
            totalPrecoProdutos += float.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Valor total dos produtos: R${Math.Round(totalPrecoProdutos,2)}");
    }
}
