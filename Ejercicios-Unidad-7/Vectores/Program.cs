namespace Vectores;

class Program
{
    static void Main(string[] args)
    {

       /*int n;
        int[] numeros = new int[10];

        for (int x = 0; x < 5; x++)
        {
            Console.WriteLine("Ingrese la nota ");
            n = int.Parse(Console.ReadLine());
            numeros[x] = n;
        }
        
        int acu = 0;

        for (int x = 0; x < 5; x++)
        {
            acu += numeros[x];
        }
        
        int promedio = acu / 5; 

        Console.WriteLine("El promedio es : " + promedio);*/

       bool [] asistenciaQuincena = new bool [5];
       int dia = 0; 
       bool asistencia = true;
       Console.WriteLine("Cargue las asistencias");
       for (int x = 0; x < 5; x++)
       {
        Console.WriteLine("Ingrese el dia: ");
        dia = int.Parse(Console.ReadLine ());
        Console.WriteLine ("Ingrese asistencia ");
        asistencia = bool.Parse(Console.ReadLine ());
        asistenciaQuincena[dia-1] = asistencia;
        if (asistenciaQuincena [dia-1] == true){
            
        
        

       }
        Console.WriteLine("Estuvo " + asistencia + " en la semana.");
        
       
    }
}
