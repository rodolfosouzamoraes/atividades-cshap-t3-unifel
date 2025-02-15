namespace at49;

class Program
{
    static List<Personagem> personagens = new List<Personagem>();
    static string[] grupos = {"","Mago","Arqueiro","Guerreiro","Cavaleiro"};
    static string nome;
    static int opcao;
    static void Main(string[] args)
    {
        Console.WriteLine("Criação de Personagem");
        Console.WriteLine("Informe a quantidade de personagem que deseja criar: ");
        int qtdPersonagens = int.Parse(Console.ReadLine());

        CriarPersonagens(qtdPersonagens);

        ExibirPersonagens();
    }

    static void CriarPersonagens(int quantidade){
        for(int i = 0; i<quantidade;i++){
            Console.WriteLine("Informe o nome do personagem: ");
            nome = Console.ReadLine();
            Console.WriteLine("Escolha um dos grupos abaixo: ");
            Console.WriteLine("1 - Mago");
            Console.WriteLine("2 - Arqueiro");
            Console.WriteLine("3 - Guerreiro");
            Console.WriteLine("4 - Cavaleiro");
            Console.WriteLine("Opção Escolhida: ");
            opcao = int.Parse(Console.ReadLine());
            if(opcao >=1 && opcao <=4){
                Personagem personagem = new Personagem(nome,grupos[opcao]);
                personagens.Add(personagem);
            }
            else{
                Console.WriteLine("Opção inválida!!! \n---------\n");
                i--;
            }
        }
    }

    static void ExibirPersonagens(){
        foreach(Personagem personagem in personagens){
            personagem.ExibirStatus();
        }
    }
}
