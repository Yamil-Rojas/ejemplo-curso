namespace Ejercicios._1;

class Program
{
    static void Main(string[] args)
    {
    //Hacer un programa que solicite 10 (5) números enteros y los guarde en un vector. 
    //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.    
    
    
    int posicion = 1;
    int [] numeros = new int[10];
    int max = numeros[0];
    for (int x = 0; x < 5; x++)
    {
        Console.WriteLine("Ingrese un número: ");
        numeros [x] = int.Parse(Console.ReadLine());

    }
    for (int x = 0; x < 5; x++)
    {
        if (numeros[x] > max){
        max = numeros[x];
        posicion = x + 1;
        }
    }
    Console.WriteLine("El máximo es: " + max);
    Console.WriteLine("Y su posición es: " + posicion);
    
    
    
    
    }
}
