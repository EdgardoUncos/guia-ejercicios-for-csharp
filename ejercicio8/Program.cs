using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8. Hacer un programa que solicite 20 números y luego mostrar por pantalla el
            // menor de ellos y la posición en la que fue encontrado.
            int menor=0, pos=0, num;

            
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero");
                num = int.Parse(Console.ReadLine());
                if (x==0)
                { 
                    menor = num;
                    pos= 1;
                }
                else if ( num < menor)
                {
                    menor = num;
                    pos = x+1;
                }
            }

            Console.WriteLine("El numero menor es: "+menor +" Su posicio es: "+pos);
        }
    }
}
