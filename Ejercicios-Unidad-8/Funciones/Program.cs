namespace Funciones;

class Program
{
    static void Main(string[] args)
    {
       // int n = devolverUno();
        
        int n1, n2, resultado;

        Console.WriteLine("ingrese un numero:");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese otro:");
        n2 = int.Parse(Console.ReadLine());
        //lógica
        resultado = sumar(n1, n2);
        //fin lógica
        Console.WriteLine("El resultado es: " + resultado);
        //SCOPE
    }

  static int sumar(int a, int b){
    int r;
    r = a + b;
    return r;
    }
}
