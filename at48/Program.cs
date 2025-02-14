namespace at48;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Informe seu peso: ");
        float peso = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe sua altura: ");
        float altura = float.Parse(Console.ReadLine());

        IMC imc = new IMC(nome,peso,altura);
        imc.ExibirResultadoIMC();
    }
}
