namespace Ejercicios._2;

class Program
{
    static void Main(string[] args)
    {
    //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
    //Se pide determinar e informar:

    //1_ El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
    //2_ Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

    int n, conNumeros; conImpares;
    double porcentajeImpares, porcentajeMaximo = -1;

    for (int x = 0; x < 5; x++)
    {
        conNumeros = 0;
        conImpares = 0;
        n = int.Parse(Console.ReadLine());
        while (n != 0)
        {
        conNumeros++;
        if (n % 2 != 0)
        conImpares++;

        n = int.Parse(Console.ReadLine());
        }

        porcentajeImpares = conImpares * 100 / conNumeros;
        if (porcentajeImpares > porcentajeMaximo){
            porcentajeMaximo = porcentajeImpares;
        }



    }



    }
}
