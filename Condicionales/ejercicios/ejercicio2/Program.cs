/*
2. Un importante negocio de desinfectante realiza descuentos dependiendo de la cantidad de litros 
Si vende menos de 100 litros, no hay descuento.
Si vende entre 101 y 300 litros, el descuento es del 10%.
Si vende entre 301 y 500 litros, el descuento es del 15%.
Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y 
calcule y emita el importe con el descuento  aplicado..)  
*/


using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int venta, litros;
            double importeD;

            Console.WriteLine("Ingrese la cantidad de litros vendidos:");
            litros = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el importe total de la venta:");
            venta = int.Parse(Console.ReadLine());

            if (litros > 500){
                importeD = venta - (venta * 0.25);
                Console.WriteLine("Compro más de 500lts, la venta con su 25% OFF es de: " + importeD);
            } else if (litros >= 301 && litros <= 500 ) {
                importeD = venta - (venta * 0.15);
                Console.WriteLine("Compro entre 301 y 500lts, la venta con su 15% OFF es de: " + importeD);
            } else if (litros >= 101 && litros <= 300 ){
                importeD = venta - (venta * 0.10);
                Console.WriteLine("Compro entre 101 y 100lts, la venta con su 10% OFF es de: " + importeD);
            } else{
                Console.WriteLine("Compró 100 lts o menos, no hay descuento. El valor es de: " + venta);
            }


        }
    }
}
