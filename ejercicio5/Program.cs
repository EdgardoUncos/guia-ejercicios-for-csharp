using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa que muestre los números del 1 al 100 de 5 en 5. Ejemplo:
            // 0, 5, 10, 15, 20…. 100.

            for (int x = 0; x <= 100; x+=5)
            {
                Console.WriteLine(x);
            }
        }
    }
}
