namespace Ejercicios._1;

class Program
{
    static void Main(string[] args)
    {
        int n, promedio, suma = 0;

        Console.WriteLine("Ingrese un nro:");
        n = int.Parse(Console.ReadLine());

        for (int x = 0; x < 5; x++)
        {
           
        Console.WriteLine("Ingrese la nota:");
        n = int.Parse(Console.ReadLine());
        suma += n;
        }
        {
        promedio = suma / 5;
        Console.WriteLine("El promedio de nota es: " + promedio);    
        }
      
      
      //for (int x = 0; x < 5; x++){ 
       // Console.WriteLine("Hello, World! " + x );
      //  }
    }
}
