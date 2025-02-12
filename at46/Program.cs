namespace at46;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número: ");
        int numeroLido = int.Parse(Console.ReadLine());
        string resultado = ParOuImpar(numeroLido);
        Console.WriteLine($"O {numeroLido} é {resultado}");
    }

    /// <summary>
    /// Método responsável por retornar par ou ímpar sobre o número
    /// </summary>
    /// <param name="numero">Número informado para calcular par ou ímpar</param>
    /// <returns>O valor correspondente</returns>
    static string ParOuImpar(int numero){
        return numero%2 == 0 ? "Par" : "Ímpar";
    }
}
