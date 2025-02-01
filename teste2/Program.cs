namespace teste2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        switch(numero){
            case 1: //if(numero == 1 || numero == 2 || numero == 3)
            case 2:
            case 3:
            Console.WriteLine(numero);
            break;
            case 10:
            case 11:
            case 12:
            case 14:
            Console.WriteLine(numero);
            break;
        }
    }
}
