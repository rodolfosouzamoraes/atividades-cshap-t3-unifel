public class Carro{
    private string nome;
    private string modelo;
    private string marca;
    private int kilometragem;
    private Cor cor;
    private int qtdPortas;
    private bool temAirBag;
    private bool temABS;
    private int ano;    

    //Propriedade da variavel nome
    public string Nome {
        get {return nome;}
        set {nome = value;}
    }

    public string Modelo {
        get {return modelo;}
        set {modelo = value;}
    }

    public string Marca {
        get {return marca;}
        set {marca = value;}
    }

    public int Kilometragem {
        get {return kilometragem;}
        set {kilometragem = value;}
    }

    public Cor Cor {
        get {return cor;}
        set {cor = value;}
    }

    public int QtdPortas {
        get {return qtdPortas;}
        set {qtdPortas = value;}
    }

    public bool TemAirBag {
        get {return temAirBag;}
        set {temAirBag = value;}
    }

    public bool TemABS {
        get {return temABS;}
        set {temABS = value;}
    }

    public int Ano {
        get {return ano;}
        set {ano = value;}
    }

    /// <summary>
    /// Definindo um construtor pra classe
    /// </summary>
    public Carro(string nome, string modelo, string marca, int kilometragem, Cor cor, int qtdPortas,
    bool temAirBag, bool temABS, int ano){
        this.nome = nome;
        this.modelo = modelo;
        this.marca = marca;
        this.kilometragem = kilometragem;
        this.cor = cor;
        this.qtdPortas = qtdPortas;
        this.temAirBag = temAirBag;
        this.temABS = temABS;
        this.ano = ano;
    }

    /// <summary>
    /// Construtor padrão da classe
    /// </summary>
    public Carro(){

    }

    public void ExibirDados(){
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Modelo : {modelo}");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"KM: {kilometragem}");
        Console.WriteLine($"Cor Nome: {cor.nome}");
        Console.WriteLine($"Cor Tipo: {cor.tipo}");
        Console.WriteLine($"Quantidade de Portas: {qtdPortas}");
        Console.WriteLine($"Se tem Airbag: {(temAirBag == true ? "Sim" : "Não")}");
        Console.WriteLine($"Se tem ABS: {(temABS == true ? "Sim" : "Não")}");
        Console.WriteLine($"Ano: {ano}");
    }
}