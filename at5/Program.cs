namespace at5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o dia que você nasceu: ");
        int dia = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o mês de nascimento: ");
        int mes = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o ano de nascimento: ");
        int ano = int.Parse(Console.ReadLine());

        Console.WriteLine($"{dia}/{mes}/{ano}");
    }
}
