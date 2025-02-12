namespace at41;

class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        while(numero <= 1000){
            Console.WriteLine("Informe um número: ");
            numero += int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Número acumulado: {numero}");
    }
}
