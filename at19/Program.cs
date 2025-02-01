namespace at19;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        if(numero > 0){
            Console.WriteLine("O número é positivo!!!");
        }
        else if(numero < 0){
            Console.WriteLine("O número é negativo!!!");
        }
        else {
            Console.WriteLine("O número é neutro!!!");
        }
    }
}
