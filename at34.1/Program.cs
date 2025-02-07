namespace at34._1;

class Program
{
    static void Main(string[] args)
    {
        int[] megasena = {0,0,0,0,0,0};
        bool numeroJaSorteado = false;

        for(int i = 0; i < megasena.Length ;i++){ //Repetir 6x i=1
            int numeroSorteado = new Random().Next(1,61); //9
            for(int j = 0; j< megasena.Length ;j++){//Vai repetir para poder verificar se o numero já existe
                if(megasena[j] == numeroSorteado){ //Verifica se o numero sorteado é o mesmo que está na posição da variavel megasena.
                    numeroJaSorteado = true;//Atribuo true para simbolizar que o numero já foi sorteado anteriormente.
                }
            }
            
            if(numeroJaSorteado == true){ //Verifica se o numero já foi sorteado
                i--;//Retrocede o loop i=0
                numeroJaSorteado = false;//Reseta a variavel para verificar novamente o numero já sorteado.
            }
            else{
                megasena[i] = numeroSorteado; //Armazena o número sorteado no vetor megasena
                //Console.WriteLine(megasena[i]);//exibe o número sorteado
            }
        }

        int[] numerosOrdenados = megasena.Order().ToArray();
        for(int i = 0; i<megasena.Length ; i++){
            Console.WriteLine(numerosOrdenados[i]);
        }
    }
}
