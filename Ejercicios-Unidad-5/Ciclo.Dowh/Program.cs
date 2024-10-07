namespace Ciclo.Dowh;

class Program
{
    static void Main(string[] args)
    {
       int n, con = 0;

       do
       {
        Console.WriteLine("Ingrese un número: ");
        n = int.Parse(Console.ReadLine());
        con++;
       } while (n != 0);

       Console.WriteLine("Ingresaste: " + con + " nros.");

       //a diferencia del ciclo While, este ciclo da una vuelta (do) y despues entra en el while
       //entonces da vueltas, hasta que se le de el corte. 
       
    }
}
