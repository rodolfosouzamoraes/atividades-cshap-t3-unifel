namespace at40;

class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        do{
            Console.WriteLine("Advinhe o um número: ");
            numero = int.Parse(Console.ReadLine());
        }while(numero!=0);

        Console.WriteLine("Acertou miserávi!!!");
    }
}
