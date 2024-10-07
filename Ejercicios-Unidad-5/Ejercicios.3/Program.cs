namespace Ejercicios._3;

class Program
{
    static void Main(string[] args)
    {
    //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

    int edad, con = 0, acu = 0, promedio;

    for (int x = 0; x < 5; x++)
    {
     Console.WriteLine("Ingrese la edad: ");
     edad = int.Parse(Console.ReadLine());

     if (edad > 18){
     acu += edad;
     con++; 
     }
    }
    {
    promedio = acu / con;
    Console.WriteLine("El promedio de edad es: " + promedio);
    }
    }
}
