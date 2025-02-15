public class Aluno{
    private int matricula;
    private float notaA;
    private float notaB;
    private float media;
    private string situacao;

    public float Media{
        get{return media;}
    }

    public string Situacao{
        get{return situacao;}
    }

    public Aluno(int matricula, float notaA, float notaB){
        this.matricula = matricula;
        this.notaA = notaA;
        this.notaB = notaB;
        CalcularMedia();
        CalcularSituacao();
    }

    private void CalcularMedia(){
        media = (notaA + notaB)/2;
    }

    private void CalcularSituacao(){
        situacao = media >= 7 ? "A" : "R";
    }

    public void ExibirDados(){        
        Console.WriteLine($"Aluno: {matricula}");
        Console.WriteLine($"Prova A: {notaA}");
        Console.WriteLine($"Prova B: {notaB}");
        Console.WriteLine($"Média: {media}");
        Console.WriteLine($"Situação: {situacao}");
        Console.WriteLine("------------------");
    }
}