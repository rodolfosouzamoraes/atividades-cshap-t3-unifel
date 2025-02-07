namespace at34;

class Program
{
    static void Main(string[] args)
    {
        for(int i = 1; i<=10 ; i++){
            Console.WriteLine("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());
            if(numero > 0){
                Console.WriteLine($"{numero} é Positivo!!!");
            }
            else if(numero < 0){
                Console.WriteLine($"{numero} é negativo!!!");
            }
            else{
                Console.WriteLine($"{numero} é neutro!!!");
            }
        }
    }
}
