using System;

namespace arrays01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];  //Forma de declararlos
            int n;
            int acu = 0;

            for(int i = 0; i < 5 ; i++){
                Console.WriteLine("Ingrese una nota: ");
                n = int.Parse(Console.ReadLine());
                numeros[i] = n;
                acu += numeros[i];
            }
            float prom = acu / 5;
            Console.WriteLine("el promedio de todos es: "+ prom);
        }
    }
}
