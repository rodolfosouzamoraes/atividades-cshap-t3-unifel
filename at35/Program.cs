namespace at35;

class Program
{
    static void Main(string[] args)
    {
        int[] codigos = new int[5];
        float[] precos = new float[5];
        
        for(int i = 0; i < codigos.Length ; i++){
            Console.WriteLine("Informe o código do produto: ");
            codigos[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o preço do produto: ");
            precos[i] = float.Parse(Console.ReadLine());
        }

        float totalPrecoProdutos = 0;

        for(int i = 0; i < codigos.Length ; i++){
            totalPrecoProdutos+= precos[i];
        }

        Console.WriteLine($"Valor total dos produtos: R${Math.Round(totalPrecoProdutos,2)}");
    }
}
