using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. Hacer un programa que solicite 10 números y luego mostrar por pantalla el
            // máximo de ellos y la posición en la que fue ingresado.
            int pos=0, mayor = 0;
            int num;
            

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero");
                num = int.Parse(Console.ReadLine());

                if( x == 0)
                {
                    mayor = num;
                    pos = x+1;
                }  
                if( num > mayor)
                { 
                    mayor = num;
                    pos = x+1;
                } 
            }
            Console.WriteLine("El numero mayor es : " +mayor);
        }
    }
}
