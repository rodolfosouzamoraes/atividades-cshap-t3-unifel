namespace at28;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um valor em terabytes: ");
        int terabytes = int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha uma das opções para poder converter: ");
        Console.WriteLine("0 - para bytes");
        Console.WriteLine("1 - para kilobytes");
        Console.WriteLine("2 - para megabytes");
        Console.WriteLine("3 - para gigabytes");
        Console.WriteLine("Opção escolhida: ");
        int opcao = int.Parse(Console.ReadLine());

        switch(opcao){
            case 0:
            int bytes = terabytes * (int)Math.Pow(1024,4);
            Console.WriteLine($"{bytes}b");
            break;
            case 1:
            int kilobytes = terabytes * (int)Math.Pow(1024,3);
            Console.WriteLine($"{kilobytes}kb");
            break;
            case 2:
            int megabytes = terabytes * (int)Math.Pow(1024,2);
            Console.WriteLine($"{megabytes}mb");
            break;
            case 3:
            int gigabytes = terabytes * 1024;
            Console.WriteLine($"{gigabytes}gb");
            break;
            default:
            Console.WriteLine("Opção inválida!!!");
            break;
        }
    }
}
