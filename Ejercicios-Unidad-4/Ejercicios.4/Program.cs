namespace Ejercicios._4;

class Program
{
    static void Main(string[] args)
    {
     //  Hacer un programa para ingresar tres números y emitir un cartel aclaratorio 
     //  si la suma de los dos primeros es mayor al producto del segundo con el tercero.

     int a, b, c;

     Console.WriteLine("Ingrese un número");
     a = int.Parse(Console.ReadLine());
     Console.WriteLine("Ingrese un número");
     b = int.Parse(Console.ReadLine());
     Console.WriteLine("Ingrese un número");
     c = int.Parse(Console.ReadLine());

     if (a + b > b * c)
        Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero");
        else {}
        

    }
}
