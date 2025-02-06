namespace at25;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número: ");
        float numero1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe um segundo número: ");
        float numero2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Escolha uma das opções abaixo: ");
        Console.WriteLine("A - Somar");
        Console.WriteLine("B - Dividir");
        Console.WriteLine("C - Subtrair");
        Console.WriteLine("D - Multiplicar");
        Console.WriteLine("Opção escolhida: ");
        string opcao = Console.ReadLine();

        float resultado = 0;

        switch(opcao){
            case "A":
            case "a":
            resultado = numero1 + numero2;
            break;
            case "B":
            case "b":
            resultado = numero1 / numero2;
            break;
            case "C":
            case "c":
            resultado = numero1 - numero2;
            break;
            case "D":
            case "d":
            resultado = numero1 * numero1;
            break;
            default:
            Console.WriteLine("Opção inválida!");
            break;
        }

        Console.WriteLine($"Resultado: {resultado}");
    }
}
