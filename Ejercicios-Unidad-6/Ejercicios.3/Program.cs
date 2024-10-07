namespace Ejercicios._3;

class Program
{
    static void Main(string[] args)
    {
        
       //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
       //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

        int n = 1, con, numeroGrupo = 0;
        // incializar la variable n = 1 para que ingrese al ciclo. (o bien usar un do while para que ingrese si o si)
       
        while (n >= 0)
        {
            numeroGrupo++;
            con = 0;
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
             n = int.Parse(Console.ReadLine()); 
             con++;   
            }
            Console.WriteLine("La cantidad del grupo " + numeroGrupo + " es: " + con );
        }




    }
}
