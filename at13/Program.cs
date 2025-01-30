namespace at13;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número: ");
        int menorNumero = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe um número maior que o anterior: ");
        int maiorNumero = int.Parse(Console.ReadLine());

        int numeroSorteado = new Random().Next(menorNumero,maiorNumero+1);

        Console.WriteLine($"Número sorteado entre {menorNumero} e {maiorNumero} foi {numeroSorteado}");
    }
}
