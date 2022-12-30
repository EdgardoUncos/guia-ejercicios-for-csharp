using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //11. Hacer un programa para ingresar 10 números y luego calcule y emita el mayor
            // de los primos de la lista. En caso de no haber ningún número primo, deberá
            // aclararlo con un cartel.

            // si usamos boleanos !bp es igual a bp == 0 o false

            int num, bp=0, con=0, mp=0;


            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero");
                num = int.Parse(Console.ReadLine());
                
                con=0;
                for (int y = 1; y <= num; y++)
                {
                    if(num%y == 0)
                        con++;
                }
                if(con==2)
                {
                    if(bp==0)
                    {
                        mp = num;
                        bp =1;
                    }
                    else if(num > mp)
                        mp = num;
                }
            }

            if(bp==1)
                Console.WriteLine("El mayor primo es : "+mp);
            else
                Console.WriteLine("No hay ningun primo");
        }
    }
}
