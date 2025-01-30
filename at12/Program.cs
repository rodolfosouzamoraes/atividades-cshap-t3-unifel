namespace at12;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int numeroAleatorio = rand.Next(0,101);
        Console.WriteLine($"Número sorteado: {numeroAleatorio}");
    }
}
