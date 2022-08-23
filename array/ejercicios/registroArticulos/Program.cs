//* Una empresa comercializa 15 tipos de artículos. Por cada venta realizada genera un registro con los siguientes datos:
//* Número de Artículo (1 a 15)
//* Cantidad Vendida 

//* Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
//* Se pide determinar e informar:
//* a) El número de artículo que más se vendió en total.
//*  b) Los números de artículos que no registraron ventas.
//* c) Cuantas unidades se vendieron del número de artículo 10.

using System;

namespace registroArticulos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entra el concepto de REGISTRO: 
            //Algo que esta compuesto por más de una variable.
            // Ej "Venta": constituida por fecha, item, cliente, producto

            int numArticulo, cantVendida;
            int [] totalCantidadVendida = new int[15]; //Cantidad de cada uno de los art

            for(int i = 0; i < 15 ; i++){
                totalCantidadVendida[i] = 0; //Inicializa en 0 todos lo elementos
            }

            //Pido el registro
            Console.WriteLine("Ingrese el numero de articulo: ");
            numArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantVendida = int.Parse(Console.ReadLine());

            while(numArticulo != 0){ //Mientras que sea distinto de 0... sigo pidiendo registro
            totalCantidadVendida[numArticulo -1] += cantVendida;  //numArticulo -1 por la posicion
                //le incremento a ese indice la cantidad en 1
    
            Console.WriteLine("Ingrese el numero de articulo: ");
            numArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantVendida = int.Parse(Console.ReadLine());

            }

            //Punto A: tengo q buscar el maximo del vector y su posicion (indice + 1: el art)
            int maxCantidad = totalCantidadVendida[0];   //Asigno el maximo en el primer elemento para arrancar
            int numMaximo = 1;   //Asigno el numero de art. en 1 para arrancar
            for(int i = 0 ; i < 15 ; i++){
                if (totalCantidadVendida[i] > maxCantidad) {   
                    maxCantidad = totalCantidadVendida[i];     //Le asigno el actual
                    numArticulo = i + 1;     //Le digo q mi articulo va a ser ese + 1 
                }
            }
            Console.WriteLine("el producto mas vendido es el: " + numArticulo + " Con la cantidad de: " + maxCantidad);
        
        
            //Punto B: Numero de los productos q no tienen ventas
            for (int i = 0; i < 15 ; i++){
                if(totalCantidadVendida[i] == 0){   //Si alguno del array de cantidades tiene 0...
                    Console.WriteLine("El producto " + (i+1) + " no registró ventas");
                }
            }
            //Punto C: Cuantos hay del punto C
            Console.WriteLine("La cantidad del 10 es: " + totalCantidadVendida[9]);   
        }
    }
}
