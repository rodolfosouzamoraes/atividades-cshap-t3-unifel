namespace at42;

class Program
{
    static void Main(string[] args)
    {
        float valoresSomados = 0;
        float contagem = 0;
        float numeroInformado = 0;
        float media;

        //Ler os números enquanto for positivo
        while(numeroInformado >= 0){
            Console.WriteLine("Informe um número: ");
            numeroInformado = float.Parse(Console.ReadLine());
            if(numeroInformado >=0){
                valoresSomados += numeroInformado;
                contagem++;
            }
        }

        //Calcular a média dos numeros positivos lidos
        media = valoresSomados/contagem;

        Console.WriteLine($"Média dos valores positivos: {media}");
    }
}
