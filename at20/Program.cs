namespace at20;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());
        int restoDivisao = numero%2;
        if(restoDivisao == 0){
            Console.WriteLine("O número é Par.");
        }
        else{
            Console.WriteLine("O número é Ímpar.");
        }
    }
}
