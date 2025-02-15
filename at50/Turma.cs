public class Turma{
    private List<Aluno> alunos;
    private float media;
    private int totalAprovados;
    private int totalReprovados;

    public Turma(){
        alunos = new List<Aluno>();
    }

    public void AdicionarNovoAluno(Aluno aluno){
        alunos.Add(aluno);
    }

    public void ExibirMediaTurma(){
        media = 0;
        foreach(Aluno aluno in alunos){
            media += aluno.Media;
        }
        media = media/alunos.Count;
        Console.WriteLine($"Média da turma: {media}");
    }

    public void ExibirSituacoes(){
        totalAprovados = 0;
        totalReprovados = 0;
        foreach(Aluno aluno in alunos){
            if(aluno.Situacao == "A"){
                totalAprovados++;
            }
            else{
                totalReprovados++;
            }
        }
        Console.WriteLine($"Total Aprovados: {totalAprovados}");
        Console.WriteLine($"Total Reprovados: {totalReprovados}");
    }

    public void ExibirAlunos(){
        foreach(var aluno in alunos){
            aluno.ExibirDados();
        }
    }
}