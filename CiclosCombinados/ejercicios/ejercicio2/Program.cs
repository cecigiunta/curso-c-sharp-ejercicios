// 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
// Se pide determinar e informar:
// El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
// Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++){
                int numero, prom, numGrupo, contadorGrupos, contadorNumeros, contadorImpares, grupoMaxImpares;
                int minimo;
                bool banderaOrdenados;
                double porcentajeImpares, porcentajeMaximo = -1;

                Console.WriteLine("Ingrese un numero: ");
                contadorNumeros = 0;    //Inicio en 0 para q cuando salga vuelva a inciarse y para q cuente ++
                contadorImpares = 0;
                banderaOrdenados = true;
                numero = int.Parse(Console.ReadLine());
                min = numero;
                while (!= 0){

                    contadorNumeros++;
                    if(numero % 2 !== 0){
                        contadorImpares++;
                    }
                    if(numero <= min){
                        min = numero;
                    } else {
                        banderaOrdenados = false;
                    }
                    Console.WriteLine("Ingrese un numero: ");
                    numero = int.Parse(Console.ReadLine());
                }
                porcentajeImpares = (contadorImpares*100) / contadorNumeros;
                if(porcentajeImpares > porcentajeMaximo){
                    porcentajeMaximo = porcentajeImpares;
                    grupoMaxImpares = i+1;
                }
                //Si la bandera está true, esa lista está ordenada

            }
            Console.WriteLine("El grupo con más impares es: " + grupoMaxImpares " con " + porcentajeMaximo)
        }
    }
}
