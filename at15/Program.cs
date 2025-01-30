namespace at15;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculo de Bhaskara!");
        Console.WriteLine("Informe o valor de A:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a letra B: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a letra C: ");
        double c = double.Parse(Console.ReadLine());

        double delta = Math.Pow(b,2) - (4 * a * c);

        double x1 = (-b + Math.Sqrt(delta))/(2*a);
        double x2 = (-b - Math.Sqrt(delta))/(2*a);

        Console.WriteLine($"x1 = {x1}");
        Console.WriteLine($"x2 = {x2}");
    }
}
