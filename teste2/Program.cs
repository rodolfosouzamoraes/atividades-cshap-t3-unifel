namespace teste2;

class Program
{
    static void Main()
    {
        Cor corA = new Cor();
        corA.nome = "Branco";
        corA.tipo = "Fosco";

        Cor corB = new Cor();
        corB.nome = "Preto";
        corB.tipo = "Brilhante";

        Cor corC = new Cor();
        corC.nome = "Vermelho";
        corC.tipo = "Brilhante";

        Carro carroA = new Carro("Civic","Sedã","Honda",0,corC,4,true,true,2024);
        Carro carroB = new Carro("Corolla","Sedã","Toyota",10000,corA,4,true,true,2020);

        Carro carroC = new Carro();
        carroC.Nome = "Sentra";
        carroC.Modelo = "Hatch";
        carroC.Marca = "Nissan";
        carroC.Kilometragem = 2000;
        carroC.QtdPortas = 4;
        carroC.Cor = corB;
        carroC.TemABS = true;
        carroC.TemAirBag = true;
        carroC.Ano = 2025;

        List<Carro> carros = new List<Carro>();
        carros.Add(carroA);
        carros.Add(carroB);
        carros.Add(carroC); 

        foreach(Carro carro in carros){
            carro.ExibirDados();
            Console.WriteLine("----------------");
        }
    }
}




