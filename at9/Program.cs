namespace at9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a quantidade de horas: ");
        int horas = int.Parse(Console.ReadLine());
        int minutos = horas * 60;
        Console.WriteLine($"{horas} horas equivale a {minutos} minutos.");
    }
}
