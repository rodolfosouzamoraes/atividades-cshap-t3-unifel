namespace at21;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número: ");
        float numero1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe um segundo número: ");
        float numero2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Escolha uma das opções: ");
        Console.WriteLine("A - Somar");
        Console.WriteLine("B - Dividir");
        Console.WriteLine("C - Subtrair");
        Console.WriteLine("D - Multiplicar");
        Console.WriteLine("Opção Escolhida: ");
        string opcao = Console.ReadLine();

        float resultado = 0;
        if(opcao == "A" || opcao == "a"){
            resultado = numero1 + numero2;
        }
        else if(opcao == "B" || opcao == "b"){
            resultado = numero1 / numero2;
        }
        else if(opcao == "C" || opcao == "c"){
            resultado = numero1 - numero2;
        }
        else if(opcao == "D" || opcao == "d"){
            resultado = numero1 * numero2;
        }
        else{
            Console.WriteLine("Opção inválida, tente novamente mais tarde!");
        }

        Console.WriteLine($"Resultado: {resultado}");
    }
}
