﻿namespace Ejercicios._4;

class Program
{
    static void Main(string[] args)
    {
    //Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” 
    //que reciba un número por valor y una variable por referencia. 
    //Que analice el número y escriba la variable recibida por referencia con:

    //a. 1 si el número es positivo.
    //b. -1 si el número es negativo.
    //c. 0 si el número es cero.

    int numero, status = 9;
    Console.WriteLine("ingrese un numero");
    numero = int.Parse(Console.ReadLine());

    positivoNegativoCero(numero, ref status);

    Console.WriteLine("El estado del valor " + numero + " es: " + status);
    }
    static void positivoNegativoCero (int n, ref int estado){
        if ( n > 0)
        estado = 1;
        else if ( n == 0)
        estado = 0;
        else 
        estado = -1;

    }
}
