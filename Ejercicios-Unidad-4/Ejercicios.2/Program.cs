using System.Security.Cryptography.X509Certificates;

namespace Ejercicios._2;

class Program
{
    static void Main(string[] args)
    {
       //Un importante negocio de desinfectante líquido realiza descuentos 
       //dependiendo de la cantidad de litros vendidos según la siguiente escala:

       //Si vende menos de 100 litros, no hay descuento.
       //Si vende entre 101 y 300 litros, el descuento es del 10%.
       //Si vende entre 301 y 500 litros, el descuento es del 15%.
       //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
        
        float litros, importe;

        Console.WriteLine("Ingrese los litros");
        litros = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el importe");
        importe = float.Parse(Console.ReadLine());
       // if (litros > 100 && litros < 301){
         //   importe = importe * 0.9f;
           // Console.WriteLine("El importe final es " + importe);}
        //else if (litros > 300 && litros < 501) {
          //  importe = importe * 0.85f;
            //Console.WriteLine("El importe final es " + importe);}    
        //else if (litros > 500)
          //  {importe = importe * 0.75f;
            //Console.WriteLine("El importe final es "+ importe);}
        //
        
        if (litros > 500)
            importe *= 0.75F;
        else if (litros > 300)
            importe *= 0.85F;
        else if (litros > 100)
            importe *= 0.90F;
                    
        Console.WriteLine("El importe final es "+ importe);





    }
}
