public class IMC{
    private string nome;
    private float pesoKg;
    private float alturaM;
    private float calculoIMC;

    public IMC(string nome, float pesoKg, float alturaM){
        this.nome = nome;
        this.pesoKg = pesoKg;
        this.alturaM = alturaM;
        CalcularIMC();
    }

    private void CalcularIMC(){
        calculoIMC = pesoKg / (alturaM * alturaM);
    }

    public void ExibirResultadoIMC(){
        Console.WriteLine($"Olá {nome}, veja seu resultado abaixo:");
        if(calculoIMC < 18.5f){Console.WriteLine("Magreza 0");}
        else if(calculoIMC >= 18.5f && calculoIMC < 25){Console.WriteLine("Normal 0");}
        else if(calculoIMC >= 25 && calculoIMC < 30){Console.WriteLine("Sobrepeso I");}
        else if(calculoIMC >= 30 && calculoIMC < 40){Console.WriteLine("Obesidade II");}
        else{Console.WriteLine("Obesidade III");}
    }
}