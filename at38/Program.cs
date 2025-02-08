namespace at38;

class Program
{
    static void Main(string[] args)
    {
        int candidato1 = 0;
        int candidato2 = 0;
        int candidato3 = 0;
        int candidato4 = 0;
        int votoNulo = 0;
        int votoBranco = 0;

        for(int i = 0; i < 5; i++){
            Console.WriteLine("Informe seu voto entre uma das possibilidades: ");
            Console.WriteLine("1. Candidato Marcos");
            Console.WriteLine("2. Candidato João");
            Console.WriteLine("3. Candidata Paula");
            Console.WriteLine("4. Candidata Joana");
            Console.WriteLine("5. Voto Nulo");
            Console.WriteLine("6. Voto em Branco");
            Console.WriteLine("Seu Voto: ");
            int voto = int.Parse(Console.ReadLine());
            switch(voto){
                case 1: candidato1++;
                break;
                case 2: candidato2++;
                break;
                case 3: candidato3++;
                break;
                case 4: candidato4++;
                break;
                case 5: votoNulo++;
                break;
                case 6: votoBranco++;
                break;
                default: Console.WriteLine("Voto inválido!"); i--;
                break;
            }
        }

        Console.WriteLine($"Total de votos candidato 1: {candidato1}");
        Console.WriteLine($"Total de votos candidato 2: {candidato2}");
        Console.WriteLine($"Total de votos candidato 3: {candidato3}");
        Console.WriteLine($"Total de votos candidato 4: {candidato4}");
        Console.WriteLine($"Total de votos nulos: {votoNulo}");
        Console.WriteLine($"Total de votos em branco: {votoBranco}");
    }
}
