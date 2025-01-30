namespace at7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o raio do círculo:");
        
        float raio = float.Parse(Console.ReadLine());
        float pi = 3.14159f;
        float area = pi * (raio*raio);

        Console.WriteLine($"Área do Círculo: {area}");
    }
}
