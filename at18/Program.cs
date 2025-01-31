namespace at18;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o raio da circunferência:");
        double raio = double.Parse(Console.ReadLine());
        double pi = 3.14159;
        double area = pi * Math.Pow(raio,2);

        Console.WriteLine($"{area}");
    }
}
