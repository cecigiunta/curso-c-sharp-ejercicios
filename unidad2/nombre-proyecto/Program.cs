using System; //Incluye la libreria

namespace nombre_proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            //* Pedir valores
            Console.WriteLine("ingrese un numero:");
            n1 = int.Parse(Console.ReadLine());  //Le deja el espacio al usr para que ingrese y se lo asigna a n1

            Console.WriteLine("ingrese otro numero:");
            n2 = int.Parse(Console.ReadLine());

            //* Realizar el calculo
            resultado = n1 + n2 ;

            //*Mostrar resultado por pantalla
            Console.WriteLine("El resultado es: " + resultado);

        }
    }
}
