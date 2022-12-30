using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite 20 números y calcule y emita por pantalla
            // cuántos son positivos (mayores a cero). Se debe mostrar un solo valor: el
            // conteo final.

            int n, cp=0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());

                if (n > 0)
                    cp++;
            }
            Console.WriteLine("La cantidad de numeros positivos es : "+cp);
        }
    }
}
