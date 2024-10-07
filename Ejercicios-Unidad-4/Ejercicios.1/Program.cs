namespace Ejercicios._1;

class Program
{
    static void Main(string[] args)
    {
        int n1, n2, R;

        Console.WriteLine("Ingrese un número: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        n2 = int.Parse(Console.ReadLine());

        if (n1 == n2) 
            R = n1 + n2;
         else if (n1 > n2)
            R = n1 - n2;
         else R = n1*n2;   
        Console.WriteLine("El resultado es: " + R);    
    }
}
