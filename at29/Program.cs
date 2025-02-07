namespace at29;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[5];
        Console.WriteLine("Informe um nome: ");
        nomes[0] = Console.ReadLine();
        Console.WriteLine("Informe mais um nome: ");
        nomes[1] = Console.ReadLine();
        Console.WriteLine("Informe mais um nome: ");
        nomes[2] = Console.ReadLine();
        Console.WriteLine("Informe mais um nome: ");
        nomes[3] = Console.ReadLine();
        Console.WriteLine("Informe mais um nome: ");
        nomes[4] = Console.ReadLine();

        int numeroSorteado = new Random().Next(0,5);
        Console.WriteLine($"Nome Sorteado: {nomes[numeroSorteado]}");
    }
}
