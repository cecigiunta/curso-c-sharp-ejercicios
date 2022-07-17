using System;

namespace ciclos_combinados
{
    class Program
    {
        static void Main(string[] args)
        {   

            //*FOR CON FOR: Cargar 20 equipos de 10 personas cada uno
            int prom, acu, n;
            for (int x = 0 ; i < 20 ; i++){   //Voy a tener un for GENERAL para mis "equipos de futbol"
                acu = 0;
                
                for (int i = 0 ; i < 10 ; i++)  //Y este for opera por cada equipo
                {
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                    acu += n
                }
                prom = acu / 10;
                Console.WriteLine("El promedio es: " + prom);
            }

            //* FOR CON WHILE: Cargo 10 equipos pero sin cantidad de personas exactas. 
            //* Cargo 10 subgrupos de datos.

            for ( int y = 0 ; y < 10 ; y++){
                int n, prom, contador, acu;

                Console.WriteLine("Ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
                contador = 0
                acu = 0;
                while (n != 0){
                    acu += n;
                    contador ++;
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                }
                prom = acu / contador;
                Console.WriteLine("El promedio es: " + prom);
            }



            //* WHILE CON FOR: Cargo x cantidad de equipos con 10 personas c/u
            Console.WriteLine("Ingrese 1 para comenzar o 0 para terminar: ");
            n = int.Parse(Console.ReadLine());
            while(n != 0){
                acu = 0;
                for (int i = 0 ; i < 10 ; i++)  //Y este for opera por cada equipo
                {
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                    acu += n
                }
                prom = acu / 10;
                Console.WriteLine("El promedio es: " + prom);
                Console.WriteLine("Ingrese 1 para continuar o 0 para cortar");
                n = int.Parse(Console.ReadLine());
            }

            //* WHILE CON WHILE: No se la cantidad ni de personas ni de equipos, pero los cargo.
            //* Comun de ver en CORTES DE CONTROL
            Console.WriteLine("Ingrese la edad: ");
            n = int.Parse(Console.ReadLine());
            while(n > 0){  //* Corta con numeros negativos o 0

                contador = 0
                acu = 0;
                while (n != 0){
                    acu += n;
                    contador ++;
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                }
                prom = acu / contador;
                Console.WriteLine("El promedio es: " + prom);
                Console.WriteLine("Ingrese la edad para continuar o un negativo para cortar: ");
                n = int.Parse(Console.ReadLine());
            
            }
        }
    }
}
