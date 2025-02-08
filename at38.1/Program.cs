namespace at38._1;

class Program
{
    static void Main(string[] args)
    {                //0,1,2,3,4,5,6
        int[] votos = {0,0,0,0,0,0,0};
        string[] opcoes = {
            "",
            "Cadidato Marcos", 
            "Candidato João", 
            "Candidata Paula",
            "Candidata Joana",
            "Voto Nulo",
            "Voto em Branco"
            };

        for(int i = 0; i < 5; i++){
            Console.WriteLine("Informe seu voto entre uma das possibilidades: ");
            
            for(int j = 1; j<opcoes.Length; j++){
                Console.WriteLine($"{j}. {opcoes[j]}");
            }

            Console.WriteLine("Seu Voto: ");
            int voto = int.Parse(Console.ReadLine());
            if(voto>=1 && voto <=6){
                votos[voto]++;
            }
            else{
                Console.WriteLine("Voto Inválido!!");
                i--;
            }
        }

        for(int i = 1; i <= 4;i++){
            Console.WriteLine($"Total de votos candidato {i}: {votos[i]}");
        }
        
        Console.WriteLine($"Total de votos nulos: {votos[5]}");
        Console.WriteLine($"Total de votos em branco: {votos[6]}");
    }
}
