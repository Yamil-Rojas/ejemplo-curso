namespace Ejercicios._4;

class Program
{
    static void Main(string[] args)
    {
//Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro
// con los siguientes datos:
// - Número de Artículo (1 a 15)
// - Cantidad Vendida 

// Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
// Se pide determinar e informar:
// a) El número de artículo que más se vendió en total.
// b) Los números de artículos que no registraron ventas.
// c) Cuantas unidades se vendieron del número de artículo 10.   

int nroArticulos;
int cantidad;
int[] totalCantidadVendida = new int[5];
for (int x = 0; x < 4; x++)
{
    totalCantidadVendida[x] = 0;
}


Console.WriteLine("Ingrese el nro de artículo: ");
nroArticulos = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad: ");
cantidad = int.Parse(Console.ReadLine());

while (nroArticulos != 0)
{
    totalCantidadVendida[nroArticulos - 1] += cantidad;

    Console.WriteLine("Ingrese el nro de artículo: ");
    nroArticulos = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad: ");
    cantidad = int.Parse(Console.ReadLine());

}

//a) 
int maxCantidad = totalCantidadVendida[0];
int nroMaximo = 1;

for (int x = 0; x < 4; x++)
{
    if (totalCantidadVendida[x] > maxCantidad){
        maxCantidad = totalCantidadVendida[x];
        nroMaximo = x + 1;
    }
}
Console.WriteLine("El producto mas vendido es: " + nroMaximo + " y la cantidad fue: " + maxCantidad);

//b)
for (int x = 0; x < 4; x++)
{
    if (totalCantidadVendida[x] == 0){
        Console.WriteLine("El producto " + (x + 1) + " no tuvo ventas");
    }  
}

//c)

Console.WriteLine("La cantidad vendida del articulo 5 es: " + totalCantidadVendida[4]);







    }
}
