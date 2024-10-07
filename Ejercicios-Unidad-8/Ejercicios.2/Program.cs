namespace Ejercicios._2;

class Program
{
    static void Main(string[] args)
    {
    //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
    //Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.    

    int n1, pares = 0;

    
    for (int x = 0; x < 4; x++)
    {
         Console.WriteLine("Ingrese un número: ");
        n1 = int.Parse(Console.ReadLine());
        if(par(n1))
        pares++;
    }
   
    Console.WriteLine("Los numeros pares son: " + pares);

    }
    static bool par (int a){
    int r;    
    if (a % 2 == 0)
         return true;
    else
         return false; 
    
                
    }
}
