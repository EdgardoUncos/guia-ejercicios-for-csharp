﻿using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa que solicite el ingreso de 10 números y que muestre el
            //mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

            // Asignamos el mayor al primer elemento ingresado en el ciclo for
            // luego comparamos.
            // Asignarle un cero afuera podria funcionar solo con valores positivos. 

            int n, max=0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());

                if(x== 0)
                    max = n;
                else if(n > max)
                    max = n;
            }
            Console.WriteLine("El mayor es : "+max);
        }
    }
}
