namespace teste2;

class Program
{
    /// <summary>
    /// Método principal
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Informe um número: ");
        int primeiroNumero = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe um segundo número: ");
        int segundoNumero = int.Parse(Console.ReadLine());
        var resultado = SomarDoisNumeros(primeiroNumero,segundoNumero);   
        Console.WriteLine($"{primeiroNumero} + {segundoNumero} = {resultado}");
    }

    /// <summary>
    /// Método para somar numeros
    /// </summary>
    static int SomarDoisNumeros(int numero1, int numero2 = 0){
        return numero1 + numero2;
    }
}




