﻿namespace Ejercicios._1;

class Program
{
    static void Main(string[] args)
    {
    // CICLOS COMBINADOS

    //Hacer un programa para ingresar 10 números. 
    //El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.    

    int n, con, acu = 0;

   

    for (int x = 0; x < 5; x++)
    {
        Console.WriteLine("Ingrese un número: ");
        n = int.Parse(Console.ReadLine());
        
        con = 0;
        for (int y = 1; y <= n; y++) 
        {
            if (n % y == 0)
                con++;
        }        
            if (con == 2)
                acu++; 
        
                    
    }
        
        Console.WriteLine("Primos son: " + acu + " números");
         
        

    }
}
