/* 
3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. 
    Para ello existe la siguiente escala de precios:

            i5 (1)	 i7 (2)	   i9 (3)
8 RAM (1)	USD 800	 USD 900   USD 1200
16 RAM (2)	USD 900	 USD 1000  USD 1400
32 RAM (3)	USD 1000 USD 1400  USD 2000               DISCO: 300

Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede
ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. 
Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si 
extiende el disco o no (ingresa 1 para extender y 0 para no extender).
calcule y emita por pantalla el monto de la máquina seleccionada.
*/

using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int memoria, disco, monto;
            string procesador;

            Console.WriteLine ("Indique qué procesador desea (i5 / i7 / i9)");
            procesador = Console.ReadLine();
            
            Console.WriteLine ("Indique cuántos GB RAM desea (8 / 16 / 32)");
            memoria = int.Parse(Console.ReadLine());
            
            Console.WriteLine ("Indique si desea extender a 1TB su disco duro (1: si / 0: no)");
            disco = int.Parse(Console.ReadLine());

            if(procesador == "i5" && memoria == 8) {
                monto = 800;
                if (disco == 1){
                    monto = monto + 300;
                    Console.WriteLine("El monto de su computadora es de: USD " + monto);
                } else if(disco == 0){
                    Console.WriteLine("El monto de su computadora es de: USD " + monto);                    
                }
            } else if ((procesador == "i7" && memoria == 8) || (procesador == "i5" && memoria == 16) ) {
                monto = 900;
                if (disco == 1){
                    monto = monto + 300;
                    Console.WriteLine("El monto de su computadora es de: USD " + monto);
                } else if(disco == 0){
                    Console.WriteLine("El monto de su computadora es de: USD " + monto);                    
                }
            } else if ((procesador == "i7" && memoria == 16) || (procesador == "i5" && memoria == 32)) {
                monto = 1000;
                if (disco == 1){
                    monto = monto + 300;
                    Console.WriteLine("El monto de su computadora es de: USD " + monto);
                } else if(disco == 0){
                    Console.WriteLine("El monto de su computadora es de: USD " + monto);                    
                }
            } else if (procesador == "i9" && memoria == 8) {
                monto = 1200;
                if (disco == 1){
                    monto = monto + 300;
                    Console.WriteLine("El monto de su computadora es de: USD " + monto);
                } else if(disco == 0){
                    Console.WriteLine("El monto de su computadora es de: USD " + monto);                    
                }
            } else if ((procesador == "i9" && memoria == 16) || (procesador == "i7" && memoria == 32)) {
                monto = 1400;
                if (disco == 1){
                    monto = monto + 300;
                    Console.WriteLine("El monto de su computadora es de: USD " + monto);
                } else if(disco == 0){
                    Console.WriteLine("El monto de su computadora es de: USD " + monto);                    
                }
            } else if (procesador == "i9" && memoria == 32) {
                monto = 2000;
                if (disco == 1){
                    monto = monto + 300;
                    Console.WriteLine("El monto de su computadora es de: USD " + monto);
                } else if(disco == 0){
                    Console.WriteLine("El monto de su computadora es de: USD " + monto);                    
                }
            }             


        }
    }
}
