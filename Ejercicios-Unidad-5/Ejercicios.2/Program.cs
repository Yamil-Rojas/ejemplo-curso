﻿namespace Ejercicios._2;

class Program
{
    static void Main(string[] args)
    {
    // Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla.
    // Solo se debe emitir UN valor por pantalla.
    
    int n, max = 0;

    for (int x = 0; x < 5; x++)
    {
       Console.WriteLine("Ingrese un nro: ");
       n = int.Parse(Console.ReadLine()); 
       if (x == 0)
        max = n;
       else {
       if (n > max)
       max = n;
       }
    }
        Console.WriteLine("El mayor es: " + max);
    


    
    }
}
