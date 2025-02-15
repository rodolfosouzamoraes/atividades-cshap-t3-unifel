namespace at50;

class Program
{
    static void Main(string[] args)
    {
        Turma turma = new Turma();

        for(int i = 0; i < 5 ;i++){
            Console.WriteLine("Informe a matricula do aluno: ");
            int matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a nota da prova A: ");
            float notaA = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a nota da prova B: ");
            float notaB = float.Parse(Console.ReadLine());

            Aluno novoAluno = new Aluno(matricula,notaA,notaB);
            turma.AdicionarNovoAluno(novoAluno);
        }

        turma.ExibirAlunos();
        turma.ExibirMediaTurma();
        turma.ExibirSituacoes();
    }
}
