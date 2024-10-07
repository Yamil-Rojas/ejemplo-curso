namespace Ejercicios._5;

class Program
{
    static void Main(string[] args)
    {
    // Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares 
    //y el mínimo de los números impares.

    int n, maximopar = 0, minimopar = 0;
    bool banPar = false, banImpar = false;

    for (int x = 0; x < 20; x++)
    {
        Console.WriteLine("Ingrese un número: ");
        n = int.Parse(Console.ReadLine());
        
        if (n % 2 == 0){
            if(banPar == false){
                maximopar = n;
                banPar = true;
            }
            else if(n > maximopar)
                maximopar = n;    

        } else {
           if (banImpar == false){
                minimopar =n;
                banImpar = true;
            }  
            else if (n < minimopar)
                minimopar = n;    
        }
        
    }
        Console.WriteLine("El maximo par es: " + maximopar);
        Console.WriteLine("El minimo par es: "+ minimopar);
    }
}
