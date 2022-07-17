//* Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla.
//* Solo se debe emitir UN valor por pantalla.

using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, actual = 0, mayor = 0;

            for (int i = 0; i < 5; i++){
                Console.WriteLine("ingrese un numero");
                num = int.Parse(Console.ReadLine());

                if (i == 0){    //Cuando me encuentre en la PRIMER vuelta del for, significa q cargo el primer num
                    mayor = num;  //entonces le asigno el mayor inicialmente
                } else {
                    if(num > mayor){  //Si estoy en cualquier otra vuelta, pregunto si mi numero actual es mayor a mi mayor asignado
                        mayor = num; //Si es, lo asigno
                    }
                }
            }
            Console.WriteLine("El máximo es: "+ mayor);
        }
    }
}
