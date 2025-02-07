namespace teste2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número que o programa deva começar a contar:");
        int numeroInicial = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe um número até onde o programa deve contar: ");
        int numeroFinal = int.Parse(Console.ReadLine());
        for(int i = numeroInicial; i<=numeroFinal ;i++){
            Console.WriteLine(i);
        }
        
    }
}
