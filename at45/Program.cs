namespace at45;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());
        /*
        if(numero > 0){
            Console.WriteLine("Positivo");
        }
        else if(numero < 0){
            Console.WriteLine("Negativo");
        }
        else {
            Console.WriteLine("Neutro");
        }*/
        Console.WriteLine(numero > 0 ? "Positivo" : numero < 0 ? "Negativo" : "Neutro");
    }
}
