namespace Ejercicio._3;

class Program
{
    static void Main(string[] args)
    {
    // Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. 
    // Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos 
    //ingresados.

    float dist, velo;
    double tiemp;

    Console.WriteLine("Ingrese la distancia");
    dist = float.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la velocidad");
    velo = float.Parse(Console.ReadLine());

    tiemp = dist/velo;

    Console.WriteLine("El tiempo aproximado de demora es: " + tiemp.ToString("0.00") + "hs.");


    }
}
