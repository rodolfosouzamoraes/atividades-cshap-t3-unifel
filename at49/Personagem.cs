public class Personagem {
    private int nivel;
    private string nome;
    private string grupo;
    private int vida;
    private int poderAtaque;

    public Personagem(string nome, string grupo){
        this.nome = nome;
        this.grupo = grupo;
        nivel = 1;
        vida = 1200;
        poderAtaque = 100;
    }

    public void ExibirStatus(){
        Console.WriteLine("----Status Personagem----");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Nível: {nivel}");
        Console.WriteLine($"Grupo: {grupo}");
        Console.WriteLine($"Vida: {vida}");
        Console.WriteLine($"PoderAtaque: {poderAtaque}");
        Console.WriteLine("-------------------------");
    }
}