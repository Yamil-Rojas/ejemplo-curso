using System.Runtime.ConstrainedExecution;

namespace Ejercicio._3;

class Program
{
    static void Main(string[] args)
    {
      //Una casa de video juegos otorga un descuento dependiendo del importe 
      //de la compra realizada según los siguientes valores:

      //Si el importe es menor a ARS 1000, no hay descuento.
      //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
      //Si el importe es ARS 5000 o más, aplica un descuento del 18%.

      //Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.

        double importe, final;

         Console.WriteLine("Ingresar importe de la compra: ");
         importe = double.Parse(Console.ReadLine());

          if (importe >= 5000){
         final = importe*0.82f;
         Console.WriteLine("El importe final es: " + final.ToString("0.00"));}

         else if (importe >= 1000 & importe <= 4999) {
         final = importe*0.90f;
         Console.WriteLine("El importe final es: " + final.ToString("0.00"));}
        else
         Console.WriteLine("No hay descuentos disponibles:");
         

           // else if (importe >= 5000)
            //importefinal = importe*0.82f;

           // Console.WriteLine("El imnporte final es: " + importefinal);
         } 
    }

