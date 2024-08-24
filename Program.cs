namespace PracticaMetodos;

internal class Program
{
    static void Main(string[] args)
    {
        //primer = int.Parse(Console.ReadLine());
        //segundo= 
        Mensaje();
        SumaNumeros(15, 25);
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

}
