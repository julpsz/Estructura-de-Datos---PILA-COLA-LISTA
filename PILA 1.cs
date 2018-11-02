using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp9
{
    class Program
    {   
        static void Main(string[] args)
        {
            Stack pila = new Stack();
            int opcion=0, contador = 0, i = 0;


            while (opcion != 3)
            {
                Console.WriteLine("MENU\n" +
                "1. Llenar dispenser a tope.(Max 10 latas)\n" +
                "2. Ingresar moneda y retirar lata\n" +
                "3. SALIR\n" +
                "Ingrese opcion:\n");

                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        llenar();
                        break;
                    case 2:
                        compr();
                        break;
                    case 3:
                        break;
                }
            }

         void llenar()
            {
                for (i = 0; i < 10; i++)
                {
                    pila.Push("lata");
                    contador = 10;
                }
            }
         void compr()
        {
            if (contador > 0)
                {
                    if (contador == 1)
                        Console.WriteLine("ATENCION! Retiro la ultima lata que quedaba\n");
                    pila.Pop();
                    contador--;
                        Console.WriteLine("Lata comprada\n");
                }
            else
                {
                    Console.WriteLine("NO HAY MAS LATAS\n");
                }
           
        }
        }
    }
}

