using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //9. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad
            //  de aquellas personas mayores a 18 años.

            int edad, con=0, acu=0;
            float prom=0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese una edad");
                edad = int.Parse(Console.ReadLine());
                if(edad >= 18)
                {
                    con++;
                    acu += edad;
                }    
                    
            }
            if ( con > 0)
                prom = acu / con;
            
            Console.WriteLine("El promedio de mayores a 18 es: "+prom);

        }
    }
}
