namespace at23;

class Program
{
    static void Main(string[] args)
    {
        float despesas = 2000;
        Console.WriteLine("Informe o valor do ingresso: ");
        float ingresso = float.Parse(Console.ReadLine());
        float valorTotal = ingresso * 120;
        
        if(valorTotal > despesas){
            float lucro = valorTotal - despesas;
            Console.WriteLine($"Lucro final: {Math.Round(lucro,2)}");
        }
        else {
            Console.WriteLine("Não houve lucro!!!");
        }
    }
}
