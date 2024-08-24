namespace PracticaMetodos;

 class Program
{
   
    static void Main(string[] args)
    {
        //primer = int.Parse(Console.ReadLine());
        //segundo= 
        Mensaje();
        SumaNumeros(15, 25);
        SumaTresNumeros(10,20,30);
        Divide2Numeros(3, 5);
        Console.WriteLine(Multiplicacion(3, 5));
        Console.WriteLine(Multiplicacion(15.5, 23.7));
        Console.WriteLine(Multiplicacion(3, 5, 7));

    }

    static void Mensaje()
    {
        Console.WriteLine("Primer mensaje en pantalla");
    }

    static void SumaNumeros(int num1, int num2)
    {
        var resultado = num1 + num2;
        //La siguiente nomencaltura sirve para poder poner strings inteligentes ($"{}")
        Console.WriteLine($"la suma de los numeros es {resultado}");

    }

    static int SumaTresNumeros(int num1, int num2, int num3)
    { 
        var res = num1 + num2 + num3;
        //La diferencia con el anterior es que con este si se devuelve el valor del resultado para que pueda utilizarse más tarde
        Console.WriteLine($"El resultado de la suma de los tres nuemros es {res}");
        return res;
    }

    static double Divide2Numeros(double num1, double num2)
    {
        var result = num1 / num2;
        Console.WriteLine($"el resultado de la divisón es de {result}");
        return result;
    }
    //Sobre carga de metodos
    static int Multiplicacion(int operador1, int operador2) => operador1 * operador2;
    static double Multiplicacion(double num1, double num2) => num1 * num2;

    static int Multiplicacion(int op1, int op2, int op3) => op1 * op2 * op3;



}
