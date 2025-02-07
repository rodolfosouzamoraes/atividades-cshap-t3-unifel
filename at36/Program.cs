namespace at36;

class Program
{
    static void Main(string[] args)
    {
        //Declarações da variáveis utilizadas no programa
        float[] temposVoltas = new float[5];
        float melhorTempo = 0;
        int voltaMelhorTempo = 0;
        float media = 0;

        //Lendo e definindo a primeira volta como a melhor volta
        Console.WriteLine("Informe o tempo da volta: ");
        temposVoltas[0] = float.Parse(Console.ReadLine());
        melhorTempo = temposVoltas[0];
        voltaMelhorTempo = 1;

        //Ler as demais voltas
        for(int i = 1; i<temposVoltas.Length ; i++){
            Console.WriteLine("Informe o tempo da volta: ");
            float tempoVolta = float.Parse(Console.ReadLine());
            
            //Atualiza o tempo da melhor volta assim como a volta melhor
            if(tempoVolta < melhorTempo){
                melhorTempo = tempoVolta;
                voltaMelhorTempo = i+1;
            }

            //Armazenar o tempo da volta no vetor
            temposVoltas[i] = tempoVolta;
        }

        //Calcular a média
        for(int i = 0; i < temposVoltas.Length ; i++){
            media += temposVoltas[i];
        }
        media = media / temposVoltas.Length;

        //Exibir os resultados
        Console.WriteLine($"Melhor tempo de volta: {melhorTempo}s");
        Console.WriteLine($"Melhor volta: {voltaMelhorTempo}");
        Console.WriteLine($"Média dos tempos de volta: {media}");
    }
}
