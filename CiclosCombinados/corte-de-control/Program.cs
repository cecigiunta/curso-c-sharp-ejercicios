//* CORTE DE CONTROL: Estrategia para manejar datos y logica
// Sirve para manejar lotes de datos agrupados. Se modifica "automaticamente"
// Sirve solo para datos AGRUPADOS, osea TODOS los del 1, despues todos los del 2...

using System;

namespace corte_de_control
{
    class Program
    {
        static void Main(string[] args)
        {
            //Casi siempre la estructura va a ser While dentro de While
            // Equipos donde cada cada jugados tiene su: legajo, edad y sueldo, codigo equipo
            // Con sueldo negativo corta el SUB LOTE
            // Cambia el equipo con el codigo de equipo

            int legajo, edad, codigoEquipo;
            float sueldo;
            int equipoActual;  //parametro que permite q siga el lote
            //Ej: 1 boca, 2 river, 3 racing, 4 independiente

            Console.WriteLine("Ingrese el legajo: ")
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad: ")
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo: ")
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo de equipo: ")
            codigoEquipo = int.Parse(Console.ReadLine());
            while (sueldo > 0) {  //Corta con sueldo negativo

                equipoActual = codigoEquipo;  //inicializo un equipo actual, cuando cambie se actualiza, para que despues corte automaticamente
                while (codigoEquipo == equipoActual) {
                    //aca procesamos...

                    //Me pide q cargue otra persona
                    Console.WriteLine("Ingrese el legajo: ")
                    legajo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la edad: ")
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo: ")
                    sueldo = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el codigo de equipo: ")
                    codigoEquipo = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
