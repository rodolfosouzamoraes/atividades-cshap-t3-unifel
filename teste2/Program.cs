namespace teste2;

class Program
{
    static void Main(string[] args)
    {
        float[] numeros = new float[5];
        numeros[0] = 90;
        numeros[1] = 7;
        numeros[2] = 8;
        numeros[3] = 14;
        numeros[4] = 27;

        float soma = numeros[0] + numeros[4];
        float subtracao = numeros[2] - numeros[1];
        float multiplicacao = numeros[4] * numeros[4];
        float divisao = numeros[0] / numeros[3];

        Console.WriteLine($"{numeros[0]} + {numeros[4]} = {soma}");
        Console.WriteLine($"{numeros[2]} - {numeros[1]} = {subtracao}");
        Console.WriteLine($"{numeros[4]} * {numeros[4]} = {multiplicacao}");
        Console.WriteLine($"{numeros[0]} / {numeros[3]} = {divisao}");
    }
}
