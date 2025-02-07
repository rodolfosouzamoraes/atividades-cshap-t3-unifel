namespace at37;

class Program
{
    static void Main(string[] args)
    {
        float totalSalMasc = 0; //Total Salário Masculino
        float totalSalFem = 0; //Total Salário Feminino
        float mediaSalMasc = 0; //Média do Salário Masculino
        float mediaSalFem = 0; // Média do Salário Feminino
        int qtdAte1000Masc = 0; // Quantidade de Salários até 1000 Masculino
        int qtdAte1000Fem = 0; // Quantidade de Salários até 1000 Feminino
        int qtdMasc = 0; // Quantidade de pessoas Masculinas lidas
        int qtdFem = 0; // Quantidade de pessoas Femininas lidas
        int[] idade = new int[10]; //Idades lidas

        for(int i = 0 ; i< idade.Length ; i++){
            Console.WriteLine("Informe sua idade: ");
            idade[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu Salário: ");
            float salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma das opções abaixo: ");
            Console.WriteLine("0 - Masculino");
            Console.WriteLine("1 - Feminino");
            Console.WriteLine("Opção escolhida: ");
            int opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 0: // Masculino
                    qtdMasc++;
                    totalSalMasc += salario;
                    if(salario<= qtdAte1000Masc){
                        qtdAte1000Masc++;
                    }
                break;
                case 1: // Feminino
                    qtdFem++;
                    totalSalFem += salario;
                    if(salario<= qtdAte1000Fem){
                        qtdAte1000Fem++;
                    }
                break;
                default:
                Console.WriteLine("A opção está inválida!");
                break;
            }
        }

        mediaSalMasc = totalSalMasc/qtdMasc;
        mediaSalFem = totalSalFem/qtdFem;

        Console.WriteLine($"Média salário Masculino: R${mediaSalMasc}");
        Console.WriteLine($"Média salário Feminino: R${mediaSalFem}");
        Console.WriteLine($"Qtd salário até R$1000 Feminino: {qtdAte1000Fem}");
        Console.WriteLine($"Qtd salário até R$1000 Masculino: {qtdAte1000Masc}");     
    }
}
