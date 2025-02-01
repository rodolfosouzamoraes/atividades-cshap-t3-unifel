namespace at24;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a primeira nota: ");
        float nota1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe a segunda nota: ");
        float nota2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe a terceira nota: ");
        float nota3 = float.Parse(Console.ReadLine());

        float media = (nota1 + nota2 + nota3)/3;

        Console.WriteLine("Informe sua frequência: ");
        float frequencia = float.Parse(Console.ReadLine());

        if(frequencia < 75){
            Console.WriteLine("Aluno reprovado por frequência!");
        }
        else{
            if(media >= 60){
                Console.WriteLine("Aluno aprovado por nota!");
            }
            else if(media >= 40){
                Console.WriteLine("Aluno de recuperação!");
            }
            else{
                Console.WriteLine("Aluno reprovado por nota.");
            }
        }
    }
}
