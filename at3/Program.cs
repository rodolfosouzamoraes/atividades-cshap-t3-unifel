namespace at3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe sua idade em anos: ");
        int idade = int.Parse(Console.ReadLine());
        int dias = idade * 365;
        Console.WriteLine($"Você já viveu {dias} dias.");
    }
}
