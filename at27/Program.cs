namespace at27;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha uma das opções abaixo: ");
        Console.WriteLine("1");
        Console.WriteLine("2");
        Console.WriteLine("3");
        Console.WriteLine("4");
        Console.WriteLine("Opção escolhida: ");
        string opcao = Console.ReadLine();

        switch(opcao){
            case "1":
            Console.WriteLine("Hackeando servidores da Nasa...");
            break;
            case "2":
            Console.WriteLine("Acessando banco de dados da CIA...");
            break;
            case "3":
            Console.WriteLine("Liberando impostos do PS5 pro...");
            break;
            case "4":
            Console.WriteLine("Derrubando site do FBI...");
            break;
            default:
            Console.WriteLine("Opção Inválida!!!");
            break;
        }

        Console.WriteLine("Processo concluído.");
    }
}
