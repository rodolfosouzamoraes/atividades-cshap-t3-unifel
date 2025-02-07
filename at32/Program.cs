namespace at32;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;
        for(int i = 0; i<3; i++){
            Console.WriteLine("Informe um número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            soma = numero1 + numero2;
            Console.WriteLine($"{numero1} + {numero2} = {soma}");
        }
    }
}
