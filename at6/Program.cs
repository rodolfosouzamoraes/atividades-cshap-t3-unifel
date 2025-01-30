namespace at6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe seu peso: ");
        float peso = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe sua altura em metros: ");
        float altura = float.Parse(Console.ReadLine());

        float imc = peso / (altura * altura);

        Console.WriteLine($"Seu IMC: {imc}");
    }
}
