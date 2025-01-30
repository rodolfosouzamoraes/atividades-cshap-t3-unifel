namespace at10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe uma temperatura em graus: ");
        float celsius = float.Parse(Console.ReadLine());

        float fahrenheit = celsius * (9/5) + 32;

        Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit}");
    }
}
