namespace at16;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número:");
        int numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        int diferenca = numero1 - numero2;
        Console.WriteLine($"{Math.Abs(diferenca)}");
    }
}
