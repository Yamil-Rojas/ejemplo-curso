namespace Ejercicio._4;

class Program
{
    static void Main(string[] args)
    {
      //Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total 
      //facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado 
      //y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

      float facturado, sueldoTotal;      

      Console.WriteLine ("ingrese el total facturado");
      facturado = float.Parse(Console.ReadLine());

      sueldoTotal = facturado*0.05F+15000;

      Console.WriteLine ("El sueldo total a cobrar es: " + sueldoTotal);

      //En este tipo de programa, puede llegar a necesitarse varios tipos de sueldos y varias comisiones.
      //Una buena Herramienta para eso seria declarar las variables con el sueldo fijo y el porcentaje de comision.
      //Llegado el caso de tener que cambiar los valores antes mencionados, basta con modificar las variables.
      //Una manera de protejerlas seria aclarando que son constantes "const float".




    }
}
