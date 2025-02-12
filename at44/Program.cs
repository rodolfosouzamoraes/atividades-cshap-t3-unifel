namespace at44;

class Program
{
    static void Main(string[] args)
    {
        int contagemErro = 0;
        while(true){
            Console.WriteLine("Login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Senha: ");
            string senha = Console.ReadLine();
            
            if(login == "1134" && senha == "Tf002Kj"){
                Console.WriteLine("Acesso Permitido!");
                break;
            }
            else{                
                contagemErro++;
                if(contagemErro == 3){
                    Console.WriteLine("Acesso Bloqueado!");
                    break;
                }
                else{
                    Console.WriteLine("Acesso Negado!");
                }
            }
        }
    }
}
