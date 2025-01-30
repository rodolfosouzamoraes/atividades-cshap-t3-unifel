namespace at11;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a quantidade de horas trabalhadas por semana: ");
        float horas = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor pago por hora: ");
        float valorHora = float.Parse(Console.ReadLine());

        float salarioSemanal = horas * valorHora;
        float salarioMensal = salarioSemanal * 4;

        Console.WriteLine($"Seu sálario semanal R${Math.Round(salarioSemanal,2)}");
        Console.WriteLine($"Seu sálario mensal R${Math.Round(salarioMensal,2)}"); 
    }
}
