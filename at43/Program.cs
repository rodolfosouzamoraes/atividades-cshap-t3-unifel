namespace at43;

class Program
{
    static void Main(string[] args)
    {
        int contagemPositivo = 0;
        int contagemNegativo = 0;
        int numeroLido = 0;
        do{
            Console.WriteLine("Informe um número: ");
            numeroLido = int.Parse(Console.ReadLine());
            if(numeroLido > 0){
                contagemPositivo++;
            }
            else if(numeroLido < 0){
                contagemNegativo++;
            }
        }while(numeroLido != 0);

        Console.WriteLine($"Contagem final dos positivos: {contagemPositivo}");
        Console.WriteLine($"Contagem final dos negativos: {contagemNegativo}");
    }
}
