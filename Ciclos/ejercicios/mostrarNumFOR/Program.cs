//* Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos.

using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            for (int i = 0 ; i < 10 ; i++){
                n++;
                Console.WriteLine(n);
            }
        }
    }
}
