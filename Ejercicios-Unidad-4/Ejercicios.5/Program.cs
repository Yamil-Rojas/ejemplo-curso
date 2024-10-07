namespace Ejercicios._5;

class Program
{
    static void Main(string[] args)
    {
    // Hacer un programa para ingresar 4 números. 
    //Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .
    
    int a, b, c, d;

    Console.WriteLine("Ingrese un número");
     a = int.Parse(Console.ReadLine());
     Console.WriteLine("Ingrese un número");
     b = int.Parse(Console.ReadLine());
     Console.WriteLine("Ingrese un número");
     c = int.Parse(Console.ReadLine());
     Console.WriteLine("Ingrese un número");
     d = int.Parse(Console.ReadLine());
     
     if (a > b && b > c && c > d)
     Console.WriteLine("Decreciente");
     else {
       Console.WriteLine("No está ordenado");
      
     }

    }
}
