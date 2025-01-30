namespace at4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número: ");
        float numero1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe um segundo número: ");
        float numero2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe um terceiro número: ");
        float numero3 = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe um quarto número: ");
        float numero4 = float.Parse(Console.ReadLine());

        float media = (numero1+numero2+numero3+numero4)/4;

        Console.WriteLine($"Resultado da média: {media}");
    }
}
