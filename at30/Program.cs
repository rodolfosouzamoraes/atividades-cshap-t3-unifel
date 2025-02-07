namespace at30;

class Program
{
    static void Main(string[] args)
    {
        string[] funcoes = new string[] {
        "", //0
        "Hackear servidores da nasa.", // 1
        "Acessar bando de dados da CIA", //2
        "Liberar Impostos do PS5 PRO", //3
        "Derrubar site do FBI" //4
        };

        Console.WriteLine("Escolha uma das opções: ");
        Console.WriteLine($"1 - {funcoes[1]}");
        Console.WriteLine($"2 - {funcoes[2]}");
        Console.WriteLine($"3 - {funcoes[3]}");
        Console.WriteLine($"4 - {funcoes[4]}");
        Console.WriteLine("Opção escolhida: ");
        int opcao = int.Parse(Console.ReadLine());

        if(opcao >= 1 && opcao<=4){
            Console.WriteLine(funcoes[opcao]);
        }
        else{
            Console.WriteLine("Opção Inválida!!!");
        }
    }
}
