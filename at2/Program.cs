namespace at2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número: ");
        float numero1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe um segundo número: ");
        float numero2 = float.Parse(Console.ReadLine());

        float soma = numero1 + numero2;
        float subtracao = numero1 - numero2;
        float multiplicacao = numero1 * numero2;
        float divisao = numero1 / numero2;

        Console.WriteLine($"Soma: {numero1} + {numero2} = {soma}");
        Console.WriteLine($"Subtração: {numero1} - {numero2} = {subtracao}");
        Console.WriteLine($"Multiplicação: {numero1} * {numero2} = {multiplicacao}");
        Console.WriteLine($"Divisão: {numero1} / {numero2} = {divisao}");
    }
}
