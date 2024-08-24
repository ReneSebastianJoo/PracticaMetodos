namespace PracticaMetodos;

internal class Program
{
    static void Main(string[] args)
    {
        //primer = int.Parse(Console.ReadLine());
        //segundo= 
        Mensaje();
        SumaNumeros(15, 25);
        SumaTresNumeros(10,20,30);
    }

    static void Mensaje()
    {
        Console.WriteLine("Primer mensaje en pantalla");
    }

    ////static int Suma(primer, segundo)
    //{

    //    resultado = primer + segundo;
    //    return resultado;
    //}

    static void SumaNumeros(int num1, int num2)
    {
        var resultado = num1 + num2;
        //La siguiente nomencaltura sirve para poder poner strings inteligentes ($"{}")
        Console.WriteLine($"la suma de los numeros es {resultado}");

    }

    static int SumaTresNumeros(int num1, int num2, int num3)
    { 
        var res = num1 + num2 + num3;
        Console.WriteLine($"El resultado de la suma de los tres nuemros es {res}");
        return res;
    }

}
