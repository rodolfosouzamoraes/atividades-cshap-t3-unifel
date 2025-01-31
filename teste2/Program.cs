namespace teste2;

class Program
{
    static void Main(string[] args)
    {
        int velocidade = 110;
        bool resultado1 =  velocidade > 0 && velocidade < 120;
        //Console.WriteLine(resultado1);

        bool resultado2 = velocidade >= 120 && !(velocidade<=0);
        //Console.WriteLine(resultado2);

        bool resultado3 = velocidade < 0 || velocidade >= 110;
        //Console.WriteLine(resultado3);

        int idade = 17;
        int hora = 21;

        bool resultado4 = (idade >= 18 && idade < 65) && hora <= 21;
        //Console.WriteLine(resultado4);

        bool resultado5 = (hora > 0 && hora < 24) || (hora < 0 && hora > 24);
        //Console.WriteLine(resultado5);

        bool resultado6 = (hora > 4 && idade < 0 || idade == 17) && !(hora != 21);
        Console.WriteLine(resultado6);
    }
}
