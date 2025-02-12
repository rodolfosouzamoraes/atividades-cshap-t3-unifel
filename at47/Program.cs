namespace at47;

class Program
{
    static void Main(string[] args)
    {
        ObterDadosUsuario();
        Console.WriteLine("Fim do programa!!");
    }

    static void ObterDadosUsuario(){
        Console.WriteLine("Informe um valor: ");
        float valor1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe um segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        MenuDeOpcoes();
        DefinirOpcao(valor1,valor2);
    }

    static void DefinirOpcao(float valor1, float valor2){
        string opcao = Console.ReadLine().ToUpper();
        float resultado = 0;
        switch(opcao){
            case "A":
            resultado = Somar(valor1, valor2);
            break;
            case "B":
            resultado = Dividir(valor1, valor2);
            break;
            case "C":
            resultado = Subtrair(valor1, valor2);
            break;
            case "D":
            resultado = Multiplicar(valor1,valor2);
            break;
            default:
            Console.WriteLine("Opção inválida!!!");
            break;
        }
        Console.WriteLine(resultado);
    }

    static void MenuDeOpcoes(){
        Console.WriteLine("Escolha uma das opções abaixo: ");
        Console.WriteLine("A - Somar");
        Console.WriteLine("B - Dividir");
        Console.WriteLine("C - Subtrair");
        Console.WriteLine("D - Multiplicar");
        Console.WriteLine("Opção escolhida: ");
    }

    static float Somar(float valor1, float valor2){
        return valor1 + valor2;
    }

    static float Dividir(float valor1, float valor2){
        return valor1/valor2;
    }

    static float Subtrair(float valor1, float valor2){
        return valor1 - valor2;
    }

    static float Multiplicar(float valor1, float valor2){
        return valor1 * valor2;
    }
}
