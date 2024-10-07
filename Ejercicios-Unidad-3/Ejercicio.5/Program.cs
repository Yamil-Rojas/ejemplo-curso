namespace Ejercicio._5;

class Program
{
    static void Main(string[] args)
    {
       //Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

        int n1, n2, n3, n4;
        Console.WriteLine("Ingrese el primer número");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer número");
        n3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el cuarto número");
        n4 = int.Parse(Console.ReadLine());

        if (n1 > 100)
        Console.WriteLine("El primer valor: " + n1 + " es mayor a 100");
        if (n2 > 100)
        Console.WriteLine("El segundo valor: " + n2 + " es mayor a 100");
        if (n3 > 100)
        Console.WriteLine("El tercer valor: " + n3 + " es mayor a 100" );
        if (n4 > 100)
        Console.WriteLine("El cuarto valor: " + n4 + " es mayor a 100");

         
       /* if (n2 > 100){
        Console.WriteLine(n2);
        } else {}
        if (n3 > 100){
        } else {}
        if (n4 > 100){
        } else {}
       // Console.WriteLine("Los mayores de 100 son: ", n1, n2, n3, n4);*/


    }
}
