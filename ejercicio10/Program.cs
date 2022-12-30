using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10. Hacer un programa que solicite 20 números y luego emitir por pantalla el
            // máximo de los números pares y el mínimo de los números impares.

            int num, bi=0, bp=0, mi=0, mp=0;
            // podemos usar la bandera en bool
            // ya tengo un numero par

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero");
                num = int.Parse(Console.ReadLine());

                if(num%2 == 0)
                { 
                    if(bp==0)
                    {
                        mp = num;
                        bp = 1;
                    }
                    else if (num > mp)
                        mp=num;

                }
                else{
                    
                    if(bi==0)
                    {
                        mi = num;
                        bi = 1;
                    }
                    else if ( num < mi)
                        mi = num;
                }
            }

            if(bp == 1)
                Console.WriteLine("El maximo par es :"+mp);
            else
                Console.WriteLine("No ingreso ningun numero par");
            
            if(bi == 1)
                Console.WriteLine("El minimo impar es : "+mi);
            else
                Console.WriteLine("No ingreso ningun numero impar");
        }
    }
}
